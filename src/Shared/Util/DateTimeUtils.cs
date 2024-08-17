using System;

namespace Melia.Shared.Util
{
	public static class DateTimeUtils
	{
		public static string ToSDateTimeNow => DateTime.Now.ToSDateTime();
		public static string ToSPropertyDTNow => DateTime.Now.ToSPropertyDateTime();

		/// <summary>
		/// Returns date time in a year(yyyy), month(MM), date (dd),
		/// day of week(0-6), hour (HH), minutes (mm) and seconds (ss)
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns></returns>
		public static string ToSDateTime(this DateTime dateTime)
		{
			var date = dateTime.ToString("yyyyMMdd");
			var time = dateTime.ToString("HHmmss");

			return date + $"{(int)dateTime.DayOfWeek}" + time;
		}

		/// <summary>
		/// Returns date time in a year(yyyy), month(MM), day of week(0-6),
		/// date (dd), hour (HH), minutes (mm) and seconds (ss)
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns></returns>
		public static string ToSPropertyDateTime(this DateTime dateTime)
		{
			var yearMonth = dateTime.ToString("yyyyMM");
			var date = dateTime.ToString("dd");
			var time = dateTime.ToString("HHmmss");

			return yearMonth + $"{(int)dateTime.DayOfWeek}" + date + time;
		}

		/// <summary>
		/// Convert DateTime to a format for yyyyMMdd for property usage.
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns></returns>
		public static string ToSPropertyDate(this DateTime dateTime) => dateTime.ToString("yyyyMMdd");

		/// <summary>
		/// Converts DateTime to an int in the format of yyyyMMdd.
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns></returns>
		public static int ToInt32(this DateTime dateTime) => dateTime.Year * 10000 + dateTime.Month * 100 + dateTime.Day;

		/// <summary>
		/// Returns DateTime as 32-bit unix timestamp.
		/// </summary>
		/// <param name="dt"></param>
		/// <returns></returns>
		public static int ToUnixTimeSeconds(this DateTime dt)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return (int)(dt.ToUniversalTime() - epoch).TotalSeconds;
		}
	}
}
