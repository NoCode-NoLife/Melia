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
		public float Factor { get; set; }
		public float FactorByLevel { get; set; }
		public int Cooldown { get; set; }
		public string CooldownGroup { get; set; }
		public int Overheat { get; set; }
		public TimeSpan OverHeatDelay { get; set; }
		public string OverheatGroup { get; set; }
		public TimeSpan ShootTime { get; set; }
		public List<TimeSpan> HitTime { get; set; }
		public List<TimeSpan> HoldTime { get; set; }
		public TimeSpan DeadHitTime { get; set; }
		public bool EnableCastMove { get; set; }
		public TimeSpan HitDelay { get; set; }
		public SkillUseType UseType { get; set; }
		public SkillAttribute Attribute { get; set; }
		public SkillClassType ClassType { get; set; }
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
		UNKNOWN,
		MELEE_GROUND,
		FORCE,
		FORCE_GROUND,
		SELF,
		SCRIPT,
		TARGET_GROUND,
		MELEE,
	}

	public enum SkillAttribute
	{
		None,
		Melee,
		Magic,
		Lightning,
		Holy,
		Poison,
		Dark,
		Fire,
		Ice,
		Earth,
		Soul,
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
			entry.AssertNotMissing("skillId", "className", "name", "maxLevel", "angle", "maxRange", "waveLength", "splashType", "splashRange", "splashHeight", "splashAngle", "splashRate", "factor", "factorByLevel", "cooldown", "cooldownGroup", "hitDelay", "deadHitDelay", "shootTime", "hitTime", "holdTime", "enableCastMove", "useType", "attribute");

			var data = new SkillData();

			data.Id = (SkillId)entry.ReadInt("skillId");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");
			data.Element = entry.ReadInt("element");
			data.BasicSp = entry.ReadFloat("basicSp");
			data.LvUpSpendSp = entry.ReadFloat("lvUpSpendSp");

			data.Angle = entry.ReadFloat("angle");
			data.MaxRange = entry.ReadFloat("maxRange");
			data.WaveLength = entry.ReadFloat("waveLength");

			data.SplashType = entry.ReadEnum<SplashType>("splashType");
			data.SplashRange = entry.ReadFloat("splashRange");
			data.SplashHeight = entry.ReadFloat("splashHeight");
			data.SplashAngle = entry.ReadFloat("splashAngle");
			data.SplashRate = entry.ReadFloat("splashRate");
			data.Factor = entry.ReadFloat("factor");
			data.FactorByLevel = entry.ReadFloat("factorByLevel");

			data.Cooldown = entry.ReadInt("cooldown");
			data.CooldownGroup = entry.ReadString("cooldownGroup");

			data.ShootTime = entry.ReadTimeSpan("shootTime");
			data.HitDelay = entry.ReadTimeSpan("hitDelay");
			data.HitTime = entry.ReadList<int>("hitTime").Select(a => TimeSpan.FromMilliseconds(a)).ToList();
			data.HoldTime = entry.ReadList<int>("holdTime").Select(a => TimeSpan.FromMilliseconds(a)).ToList();
			data.DeadHitTime = entry.ReadTimeSpan("deadHitDelay");
			data.EnableCastMove = entry.ReadBool("enableCastMove");
			data.UseType = entry.ReadEnum<SkillUseType>("useType");
			data.Attribute = entry.ReadEnum<SkillAttribute>("attribute");
			data.ClassType = entry.ReadEnum<SkillClassType>("classType");

			data.Overheat = entry.ReadInt("overheat");
			data.OverHeatDelay = entry.ReadTimeSpan("overheatDelay");
			data.OverheatGroup = entry.ReadString("overheatGroup");

			this.AddOrReplace(data.Id, data);
		}
	}
}
