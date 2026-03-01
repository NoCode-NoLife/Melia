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
	public class JobExpData
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
		private readonly List<BaseExpData> _exp = new();
		private readonly List<JobExpData> _jobExp = new();

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
		/// Returns the total exp required to reach the next job level
		/// after the given level, in the given rank.
		/// </summary>
		/// <param name="rank"></param>
		/// <param name="level"></param>
		/// <returns></returns>
		public long GetNextTotalJobExp(int rank, int level)
		{
			var maxLevel = this.GetMaxJobLevel(rank);

			if (level < 1 || level > maxLevel)
				throw new ArgumentException($"Invalid level (expected: 1~{maxLevel}, got: {level}).");

			var highestRank = _jobExp.Max(a => a.Rank);
			if (rank > highestRank)
				rank = highestRank;

			var data = _jobExp.Where(a => a.Rank == rank);
			if (!data.Any())
				throw new KeyNotFoundException("No job exp data found for rank '" + rank + "' and level '" + level + "'.");

			var result = data.Where(a => a.Level <= level).Sum(a => a.Exp);

			return result;
		}

		/// <summary>
		/// Returns the max job level for the given rank.
		/// </summary>
		/// <param name="rank"></param>
		/// <returns></returns>
		public int GetMaxJobLevel(int rank)
		{
			var highestRank = _jobExp.Max(a => a.Rank);
			if (rank > highestRank)
				rank = highestRank;

			var data = _jobExp.Where(a => a.Rank == rank);
			if (!data.Any())
				throw new KeyNotFoundException("No job exp data found for rank '" + rank + "'.");

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
			else if (entry.ContainsKey("jobExp"))
				this.ReadJobExpEntry(entry);
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
		/// Reads given job EXP entry.
		/// </summary>
		/// <param name="jobExpEntry"></param>
		protected void ReadJobExpEntry(JObject jobExpEntry)
		{
			foreach (JObject entry in jobExpEntry["jobExp"])
			{
				entry.AssertNotMissing("rank", "level", "exp");

				var data = new JobExpData();

				data.Rank = entry.ReadInt("rank");
				data.Level = entry.ReadInt("level");
				data.Exp = entry.ReadLong("exp");

				_jobExp.Add(data);
			}
		}

		/// <summary>
		/// Called after loading, adds data to Entries so the servers
		/// can show that something was loaded.
		/// </summary>
		protected override void AfterLoad()
		{
			this.Entries.AddRange(_exp.Cast<object>());
			this.Entries.AddRange(_jobExp);
		}
	}
}
