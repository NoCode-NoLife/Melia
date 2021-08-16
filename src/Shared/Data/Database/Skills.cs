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

		public int CoolDown { get; internal set; }
		public string CoolDownGroup { get; internal set; }
		public int OverHeat { get; internal set; }
		public int OverHeatDelay { get; internal set; }
		public string OverHeatGroup { get; internal set; }
		public int ShootTime { get; internal set; }
		public List<int> HitTime { get; internal set; }
		public List<int> HoldTime { get; internal set; }
		public int DeadHitTime { get; internal set; }
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
			entry.AssertNotMissing("skillId", "className", "name", "basicSp", "lvUpSpendSp", "angle", "maxRange", "waveLength", "splashType", "splashRange", "splashHeight", "splashAngle", "splashRate");

			var info = new SkillData();

			info.Id = entry.ReadInt("skillId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");

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
			if (entry.ContainsKey("overheat"))
			{
				info.OverHeat = entry.ReadInt("overheat");
				info.OverHeatDelay = entry.ReadInt("overHeatDelay");
				info.OverHeatGroup = entry.ReadString("overHeatGroup");
			}
			info.ShootTime = entry.ReadInt("shootTime");
			info.HitTime = (List<int>)entry.ReadArray("hitTime").ToObject<IList<int>>();
			info.HoldTime = (List<int>)entry.ReadArray("holdTime").ToObject<IList<int>>();
			info.DeadHitTime = entry.ReadInt("deadHitDelay");

			this.Entries[info.Id] = info;
		}
	}
}
