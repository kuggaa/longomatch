// Sections.cs
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
using System.Linq;
using System.Runtime.Serialization;
using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces;
using Mono.Unix;
using Newtonsoft.Json;

using Image = LongoMatch.Core.Common.Image;

namespace LongoMatch.Core.Store.Templates
{

	/// <summary>
	/// A dashboard contains a set of <see cref="DashboardButton"/> disposed
	/// in a grid to code events in a the game's timeline.
	/// </summary>
	[Serializable]
	public class Dashboard: IStorable, ITemplate
	{

		const int CAT_WIDTH = 120;
		const int CAT_HEIGHT = 80;
		const int MIN_WIDTH = 320;
		const int MIN_HEIGHT = 240;

		public Dashboard ()
		{
			try {
				FieldBackground = Config.FieldBackground;
				HalfFieldBackground = Config.HalfFieldBackground;
				GoalBackground = Config.GoalBackground;
			} catch {
				/* Ingore for unit tests */
			}
			ID = Guid.NewGuid ();
			List = new List<DashboardButton> ();
		}

		void InitializeLists ()
		{
			// After being deserialized, make sure to create a default GamePeriod
			if (GamePeriods == null) {
				GamePeriods = new List<string> ();
				GamePeriods.Add ("1");
				GamePeriods.Add ("2");
			}
		}

		[OnDeserialized]
		internal void OnDeserializedMethod (StreamingContext context)
		{
			InitializeLists ();
		}

		[OnSerializing]
		internal void OnSerializingMethod (StreamingContext context)
		{
			InitializeLists ();
		}

		/// <summary>
		/// Unique ID describing the dashboard
		/// </summary>
		public Guid ID {
			get;
			set;
		}

		/// <summary>
		/// When set to <c>true</c> the dashboard is treated as a system dashboard
		/// and it can't be modified
		/// </summary>
		[JsonIgnore]
		public bool Static {
			get;
			set;
		}

		/// <summary>
		/// A list with all the buttons in this dashboard
		/// </summary>
		public List<DashboardButton> List {
			get;
			set;
		}

		/// <summary>
		/// The name of the dashboard
		/// </summary>
		public string Name {
			get;
			set;
		}

		/// <summary>
		/// A list with the default periods for this dashboard.
		/// When a new project is created this list will be used
		/// to the same amount of periods in this list and with
		/// the same names
		/// </summary>
		/// <value>The game periods.</value>
		public List<string> GamePeriods {
			get;
			set;
		}

		/// <summary>
		/// The icon used for this dashboard
		/// </summary>
		public Image Image {
			get;
			set;
		}

		/// <summary>
		/// The field background image
		/// </summary>
		public Image FieldBackground {
			get;
			set;
		}

		/// <summary>
		/// The half field background image
		/// </summary>
		public Image HalfFieldBackground {
			get;
			set;
		}

		/// <summary>
		/// The goal background image
		/// </summary>
		public Image GoalBackground {
			get;
			set;
		}

		/// <summary>
		/// When set to <c>true</c>, creating a new event does not show the dialog
		/// window to edit the event details.
		/// </summary>
		public bool DisablePopupWindow {
			get;
			set;
		}

		/// <summary>
		/// A list with all the timers used in this dashboard
		/// </summary>
		[JsonIgnore]
		public List<Timer> Timers {
			get {
				return List.OfType<Timer> ().ToList ();
			}
		}

		[JsonIgnore]
		public int CanvasWidth {
			get {
				if (List.Count == 0) {
					return MIN_WIDTH;
				}
				return Math.Max (MIN_WIDTH, (int)List.Max (c => c.Position.X + c.Width));
			}
		}

		[JsonIgnore]
		public int CanvasHeight {
			get {
				if (List.Count == 0) {
					return MIN_HEIGHT;
				}
				return Math.Max (MIN_WIDTH, (int)List.Max (c => c.Position.Y + c.Height));
			}
		}

		[JsonIgnore]
		public Dictionary<string, List<Tag>> CommonTagsByGroup {
			get {
				return List.OfType<TagButton> ().Select (t => t.Tag).
					GroupBy (t => t.Group).ToDictionary (g => g.Key, g => g.ToList ());
			}
		}

		/// <summary>
		/// Changes a hotkey for a button in the dashboard checking
		/// the hotkey is not already in use.
		/// </summary>
		/// <param name="button">Button to change the hotkey.</param>
		/// <param name="hotkey">New hotkey for the button.</param>
		public void ChangeHotkey (DashboardButton button, HotKey hotkey)
		{
			if (List.Count (d => d.HotKey == hotkey) > 0) {
				throw new HotkeyAlreadyInUse (hotkey);
			} else {
				button.HotKey = hotkey;
			}
		}

		/// <summary>
		/// Adds the default tags to a button
		/// </summary>
		/// <param name="ev">The event type where the tags will be added</param>
		public void AddDefaultTags (AnalysisEventType ev)
		{
			ev.Tags.Add (new Tag (Catalog.GetString ("Success"),
				Catalog.GetString ("Outcome")));
			ev.Tags.Add (new Tag (Catalog.GetString ("Failure"),
				Catalog.GetString ("Outcome")));
		}

