using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillTreeData
	{
		public JobId JobId { get; set; }
		public SkillId SkillId { get; set; }
		public int UnlockLevel { get; set; }
		public int MaxLevel { get; set; }
	}

	/// <summary>
	/// Skill tree database.
	/// </summary>
	public class SkillTreeDb : DatabaseJson<SkillTreeData>
	{
		/// <summary>
		/// Returns all skills the given job can learn at a certain job level
		/// level.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="circle"></param>
		/// <returns></returns>
		public SkillTreeData[] FindSkills(JobId jobId, int jobLevel)
		{
			return this.Entries.Where(a => a.JobId == jobId && a.UnlockLevel <= jobLevel).ToArray();
		}

		/// <summary>
		/// Returns a list of SkillIds that the given job can learn
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public List<SkillId> FindSkills(JobId jobId)
		{
			return this.Entries.Where(a => a.JobId == jobId).Select(a => a.SkillId).ToList();
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("jobId", "skillId", "unlockLevel", "maxLevel");

			var data = new SkillTreeData();

			data.JobId = (JobId)entry.ReadInt("jobId");
			data.SkillId = (SkillId)entry.ReadInt("skillId");
			data.UnlockLevel = entry.ReadInt("unlockLevel");
			data.MaxLevel = entry.ReadInt("maxLevel");

			this.Add(data);
		}
	}
}
