using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class BaseExpData
	{
		public int Level { get; set; }
		public long Exp { get; set; }
	}

	[Serializable]
	public class ClassExpData
	{
		public int Rank { get; set; }
		public int Level { get; set; }
		public long Exp { get; set; }
	}

	/// <summary>
	/// Exp database.
	/// </summary>
	public class ExpDb : DatabaseJson<object>
	{
		private readonly List<BaseExpData> _exp = new List<BaseExpData>();
		private readonly List<ClassExpData> _classExp = new List<ClassExpData>();

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
		public long GetNextExp(int level)
		{
			if (level < 1)
				throw new ArgumentException("Invalid level (too low).");

			if (level > _exp.Count)
				return 0;

			var index = level - 1;
			var exp = _exp[index];

			return exp.Exp;
		}

		/// <summary>
		/// Returns the EXP required to reach the given level.
		/// </summary>
		/// <param name="level"></param>
		/// <returns></returns>
		public long GetTotalExp(int level)
		{
			var result = 0L;
			for (var i = 1; i < level; ++i)
				result += this.GetNextExp(i);

			return result;
		}

		/// <summary>
		/// Returns the total exp required to reach the next class level
		/// after the given level, in the given rank.
		/// </summary>
		/// <param name="rank"></param>
		/// <param name="level"></param>
		/// <returns></returns>
		public long GetNextTotalClassExp(int rank, int level)
		{
			var maxLevel = this.GetMaxClassLevel(rank);

			if (level < 1 || level > maxLevel)
				throw new ArgumentException($"Invalid level (expected: 1~{maxLevel}).");

			var data = _classExp.Where(a => a.Rank == rank);
			if (!data.Any())
				throw new KeyNotFoundException("No class exp data found for rank '" + rank + "' and level '" + level + "'.");

			var result = data.Where(a => a.Level <= level).Sum(a => a.Exp);

			return result;
		}

		/// <summary>
		/// Returns the max class level for the given rank.
		/// </summary>
		/// <param name="rank"></param>
		/// <returns></returns>
		public int GetMaxClassLevel(int rank)
		{
			var data = _classExp.Where(a => a.Rank == rank);
			return data.Max(a => a.Level);
		}

		/// <summary>
		/// Returns the max level.
		/// </summary>
		/// <returns></returns>
		public int GetMaxLevel()
		{
			return _exp.Where(a => a.Exp > 0).Max(a => a.Level);
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <remarks>
		/// Uses the JSON database to be fed its entries, but doesn't
		/// adhere to the Entries format and uses custom lists instead.
		/// </remarks>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			if (entry.ContainsKey("exp"))
				this.ReadExpEntry(entry);
			else if (entry.ContainsKey("classExp"))
				this.ReadClassExpEntry(entry);
			else
				throw new DatabaseErrorException("Unknown exp type.");
		}

		/// <summary>
		/// Reads given EXP entry.
		/// </summary>
		/// <param name="expEntry"></param>
		protected void ReadExpEntry(JObject expEntry)
		{
			foreach (JObject entry in expEntry["exp"])
			{
				entry.AssertNotMissing("level", "exp");

				var data = new BaseExpData();

				data.Level = entry.ReadInt("level");
				data.Exp = entry.ReadLong("exp");

				_exp.Add(data);
			}
		}

		/// <summary>
		/// Reads given class EXP entry.
		/// </summary>
		/// <param name="classExpEntry"></param>
		protected void ReadClassExpEntry(JObject classExpEntry)
		{
			foreach (JObject entry in classExpEntry["classExp"])
			{
				entry.AssertNotMissing("rank", "level", "exp");

				var data = new ClassExpData();

				data.Rank = entry.ReadInt("rank");
				data.Level = entry.ReadInt("level");
				data.Exp = entry.ReadLong("exp");

				_classExp.Add(data);
			}
		}

		/// <summary>
		/// Called after loading, adds data to Entries so the servers
		/// can show that something was loaded.
		/// </summary>
		protected override void AfterLoad()
		{
			this.Entries.AddRange(_exp.Cast<object>());
			this.Entries.AddRange(_classExp);
		}
	}
}
