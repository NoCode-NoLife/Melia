using System;

namespace Melia.Zone
{
	public class GameTime : IFormattable
	{
		/// <summary>
		/// Time of the game's release.
		/// </summary>
		public static readonly DateTime BeginOfTime = DateTime.Parse("2016-03-28");

		/// <summary>
		/// Returns the current time in the game world.
		/// </summary>
		public static GameTime Now => new GameTime(DateTime.Now);

		/// <summary>
		/// Returns how long one hour in the game world is in real time.
		/// </summary>
		public static TimeSpan OneHour => TimeSpan.FromTicks(ZoneServer.Instance.Conf.World.TicksPerMinute * ZoneServer.Instance.Conf.World.MinutesPerHour);

		/// <summary>
		/// The current hour in the game world.
		/// </summary>
		public readonly int Hour;

		/// <summary>
		/// The current minute in the game world.
		/// </summary>
		public readonly int Minute;

		/// <summary>
		/// The current year in the game world.
		/// </summary>
		public readonly int Year;

		/// <summary>
		/// The current month in the game world.
		/// </summary>
		public readonly int Month;

		/// <summary>
		/// The current day of the month in the game world.
		/// </summary>
		public readonly int Day;

		/// <summary>
		/// DateTime object used by this instance.
		/// </summary>
		public readonly DateTime DateTime;

		/// <summary>
		/// Returns time stamp for this instance's date (Format: yyyymdd).
		/// </summary>
		public int DateTimeStamp => (this.Year * 1000 + (this.Month + 1) * 100 + this.Day);

		/// <summary>
		/// Returns the time of day based on the hours.
		/// </summary>
		public TimeOfDay TimeOfDay
		{
			get
			{
				if (this.Hour >= 4 && this.Hour < 6)
					return TimeOfDay.Dawn;
				else if (this.Hour >= 6 && this.Hour < 18)
					return TimeOfDay.Day;
				else if (this.Hour >= 18 && this.Hour < 20)
					return TimeOfDay.Dusk;
				else
					return TimeOfDay.Night;
			}
		}

		/// <summary>
		/// Generates new game time based on the given DateTime.
		/// </summary>
		/// <param name="dt"></param>
		public GameTime(DateTime dt)
		{
			this.DateTime = (dt < BeginOfTime ? BeginOfTime : dt);

			var ticksPerMinute = ZoneServer.Instance.Conf.World.TicksPerMinute;
			var minutesPerHour = ZoneServer.Instance.Conf.World.MinutesPerHour;
			var hoursPerDay = ZoneServer.Instance.Conf.World.HoursPerDay;
			var daysPerMonth = ZoneServer.Instance.Conf.World.DaysPerMonth;
			var monthsPerYear = ZoneServer.Instance.Conf.World.MonthsPerYear;

			var ticksPassed = (this.DateTime.Ticks - BeginOfTime.Ticks);
			var minutesPassed = ticksPassed / ticksPerMinute;

			this.Year = (int)(minutesPassed / minutesPerHour / hoursPerDay / daysPerMonth / monthsPerYear) + 1;
			this.Month = (int)(minutesPassed / minutesPerHour / hoursPerDay / daysPerMonth % monthsPerYear) + 1;
			this.Day = (int)(minutesPassed / minutesPerHour / hoursPerDay % daysPerMonth) + 1;
			this.Hour = (int)(minutesPassed / minutesPerHour % hoursPerDay);
			this.Minute = (int)(minutesPassed % minutesPerHour);
		}

		/// <summary>
		/// Returns an instance that's set to the next time the
		/// given hour and minute occurs.
		/// </summary>
		/// <example>
		/// If it's 00:00:00 in real-time (00:00 in game-time), then
		/// GetNextTime(12, 00) would return game-time 12:00, with a
		/// DateTime of 00:18:00.
		/// </example>
		/// <param name="hour"></param>
		/// <param name="minutes"></param>
		/// <returns></returns>
		public static GameTime GetNextTime(int hour, int minute)
			=> GetNextTime(DateTime.Now, hour, minute);

		/// <summary>
		/// Returns an instance that's set to the next time the
		/// given hour and minute occurs after the given time.
		/// </summary>
		/// <example>
		/// If it's 00:00:00 in real-time (00:00 game-time), then
		/// GetNextTime(12, 00) would return game-time 12:00, with a
		/// DateTime of 00:18:00.
		/// </example>
		/// <param name="dateTime"></param>
		/// <param name="hour"></param>
		/// <param name="minute"></param>
		/// <returns></returns>
		public static GameTime GetNextTime(DateTime dateTime, int hour, int minute)
		{
			var ticksPerMinute = ZoneServer.Instance.Conf.World.TicksPerMinute;
			var minutesPerHour = ZoneServer.Instance.Conf.World.MinutesPerHour;
			var hoursPerDay = ZoneServer.Instance.Conf.World.HoursPerDay;
			var ticksPerHour = ticksPerMinute * minutesPerHour;

			if (hour < 0 || hour >= hoursPerDay)
				throw new ArgumentException("Invalid hour.");

			if (minute < 0 || minute >= minutesPerHour)
				throw new ArgumentException("Invalid minute.");

			var gameTime = new GameTime(dateTime);

			var hours = hour - gameTime.Hour;
			var minutes = minute - gameTime.Minute;

			if (hours <= 0)
			{
				hours += hoursPerDay;
			}

			if (minutes < 0)
			{
				minutes = minutesPerHour + minutes;
				hours -= 1;
			}

			var thenDateTime = dateTime.AddTicks(hours * ticksPerHour).AddTicks(minutes * ticksPerMinute);

			return new GameTime(thenDateTime);
		}

		/// <summary>
		/// Returns a string representation of the game time.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.ToString("y-M-dd HH:mm");
		}

		/// <summary>
		/// Returns a string representation of the game time in the given
		/// format.
		/// </summary>
		/// <param name="format"></param>
		/// <param name="formatProvider"></param>
		/// <returns></returns>
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (format == null)
				return this.ToString();

			return this.ToString(format);
		}

		/// <summary>
		/// Returns a string representation of the game time in the given
		/// format.
		/// <param name="format"></param>
		/// <returns></returns>
		public string ToString(string format)
		{
			var h12 = this.Hour % 12;
			if (this.Hour == 12)
				h12 = 12;

			format = format.Replace("ampm", (h12.ToString("00") + ":" + this.Minute.ToString("00") + (this.Hour < 12 ? " A.M." : " P.M.")));

			format = format.Replace("hh", h12.ToString("00"));
			format = format.Replace("h", h12.ToString());

			format = format.Replace("HH", this.Hour.ToString("00"));
			format = format.Replace("H", this.Hour.ToString());

			format = format.Replace("mm", this.Minute.ToString("00"));
			format = format.Replace("m", this.Minute.ToString());

			format = format.Replace("yyyy", this.Year.ToString("0000"));
			format = format.Replace("yyy", this.Year.ToString("000"));
			format = format.Replace("yy", this.Year.ToString("00"));
			format = format.Replace("y", this.Year.ToString("0"));

			format = format.Replace("dd", this.Day.ToString("00"));
			format = format.Replace("d", this.Day.ToString());

			format = format.Replace("tt", (this.Hour < 12 ? "AM" : "PM"));
			format = format.Replace("t", (this.Hour < 12 ? "A" : "P"));

			format = format.Replace("MM", (this.Month + 1).ToString("00"));
			format = format.Replace("M", (this.Month + 1).ToString());

			return format;
		}
	}

	public enum TimeOfDay
	{
		Dawn,
		Day,
		Dusk,
		Night,
	}
}
