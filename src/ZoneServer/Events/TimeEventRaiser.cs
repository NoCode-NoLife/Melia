using System;
using Yggdrasil.Scheduling;

namespace Melia.Zone.Events
{
	/// <summary>
	/// Raises time events on the event manager.
	/// </summary>
	public class TimeEventRaiser : IUpdateable
	{
		private bool _firstRun = true;

		private int _lastSecond;
		private int _lastMinute;
		private int _lastHour;

		/// <summary>
		/// Raises time events as necessary.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			var now = DateTime.Now;

			if (_firstRun)
			{
				_lastSecond = now.Second;
				_lastMinute = now.Minute;
				_lastHour = now.Hour;

				_firstRun = false;
				return;
			}

			// World tick
			ZoneServer.Instance.ServerEvents.OnWorldTick(now);

			// Raise seconds event if the seconds have changed since
			// the last update
			if (_lastSecond != now.Second)
				ZoneServer.Instance.ServerEvents.OnSecondTick(now);

			// Raise minutes event if the minutes have changed since
			// the last update
			if (_lastMinute != now.Minute)
			{
				ZoneServer.Instance.ServerEvents.OnMinuteTick(now);

				// Raise five minutes event if the minutes have changed
				// and it's now an even five minutes.
				if ((now.Minute % 5) == 0)
					ZoneServer.Instance.ServerEvents.OnFiveMinutesTick(now);

				// Raise fifteen minutes event if the minutes have changed
				// and it's now an even fifteen minutes.
				if ((now.Minute % 15) == 0)
					ZoneServer.Instance.ServerEvents.OnFifteenMinutesTick(now);

				// Raise twenty minutes event if the minutes have changed
				// and it's now an even twenty minutes.
				if ((now.Minute % 20) == 0)
					ZoneServer.Instance.ServerEvents.OnTwentyMinutesTick(now);

				// Raise thirty minutes event if the minutes have changed
				// and it's now an even thirty minutes.
				if ((now.Minute % 30) == 0)
					ZoneServer.Instance.ServerEvents.OnThirtyMinutesTick(now);
			}

			// Raise hours event if the hours have changed since
			// the last update
			if (_lastHour != now.Hour)
				ZoneServer.Instance.ServerEvents.OnHourTick(now);

			// Save times so we can compare them during the next update
			_lastSecond = now.Second;
			_lastMinute = now.Minute;
			_lastHour = now.Hour;
		}
	}
}
