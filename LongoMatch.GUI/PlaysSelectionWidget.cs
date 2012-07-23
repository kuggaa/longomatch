// 
//  Copyright (C) 2012 Andoni Morales Alastruey
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
using System.Collections.Generic;

using LongoMatch.Common;
using LongoMatch.Handlers;
using LongoMatch.Interfaces;
using LongoMatch.Store;

namespace LongoMatch.Gui.Component
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class PlaysSelectionWidget : Gtk.Bin
	{
	
		public event PlaysDeletedHandler PlaysDeleted;
		public event PlaySelectedHandler PlaySelected;
		public event PlayListNodeAddedHandler PlayListNodeAdded;
		public event SnapshotSeriesHandler SnapshotSeries;
		public event RenderPlaylistHandler RenderPlaylist;
		public event TagPlayHandler TagPlay;
		
		Project project;
		
		public PlaysSelectionWidget ()
		{
			this.Build ();
			localPlayersList.Team = Team.LOCAL;
			visitorPlayersList.Team = Team.VISITOR;
			ConnectSignals();
		}
		
		#region Plubic Methods
		
		public void SetProject(Project project, bool isLive) {
			this.project = project;
			playsList.ProjectIsLive = isLive;
			localPlayersList.ProjectIsLive = isLive;
			visitorPlayersList.ProjectIsLive = isLive;
			playsList.Project=project;
			visitorPlayersList.Project = project;
			localPlayersList.Project = project;
			visitorPlaysList.LabelProp = project.VisitorTeamTemplate.TeamName;
			localPlaysList.LabelProp = project.LocalTeamTemplate.TeamName;
			UpdateTeamsModels();
		}
		
		public void Clear() {
			playsList.Project = null;
			localPlayersList.Clear();
			visitorPlayersList.Clear();
		}
		
		public bool PlayListLoaded {
			set {
				playsList.PlayListLoaded = value;
				localPlayersList.PlayListLoaded = value;
				visitorPlayersList.PlayListLoaded = value;
			}
		}
		
		public ITemplatesService TemplatesService {
			set {
				playsList.TemplatesService = value;
			}
		}
		
		public void AddPlay(Play play) {
			playsList.AddPlay(play);
			UpdateTeamsModels();
		}
		
		public void RemovePlays (List<Play> plays) {
			playsList.RemovePlays(plays);
			UpdateTeamsModels();
		}
		#endregion
		
		private void ConnectSignals() {
			playsList.TimeNodeDeleted += EmitPlaysDeleted;

			/* Connect TimeNodeSelected events */
			playsList.TimeNodeSelected += EmitPlaySelected;
			localPlayersList.TimeNodeSelected += EmitPlaySelected;
			visitorPlayersList.TimeNodeSelected += EmitPlaySelected;

			/* Connect PlayListNodeAdded events */
			playsList.PlayListNodeAdded += EmitPlayListNodeAdded;
			localPlayersList.PlayListNodeAdded += EmitPlayListNodeAdded;
			visitorPlayersList.PlayListNodeAdded += EmitPlayListNodeAdded;

			/* Connect tags events */
			playsList.TagPlay += EmitTagPlay;

			/* Connect SnapshotSeries events */
			playsList.SnapshotSeriesEvent += EmitSnapshotSeries;
			localPlayersList.SnapshotSeriesEvent += EmitSnapshotSeries;
			visitorPlayersList.SnapshotSeriesEvent += EmitSnapshotSeries;

			playsList.RenderPlaylistEvent += EmitRenderPlaylist;
			localPlayersList.RenderPlaylistEvent += EmitRenderPlaylist;
			visitorPlayersList.RenderPlaylistEvent += EmitRenderPlaylist;
 		}
 		
		private void UpdateTeamsModels() {
			localPlayersList.SetTeam(project.LocalTeamTemplate, project.AllPlays());
			visitorPlayersList.SetTeam(project.VisitorTeamTemplate, project.AllPlays());
		}
		
		private void EmitPlaysDeleted(List<Play> plays)
		{
			if (PlaysDeleted != null)
				PlaysDeleted(plays);
		}
		
		private void EmitPlaySelected(Play play)
		{
			if (PlaySelected != null)
				PlaySelected(play);
		}
		
		private void EmitSnapshotSeries(Play play)
		{
			if (SnapshotSeries != null)
				SnapshotSeries(play);
		}
		
		private void EmitRenderPlaylist(IPlayList playlist) {
			if (RenderPlaylist != null)
				RenderPlaylist(playlist);
		}
		
		private void EmitPlayListNodeAdded(Play play)
		{
			if (PlayListNodeAdded != null)
				PlayListNodeAdded(play);
		}
		
		private void EmitTagPlay(Play play) {
			if (TagPlay != null)
				TagPlay (play);
			UpdateTeamsModels();
		}
	}
}
