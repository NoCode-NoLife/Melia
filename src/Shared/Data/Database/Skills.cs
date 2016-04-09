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
			entry.AssertNotMissing("skillId", "className", "engName", "angle", "maxRange", "waveLength", "splashType", "splashRange", "splashHeight", "splashAngle");

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

			this.Entries[info.Id] = info;
		}
	}
}
