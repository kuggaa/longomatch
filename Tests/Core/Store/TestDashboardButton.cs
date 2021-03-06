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
using LongoMatch.Core.Store;
using NUnit.Framework;
using LongoMatch.Core.Common;

namespace Tests.Core.Store
{
	[TestFixture()]
	public class TestDashboardButton
	{
		[Test()]
		public void TestSerialization ()
		{
			DashboardButton db = new DashboardButton ();
			Utils.CheckSerialization (db);
			db = new TimedDashboardButton ();
			Utils.CheckSerialization (db);
			db = new TagButton ();
			Utils.CheckSerialization (db);
			db = new TimerButton ();
			Utils.CheckSerialization (db);
			db = new EventButton ();
			Utils.CheckSerialization (db);
			db = new AnalysisEventButton ();
			Utils.CheckSerialization (db);
			db = new PenaltyCardButton ();
			Utils.CheckSerialization (db);
			db = new PenaltyCardButton ();
			Utils.CheckSerialization (db);
			db = new ScoreButton ();
			Utils.CheckSerialization (db);
		}
		
		[Test()]
		public void TestTimedDashboardButton ()
		{
			TimedDashboardButton db = new TimedDashboardButton ();
			Assert.IsNotNull (db.Start);
			Assert.IsNotNull (db.Stop);
		}
		
		[Test()]
		public void TestTagButton ()
		{
			TagButton db = new TagButton ();
			Assert.IsNull (db.Name);
			Assert.IsNull (db.HotKey);
			db.Tag = new Tag ("test");
			Assert.AreEqual (db.Name, "test");
			db.Name = "test2";
			Assert.AreEqual (db.Tag.Value, "test2");
		}
		
		[Test()]
		public void TestTimerButton ()
		{
			TimerButton tm = new TimerButton ();
			Assert.IsNull (tm.Name);
			tm.Timer = new Timer {Name = "test"};
			Assert.AreEqual (tm.Name, "test");
			tm.Name = "test2";
			Assert.AreEqual (tm.Timer.Name, "test2");
		}
		
		[Test()]
		public void TestEventButton ()
		{
			EventButton eb = new EventButton ();
			Assert.IsNull (eb.Name);
			Assert.IsNull (eb.BackgroundColor);
			eb.EventType = new EventType {Name = "test", Color = Color.Red};
			Assert.AreEqual (eb.Name, "test");
			Assert.AreEqual (eb.BackgroundColor, Color.Red);
			eb.Name = "test2";
			eb.BackgroundColor = Color.Blue;
			Assert.AreEqual (eb.EventType.Name, "test2");
			Assert.AreEqual (eb.EventType.Color, Color.Blue);
		}
		
		[Test()]
		public void TestAnalysisEventButton ()
		{
			AnalysisEventButton ab = new AnalysisEventButton ();
			ab.EventType = new AnalysisEventType ();
			Assert.AreEqual (ab.EventType, ab.AnalysisEventType);
		}
		
		[Test()]
		public void TestPenaltyCardButton ()
		{
			PenaltyCardButton pb = new PenaltyCardButton ();
			Assert.IsNull (pb.BackgroundColor);
			Assert.IsNull (pb.Name);
			pb.PenaltyCard = new PenaltyCard ("test", Color.Red, CardShape.Circle);
			Assert.AreEqual (pb.Name, "test");
			Assert.AreEqual (pb.BackgroundColor, Color.Red);
			Assert.AreEqual (pb.PenaltyCardEventType, pb.EventType);
		}
		
		[Test()]
		public void TestScoreButton ()
		{
			ScoreButton sb = new ScoreButton ();
			Assert.IsNull (sb.BackgroundColor);
			Assert.IsNull (sb.Name);
			sb.Score = new Score ("test", 2);
			Assert.AreEqual (sb.Name, "test");
			Assert.AreEqual (sb.BackgroundColor, sb.Score.Color);
			Assert.AreEqual (sb.ScoreEventType, sb.EventType);
		}
	}
}

