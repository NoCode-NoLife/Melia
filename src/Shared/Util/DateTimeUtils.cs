using System;

namespace Melia.Shared.Util
{
	public static class DateTimeUtils
	{
		/// <summary>
		/// Returns date time in a year(yyyy), month(MM), day of week(0-6),
		/// date (dd), hour (HH), minutes (mm) and seconds (ss)
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns></returns>
		public static string ToPropertyDateTimeString(this DateTime dateTime)
		{
			var yearMonth = dateTime.ToString("yyyyMM");
			var date = dateTime.ToString("dd");
			var time = dateTime.ToString("HHmmss");

			return yearMonth + $"{(int)dateTime.DayOfWeek}" + date + time;
		}
	}
}
