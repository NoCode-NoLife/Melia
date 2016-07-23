using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	public class GameTimeController
	{
		public const int TICKS_PER_SECOND = 10;
		public const int MILLIS_IN_TICK = 100;

		public static GameTimeController Instance = new GameTimeController();

		protected static int _gameTicks;
		protected static DateTime _gameStartTime;

		private static List<IEntity> _movingObjects = new List<IEntity>();

		private Thread TimeThread { get; set; }

		Stopwatch stopWatch;

		public void ProcessTime()
		{
			for (;;)
			{
				//Log.Debug("gameTicks: {0}", _gameTicks);
				int _oldTicks = _gameTicks;

				long runtime = stopWatch.ElapsedMilliseconds;

				_gameTicks = (int) stopWatch.ElapsedMilliseconds / MILLIS_IN_TICK;

				if (_oldTicks != _gameTicks)
				{
					moveObjects();
				}

				runtime = stopWatch.ElapsedMilliseconds - runtime;

				int sleepTime = 1 + MILLIS_IN_TICK - (int)runtime % MILLIS_IN_TICK;

				if (sleepTime > 0)
					Thread.Sleep(sleepTime);

			}
		}

		private GameTimeController()
		{
			_gameStartTime = DateTime.Now;
			_gameTicks = 0;

			stopWatch = new Stopwatch();
			stopWatch.Reset();
			stopWatch.Start();

			TimeThread = new Thread(new ThreadStart(ProcessTime));
			TimeThread.Priority = ThreadPriority.Highest;
			TimeThread.Start();

		}

		public int GetGameTicks()
		{
			return _gameTicks;
		}

		public void moveObjects()
		{
			List<IEntity> staticList;
			List<IEntity> endedEntities = new List<IEntity>();
			lock (_movingObjects)
			{
				staticList = _movingObjects.ToList();
			}

			bool endMovement;
			foreach (var entity in staticList)
			{
				endMovement = entity.UpdatePosition(_gameTicks);

				// If this entity ended its movement
				if (endMovement)
				{
					// Remove entity from moving objets
					lock (_movingObjects)
						_movingObjects.Remove(entity);

					// Add it to list of ended entities.
					endedEntities.Add(entity);
				}
			}

			Timer notifyEndedTask = null;
			notifyEndedTask = new Timer(new TimerCallback(NotifyEndedEntities), endedEntities, 0, Timeout.Infinite);
			GC.KeepAlive(notifyEndedTask);

		}

		public void NotifyEndedEntities(Object obj)
		{
			if (obj is List<IEntity>)
			{
				List<IEntity> thisList = (List<IEntity>)obj;
				foreach (var entity in thisList)
				{
					/*
					if (entity.AI != null)
						entity.AI.notifyEvent(AI.AIEventTypes.AI_EVENT_ARRIVED);
					*/
				}
			}
		}

		public void RegisterMovingObject(IEntity entity)
		{
			if (entity == null)
				return;

			lock (_movingObjects)
			{
				if (!_movingObjects.Contains(entity))
				{
					_movingObjects.Add(entity);
				}
			}
		}
	}
}
