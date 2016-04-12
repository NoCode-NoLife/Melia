// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Newtonsoft.Json.Linq;
using System;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string EngName { get; set; }

		public float Angle { get; set; }
		public float MaxRange { get; set; }
		public float WaveLength { get; set; }

		public SplashType SplashType { get; set; }
		public float SplashRange { get; set; }
		public float SplashHeight { get; set; }
		public float SplashAngle { get; set; }
		public float SplashRate { get; set; }

		public float SpendSP { get; set; }

		public bool RegisterAsShortcut { get; set; } // Indicates if this skill gets auto-registered in shortcut bar when learned
		public bool IsFromSkillList { get; set; } // Indicates if this skill is learnable from the Skill List (or if its a basic skill (weapon skill, etc))
	}

	public enum SplashType
	{
		Square,
		Circle,
		Fan,
	}

	/// <summary>
	/// Skill database, indexed by skill id.
	/// </summary>
	public class SkillDb : DatabaseJsonIndexed<int, SkillData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("skillId", "className", "engName", "angle", "maxRange", "waveLength", "splashType", "splashRange", "splashHeight", "splashAngle", "splashRate");

			var info = new SkillData();

			info.Id = entry.ReadInt("skillId");
			info.ClassName = entry.ReadString("className");
			info.EngName = entry.ReadString("engName");

			info.Angle = entry.ReadFloat("angle");
			info.MaxRange = entry.ReadFloat("maxRange");
			info.WaveLength = entry.ReadFloat("waveLength");

			info.SplashType = (SplashType)entry.ReadInt("splashType");
			info.SplashRange = entry.ReadFloat("splashRange");
			info.SplashHeight = entry.ReadFloat("splashHeight");
			info.SplashAngle = entry.ReadFloat("splashAngle");
			info.SplashRate = entry.ReadFloat("splashRate");
			info.SpendSP = 10.0f;

			if (info.Id > 10000)
			{
				info.IsFromSkillList = true;
			}

			this.Entries[info.Id] = info;
		}
	}
}
