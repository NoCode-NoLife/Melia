// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillData
	{
		public SkillId Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public int Element { get; set; }
		public float BasicSp { get; set; }
		public float LvUpSpendSp { get; set; }

		public float Angle { get; set; }
		public float MaxRange { get; set; }
		public float WaveLength { get; set; }

		public SplashType SplashType { get; set; }
		public float SplashRange { get; set; }
		public float SplashHeight { get; set; }
		public float SplashAngle { get; set; }
		public float SplashRate { get; set; }
		public float SkillFactor { get; set; }
		public int Cooldown { get; set; }
		public string CooldownGroup { get; set; }
		public int Overheat { get; set; }
		public int OverHeatDelay { get; set; }
		public string OverheatGroup { get; set; }
		public int ShootTime { get; set; }
		public List<int> HitTime { get; set; }
		public List<int> HoldTime { get; set; }
		public int DeadHitTime { get; set; }
		public bool EnableCastMove { get; set; }
		public int HitDelay { get; set; }
		public SkillUseType UseType { get; set; }
		public SkillAttribute Attribute { get; set; }
	}

	public enum SplashType
	{
		Square,
		Circle,
		Fan,
		Area,
	}

	public enum SkillUseType
	{
		UNKNOWN,
		MELEE_GROUND,
		FORCE,
		FORCE_GROUND,
		SELF,
		SCRIPT,
		TARGET_GROUND,
	}

	public enum SkillAttribute
	{
		Melee,
		Lightning,
		Holy,
		Poison,
		Dark,
		Fire,
		Ice,
		Earth,
		Soul,
	}

	/// <summary>
	/// Skill database, indexed by skill id.
	/// </summary>
	public class SkillDb : DatabaseJsonIndexed<SkillId, SkillData>
	{
		/// <summary>
		/// Returns first skill data entry with given class name, or null
		/// if it wasn't found.
		/// </summary>
		/// <param name="className"></param>
		/// <returns></returns>
		public SkillData Find(string className)
			=> this.Find(a => a.ClassName == className);

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("skillId", "className", "name", "maxLevel", "angle", "maxRange", "waveLength", "splashType", "splashRange", "splashHeight", "splashAngle", "splashRate", "skillFactor", "cooldown", "cooldownGroup", "hitDelay", "deadHitDelay", "shootTime", "hitTime", "holdTime", "enableCastMove", "useType", "attribute");

			var info = new SkillData();

			info.Id = (SkillId)entry.ReadInt("skillId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Element = entry.ReadInt("element");
			info.BasicSp = entry.ReadFloat("basicSp");
			info.LvUpSpendSp = entry.ReadFloat("lvUpSpendSp");

			info.Angle = entry.ReadFloat("angle");
			info.MaxRange = entry.ReadFloat("maxRange");
			info.WaveLength = entry.ReadFloat("waveLength");

			info.SplashType = (SplashType)entry.ReadInt("splashType");
			info.SplashRange = entry.ReadFloat("splashRange");
			info.SplashHeight = entry.ReadFloat("splashHeight");
			info.SplashAngle = entry.ReadFloat("splashAngle");
			info.SplashRate = entry.ReadFloat("splashRate");
			info.SkillFactor = entry.ReadFloat("skillFactor");

			info.Cooldown = entry.ReadInt("cooldown");
			info.CooldownGroup = entry.ReadString("cooldownGroup");

			info.ShootTime = entry.ReadInt("shootTime");
			info.HitDelay = entry.ReadInt("hitDelay");
			info.HitTime = entry.ReadList<int>("hitTime");
			info.HoldTime = entry.ReadList<int>("holdTime");
			info.DeadHitTime = entry.ReadInt("deadHitDelay");
			info.EnableCastMove = entry.ReadBool("enableCastMove");
			info.UseType = entry.ReadEnum<SkillUseType>("useType");
			info.Attribute = entry.ReadEnum<SkillAttribute>("attribute");

			info.Overheat = entry.ReadInt("overheat");
			info.OverHeatDelay = entry.ReadInt("overheatDelay");
			info.OverheatGroup = entry.ReadString("overheatGroup");

			this.Entries[info.Id] = info;
		}
	}
}
