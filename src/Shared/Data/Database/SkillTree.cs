// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Newtonsoft.Json.Linq;
using System;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillTree
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
	public class SkillTreeDb : DatabaseJsonIndexed<int, SkillTree>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("SkillTreeId", "SkillId", "JobId", "UnlockGrade", "LevelPerGrade", "MaxLevel");

			var info = new SkillTree();

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
