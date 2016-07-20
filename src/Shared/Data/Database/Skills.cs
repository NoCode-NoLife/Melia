// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Newtonsoft.Json.Linq;
using System;
using Melia.Shared.Const;
using System.Collections.Generic;
using Melia.Shared.Util;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillEffectData
	{
		public string EffectType { get; set; }
		public int EffectId { get; set; }
		public bool IsPermanent { get; set; }
		public float LifeTime { get; set; }
		public bool CanStack { get; set; }
		public bool IsBuff { get; set; }
		public int Amount { get; set; }
		public bool IsPercent { get; set; }
		//public int MaxInteractions { get; set; }
	}

	[Serializable]
	public class SkillData
	{
		public int Id { get; set; }
		public int Level { get; set; }
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

		public float LifeInSeconds { get; set; } // Life of skill (for ground skills)
		public int EffectId { get; set; } // Effect in the ground
		public SkillType Type { get; set; }
		public bool IsDot { get; set; } // Damage overtime
		public bool IsInstant { get; set; } // if true, skill lives only one instant, otherwise, it lives during lifertime.
		//public int buffId { get; set; }
		//public bool buffCanStack { get; set; }
		//public bool buffIsPermanent { get; set; }
		//public double buffLifeInSeconds { get; set; }
		public bool EffectsDependOnSkill { get; set; }
		public int MaxInteractions { get; set; }
		public TargetType TargetType { get; set; }

		public List<SkillEffectData> effects;

		public Dictionary<Stat, StatModifier> statModifiers;

		public SkillData()
		{
			this.statModifiers = new Dictionary<Stat, StatModifier>();
		}
	}

	public enum SplashType
	{
		Square,
		Circle,
		Fan,
	}

	public enum SkillType
	{
		GROUND,
		ACTOR,
	}

	/// <summary>
	/// Skill database, indexed by skill id.
	/// </summary>
	public class SkillDb : DatabaseJsonIndexed<int, SkillData>
	{

		public Dictionary<int, Dictionary<int, SkillData>> skills;

		public SkillDb()
		{
			skills = new Dictionary<int, Dictionary<int, SkillData>>();
		}

		public SkillData FindSkill(int skillId, int level)
		{

			// Search the skill levels
			Dictionary<int, SkillData> skillLevels;
			if (!skills.TryGetValue(skillId, out skillLevels))
			{
				return null;
			}

			// Search the skill
			SkillData skill;
			if (!skillLevels.TryGetValue(level, out skill))
			{
				return null;
			}

			return skill;

		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("skillId", "level", "className", "engName", "angle", "maxRange", "waveLength", "splashType", "splashRange", "splashHeight", "splashAngle", "splashRate",
				"spConsume", "lifeTime", "visualEffectId", "isInstant", "maxInteractions", "effectsDependOnSkill", "activateOnce", "effects");

			var info = new SkillData();

			info.Id = entry.ReadInt("skillId");
			info.Level = entry.ReadInt("level");
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
			info.SpendSP = entry.ReadInt("spConsume");
			info.LifeInSeconds = entry.ReadFloat("lifeTime");
			info.EffectId = entry.ReadInt("visualEffectId");
			info.IsInstant = entry.ReadBool("isInstant");
			info.IsDot = !entry.ReadBool("activateOnce");
			info.MaxInteractions = entry.ReadInt("maxInteractions");
			info.EffectsDependOnSkill = entry.ReadBool("effectsDependOnSkill");
			if (entry.ContainsKey("targetType"))
			{
				foreach (var targetType in entry["targetType"])
				{
					switch ((string)targetType)
					{
						case "SELF":
							info.TargetType |= TargetType.SELF;
							break;
						case "FRIEND":
							info.TargetType |= TargetType.FRIEND;
							break;
						case "ENEMY":
							info.TargetType |= TargetType.ENEMY;
							break;
						case "PARTY":
							info.TargetType |= TargetType.PARTY;
							break;
						case "MONSTER":
							info.TargetType |= TargetType.MONSTER;
							break;
						default:
							Log.Error("Skill {0} tried to load invalid TargetType {1}", info.Id, entry.ReadString("targetType"));
							break;
					}
				}
				
			}

			info.effects = this.ReadClassSkillEffectEntry(entry);

			if (info.Id > 10000)
			{
				info.IsFromSkillList = true;
			}

			this.Entries[info.Id] = info;

			// Add this skill sorted by level.
			Dictionary<int, SkillData> skillLevels;

			if (skills.TryGetValue(info.Id, out skillLevels)) {
				if (skillLevels.ContainsKey(info.Level))
				{
					Log.Error("Error when loading skills. Skill Level duplicated. Skill {0} Level {1}", info.Id, info.Level);
					/// TODO , return error and exit server.
					return;
				}
				// Add this skill level
				skillLevels.Add(info.Level, info);
			} else
			{
				// Add skill level, to a new skill ID slot.
				skillLevels = new Dictionary<int, SkillData>();
				skillLevels.Add(info.Level, info);
				skills.Add(info.Id, skillLevels);
			}

		}

		protected List<SkillEffectData> ReadClassSkillEffectEntry(JObject classSkillEffectEntry)
		{
			List<SkillEffectData> effects = new List<SkillEffectData>();

			foreach (JObject entry in classSkillEffectEntry["effects"])
			{
				entry.AssertNotMissing("effectId", "isPermanent", "lifeTime", "canStack");

				var data = new SkillEffectData();

				data.EffectType = entry.ReadString("effectType");
				data.EffectId = entry.ReadInt("effectId");
				data.IsPermanent = entry.ReadBool("isPermanent");
				data.LifeTime = entry.ReadFloat("lifeTime");
				data.CanStack = entry.ReadBool("canStack");
				data.IsBuff = entry.ReadBool("isBuff");
				data.Amount = entry.ReadInt("amount");
				data.IsPercent = entry.ReadBool("isPercent");

				effects.Add(data);
			}

			return effects;
		}

	}
}
