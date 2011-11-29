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
using System.Collections.Generic;

using LongoMatch.Common;
using LongoMatch.Gui;
using LongoMatch.Store;

namespace LongoMatch.Services
{
	public class GameUnitsManager
	{
		MainWindow mainWindow;
		PlayerBin player;
		Project openedProject;
		Dictionary<GameUnit, Time> gameUnitsStarted;
		ushort fps;
		
		
		public GameUnitsManager (MainWindow mainWindow, PlayerBin player)
		{
			this.mainWindow = mainWindow;
			this.player = player;
			gameUnitsStarted = new Dictionary<GameUnit, Time>();
			mainWindow.GameUnitEvent += HandleMainWindowGameUnitEvent;
		}
		
		public Project OpenedProject{
			set {
				openedProject = value;
				gameUnitsStarted.Clear();
				
				if (openedProject == null)
					return;
				
				fps = openedProject.Description.File.Fps;
				mainWindow.UpdateGameUnits(value.GameUnits);
			}
		}
	
		private void ConnectSignals() {
			mainWindow.GameUnitEvent += HandleMainWindowGameUnitEvent;
		}
		
		private void StartGameUnit(GameUnit gameUnit) {
			if (gameUnitsStarted.ContainsKey(gameUnit)){
				Log.Warning("Trying to start a game unit that was already started");
			} else {
				gameUnitsStarted.Add(gameUnit, new Time{MSeconds=(int)player.CurrentTime});
			}
		}
		
		private void CancelGameUnit(GameUnit gameUnit) {
			if (gameUnitsStarted.ContainsKey(gameUnit)) {
				gameUnitsStarted.Remove(gameUnit);
			} else {
				Log.Warning("Tryed to cancel a game unit that was not started: " + gameUnit);
			}
			Log.Debug("Cancelled pending unit for game unit:" + gameUnit);
		}
		
		private void StopGameUnit(GameUnit gameUnit) {
			TimelineNode timeInfo;
			Time start, stop;
			
			if (!gameUnitsStarted.ContainsKey(gameUnit)) {
				Log.Warning("Tryed to stop a game unit that was not started: " + gameUnit);
				return;
			}
			
			start = gameUnitsStarted[gameUnit];
			stop = new Time{MSeconds=(int)player.CurrentTime};
			timeInfo = new TimelineNode {Name=gameUnit.Name, Fps=fps, Start=start, Stop=stop};
			
			gameUnit.Add(timeInfo);
			gameUnitsStarted.Remove(gameUnit);
			Log.Debug(String.Format("Added new unit:{0} to {1} ", timeInfo, gameUnit));
		}

		void HandleMainWindowGameUnitEvent (GameUnit gameUnit, LongoMatch.Common.GameUnitEventType eType)
		{
			Log.Debug("Received GameUnit event of type: " + eType);
			switch (eType) {
			case GameUnitEventType.Start:
			{
				StartGameUnit(gameUnit);
				break;
			}
			case GameUnitEventType.Cancel:
			{
				CancelGameUnit(gameUnit);
				break;
			}
			case GameUnitEventType.Stop:
			{
				StopGameUnit(gameUnit);
				break;
			}
			}
		}
	}
}