// Handlers.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//

using System;
using System.Collections.Generic;
using LongoMatch.Interfaces;
using LongoMatch.Interfaces.GUI;
using LongoMatch.Store;
using LongoMatch.Common;
using LongoMatch.Store.Drawables;
using LongoMatch.Interfaces.Drawing;

namespace LongoMatch.Handlers
{

	/*Tagging Events*/
	/* A Play was selected */
	public delegate void PlaySelectedHandler(Play play);
	/* A new play needs to be create for a specific category at the current play time */
	public delegate void NewTagHandler(Category category, List<Player> plays);
	/* Signal the start time to tag a new play */
	public delegate void NewTagStartHandler (Category category);
	/* Signal the stop time to tag a new play */
	public delegate void NewTagStopHandler(Category category);
	/* Signal cancellation of tag */
	public delegate void NewTagCancelHandler(Category category);
	/* A new play needs to be created at a defined frame */
	public delegate void NewTagAtPosHandler(Category category, Time position);
	//A play was edited
	public delegate void TimeNodeChangedHandler(TimeNode tNode, object val);
	/* A list of plays needs to be deleted */
	public delegate void PlaysDeletedHandler(List<Play> plays);
	/* Tag a play */
	public delegate void TagPlayHandler(Play play);
	/* Change the Play's category */
	public delegate void PlayCategoryChangedHandler(Play play, Category cat);
	/* DUplicate play */
	public delegate void DuplicatePlaysHandler (List<Play> plays);
	
	public delegate void TeamsTagsChangedHandler ();
	
	/* Project Events */
	public delegate void SaveProjectHandler(Project project, ProjectType projectType);
	public delegate void OpenedProjectChangedHandler(Project project, ProjectType projectType, PlaysFilter filter,
	                                                 IAnalysisWindow analysisWindow);
	public delegate void OpenProjectIDHandler(Guid project_id);
	public delegate void OpenProjectHandler();
	public delegate void CloseOpenendProjectHandler();
	public delegate void NewProjectHandler(Project project);
	public delegate void OpenNewProjectHandler(Project project, ProjectType projectType, CaptureSettings captureSettings);
	public delegate void ImportProjectHandler ();
	public delegate void ExportProjectHandler (Project project);
	public delegate void QuitApplicationHandler ();
	public delegate void CreateThumbnailsHandler (Project project);
	
	/* GUI */
	public delegate void ManageJobsHandler();
	public delegate void ManageTeamsHandler();
	public delegate void ManageCategoriesHandler();
	public delegate void ManageProjects();
	public delegate void ManageDatabases();
	public delegate void EditPreferences();
	

	/*Playlist Events*/
	/* Add the a play to the opened playlist */
	public delegate void PlayListNodeAddedHandler(List<Play> play);
	/* A play list element is selected */
	public delegate void PlayListNodeSelectedHandler(PlayListPlay play);
	/* Open a playlist */
	public delegate void OpenPlaylistHandler();
	/* New a playlist */
	public delegate void NewPlaylistHandler();
	/* Save a playlist */
	public delegate void SavePlaylistHandler();

	/* The position of the stream has changed */
	public delegate void PositionChangedHandler(Time pos);
	
	/* Create snapshots for a play */
	public delegate void SnapshotSeriesHandler(Play tNode);
	
	/* Add a new rendering job */
	public delegate void RenderPlaylistHandler(IPlayList playlist);
	 
	/* Convert a video file */
	public delegate void ConvertVideoFilesHandler (List<MediaFile> inputFiles, EncodingSettings encSettings);
	
	/* A date was selected */
	public delegate void DateSelectedHandler(DateTime selectedDate);
	
	/* A new version of the software exists */
	public delegate void NewVersionHandler(Version version, string URL);

	/* Edit Category */
	public delegate void CategoryHandler(Category category);
	public delegate void CategoriesHandler(List<Category> categoriesList);
	
	/* Edit player properties */
	public delegate void PlayerPropertiesHandler(Player player);
	public delegate void PlayersPropertiesHandler(List<Player> players);
	
	/* A list of projects have been selected */
	public delegate void ProjectsSelectedHandler(List<ProjectDescription> projects);
	public delegate void ProjectSelectedHandler(ProjectDescription project);
	
	public delegate void KeyHandler (object sender, int key, int modifier);

	/* The plays filter was updated */	
	public delegate void FilterUpdatedHandler ();
	
	public delegate void DetachPlayerHandler ();
	
	/* Show project stats */
	public delegate void ShowProjectStats(Project project);
	
	public delegate void ShowFullScreenHandler (bool fullscreen);
	public delegate void PlaylistVisibiltyHandler (bool visible);
	public delegate void AnalysisWidgetsVisibilityHandler (bool visible);
	public delegate void AnalysisModeChangedHandler (VideoAnalysisMode mode);
	public delegate void TagSubcategoriesChangedHandler (bool tagsubcategories);
	
	public delegate void ShowTimelineMenuHandler (List<Play> plays, Category cat, Time time);
	public delegate void ShowTaggerMenuHandler (List<Play> plays);
	public delegate void ShowDrawToolMenuHandler (IBlackboardObject drawable);
	public delegate void ConfigureDrawingObjectHandler (IBlackboardObject drawable);
	public delegate void DrawableChangedHandler (IBlackboardObject drawable);

	public delegate void BackEventHandle ();
}
