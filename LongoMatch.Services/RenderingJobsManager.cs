// 
//  Copyright (C) 2011 Andoni Morales Alastruey
// 
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//  
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces;
using LongoMatch.Core.Interfaces.GUI;
using LongoMatch.Core.Interfaces.Multimedia;
using LongoMatch.Core.Store;
using Mono.Unix;
using LongoMatch.Core.Store.Playlists;

namespace LongoMatch.Services
{
	public class RenderingJobsManager: IRenderingJobsManager, IService
	{
		/* List of pending jobs */
		List<Job> jobs, pendingJobs;
		IVideoEditor videoEditor;
		IVideoConverter videoConverter;
		IFramesCapturer capturer;
		Job currentJob;
		IRenderingStateBar stateBar;
		IMultimediaToolkit multimediaToolkit;
		IGUIToolkit guiToolkit;

		public RenderingJobsManager (IMultimediaToolkit multimediaToolkit, IGUIToolkit guiToolkit)
		{
			this.guiToolkit = guiToolkit;
			this.multimediaToolkit = multimediaToolkit; 
			this.stateBar = guiToolkit.RenderingStateBar;
			jobs = new List<Job> ();
			pendingJobs = new List<Job> ();
		}

		public List<Job> Jobs {
			get {
				return jobs;
			}
		}

		public List<Job> PendingJobs {
			get {
				return pendingJobs;
			}
		}

		public void AddJob (Job job)
		{
			if (job == null)
				return;
			jobs.Add (job);
			pendingJobs.Add (job);
			UpdateJobsStatus ();
			if (pendingJobs.Count == 1)
				StartNextJob ();
		}

		public void RetryJobs (List<Job> retryJobs)
		{
			foreach (Job job in retryJobs) {
				if (!jobs.Contains (job))
					return;
				if (!pendingJobs.Contains (job)) {
					job.State = JobState.NotStarted;
					jobs.Remove (job);
					jobs.Add (job);
					pendingJobs.Add (job);
					UpdateJobsStatus ();
				}
			}
		}

		public void DeleteJob (Job job)
		{
			job.State = JobState.Cancelled;
			CancelJob (job);
		}

		public void ClearDoneJobs ()
		{
			jobs.RemoveAll (j => j.State == JobState.Finished);
		}

		public void CancelJobs (List<Job> cancelJobs)
		{
			foreach (Job job in cancelJobs) {
				job.State = JobState.Cancelled;
				pendingJobs.Remove (job);
			}
			
			if (cancelJobs.Contains (currentJob))
				CancelCurrentJob ();
		}

		public void CancelCurrentJob ()
		{
			CancelJob (currentJob);
		}

		public void CancelJob (Job job)
		{
			if (currentJob != job)
				return;
			
			if (job is EditionJob) {
				videoEditor.Progress -= OnProgress;
				videoEditor.Error -= OnError;
				videoEditor.Cancel ();
			} else {
				videoConverter.Progress -= OnProgress;
				videoConverter.Error -= OnError;
				videoConverter.Cancel ();
			}
			job.State = JobState.Cancelled;
			RemoveCurrentFromPending ();
			UpdateJobsStatus ();
			StartNextJob ();
		}

		public void CancelAllJobs ()
		{
			foreach (Job job in pendingJobs)
				job.State = JobState.Cancelled;
			pendingJobs.Clear ();
			CancelJob (currentJob);
		}

		protected void ManageJobs ()
		{
			guiToolkit.ManageJobs ();
		}

		private void LoadConversionJob (ConversionJob job)
		{
			videoConverter = multimediaToolkit.GetVideoConverter (job.EncodingSettings.OutputFile);
			videoConverter.Progress += OnProgress;
			videoConverter.EncodingSettings = job.EncodingSettings;
			videoConverter.Error += OnError;
			
			foreach (MediaFile file in job.InputFiles) {
				videoConverter.AddFile (file.FilePath, file.Duration.MSeconds,
					file.VideoWidth, file.VideoHeight, file.Par);
			}
			
			try {
				videoConverter.Start ();
			} catch (Exception ex) {
				videoConverter.Cancel ();
				job.State = JobState.Error;
				Log.Exception (ex);
				Log.Error ("Error rendering job: ", job.Name);
				guiToolkit.ErrorMessage (Catalog.GetString ("Error rendering job: ") + ex.Message);
			}
		}

