// Project.cs
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
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Mono.Unix;

using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces;
using LongoMatch.Core.Store;
using LongoMatch.Core.Store.Playlists;
using LongoMatch.Core.Store.Templates;

namespace LongoMatch.Core.Store
{

	/// <summary>
	/// I hold the information needed by a project and provide persistency using
	/// the db4o database.
	/// I'm structured in the following way:
	/// -Project Description (<see cref="LongoMatch.Utils.PreviewMediaFile"/>
	/// -1 Categories Template
	/// -1 Local Team Template
	/// -1 Visitor Team Template
	/// -1 list of <see cref="LongoMatch.Store.MediaTimeNode"/> for each category
	/// </summary>
	///
	[Serializable]
	public class Project : IComparable, IStorable
	{
		ProjectDescription description;
		SubstitutionEventType subsType;

		#region Constructors

		public Project ()
		{
			ID = System.Guid.NewGuid ();
			Timeline = new List<TimelineEvent> ();
			Dashboard = new Dashboard ();
			LocalTeamTemplate = new Team ();
			VisitorTeamTemplate = new Team ();
			Timers = new List<Timer> ();
			Periods = new List<Period> ();
			Playlists = new List<Playlist> ();
			EventTypes = new List<EventType> ();
		}

		#endregion

		#region Properties

		/// <summary>
		/// Unique ID for the project
		/// </summary>
		public Guid ID {
			get;
			set;
		}

		public List<TimelineEvent> Timeline {
			get;
			set;
		}

		public ProjectDescription Description {
			get {
				return description;
			}
			set {
				if (value != null) {
					value.ProjectID = ID;
				}
				description = value;
			}
		}

		[JsonProperty (Order = -7)]
		public List<EventType> EventTypes {
			get;
			set;
		}

		/// <value>
		/// Categories template
		/// </value>
		[JsonProperty (Order = -10)]
		public Dashboard Dashboard {
			get;
			set;
		}

		/// <value>
		/// Local team template
		/// </value>
		[JsonProperty (Order = -9)]
		public Team LocalTeamTemplate {
			get;
			set;
		}

		/// <value>
		/// Visitor team template
		/// </value>
		[JsonProperty (Order = -8)]
		public Team VisitorTeamTemplate {
			get;
			set;
		}

		public List<Period> Periods {
			get;
			set;
		}

		public List<Timer> Timers {
			get;
			set;
		}

		public List<Playlist> Playlists {
			get;
			set;
		}

		[JsonIgnore]
		public List<Score> Scores {
			get {
				var scores = Dashboard.List.OfType<ScoreButton> ().Select (b => b.Score);
				return ScoreEvents.Select (e => e.Score).Union (scores).OrderByDescending (s => s.Points).ToList ();
			}
		}

		[JsonIgnore]
		public List<PenaltyCard> PenaltyCards {
			get {
				var pc = Dashboard.List.OfType<PenaltyCardButton> ().Select (b => b.PenaltyCard);
				return PenaltyCardsEvents.Select (e => e.PenaltyCard).Union (pc).ToList ();
			}
		}

		[JsonIgnore]
		public List<ScoreEvent> ScoreEvents {
			get {
				return Timeline.OfType<ScoreEvent> ().Select (t => t).ToList ();
			}
		}

		[JsonIgnore]
		public List<PenaltyCardEvent> PenaltyCardsEvents {
			get {
				return Timeline.OfType<PenaltyCardEvent> ().Select (t => t).ToList ();
			}
		}

		[JsonIgnore]
		public IEnumerable<IGrouping<EventType, TimelineEvent>> EventsGroupedByEventType {
			get {
				return Timeline.GroupBy (play => play.EventType);
			}
		}

		[JsonIgnore]
		public SubstitutionEventType SubstitutionsEventType {
			get {
				if (subsType == null) {
					subsType = EventTypes.OfType<SubstitutionEventType> ().FirstOrDefault ();
					if (subsType == null) {
						subsType = new SubstitutionEventType ();
						subsType.SortMethod = SortMethodType.SortByStartTime;
					}
				}
				return subsType;
			}
		}

