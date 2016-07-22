// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Melia.Shared.World;

namespace Melia.Shared.Util
{
	/// <summary>
	/// A few commonly used math-related functions.
	/// </summary>
	public static class Math2
	{
		/// <summary>
		/// Returns min, if val is lower than min, max, if val is
		/// greater than max, or simply val.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		public static int Clamp(int min, int max, int val)
		{
			if (val < min)
				return min;
			if (val > max)
				return max;
			return val;
		}

		/// <summary>
		/// Returns min, if val is lower than min, max, if val is
		/// greater than max, or simply val.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		public static float Clamp(float min, float max, float val)
		{
			if (val < min)
				return min;
			if (val > max)
				return max;
			return val;
		}

		/// <summary>
		/// Returns min, if val is lower than min, max, if val is
		/// greater than max, or simply val.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		public static long Clamp(long min, long max, long val)
		{
			if (val < min)
				return min;
			if (val > max)
				return max;
			return val;
		}

		/// <summary>
		/// Returns true if val is between min and max (incl).
		/// </summary>
		/// <param name="val"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static bool Between(int val, int min, int max)
		{
			return (val >= min && val <= max);
		}

		/// <summary>
		/// Calculate rotation toward target
		/// </summary>
		/// <param name="rotated"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static Direction AngleBetweenTwoEntity(Position source, Position target)
		{
			float dy = source.X - target.X;
			float dx = source.Z - target.Z;
			double angle = Math.Atan2(-dx, -dy) * 180.0 / Math.PI;
			return new Direction(
				(float)Math.Cos((angle / 180D) * Math.PI),
				(float)Math.Sin((angle / 180D) * Math.PI)
			);
		}
}
}
