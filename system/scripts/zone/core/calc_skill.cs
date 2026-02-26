//--- Melia Script ----------------------------------------------------------
// Skill Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate skill-related values, such as properties.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.Monsters;

public class SkillCalculationsScript : GeneralScript
{
	/// <summary>
	/// Returns skill's AoE Attack Ratio?
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GET_SR_LV(Skill skill)
	{
		var baseValue = skill.Properties.GetFloat(PropertyName.SklSR);

		var byOwner = 0f;
		if (skill.Owner is Character character)
			byOwner += character.Properties.GetFloat(PropertyName.SR);

		return Math.Max(1, baseValue + byOwner);
	}


	/// <summary>
	/// Returns skill factor, which is a multiplier typically applied
	/// to an actors base damage.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SklFactor(Skill skill)
	{
		var baseValue = skill.Data.Factor;
		var byConfRate = 1f;

		if (skill.IsNormalAttack)
			byConfRate = ZoneServer.Instance.Conf.World.NormalAttackSkillFactorRate;
		else if (skill.Owner is IMonster)
			byConfRate = ZoneServer.Instance.Conf.World.MonsterSkillFactorRate;
		else
			byConfRate = ZoneServer.Instance.Conf.World.PlayerSkillFactorRate;

		return baseValue * byConfRate;
	}

	/// <summary>
	/// Returns skill factor by level, which is a multiplier typically applied
	/// to an actors base damage for each level of the skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SklFactorByLevel(Skill skill)
	{
		var baseValue = skill.Data.FactorByLevel;
		var byConfRate = 1f;

		if (skill.IsNormalAttack)
			byConfRate = ZoneServer.Instance.Conf.World.NormalAttackSkillFactorRate;
		else if (skill.Owner is IMonster)
			byConfRate = ZoneServer.Instance.Conf.World.MonsterSkillFactorRate;
		else
			byConfRate = ZoneServer.Instance.Conf.World.PlayerSkillFactorRate;

		return baseValue * byConfRate;
	}

	/// <summary>
	/// Returns skill's skill factor, which in most cases in equivilant
	/// to the skill's damage in percentage.
	/// </summary>
	/// <example>
	/// var damage = SCR_GetRandomAtk(attacker, target, skill) * SCR_Get_SkillFactor(skill) / 100f;
	/// </example>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SkillFactor(Skill skill)
	{
		var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");

		var sklFactor = skill.Properties.GetFloat(PropertyName.SklFactor);
		var sklFactorByLevel = skill.Properties.GetFloat(PropertyName.SklFactorByLevel);

		var value = sklFactor + (sklFactorByLevel * (skill.Level - 1));

		var byReinforceRate = SCR_Get_AbilityReinforceRate(skill);
		value += value * byReinforceRate;

		return value;
	}

	/// <summary>
	/// Returns the reinforce ability rate for the skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_AbilityReinforceRate(Skill skill)
	{
		if (skill.Data.ReinforceAbility == 0)
			return 0;

		if (!skill.Owner.Components.TryGet<AbilityComponent>(out var abilities))
			return 0;

		if (!abilities.TryGetActive(skill.Data.ReinforceAbility, out var reinforceAbility))
			return 0;

		var byAbility = reinforceAbility.Level * 0.005f;

		if (reinforceAbility.Level == 100)
			byAbility += 0.10f;

		var byHidden = 0f;
		if (skill.Data.HiddenReinforceAbility != 0 && abilities.TryGetActive(skill.Data.HiddenReinforceAbility, out var hiddenReinforceAbility))
		{
			var level = hiddenReinforceAbility.Level;
			var factorByLevel = skill.Data.HiddenReinforceAbilityFactorByLevel;

			byHidden = level * factorByLevel / 100f;
		}

		return byAbility + byHidden;
	}

	/// <summary>
	/// Returns skill's bonus damage.
	/// </summary>
	/// <example>
	/// var damage = SCR_GetRandomAtk(attacker, target, skill) + SCR_Get_SkillAtkAdd(skill);
	/// </example>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SkillAtkAdd(Skill skill)
	{
		var sklAtkAdd = skill.Properties.GetFloat(PropertyName.SklAtkAdd);
		var sklAtkAddByLevel = skill.Properties.GetFloat(PropertyName.SklAtkAddByLevel);

		return sklAtkAdd + (sklAtkAddByLevel * (skill.Level - 1));
	}

