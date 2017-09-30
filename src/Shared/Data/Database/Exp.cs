// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ClassExpData
	{
		public int Rank { get; set; }
		public int Level { get; set; }
		public int Exp { get; set; }
	}

	/// <summary>
	/// Exp database.
	/// </summary>
	public class ExpDb : DatabaseJson<object>
	{
		private List<int> _exp = new List<int>();
		private List<ClassExpData> _classExp = new List<ClassExpData>();

		/// <summary>
		/// Returns exp required to reach the next level after the
		/// given one.
		/// </summary>
		/// <remarks>
		/// Returns 0 if there's no data for the given level,
		/// i.e. if it's the last one or goes beyond.
		/// </remarks>
		/// <param name="level"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">Thrown if level is invalid (< 1).</exception>
		public int GetExp(int level)
		{
			if (level < 1)
				throw new ArgumentException("Invalid level (too low).");

			if (level > _exp.Count)
				return 0;

			var index = level - 1;
			var exp = _exp[index];

			return exp;
		}

		/// <summary>
		/// Returns the EXP required to reach the given level.
		/// </summary>
		/// <param name="level"></param>
		/// <returns></returns>
		public int GetTotalExp(int level)
		{
			var result = 0;
			for (var i = 1; i < level; ++i)
				result += this.GetExp(i);

			return result;
		}

		/// <summary>
		/// Returns the total exp required to reach the next class level
		/// after the given level, in the given rank.
		/// </summary>
		/// <param name="rank"></param>
		/// <param name="level"></param>
		/// <returns></returns>
		public int GetTotalClassExp(int rank, int level)
		{
			if (level < 1 || level > 15)
				throw new ArgumentException("Invalid level (expected: 1~15).");

			var data = _classExp.Where(a => a.Rank == rank);
			if (!data.Any())
				throw new KeyNotFoundException("No class exp data found for rank '" + rank + "' and level '" + level + "'.");

			var result = data.Where(a => a.Level <= level).Sum(a => a.Exp);

			return result;
		}

		protected override void ReadEntry(JObject entry)
		{
			if (entry.ContainsKey("exp"))
				this.ReadExpEntry(entry);
			else if (entry.ContainsKey("classExp"))
				this.ReadClassExpEntry(entry);
			else
				throw new DatabaseErrorException("Unknown exp type.");
		}

		protected void ReadExpEntry(JObject expEntry)
		{
			foreach (JObject entry in expEntry["exp"])
			{
				entry.AssertNotMissing("level", "exp");

				var exp = entry.ReadInt("exp");

				_exp.Add((int)exp);
			}
		}

		protected void ReadClassExpEntry(JObject classExpEntry)
		{
			foreach (JObject entry in classExpEntry["classExp"])
			{
				entry.AssertNotMissing("rank", "level", "exp");

				var data = new ClassExpData();

				data.Rank = entry.ReadInt("rank");
				data.Level = entry.ReadInt("level");
				data.Exp = entry.ReadInt("exp");

				_classExp.Add(data);
			}
		}

		protected override void AfterLoad()
		{
			// To display that something was loaded.
			this.Entries.AddRange(_exp.Cast<object>());
			this.Entries.AddRange(_classExp);
		}
	}
}