		[JsonIgnore]
		public LineupEvent Lineup {
			get {
				LineupEvent lineup = Timeline.OfType <LineupEvent> ().FirstOrDefault ();
				if (lineup == null) {
					lineup = CreateLineupEvent ();
				}
				return lineup;
			}
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Frees all the project's resources helping the GC
		/// </summary>
		public void Clear ()
		{
			Timeline.Clear ();
			Dashboard.List.Clear ();
			VisitorTeamTemplate.List.Clear ();
			LocalTeamTemplate.List.Clear ();
			Periods.Clear ();
			Timers.Clear ();
		}

		public void UpdateScore ()
		{
			Description.LocalGoals = GetScore (TeamType.LOCAL);
			Description.VisitorGoals = GetScore (TeamType.VISITOR);
		}

		public TimelineEvent AddEvent (EventType type, Time start, Time stop, Time eventTime, Image miniature,
		                               Score score, PenaltyCard card, bool addToTimeline = true)
		{
			TimelineEvent evt;
			string count;
			string name;

			count = String.Format ("{0:000}", EventsByType (type).Count + 1);
			if (type is PenaltyCardEventType) {
				name = String.Format ("{0} {1}", card.Name, count);
				evt = new PenaltyCardEvent { PenaltyCard = card };
			} else if (type is ScoreEventType) {
				name = String.Format ("{0} {1}", score.Name, count);
				evt = new ScoreEvent { Score = score };
			} else {
				name = String.Format ("{0} {1}", type.Name, count);
				evt = new TimelineEvent ();
			}
			
			evt.Name = name;
			evt.Start = start;
			evt.Stop = stop;
			evt.EventTime = eventTime;
			evt.EventType = type;
			evt.Notes = "";
			evt.Miniature = miniature;
			evt.CamerasConfig = new List<CameraConfig> { new CameraConfig (0) };

			if (addToTimeline) {
				Timeline.Add (evt);
				if (evt is ScoreEvent) {
					UpdateScore ();
				}
			}
			return evt;
		}

		public void AddEvent (TimelineEvent play)
		{
			Timeline.Add (play);
			if (play is ScoreEvent) {
				UpdateScore ();
			}
		}

		/// <summary>
		/// Delete a play from the project
		/// </summary>
		/// <param name="tNode">
		/// A <see cref="MediaTimeNode"/>: play to be deleted
		/// </param>
		/// <param name="section">
		/// A <see cref="System.Int32"/>: category the play belongs to
		/// </param>
		public void RemoveEvents (List<TimelineEvent> plays)
		{
			bool updateScore = false;

			foreach (TimelineEvent play in plays) {
				Timeline.Remove (play);
				if (play is ScoreEvent) {
					updateScore = true;
				}
			}
			if (updateScore) {
				UpdateScore ();
			}
		}

		public void CleanupTimers ()
		{
			foreach (Timer t in Timers) {
				t.Nodes.RemoveAll (tn => tn.Start == null || tn.Stop == null);
			}
		}

		public void UpdateEventTypesAndTimers ()
		{
			IEnumerable<EventType> dashboardtypes = new List<EventType> ();
			IEnumerable<EventType> timelinetypes;

			if (Dashboard != null) {
				/* Timers */
				IEnumerable<Timer> timers = Dashboard.List.OfType<TimerButton> ().Select (b => b.Timer);
				Timers.AddRange (timers.Except (Timers));
			
				/* Update event types list that changes when the user adds or remove a
				 * a new button to the dashboard or after importing a project with events
				 * tagged with a different dashboard */
				dashboardtypes = Dashboard.List.OfType<EventButton> ().Select (b => b.EventType);
			}

			/* Remove event types that have no events and are not in the dashboard anymore */
			foreach (EventType evt in EventTypes.Except (dashboardtypes).ToList ()) {
				if (evt == SubstitutionsEventType) {
					continue;
				}
				if (Timeline.Count (e => e.EventType == evt) == 0) {
					EventTypes.Remove (evt);
				}
			}
			EventTypes.AddRange (dashboardtypes.Except (EventTypes));
			timelinetypes = Timeline.Select (t => t.EventType).Distinct ().Except (EventTypes);
			EventTypes.AddRange (timelinetypes.Except (EventTypes));
			if (!EventTypes.Contains (SubstitutionsEventType)) {
				EventTypes.Add (SubstitutionsEventType);
			}

			/* Remove null EventTypes just in case */
			EventTypes = EventTypes.Where (e => e != null).ToList ();
		}

		public SubstitutionEvent SubsitutePlayer (Team template, Player playerIn, Player playerOut,
		                                          SubstitutionReason reason, Time subsTime)
		{
			TeamType team;
			LineupEvent lineup;
			SubstitutionEvent se;
			
			if (template == LocalTeamTemplate) {
				team = TeamType.LOCAL;
			} else {
				team = TeamType.VISITOR;
			}
			lineup = Timeline.OfType<LineupEvent> ().FirstOrDefault ();
			if (lineup == null) {
				throw new SubstitutionException (Catalog.GetString ("No lineup events found"));
			}
			if (subsTime < lineup.EventTime) {
				throw new SubstitutionException (Catalog.GetString ("A substitution can't happen before the lineup event"));
			}
			se = new SubstitutionEvent ();
			se.EventType = SubstitutionsEventType;
			se.In = playerIn;
			se.Out = playerOut;
			se.Reason = reason;
			se.EventTime = subsTime;
			se.Team = team;
			Timeline.Add (se);
			return se;
		}

		public void CurrentLineup (Time currentTime,
		                           out List<Player> homeFieldPlayers,
		                           out List<Player> homeBenchPlayers,
		                           out List<Player> awayFieldPlayers,
		                           out List<Player> awayBenchPlayers)
		{
			Team homeTeam, awayTeam;
			List<Player> homeTeamPlayers, awayTeamPlayers;

			homeTeamPlayers = Lineup.HomeStartingPlayers.Concat (Lineup.HomeBenchPlayers).ToList ();
			awayTeamPlayers = Lineup.AwayStartingPlayers.Concat (Lineup.AwayBenchPlayers).ToList ();

			foreach (SubstitutionEvent ev in Timeline.OfType<SubstitutionEvent> ().
			         Where (e => e.EventTime <= currentTime)) {
				if (ev.In != null && ev.Out != null) {
					if (ev.Team == TeamType.LOCAL) {
						homeTeamPlayers.Swap (ev.In, ev.Out);
					} else {
						awayTeamPlayers.Swap (ev.In, ev.Out);
					}
				}
			}

			homeTeam = new Team {
				Formation = LocalTeamTemplate.Formation,
				List = homeTeamPlayers
			};
			awayTeam = new Team {
				Formation = VisitorTeamTemplate.Formation,
				List = awayTeamPlayers
			};
			
			homeFieldPlayers = homeTeam.StartingPlayersList;
			homeBenchPlayers = homeTeam.BenchPlayersList;
			awayFieldPlayers = awayTeam.StartingPlayersList;
			awayBenchPlayers = awayTeam.BenchPlayersList;
		}

		public bool LineupChanged (Time start, Time stop)
		{
			return Timeline.OfType<SubstitutionEvent> ().
				Count (s => s.EventTime > start && s.EventTime <= stop) > 0;
		}

		public LineupEvent CreateLineupEvent ()
		{
			Time startTime;
			LineupEvent lineup;

			if (Periods.Count == 0) {
				startTime = new Time (0);
			} else {
				startTime = Periods [0].PeriodNode.Start;
			}

			lineup = new LineupEvent {
				Name = Catalog.GetString ("Lineup"),
				EventType = SubstitutionsEventType,
				HomeStartingPlayers = LocalTeamTemplate.StartingPlayersList,
				HomeBenchPlayers = LocalTeamTemplate.BenchPlayersList,
				AwayStartingPlayers = VisitorTeamTemplate.StartingPlayersList,
				AwayBenchPlayers = VisitorTeamTemplate.BenchPlayersList, 
				EventTime = startTime
			};
			Timeline.Add (lineup);

			return lineup;
		}

		public List<TimelineEvent> EventsByType (EventType evType)
		{
			return Timeline.Where (p => p.EventType.ID == evType.ID).ToList ();
		}

		public int GetScore (TeamType team)
		{
			return Timeline.OfType<ScoreEvent> ().Where (s => EventTaggedTeam (s) == team).Sum (s => s.Score.Points); 
		}

		public TeamType EventTaggedTeam (TimelineEvent play)
		{
			bool home = false, away = false;
			
			if (play.Team == TeamType.LOCAL || play.Team == TeamType.BOTH ||
			    play.Players.Count (p => LocalTeamTemplate.List.Contains (p)) > 0) {
				home = true;
			}
			if (play.Team == TeamType.VISITOR || play.Team == TeamType.BOTH ||
			    play.Players.Count (p => VisitorTeamTemplate.List.Contains (p)) > 0) {
				away = true;
			}
			
			if (away && home) {
				return TeamType.BOTH;
			} else if (home) {
				return TeamType.LOCAL;
			} else if (away) {
				return TeamType.VISITOR;
			} else {
				return TeamType.NONE;
			}
		}

		public Image GetBackground (FieldPositionType pos)
		{
			switch (pos) {
			case FieldPositionType.Field:
				return Dashboard.FieldBackground;
			case FieldPositionType.HalfField:
				return Dashboard.HalfFieldBackground;
			case FieldPositionType.Goal:
				return Dashboard.GoalBackground;
			}
			return null;
		}

		public void ConsolidateDescription ()
		{
			Description.LastModified = DateTime.UtcNow;
			Description.LocalName = LocalTeamTemplate.Name;
			Description.LocalShield = LocalTeamTemplate.Shield;
			Description.LocalGoals = GetScore (TeamType.LOCAL);
			Description.VisitorName = VisitorTeamTemplate.Name;
			Description.VisitorShield = VisitorTeamTemplate.Shield;
			Description.VisitorGoals = GetScore (TeamType.VISITOR);
		}


		/// <summary>
		/// Resynchronize events with the periods synced with the video file.
		/// Imported projects or fake analysis projects create events assuming periods
		/// don't have gaps between them.
		/// After adding a file to the project and synchronizing the periods with the
		/// video file, all events must be offseted with the new start time of the period.
		/// 
		/// Before sync:
		///   Period 1: start=00:00:00 Period 2: start=00:30:00
		///   evt1 00:10:00            evt2 00:32:00
		/// After sync:
		///   Period 1: start=00:05:00 Period 2: start= 00:39:00
		///   evt1 00:15:00            evt2 00:41:00
		/// </summary>
		/// <param name="periods">The new periods syncrhonized with the video file.</param>
		public void ResyncEvents (List<Period> periods)
		{
			List<TimelineEvent> newTimeline = new List<TimelineEvent> ();

			if (periods.Count != Periods.Count) {
				throw new IndexOutOfRangeException (
					"Periods count is different from the project's ones");
			}

			for (int i = 0; i < periods.Count; i++) {
				Period oldPeriod = Periods [i];
				TimeNode oldTN = oldPeriod.PeriodNode;
				TimeNode newTN = periods [i].PeriodNode;
				Time diff = newTN.Start - oldTN.Start;

				/* Find the events in this period */
				var periodEvents = Timeline.Where (e =>
					e.EventTime >= oldTN.Start &&
				                   e.EventTime <= oldTN.Stop).ToList ();

				/* Apply new offset and move the new timeline so that the next
				 * iteration for the following period does not use them anymore */
				periodEvents.ForEach (e => {
					e.Move (diff);
					newTimeline.Add (e);
					Timeline.Remove (e);
				});
				oldPeriod.Nodes.ForEach (t => t.Move (diff));
			}
			Timeline = newTimeline;
		}

		public bool Equals (Project project)
		{
			if (project == null)
				return false;
			else
				return ID == project.ID;
		}

		public int CompareTo (object obj)
		{
			if (obj is Project) {
				Project project = (Project)obj;
				return ID.CompareTo (project.ID);
			} else
				throw new ArgumentException ("object is not a Project and cannot be compared");
		}

		public static void Export (Project project, string file)
		{
			file = Path.ChangeExtension (file, Constants.PROJECT_EXT);
			Serializer.Save (project, file);
		}

		public static Project Import (string file)
		{
			try {
				return Serializer.Load<Project> (file);
			} catch (Exception e) {
				Log.Exception (e);
				throw new Exception (Catalog.GetString ("The file you are trying to load " +
				"is not a valid project"));
			}
		}

		#endregion
	}
}