	/// <summary>
	/// Returns the amount of SP spent when using the skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SpendSP(Skill skill)
	{
		var baseValue = skill.Data.BasicSp;
		if (baseValue == 0)
			return 0;

		var ownerLevel = skill.Owner.Level;
		var levelCorrection = ownerLevel - 300f;

		// The value starts at ~18% at level 1 and keeps going up as the
		// owner's level increases. At level 100 it's 45%, at level 200
		// it's 72.5%, at 300 it's 100%, and it goes past that afterwards.
		if (levelCorrection < 0)
			levelCorrection = levelCorrection * 2.75f / 1000f;
		else if (levelCorrection >= 0)
			levelCorrection = levelCorrection * 1.25f / 1000f;

		var value = baseValue * (levelCorrection + 1);

		var byAbilityRate = 0; // TODO: Add ability multiplier support
		value += value * (byAbilityRate / 100f);

		return (int)Math.Max(0, value);
	}

	/// <summary>
	/// Returns the amount of stamina spent when using the skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Skill_STA(Skill skill)
	{
		var baseValue = skill.Data.BasicStamina;
		if (baseValue == 0)
			return 0;

		// The value in the database is in "displayed stamina", so they
		// need to be multiplied to get the actual value, which is a
		// thousand times the display value. Alternatively we could
		// adjust the skill data, but it's safer to leave the game's
		// data untouched.
		return baseValue * 1000;
	}

	/// <summary>
	/// Returns the skill's wave length, which is related to its area
	/// of effect.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_WaveLength(Skill skill)
	{
		var baseValue = skill.Properties.GetFloat(PropertyName.SklWaveLength);

		var byOwner = 0f;
		if (skill.Data.SplashType == SplashType.Square)
		{
			byOwner += skill.Owner.Properties.GetFloat(PropertyName.SkillRange);
			byOwner += skill.Owner.Properties.GetFloat(skill.Data.AttackType + "_Range");
		}

		return baseValue + byOwner;
	}

	/// <summary>
	/// Returns the skill's splash angle, which is related to its area
	/// of effect.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_SPLANGLE(Skill skill)
	{
		if (skill.Data.SplashType != SplashType.Fan)
			return skill.Properties.GetFloat(PropertyName.SklSplAngle);

		var baseValue = skill.Properties.GetFloat(PropertyName.SklSplAngle);
		var byOwner = skill.Owner.Properties.GetFloat(PropertyName.SkillAngle);

		return baseValue + byOwner;
	}

	/// <summary>
	/// Returns the skill's wave length, which is related to its attack
	/// range.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SplRange(Skill skill)
	{
		var baseValue = skill.Properties.GetFloat(PropertyName.SklSplRange);

		var byOwner = 0f;
		if (skill.Data.SplashType == SplashType.Fan)
		{
			byOwner += skill.Owner.Properties.GetFloat(PropertyName.SkillRange);
			byOwner += skill.Owner.Properties.GetFloat(skill.Data.AttackType + "_Range");
		}
		else if (skill.Data.SplashType == SplashType.Square)
		{
			byOwner += skill.Owner.Properties.GetFloat(PropertyName.SkillAngle);
		}

		return baseValue + byOwner;
	}

	/// <summary>
	/// Returns the skill's delay time, which appears to be used as the
	/// delay until a monster can use a skill again.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GET_DELAY_TIME(Skill skill)
	{
		if (skill.Owner is not IMonster monster)
			return skill.Properties.GetFloat(PropertyName.DelayTime);

		float baseValue;

		if (skill.Data.ClassType == SkillClassType.Missile || skill.Data.UseType == SkillUseType.Force || skill.Data.UseType == SkillUseType.ForceGround)
		{
			if (monster.Level < 75)
				baseValue = 3000;
			else if (monster.Level < 170)
				baseValue = 2500;
			else if (monster.Level < 220)
				baseValue = 2000;
			else
				baseValue = 1500;
		}
		else
		{
			if (monster.Level < 40)
				baseValue = 3000;
			else if (monster.Level < 75)
				baseValue = 2500;
			else if (monster.Level < 170)
				baseValue = 2000;
			else if (monster.Level < 220)
				baseValue = 1500;
			else
				baseValue = 1000;
		}

		var byDelayRate = ZoneServer.Instance.Conf.World.MonsterSkillDelayRate;

		return baseValue * byDelayRate;
	}

