//
//  Copyright (C) 2013 Andoni Morales Alastruey
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
using LongoMatch.Handlers;
using LongoMatch.Store;

namespace LongoMatch.Interfaces.GUI
{
	public interface IMainController
	{
		/* Projects */
		event NewProjectHandler NewProjectEvent;
		event OpenNewProjectHandler OpenNewProjectEvent;
		event OpenProjectHandler OpenProjectEvent;
		event OpenProjectIDHandler OpenProjectIDEvent;
		event ImportProjectHandler ImportProjectEvent;
		event ExportProjectHandler ExportProjectEvent;
		event QuitApplicationHandler QuitApplicationEvent;
		
		/* Managers */
		event ManageJobsHandler ManageJobsEvent; 
		event ManageTeamsHandler ManageTeamsEvent;
		event ManageCategoriesHandler ManageCategoriesEvent;
		event ManageProjects ManageProjectsEvent;
		event ManageDatabases ManageDatabasesEvent;
		event EditPreferences EditPreferencesEvent;
		
		/* Convert Video Files */
		event ConvertVideoFilesHandler ConvertVideoFilesEvent;
		
		void AddExportEntry (string name, string shortName, Action<Project, IGUIToolkit> exportAction);
		void AddImportEntry (string name, string shortName, string filterName,
		                     string filter, Func<string, Project> importFunc,
		                     bool requiresNewFile);
	}
}
