//
//  Copyright (C) 2014 Andoni Morales Alastruey
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
using LongoMatch.Store;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LongoMatch.Store
{
	public class Timer
	{
		public Timer ()
		{
			Nodes = new List<TimeNode>();
		}
		
		public string Name {
			get;
			set;
		}
		
		public List<TimeNode> Nodes {
			get;
			set;
		}
		
		[JsonIgnore]
		public Time TotalTime {
			get {
				return new Time (Nodes.Sum (tn => tn.Duration.MSeconds));
			}
		}
		
		public void Start (Time start, string name = null) {
			if (name == null)
				name = Name;
			Stop (start);
			TimeNode tn = new TimeNode {Name = name, Start = start};
			Nodes.Add (tn);
		}
		
		public void Stop (Time stop) {
			if (Nodes.Count > 0) {
				TimeNode last = Nodes.Last ();
				if (last.Stop == null) {
					last.Stop = stop;
				}
			}
		}
	}
}