	/// <summary>
	/// Calculates and returns the skill's speed rate.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GET_SklSpdRate(Skill skill)
	{
		// Formulas based on player accounts and experimentation. They're
		// not 100% accurate, but the goal was to get them close to the
		// values seen in the skill packets, and the result kinda works.
		// And isn't that all that matters? Yes. Yes it is. ^__^
		//
		// https://forum.treeofsavior.com/t/attack-speed-formula/395989
		// 
		// We can see the skill speed rate in the skill packets, and we
		// can see it change with the dex stat, so this is definitely a
		// factor, and the formulas found by the community somewhat match
		// the logged values.
		// The bonuses from skills and buffs seem weird at first glance
		// (for example, Hasisas adds "175 Attack Speed"), but given our
		// formula this value actually makes sense, as Hasisas was logged
		// to increase the speed rate by ~0.18, which is a close match
		// for bonus/1000.
		// 
		// Theory on how attack speed works:
		// Every skill, including normal attack skills, have a "shoot time",
		// which seems to be the time until the skill can be used again.
		// For example, if you have a skill speed rate of 1 and you use
		// a skill with a shoot time of 1000, the client will use the
		// skill every ~1000ms. If you then raise the skill speed rate,
		// the client will use the skill every ~1000ms divided by the
		// speed rate. This means you'd reach a hit rate of 2 hits per
		// second if you get your speed rate to 2.
		// For a skill with a much lower shoot time you attack faster
		// out of the gate and higher speed rates will have a lower
		// impact on your hits/second. For example, the default shoot
		// time of the dagger attack skill is 400ms, which would be
		// lowered to 200ms with a speed rate of 2.
		// It's currently unknown whether there's a speed cap, though
		// the hits get a little unrealiable at higher values, above a
		// speed rate of 3. It's safe to assume that there is a limit
		// somewhere in the 2~3 speed rate range. But for now we'll
		// leave it like this for funsies.

		var baseValue = skill.Properties.GetFloat(PropertyName.SklSpdRateValue);
		var byDex = 0f;
		var byBuff = 0f;

		if (skill.Owner is IMonster)
		{
			baseValue *= ZoneServer.Instance.Conf.World.MonsterSkillSpeedRate;
		}

		if (skill.Data.SpeedRateAffectedByDex)
		{
			var dex = skill.Owner.Properties.GetFloat(PropertyName.DEX);
			byDex = (float)Math.Pow(dex / 500f, 0.46f);
		}

		if (skill.Data.SpeedRateAffectedByBuff)
		{
			var spdBm = skill.Owner.Properties.GetFloat(PropertyName.SPD_BM, 0);
			byBuff = spdBm / 1000f;
		}

		// Don't let the result go to 0, as such a speed rate would result
		// in an infinite damage delay. Limiting it to 0.01 effectively
		// means that a skill can't be modified to be more than 100
		// times slower than normal.
		return (float)Math.Max(0.01f, baseValue + byDex + byBuff);
	}

	/// <summary>
	/// Calculates and returns the skill's shoot time.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GET_ShootTime(Skill skill)
	{
		var sklSpdRate = skill.Properties.GetFloat(PropertyName.SklSpdRate);
		var baseValue = skill.Data.ShootTime.TotalMilliseconds;

		return (float)(baseValue / sklSpdRate);
	}

	/// <summary>
	/// Calculates and returns the skill's overheat cooldown time in
	/// milliseconds.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GET_USEOVERHEAT(Skill skill)
	{
		var baseValue = (int)skill.Data.CooldownTime.TotalMilliseconds;
		var buffModifier = 1f;

		if (skill.Owner.Properties.TryGetFloat(PropertyName.OverHeat_BM, out var overheatBm))
			buffModifier += overheatBm / 100f;

		return (int)Math.Max(0, baseValue * buffModifier);
	}

	/// <summary>
	/// Calculates and returns the skill's available max overheat count,
	/// indicating how many times the skill can be used before it goes on
	/// cooldown.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float GET_SKILL_OVERHEAT_COUNT(Skill skill)
	{
		var baseValue = skill.Data.OverheatCount;

		return Math.Max(0, baseValue);
	}
}