		private void LoadEditionJob (EditionJob job)
		{
			videoEditor = multimediaToolkit.GetVideoEditor ();
			videoEditor.EncodingSettings = job.EncodingSettings;
			videoEditor.Progress += OnProgress;
			videoEditor.Error += OnError;
			
			foreach (IPlaylistElement segment in job.Playlist.Elements) {
				if (segment is PlaylistPlayElement) {
					ProcessPlay (segment as PlaylistPlayElement);
				} else if (segment is PlaylistVideo) {
					ProcessVideo (segment as PlaylistVideo);
				} else if (segment is PlaylistImage) {
					ProcessImage (segment as PlaylistImage);
				} else if (segment is PlaylistDrawing) {
					ProcessDrawing (segment as PlaylistDrawing);
				}
			}
			
			try {
				videoEditor.Start ();
			} catch (Exception ex) {
				videoEditor.Cancel ();
				job.State = JobState.Error;
				Log.Exception (ex);
				Log.Error ("Error rendering job: ", job.Name);
				guiToolkit.ErrorMessage (Catalog.GetString ("Error rendering job: ") + ex.Message);
			}
		}

		void ProcessImage (Image image, Time duration)
		{
			string path = System.IO.Path.GetTempFileName ().Replace (@"\", @"\\");
			image.Save (path);
			videoEditor.AddImageSegment (path, 0, duration.MSeconds, "", new Area ());
		}

		void ProcessImage (PlaylistImage image)
		{
			Log.Debug (String.Format ("Adding still image with duration {0}s",
				image.Duration));
			ProcessImage (image.Image, image.Duration);
		}

		void ProcessVideo (PlaylistVideo video)
		{
			Log.Debug ("Adding external video " + video.File.FilePath);
			videoEditor.AddSegment (video.File.FilePath, 0, video.File.Duration.MSeconds,
				1, "", video.File.HasAudio, new Area ());
		}

		void ProcessDrawing (PlaylistDrawing drawing)
		{
			Image img;
			
			Log.Debug (String.Format ("Adding still drawing with duration {0}s",
				drawing.Duration));
			img = Drawing.Utils.RenderFrameDrawing (Config.DrawingToolkit, drawing.Width,
				drawing.Height, drawing.Drawing);
			ProcessImage (img, drawing.Duration);
		}

		bool ProcessPlay (PlaylistPlayElement element)
		{
			Time lastTS;
			TimelineEvent play;
			MediaFile file;
			IEnumerable<FrameDrawing> drawings;
			int cameraIndex;
			Area roi;

			play = element.Play;
			Log.Debug (String.Format ("Adding segment {0}", element));
			
			lastTS = play.Start;
			if (element.CamerasConfig.Count == 0) {
				cameraIndex = 0;
				roi = new Area ();
			} else {
				cameraIndex = element.CamerasConfig [0].Index;
				roi = element.CamerasConfig [0].RegionOfInterest;
			}
			if (cameraIndex >= element.FileSet.Count) {
				Log.Error (string.Format ("Camera index={0} not matching for current fileset count={1}",
					cameraIndex, element.FileSet.Count));
				file = element.FileSet [0];
			} else {
				file = element.FileSet [cameraIndex];
			}
			drawings = play.Drawings.Where (d => d.CameraConfig.Index == cameraIndex);

			if (file == null || drawings == null) {
				return false;
			}
			if (!file.Exists ()) {
				return false;
			}
			foreach (FrameDrawing fd in drawings) {
				if (fd.Render < play.Start || fd.Render > play.Stop) {
					Log.Warning ("Drawing is not in the segments boundaries " +
					fd.Render.ToMSecondsString ());
					continue;
				}
				string image_path = CreateStillImage (file.FilePath, fd);
				if (image_path == null) {
					continue;
				}
				videoEditor.AddSegment (file.FilePath, lastTS.MSeconds,
					fd.Render.MSeconds - lastTS.MSeconds,
					element.Rate, play.Name, file.HasAudio, roi);
				// Drawings have already been cropped to ROI by the canvas, we pass an empty area
				videoEditor.AddImageSegment (image_path, 0, fd.Pause.MSeconds, play.Name, new Area ());
				lastTS = fd.Render;
			}
			videoEditor.AddSegment (file.FilePath, lastTS.MSeconds,
				play.Stop.MSeconds - lastTS.MSeconds,
				element.Rate, play.Name, file.HasAudio, roi);
			return true;
		}

		private string CreateStillImage (string filename, FrameDrawing drawing)
		{
			Image frame, final_image;
			string path = System.IO.Path.GetTempFileName ().Replace (@"\", @"\\");
			
			capturer = multimediaToolkit.GetFramesCapturer ();
			capturer.Open (filename);
			frame = capturer.GetFrame (drawing.Render, true);
			capturer.Dispose ();
			if (frame == null) {
				Log.Error (String.Format ("Could not get frame for file {0} at pos {1}",
					filename, drawing.Render.ToMSecondsString ()));
				return null;
			}
			final_image = Drawing.Utils.RenderFrameDrawingToImage (Config.DrawingToolkit, frame, drawing);
			final_image.Save (path);
			return path;
		}

		private void CloseAndNext ()
		{
			RemoveCurrentFromPending ();
			UpdateJobsStatus ();
			StartNextJob ();
		}

		private void ResetGui ()
		{
			stateBar.ProgressText = "";
			stateBar.JobRunning = false;
		}

		private void StartNextJob ()
		{
			if (pendingJobs.Count == 0) {
				ResetGui ();
				return;
			}
			
			currentJob = pendingJobs [0];
			if (currentJob is EditionJob) {
				LoadEditionJob (currentJob as EditionJob);
			} else {
				LoadConversionJob (currentJob as ConversionJob);
			}
		}

		private void UpdateProgress (float progress)
		{
			stateBar.Fraction = progress;
			stateBar.ProgressText = String.Format ("{0}... {1:0.0}%", Catalog.GetString ("Rendering"),
				progress * 100);
		}

		private void UpdateJobsStatus ()
		{
			stateBar.Text = String.Format ("{0} ({1} {2})", Catalog.GetString ("Rendering queue"),
				pendingJobs.Count, Catalog.GetString ("Pending"));
		}

		private void RemoveCurrentFromPending ()
		{
			try {
				pendingJobs.Remove (currentJob);
			} catch {
			}
		}

		void HandleError ()
		{
			Log.Debug ("Job finished with errors");
			guiToolkit.ErrorMessage (Catalog.GetString ("An error has occurred in the video editor.")
			+ Catalog.GetString ("Please, try again."));
			currentJob.State = JobState.Error;
			CloseAndNext ();
		}

		private void MainLoopOnProgress (float progress)
		{
			if (progress > (float)EditorState.START && progress <= (float)EditorState.FINISHED
			    && progress > stateBar.Fraction) {
				UpdateProgress (progress);
			}

			if (progress == (float)EditorState.CANCELED) {
				Log.Debug ("Job was cancelled");
				currentJob.State = JobState.Cancelled;
				CloseAndNext ();
			} else if (progress == (float)EditorState.START) {
				Log.Debug ("Job started");
				currentJob.State = JobState.Running;
				stateBar.JobRunning = true;
				UpdateProgress (progress);
			} else if (progress == (float)EditorState.FINISHED) {
				Log.Debug ("Job finished successfully");
				if (currentJob is EditionJob) {
					videoEditor.Progress -= OnProgress;
				} else {
					videoConverter.Progress -= OnProgress;
				}
				UpdateProgress (progress);
				currentJob.State = JobState.Finished;
				CloseAndNext ();
			} else if (progress == (float)EditorState.ERROR) {
				HandleError ();
			}
		}

		protected void OnError (object sender, string message)
		{
			HandleError ();
		}

		protected void OnProgress (float progress)
		{
			MainLoopOnProgress (progress);
		}

		#region IService

		public int Level {
			get {
				return 30;
			}
		}

		public string Name {
			get {
				return "Rendering jobs";
			}
		}

		public bool Start ()
		{
			stateBar.Cancel += (sender, e) => CancelCurrentJob ();
			stateBar.ManageJobs += (sender, e) => ManageJobs ();
			Config.EventsBroker.ConvertVideoFilesEvent += (inputFiles, encSettings) => {
				ConversionJob job = new ConversionJob (inputFiles, encSettings);
				AddJob (job);
			};

			return true;
		}

		public bool Stop ()
		{
			return true;
		}

		#endregion
	}
}