		/// <summary>
		/// Checks if there are circular depedencies in the buttons links.
		/// </summary>
		/// <returns><c>false</c> if no circular dependencies where found.</returns>
		public bool HasCircularDependencies ()
		{
			foreach (DashboardButton button in List) {
				try {
					foreach (ActionLink link in button.ActionLinks) {
						CheckLinks (link, new List<DashboardButton> ());
					}
				} catch (CircularDependencyException) {
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Removes a button from the list remving also dead links.
		/// </summary>
		/// <param name="button">The button to remove.</param>
		public void RemoveButton (DashboardButton button)
		{
			List.Remove (button);
			foreach (DashboardButton b in List) {
				b.ActionLinks.RemoveAll (l => l.DestinationButton == button);
			}
		}

		/// <summary>
		/// Removes dead links for this button, called after the event tags
		/// have been edited.
		/// </summary>
		/// <param name="button">Dashboard button.</param>
		public void RemoveDeadLinks (AnalysisEventButton button)
		{
			/* Remove all links pointing to a tag that does not exists anymore */
			foreach (DashboardButton b in List) {
				b.ActionLinks.RemoveAll (l => l.DestinationButton == button &&
				l.DestinationTags != null &&
				l.DestinationTags.Count > 0 &&
				!l.DestinationTags.Intersect (button.AnalysisEventType.Tags).Any ());
			}
		}

		/// <summary>
		/// Adds a new <see cref="AnalysisEventButton"/> with the default values
		/// </summary>
		/// <returns>A new button.</returns>
		/// <param name="index">Index of this button used to name it</param>
		public AnalysisEventButton AddDefaultItem (int index)
		{
			AnalysisEventButton button;
			AnalysisEventType evtype;
			Color c = StyleConf.ButtonEventColor;
			HotKey h = new HotKey ();
			
			evtype = new AnalysisEventType {
				Name = "Event Type " + index,
				SortMethod = SortMethodType.SortByStartTime,
				Color = c
			};
			AddDefaultTags (evtype);

			button = new  AnalysisEventButton {
				EventType = evtype,
				Start = new Time{ TotalSeconds = 10 },
				Stop = new Time { TotalSeconds = 10 },
				HotKey = h,
				/* Leave the first row for the timers and score */
				Position = new Point (10 + (index % 7) * (CAT_WIDTH + 10),
					10 + (index / 7 + 1) * (CAT_HEIGHT + 10)),
				Width = CAT_WIDTH,
				Height = CAT_HEIGHT,
			};
			List.Insert (index, button);
			return button;
		}

		/// <summary>
		/// Creates a new dashboard with a default set of buttons
		/// </summary>
		/// <returns>the new dashboadrd.</returns>
		/// <param name="count">Number of <see cref="AnalysisEventButton"/> to add.</param>
		public static Dashboard DefaultTemplate (int count)
		{
			TagButton tagbutton;
			TimerButton timerButton;
			PenaltyCardButton cardButton;
			ScoreButton scoreButton;
			List<string> periods = new List<string> ();
			Dashboard template = new Dashboard ();
			
			template.FillDefaultTemplate (count);

			periods.Add ("1");
			periods.Add ("2");
			template.GamePeriods = periods; 

			tagbutton = new TagButton {
				Tag = new Tag (Catalog.GetString ("Attack"), ""),
				Position = new Point (10, 10)
			};
			template.List.Add (tagbutton);
			
			tagbutton = new TagButton {
				Tag = new Tag (Catalog.GetString ("Defense"), ""),
				Position = new Point (10 + (10 + CAT_WIDTH) * 1, 10)
			};
			template.List.Add (tagbutton);

			cardButton = new PenaltyCardButton {
				PenaltyCard = new PenaltyCard (Catalog.GetString ("Red card"),
					Color.Red, CardShape.Rectangle),
				Position = new Point (10 + (10 + CAT_WIDTH) * 2, 10)
			};
			template.List.Add (cardButton);

			cardButton = new PenaltyCardButton {
				PenaltyCard = new PenaltyCard (Catalog.GetString ("Yellow card"),
					Color.Yellow, CardShape.Rectangle),
				Position = new Point (10 + (10 + CAT_WIDTH) * 3, 10)
			};
			template.List.Add (cardButton);
			
			scoreButton = new ScoreButton {
				Score = new Score {
					Name = Catalog.GetString ("Free play goal"),
					Points = 1,
					Color = StyleConf.ButtonScoreColor
				},
				Position = new Point (10 + (10 + CAT_WIDTH) * 4, 10)
			};
			template.List.Add (scoreButton);
			
			scoreButton = new ScoreButton {
				Score = new Score {
					Name = Catalog.GetString ("Penalty goal"),
					Points = 1,
					Color = StyleConf.ButtonScoreColor
				},
				Position = new Point (10 + (10 + CAT_WIDTH) * 5, 10)
			};
			template.List.Add (scoreButton);
			
			timerButton = new TimerButton {
				Timer = new Timer { Name = Catalog.GetString ("Ball playing") },
				Position = new Point (10 + (10 + CAT_WIDTH) * 6, 10)
			};
			template.List.Add (timerButton);
			return template;
		}

		void FillDefaultTemplate (int count)
		{
			for (int i = 1; i <= count; i++)
				AddDefaultItem (i - 1);
		}

		void CheckLinks (ActionLink link, List<DashboardButton> traversed = null)
		{
			DashboardButton source;

			if (traversed == null)
				traversed = new List<DashboardButton> ();

			source = link.SourceButton;
			if (traversed.Contains (source)) {
				throw new CircularDependencyException ();
			} else {
				traversed.Add (source);
			}

			foreach (ActionLink l in link.DestinationButton.ActionLinks) {
				CheckLinks (l, traversed.ToList ());
			}
		}
	}
}
