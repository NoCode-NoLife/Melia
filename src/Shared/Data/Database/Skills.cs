// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillData
	{
		public int Id { get; set; }
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
		public int CoolDown { get; internal set; }
		public string CoolDownGroup { get; internal set; }
		public int OverHeat { get; internal set; }
		public int OverHeatDelay { get; internal set; }
		public string OverHeatGroup { get; internal set; }
		public int ShootTime { get; internal set; }
		public List<int> HitTime { get; internal set; }
		public List<int> HoldTime { get; internal set; }
		public int DeadHitTime { get; internal set; }
		public bool EnableCastMove { get; internal set; }
		public int HitDelay { get; internal set; }
		public SkillUseType UseType { get; internal set; }
	}

	public enum SplashType
	{
		Square,
		Circle,
		Fan,
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

	/// <summary>
	/// Skill database, indexed by skill id.
	/// </summary>
	public class SkillDb : DatabaseJsonIndexed<int, SkillData>
	{
		/// <summary>
		/// Helper Function for Item Group as String to ItemGroup
		/// </summary>
		/// <param name="group"></param>
		/// <returns></returns>
		public SkillUseType GetSkillUseType(string useType)
		{
			switch (useType)
			{
				case "MELEE_GROUND": return SkillUseType.MELEE_GROUND;
				case "FORCE": return SkillUseType.FORCE;
				case "FORCE_GROUND": return SkillUseType.FORCE_GROUND;
				case "SELF": return SkillUseType.SELF;
				case "SCRIPT": return SkillUseType.SCRIPT;
				case "TARGET_GROUND": return SkillUseType.TARGET_GROUND;
				default: return SkillUseType.UNKNOWN;
			}
		}
		/// <summary>
		/// Returns first skill data entry with given class name, or null
		/// if it wasn't found.
		/// </summary>
		/// <param name="className"></param>
		/// <returns></returns>
		public SkillData Find(string className)
		{
			return this.Entries.Values.FirstOrDefault(a => a.ClassName == className);
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("skillId", "className", "name");

			var info = new SkillData();

			//{ skillId: 20007, className: "Wizard_MagicMissile", name: "Magic Missile", maxLevel: 5, element: 6, basicSp: 100, angle: 90, maxRange: 140, waveLength: 35, splashRange: 12,
			// splashAngle: 30, splashRate: -99.0, skillFactor: 115.0, skillFactorPerLevel: 115.300003, coolDown: 25000, coolDownGroup: "MagicMissile", hitDelay: 350, overHeat: 5,
			// overHeatDelay: 30000, overHeatGroup: "MagicMissile_OH", shootTime: 600, hitTime: [ 0 ], holdTime: [ 400 ], useType: "MELEE_GROUND" },

			info.Id = entry.ReadInt("skillId");
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

			info.CoolDown = entry.ReadInt("coolDown");
			info.CoolDownGroup = entry.ReadString("coolDownGroup");

			info.ShootTime = entry.ReadInt("shootTime");
			info.HitDelay = entry.ReadInt("hitDelay");
			info.HitTime = entry.ReadList<int>("hitTime");
			info.HoldTime = entry.ReadList<int>("holdTime");
			info.DeadHitTime = entry.ReadInt("deadHitDelay");
			info.EnableCastMove = entry.ReadBool("enableCastMove", false);
			info.UseType = this.GetSkillUseType(entry.ReadString("useType"));

			if (entry.ContainsKey("overheat"))
			{
				info.OverHeat = entry.ReadInt("overheat");
				info.OverHeatDelay = entry.ReadInt("overHeatDelay");
				info.OverHeatGroup = entry.ReadString("overHeatGroup");
			}

			this.Entries[info.Id] = info;
		}
	}
}
