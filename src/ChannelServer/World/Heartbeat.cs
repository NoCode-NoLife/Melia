using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	/// <summary>
	/// A world's heartbeat, responsible for regularly occuring events.
	/// </summary>
	public class Heartbeat
	{
		/// <summary>
		/// The time between ticks in milliseconds.
		/// </summary>
		private const int Period = 250;

		private bool _running = false;
		private Timer _heartbeatTimer;
		private Stopwatch _updateTimer;

		private int _lastSecond;
		private int _lastMinute;
		private int _lastHour;
		private int _updating;

		private readonly List<IUpdateable> _updateables = new List<IUpdateable>();

		private Stopwatch _tickDurationTimer;
		private TimeSpan _averageTickTotal;
		private int _averateTickCount;

		/// <summary>
		/// Returns the average duration of the heartbeat's tick.
		/// </summary>
		public TimeSpan AverageTickDuration { get; private set; }

		/// <summary>
		/// Raised every time the heartbeat executes.
		/// </summary>
		public event Action<DateTime> HeartbeatTick;

		/// <summary>
		/// Raised every full second.
		/// </summary>
		public event Action<DateTime> SecondTick;

		/// <summary>
		/// Raised every full minute.
		/// </summary>
		public event Action<DateTime> MinuteTick;

		/// <summary>
		/// Raised every even 5 minutes (5, 10, 15, etc.)
		/// </summary>
		public event Action<DateTime> FiveMinutesTick;

		/// <summary>
		/// Raised every even 15 minutes (0, 15, 30, 45)
		/// </summary>
		public event Action<DateTime> FifteenMinutesTick;

		/// <summary>
		/// Raised every even 20 minutes (0, 20, 40)
		/// </summary>
		public event Action<DateTime> TwentyMinutesTick;

		/// <summary>
		/// Raised every even 15 minutes (0, 30)
		/// </summary>
		public event Action<DateTime> ThirtyMinutesTick;

		/// <summary>
		/// Raised every full hour.
		/// </summary>
		public event Action<DateTime> HourTick;

		/// <summary>
		/// Starts server's heartbeat.
		/// </summary>
		public void Start()
		{
			if (_running)
				throw new InvalidOperationException("Heartbeat was already started.");

			var now = DateTime.Now;

			// Initiate event counters
			_lastSecond = now.Second;
			_lastMinute = now.Minute;
			_lastHour = now.Hour;

			// Start hearbeat
			var startIn = 1000 - now.Millisecond;

			_updateTimer = new Stopwatch();
			_tickDurationTimer = new Stopwatch();
			_heartbeatTimer = new Timer(this.OnTick, null, startIn, Period);

			_running = true;
		}

		/// <summary>
		/// Adds object to automatic heartbeat update.
		/// </summary>
		/// <param name="updateable"></param>
		public void Add(IUpdateable updateable)
		{
			lock (_updateables)
			{
				if (!_updateables.Contains(updateable))
					_updateables.Add(updateable);
			}
		}

		/// <summary>
		/// Removes object from automatic heartbeat update.
		/// </summary>
		/// <param name="updateable"></param>
		public void Remove(IUpdateable updateable)
		{
			lock (_updateables)
				_updateables.Remove(updateable);
		}

		/// <summary>
		/// Callback for heartbeat timer. Called regularly to execute Update.
		/// </summary>
		/// <param name="state"></param>
		private void OnTick(object state)
		{
			_tickDurationTimer.Restart();

			try
			{
				var elapsed = _updateTimer.Elapsed;
				_updateTimer.Restart();

				this.Update(elapsed);
			}
			catch (Exception ex)
			{
				Log.Error("Heartbeat.OnTick: {0}", ex);
			}

			_tickDurationTimer.Stop();
			this.UpdateAverageTickTime(_tickDurationTimer.Elapsed);
		}

		/// <summary>
		/// Updates the average update time of the heartbeat using the
		/// given latest duration.
		/// </summary>
		/// <param name="duration"></param>
		private void UpdateAverageTickTime(TimeSpan duration)
		{
			_averageTickTotal += duration;
			_averateTickCount++;

			if (_averateTickCount >= 10)
			{
				this.AverageTickDuration = TimeSpan.FromTicks(_averageTickTotal.Ticks / _averateTickCount);

				_averageTickTotal = TimeSpan.Zero;
				_averateTickCount = 0;
			}
		}

		/// <summary>
		/// Raises events and runs updates.
		/// </summary>
		/// <param name="elapsed"></param>
		private void Update(TimeSpan elapsed)
		{
			// Make sure only one update occurs at a time.
			if (Interlocked.CompareExchange(ref _updating, 1, 0) == 1)
			{
				Log.Warning("Heartbeat.Update: Skipping world update, previous update has not finished yet.");
				return;
			}

			try
			{
				this.RaiseTimeEvents(elapsed);
				this.UpdateUpdateables(elapsed);
			}
			catch (Exception ex)
			{
				Log.Error("Heartbeat.Update: " + ex);
			}
			finally
			{
				// Release update lock
				_updating = 0;
			}
		}

		/// <summary>
		/// Runs updates on all registered updateable objects.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateUpdateables(TimeSpan elapsed)
		{
			lock (_updateables)
			{
				for (var i = 0; i < _updateables.Count; ++i)
					_updateables[i].Update(elapsed);
			}
		}

		/// <summary>
		/// Raises time events as necessary.
		/// </summary>
		/// <param name="elapsed"></param>
		private void RaiseTimeEvents(TimeSpan elapsed)
		{
			var now = DateTime.Now;

			// World tick
			this.HeartbeatTick?.Invoke(now);

			// Stop here if this is the first time Update was called
			if (elapsed.TotalSeconds == 0)
				return;

			// Raise seconds event if the seconds have changed since
			// the last update
			if (_lastSecond != now.Second)
				this.SecondTick?.Invoke(now);

			// Raise minutes event if the minutes have changed since
			// the last update
			if (_lastMinute != now.Minute)
			{
				this.MinuteTick?.Invoke(now);

				// Raise five minutes event if the minutes have changed
				// and it's now an even five minutes.
				if ((now.Minute % 5) == 0)
					this.FiveMinutesTick?.Invoke(now);

				// Raise fifteen minutes event if the minutes have changed
				// and it's now an even fifteen minutes.
				if ((now.Minute % 15) == 0)
					this.FifteenMinutesTick?.Invoke(now);

				// Raise twenty minutes event if the minutes have changed
				// and it's now an even twenty minutes.
				if ((now.Minute % 20) == 0)
					this.TwentyMinutesTick?.Invoke(now);

				// Raise thirty minutes event if the minutes have changed
				// and it's now an even thirty minutes.
				if ((now.Minute % 30) == 0)
					this.ThirtyMinutesTick?.Invoke(now);
			}

			// Raise hours event if the hours have changed since
			// the last update
			if (_lastHour != now.Hour)
				this.HourTick?.Invoke(now);

			// Save times so we can compare them during the next update
			_lastSecond = now.Second;
			_lastMinute = now.Minute;
			_lastHour = now.Hour;
		}
	}

	/// <summary>
	/// An object that can be updated.
	/// </summary>
	public interface IUpdateable
	{
		/// <summary>
		/// Updates object.
		/// </summary>
		/// <param name="elapsed"></param>
		void Update(TimeSpan elapsed);
	}
}
