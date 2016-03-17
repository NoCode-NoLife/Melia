// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Melia.Shared.Util
{
	public static class Extensions
	{
		/// <summary>
		/// Calculates differences between 2 strings.
		/// </summary>
		/// <remarks>
		/// http://en.wikipedia.org/wiki/Levenshtein_distance
		/// </remarks>
		/// <example>
		/// <code>
		/// "test".LevenshteinDistance("test")       // == 0
		/// "test1".LevenshteinDistance("test2")     // == 1
		/// "test1".LevenshteinDistance("test1 asd") // == 4
		/// </code>
		/// </example>
		public static int LevenshteinDistance(this string str, string compare, bool caseSensitive = true)
		{
			if (!caseSensitive)
			{
				str = str.ToLower();
				compare = compare.ToLower();
			}

			var sLen = str.Length;
			var cLen = compare.Length;
			var result = new int[sLen + 1, cLen + 1];

			if (sLen == 0)
				return cLen;

			if (cLen == 0)
				return sLen;

			for (int i = 0; i <= sLen; result[i, 0] = i++) ;
			for (int i = 0; i <= cLen; result[0, i] = i++) ;

			for (int i = 1; i <= sLen; i++)
			{
				for (int j = 1; j <= cLen; j++)
				{
					var cost = (compare[j - 1] == str[i - 1]) ? 0 : 1;
					result[i, j] = Math.Min(Math.Min(result[i - 1, j] + 1, result[i, j - 1] + 1), result[i - 1, j - 1] + cost);
				}
			}

			return result[sLen, cLen];
		}

		/// <summary>
		/// Returns IP address as integer.
		/// </summary>
		/// <example>
		/// IPAddress.Parse("127.0.0.1").ToInt32(); // 0x0100007F
		/// </example>
		/// <param name="ipAddress"></param>
		/// <returns></returns>
		public static int ToInt32(this IPAddress ipAddress)
		{
			return BitConverter.ToInt32(ipAddress.GetAddressBytes(), 0);
		}

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
