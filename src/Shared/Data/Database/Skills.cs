using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillData
	{
		public SkillId Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }

		public SkillUseType UseType { get; set; }
		public SkillAttackType AttackType { get; set; }
		public SkillAttribute Attribute { get; set; }
		public SkillClassType ClassType { get; set; }

		public int MaxLevel { get; set; }
		public float BasicSp { get; set; }
		public float BasicStamina { get; set; }

		public float EnableAngle { get; set; }
		public float MaxRange { get; set; }
		public float WaveLength { get; set; }

		public SplashType SplashType { get; set; }
		public float SplashRange { get; set; }
		public float SplashHeight { get; set; }
		public float SplashAngle { get; set; }
		public float SplashRate { get; set; }

		public float Factor { get; set; }
		public float FactorByLevel { get; set; }
		public float AtkAdd { get; set; }
		public float AtkAddByLevel { get; set; }

		public TimeSpan DefaultHitDelay { get; set; }
		public TimeSpan DeadHitDelay { get; set; }
		public TimeSpan ShootTime { get; set; }
		public TimeSpan DelayTime { get; set; }
		public TimeSpan CancelTime { get; set; }
		public List<TimeSpan> HitTime { get; set; }
		public List<TimeSpan> HoldTime { get; set; }

		public float SpeedRate { get; set; }
		public bool SpeedRateAffectedByDex { get; set; }
		public bool SpeedRateAffectedByBuff { get; set; }

		public bool EnableCastMove { get; set; }

		public HitType KnockDownHitType { get; set; }
		public int KnockDownVelocity { get; set; }
		public int KnockDownVAngle { get; set; }

		public AbilityId ReinforceAbility { get; set; }
		public AbilityId HiddenReinforceAbility { get; set; }
		public float HiddenReinforceAbilityFactorByLevel { get; set; }

		public CooldownId CooldownGroup { get; set; }
		public TimeSpan CooldownTime { get; set; }

		public CooldownId OverheatGroup { get; set; }
		public int OverheatCount { get; set; }
		public TimeSpan OverHeatDelay { get; set; }
	}

	public enum SplashType
	{
		Square,
		Circle,
		Fan,
		Area,
		Wall,
	}

	public enum SkillUseType
	{
		Melee,
		Force,
		Self,
		Script,
		MeleeGround,
		ForceGround,
		TargetGround,
	}

	public enum SkillAttackType
	{
		None,
		Slash,
		Aries,
		Strike,
		Magic,
		Arrow,
		Gun,
		Cannon,

		// These values don't seem to be attack types, but they are found
		// on skills in the client's data.
		Melee,
		Holy,
		Pad,
	}

	public enum SkillAttribute
	{
		None,
		Fire,
		Ice,
		Lightning,
		Earth,
		Poison,
		Holy,
		Dark,
		Soul,

		// Any attributes using Melee or Magic could be bugs, since those
		// should be attack types, not attributes. But they are found on
		// skills in the the client's data.
		Melee,
		Magic,
	}

	public enum SkillClassType
	{
		None,
		Melee,
		Missile,
		Magic,
		Responsive,
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

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("skillId", "className", "name", "useType", "attackType", "attribute", "classType", "maxLevel", "enableAngle", "maxRange", "waveLength", "splashType", "splashRange", "splashHeight", "splashAngle", "splashRate", "factor", "factorByLevel", "atkAdd", "atkAddByLevel", "defaultHitDelay", "deadHitDelay", "shootTime", "delayTime", "cancelTime", "hitTime", "holdTime", "speedRate", "speedRateAffectedByDex", "speedRateAffectedByBuff", "enableCastMove");

			var data = new SkillData();

			data.Id = (SkillId)entry.ReadInt("skillId");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");

			data.UseType = entry.ReadEnum<SkillUseType>("useType");
			data.AttackType = entry.ReadEnum<SkillAttackType>("attackType");
			data.Attribute = entry.ReadEnum<SkillAttribute>("attribute");
			data.ClassType = entry.ReadEnum<SkillClassType>("classType");

			data.MaxLevel = entry.ReadInt("maxLevel");
			data.BasicSp = entry.ReadFloat("basicSp", 0);
			data.BasicStamina = entry.ReadFloat("basicStamina", 0);

			data.EnableAngle = entry.ReadFloat("enableAngle");
			data.MaxRange = entry.ReadFloat("maxRange");
			data.WaveLength = entry.ReadFloat("waveLength");

			data.SplashType = entry.ReadEnum<SplashType>("splashType");
			data.SplashRange = entry.ReadFloat("splashRange");
			data.SplashHeight = entry.ReadFloat("splashHeight");
			data.SplashAngle = entry.ReadFloat("splashAngle");
			data.SplashRate = entry.ReadFloat("splashRate");

			data.Factor = entry.ReadFloat("factor");
			data.FactorByLevel = entry.ReadFloat("factorByLevel");
			data.AtkAdd = entry.ReadFloat("atkAdd");
			data.AtkAddByLevel = entry.ReadFloat("atkAddByLevel");

			data.DefaultHitDelay = entry.ReadTimeSpan("defaultHitDelay");
			data.DeadHitDelay = entry.ReadTimeSpan("deadHitDelay");
			data.ShootTime = entry.ReadTimeSpan("shootTime");
			data.DelayTime = entry.ReadTimeSpan("delayTime");
			data.CancelTime = entry.ReadTimeSpan("cancelTime");
			data.HitTime = entry.ReadList<int>("hitTime").Select(a => TimeSpan.FromMilliseconds(a)).ToList();
			data.HoldTime = entry.ReadList<int>("holdTime").Select(a => TimeSpan.FromMilliseconds(a)).ToList();

			data.SpeedRate = entry.ReadFloat("speedRate");
			data.SpeedRateAffectedByDex = entry.ReadBool("speedRateAffectedByDex");
			data.SpeedRateAffectedByBuff = entry.ReadBool("speedRateAffectedByBuff");

			data.EnableCastMove = entry.ReadBool("enableCastMove");

			data.KnockDownHitType = entry.ReadEnum<HitType>("knockDownType", HitType.Normal);
			data.KnockDownVelocity = entry.ReadInt("knockDownVelocity", 0);
			data.KnockDownVAngle = entry.ReadInt("knockDownVAngle", 0);

			data.ReinforceAbility = entry.ReadEnum<AbilityId>("reinforceAbility", 0);
			data.HiddenReinforceAbility = entry.ReadEnum<AbilityId>("hiddenReinforceAbility", 0);
			data.HiddenReinforceAbilityFactorByLevel = entry.ReadFloat("hiddenReinforceAbilityFactorByLevel", 0);

			data.CooldownGroup = entry.ReadEnum<CooldownId>("cooldownGroup", CooldownId.Default);
			data.CooldownTime = entry.ReadTimeSpan("cooldownTime", TimeSpan.Zero);

			data.OverheatGroup = entry.ReadEnum<CooldownId>("overheatGroup", CooldownId.Default);
			data.OverheatCount = entry.ReadInt("overheatCount", 0);
			data.OverHeatDelay = entry.ReadTimeSpan("overheatDelay", TimeSpan.Zero);

			this.AddOrReplace(data.Id, data);
		}
	}
}
