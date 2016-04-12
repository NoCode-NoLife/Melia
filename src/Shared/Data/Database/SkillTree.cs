// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillTreeInfo
	{
		public int Id { get; set; }
		public int SkillId { get; set; }
		public int JobId { get; set; }
		public int UnlockGrade { get; set; }
		public int LevelPerGrade { get; set; }
		public int MaxLevel { get; set; }
	}

	/// <summary>
	/// SkillTree database
	/// </summary>
	public class SkillTreeDb : DatabaseJsonIndexed<int, SkillTreeInfo>
	{
		public List<SkillTreeInfo> FindByJobId(int jobId)
		{
			return this.Entries.FindAll(a => a.Value.JobId.Equals(jobId));
		}

		public List<SkillTreeInfo> FindBySkillId(int skillId)
		{
			return this.Entries.FindAll(a => a.Value.SkillId.Equals(skillId));
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("SkillTreeId", "SkillId", "JobId", "UnlockGrade", "LevelPerGrade", "MaxLevel");

			var info = new SkillTreeInfo();

			info.Id = entry.ReadInt("SkillTreeId");
			info.SkillId = entry.ReadInt("SkillId");
			info.JobId = entry.ReadInt("JobId");
			info.UnlockGrade = entry.ReadInt("UnlockGrade");
			info.LevelPerGrade = entry.ReadInt("LevelPerGrade");
			info.MaxLevel = entry.ReadInt("MaxLevel");

			this.Entries[info.Id] = info;
		}
	}
}
