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

using LongoMatch.Core.Common;

namespace LongoMatch.Gui.Dialog
{
	public class AboutDialog: Gtk.AboutDialog
	{
		public AboutDialog (Version version)
		{
			ProgramName = Config.SoftwareName;
			Version = String.Format ("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
			Copyright = Config.Copyright;
			Website = Constants.WEBSITE;
			License = Config.License;
			Authors = new string[] { "Andoni Morales Alastruey", "Fluendo" };
			TranslatorCredits = Constants.TRANSLATORS;
			SetUrlHook (delegate(Gtk.AboutDialog dialog, string url) {
				try {
					System.Diagnostics.Process.Start (url);
				} catch {
				}
			});
		}
	}
}

