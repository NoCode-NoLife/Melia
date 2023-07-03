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
		public int ClassId { get; set; }
		public AbilityId AbilityId { get; set; }
		public string ClassName { get; set; }
		public int MaxLevel { get; set; }
		public int Price { get; set; }
		public int Time { get; set; }
		public string PriceTimeScript { get; set; }
		public string UnlockScriptName { get; set; }
		public string UnlockScriptArgStr { get; set; }
		public int UnlockScriptArgNum { get; set; }

		public bool HasUnlockScript => !string.IsNullOrWhiteSpace(this.UnlockScriptName);
		public bool HasPriceTimeScript => !string.IsNullOrWhiteSpace(this.PriceTimeScript);
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
		/// Returns abilities the given job can learn.
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public IEnumerable<AbilityTreeData> Find(string category)
		{
			if (category.StartsWith("Ability_"))
				category = category.Substring(8);

			return this.Entries.Where(a => a.Category == category);
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("category", "classId", "abilityId", "jobId", "maxLevel");

			var data = new AbilityTreeData();

			data.Category = entry.ReadString("category");
			data.JobId = (JobId)entry.ReadInt("jobId");
			data.ClassId = entry.ReadInt("classId");
			data.AbilityId = (AbilityId)entry.ReadInt("abilityId");
			data.ClassName = entry.ReadString("className");
			data.MaxLevel = entry.ReadInt("maxLevel");
			data.Price = entry.ReadInt("price", 0);
			data.Time = entry.ReadInt("time", 0);
			data.PriceTimeScript = entry.ReadString("priceTimeScript", "");

			if (entry.TryGetObject("unlockScript", out var scriptEntry))
			{
				scriptEntry.AssertNotMissing("name", "argStr", "argNum");

				data.UnlockScriptName = scriptEntry.ReadString("name");
				data.UnlockScriptArgStr = scriptEntry.ReadString("argStr");
				data.UnlockScriptArgNum = scriptEntry.ReadInt("argNum");
			}

			this.Entries.RemoveAll(a => a.JobId == data.JobId && a.AbilityId == data.AbilityId);
			this.Add(data);
		}
	}
}
