// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World
{
	public class Skill : IPropertyObject
	{
		/// <summary>
		/// The skill's unique id.
		/// </summary>
		/// <remarks>
		/// We're basically assigning a new object id to every skill here,
		/// every time it's loaded. That *might* work, but we have to be
		/// careful. If there's a single case where the skill id needs to
		/// persist, we have to seriously rethink our approach to object
		/// ids, and potentially create a global pool on the database or
		/// something.
		/// </remarks>
		public long ObjectId { get; } = ChannelServer.Instance.World.CreateSkillObjectId();

		/// <summary>
		/// The skill's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties();

		/// <summary>
		/// The skill's owner.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns the skill's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Gets or sets skill's level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Returns the amount of SP necessary to use the skill.
		/// </summary>
		public int SpendSp
		{
			get
			{
				var lvUpSpendSpRounded = Math.Round(this.Data.LvUpSpendSp, 4);
				return (int)(this.Data.BasicSp + (this.Level - 1) * lvUpSpendSpRounded);
			}
		}

		/// <summary>
		/// Over Heat Counter
		/// </summary>
		public int OverHeatCount { get; set; }

		/// <summary>
		/// The skill's data from the skill database.
		/// </summary>
		/// <remarks>
		/// Potentially temporary. It would be better to have everything
		/// directly on the Skill, but there are 200 skill properties,
		/// not every skill needs all of them, and a lot of those,
		/// presumably, simply use the value from data, without any
		/// modification or need to store them across sessions.
		/// Hold off decisions until we know more about skill's property
		/// usage.
		/// </remarks>
		public SkillData Data { get; }
		public CoolDownData CoolDownData { get; }
		public CoolDownData OverHeatData { get; }

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		/// <param name="level"></param>
		public Skill(Character character, int skillId, int level)
		{
			this.Character = character;
			this.Id = skillId;
			this.Level = level;
			this.OverHeatCount = 0; // So they don't reuse this value just cooldown value?
			this.Data = ChannelServer.Instance.Data.SkillDb.Find(skillId) ?? throw new ArgumentException($"Unknown skill '{skillId}'.");
			this.CoolDownData = ChannelServer.Instance.Data.CoolDownDb.Find(this.Data.CoolDownGroup) ?? throw new ArgumentException($"Unknown skill '{skillId}' cooldown group '{this.Data.CoolDownGroup}'.");
			this.OverHeatData = ChannelServer.Instance.Data.CoolDownDb.Find(this.Data.OverHeatGroup) ?? throw new ArgumentException($"Unknown skill '{skillId}' overheat group '{this.Data.OverHeatGroup}'.");

			// I don't know what exactly LevelByDB's purpose is, but if
			// it's not sent, skills can be leveled past their max level.
			// It's like that's the value the client uses to calculate
			// the current max level.

			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.Level, () => this.Level));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.LevelByDB, () => this.Level));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SpendSP, () => this.SpendSp));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.WaveLength, () => this.Data.WaveLength));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SplAngle, () => this.Data.SplashAngle));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SplRange, () => this.Data.SplashRange));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SR, () => this.Data.SplashRate));

			// This property's value is the result of a Lua function,
			// see skill.ies. Does the item's SR (SCR_Get_Skl_SR) count
			// towards this as well?
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SkillSR, () => this.Data.SplashRate + this.Character.SplashRate));

			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.MaxR, () => this.Data.MaxRange));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.CoolDown, () => this.Data.CoolDown));
			//this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SpendItemCount, () => 1f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.WaveLength, () => this.Data.WaveLength));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SkillFactor, () => this.Data.SkillFactor));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.HitDelay, () => this.Data.HitDelay));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SpendSta, () => 0f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.AbleShootRotate, () => 0f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SklSpdRate, () => 1f)); // Constant
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SpendPoison, () => 0f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.ReadyTime, () => 0f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SkillAtkAdd, () => 0f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.EnableShootMove, () => this.Data.EnableCastMove ? 1f : 0f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.UseOverHeat, () => this.Data.OverHeat));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SkillASPD, () => 1f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.BackHitRange, () => 0f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.Skill_Delay, () => 0f));
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.ReinforceAtk, () => 0f));

			//this.Properties.Add(new RefFloatProperty(PropertyId.Skill.SkillSR, () => 14f)); // Has to be calculated with Lua Script
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.CaptionTime, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.CaptionRatio, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.CaptionRatio2, () => 0f)); // Needs to be calculated if used, uses lua script
			this.Properties.Add(new RefFloatProperty(PropertyId.Skill.CaptionRatio3, () => 0f)); // Needs to be calculated if used, uses lua script
		}
	}
}
