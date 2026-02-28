using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillData : ITagged
	{
		public SkillId Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }

		public SkillActivationType ActivationType { get; set; }
		public SkillUseType UseType { get; set; }
		public SkillAttackType AttackType { get; set; }
		public AttributeType Attribute { get; set; }
		public SkillClassType ClassType { get; set; }
		public Tags Tags { get; set; }

		public float BasicSp { get; set; }
		public float BasicStamina { get; set; }
		public string SpendSpScript { get; set; }

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
		public int HitCount { get; set; }
		public int MultiHitCount { get; set; }

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
		public int KnockDownHAngle { get; set; }
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

		// The Vanquisher skills have an empty string as splash type.
		// TODO: Figure out what it does.
		Empty,
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

	// We used to have this dedicated skill attribute enum for the skill data
	// in addition to the AttributeType enum in Shared, which effectively does
	// the same thing. We switched over to using AttributeType to unify the
	// attributes, though we'll leave this here as a reminder for the moment,
	// and in case we might actually want or need separate enums.
	// The only difference of note is that the skill data uses a "Magic"
	// attribute, which doesn't appear to exist as a monster attribute.
	//public enum SkillAttribute
	//{
	//	None,
	//	Fire,
	//	Ice,
	//	Lightning,
	//	Earth,
	//	Poison,
	//	Holy,
	//	Dark,
	//	Soul,

	//	// Any attributes using Melee or Magic could be bugs, since those
	//	// should be attack types, not attributes. But they are found on
	//	// skills in the the client's data.
	//	Melee,
	//	Magic,
	//}

	public enum SkillClassType
	{
		None,
		Melee,
		Missile,
		Magic,
		Responsive,
	}

	/// <summary>
	/// Defines how a skill is activated.
	/// </summary>
	public enum SkillActivationType
	{
		/// <summary>
		/// Skill is used actively by an actor.
		/// </summary>
		ActiveSkill,

		/// <summary>
		/// Skill is not used and its effects are passive.
		/// </summary>
		PassiveSkill,
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
			entry.AssertNotMissing("skillId", "className", "name", "useType", "attackType", "attribute", "classType", "enableAngle", "maxRange", "waveLength", "splashType", "splashRange", "splashHeight", "splashAngle", "splashRate", "factor", "factorByLevel", "atkAdd", "atkAddByLevel", "hitCount", "multiHitCount", "defaultHitDelay", "deadHitDelay", "shootTime", "delayTime", "cancelTime", "hitTime", "holdTime", "speedRate", "speedRateAffectedByDex", "speedRateAffectedByBuff", "enableCastMove");

			var data = new SkillData();

			data.Id = (SkillId)entry.ReadInt("skillId");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");

			data.ActivationType = entry.ReadEnum<SkillActivationType>("activationType");
			data.UseType = entry.ReadEnum<SkillUseType>("useType");
			data.AttackType = entry.ReadEnum<SkillAttackType>("attackType");
			data.Attribute = entry.ReadEnum<AttributeType>("attribute");
			data.ClassType = entry.ReadEnum<SkillClassType>("classType");

			data.BasicSp = entry.ReadFloat("basicSp", 0);
			data.BasicStamina = entry.ReadFloat("basicStamina", 0);
			data.SpendSpScript = entry.ReadString("spendSpScript", "SCR_Get_SpendSP");

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
			data.HitCount = entry.ReadInt("hitCount");
			data.MultiHitCount = entry.ReadInt("multiHitCount");

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
			data.KnockDownHAngle = entry.ReadInt("knockDownHAngle", 0);
			data.KnockDownVAngle = entry.ReadInt("knockDownVAngle", 0);

			data.ReinforceAbility = entry.ReadEnum<AbilityId>("reinforceAbility", 0);
			data.HiddenReinforceAbility = entry.ReadEnum<AbilityId>("hiddenReinforceAbility", 0);
			data.HiddenReinforceAbilityFactorByLevel = entry.ReadFloat("hiddenReinforceAbilityFactorByLevel", 0);

			data.CooldownGroup = entry.ReadEnum<CooldownId>("cooldownGroup", CooldownId.Default);
			data.CooldownTime = entry.ReadTimeSpan("cooldownTime", TimeSpan.Zero);

			data.OverheatGroup = entry.ReadEnum<CooldownId>("overheatGroup", CooldownId.Default);
			data.OverheatCount = entry.ReadInt("overheatCount", 0);
			data.OverHeatDelay = entry.ReadTimeSpan("overheatDelay", TimeSpan.Zero);

			data.Tags = new Tags(entry.ReadList<string>("tags", []));

			this.AddOrReplace(data.Id, data);
		}
	}
}
