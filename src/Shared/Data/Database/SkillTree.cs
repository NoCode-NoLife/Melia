using System;
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
		/// Returns all skills the given job can learn at a certain job
		/// level.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="jobLevel"></param>
		/// <returns></returns>
		public SkillTreeData[] FindSkills(JobId jobId, int jobLevel)
		{
			return this.Entries.Where(a => a.JobId == jobId && a.UnlockLevel <= jobLevel).ToArray();
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
