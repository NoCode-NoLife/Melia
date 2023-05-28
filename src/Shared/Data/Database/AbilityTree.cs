using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AbilityTreeData
	{
		public string Category { get; set; }
		public JobId JobId { get; set; }
		public AbilityId AbilityId { get; set; }
		public string ClassName { get; set; }
		public int MaxLevel { get; set; }
		public int Price { get; set; }
		public int Time { get; set; }
		public string PriceTime { get; set; }
		public string Unlock { get; set; }

		public bool HasUnlock => !string.IsNullOrWhiteSpace(this.Unlock);
		public bool HasPriceTime => !string.IsNullOrWhiteSpace(this.PriceTime);
	}

	/// <summary>
	/// Ability tree database.
	/// </summary>
	public class AbilityTreeDb : DatabaseJson<AbilityTreeData>
	{
		/// <summary>
		/// Returns data for the given job and ability, or null if no
		/// data exists.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public AbilityTreeData Find(JobId jobId, AbilityId abilityId)
		{
			return this.Entries.FirstOrDefault(a => a.JobId == jobId && a.AbilityId == abilityId);
		}

		/// <summary>
		/// Returns abilities the given job can learn.
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public IEnumerable<AbilityTreeData> Find(JobId jobId)
		{
			return this.Entries.Where(a => a.JobId == jobId);
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("category", "jobId", "abilityId", "maxLevel", "unlock");

			var data = new AbilityTreeData();

			data.Category = entry.ReadString("category");
			data.JobId = (JobId)entry.ReadInt("jobId");
			data.AbilityId = (AbilityId)entry.ReadInt("abilityId");
			data.ClassName = entry.ReadString("className");
			data.MaxLevel = entry.ReadInt("maxLevel");
			data.Price = entry.ReadInt("price", 0);
			data.Time = entry.ReadInt("time", 0);
			data.PriceTime = entry.ReadString("priceTime", "");
			data.Unlock = entry.ReadString("unlock", "");

			this.Entries.RemoveAll(a => a.JobId == data.JobId && a.AbilityId == data.AbilityId);
			this.Add(data);
		}
	}
}
