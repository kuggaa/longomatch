//
//  Copyright (C) 2015 Andoni Morales Alastruey
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
using System.IO;

namespace LongoMatch.Core.Common
{
	public class Utils
	{
		static int currentPlatformID = -1;

		public static string SanitizePath (string path, params char[] replaceChars)
		{
			path = path.Trim ();
			foreach (char c in Path.GetInvalidFileNameChars ()) {
				path = path.Replace (c, '_');
			}
			foreach (char c in replaceChars) {
				path = path.Replace (c, '_');
			}
			return path;
		}

		public static PlatformID RunningPlatform ()
		{
			if (currentPlatformID == -1) {
				currentPlatformID = (int)Environment.OSVersion.Platform;

				if (currentPlatformID == (int)PlatformID.Unix) {
					if (Directory.Exists ("/Applications")
					    & Directory.Exists ("/System")
					    & Directory.Exists ("/Users")
					    & Directory.Exists ("/Volumes")) {
						currentPlatformID = (int)PlatformID.MacOSX;
					}
				}
			}
			return (PlatformID)currentPlatformID;
		}
	}
}

