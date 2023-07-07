//--- Melia Script ----------------------------------------------------------
// Skill Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate skill-related values, such as properties.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;

public class SkillCalculationsScript : GeneralScript
{
	/// <summary>
	/// Returns skill's AoE Attack Ratio?
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_GET_SR_LV")]
	public float SCR_GET_SR_LV(Skill skill)
	{
		var baseValue = skill.Properties.GetFloat(PropertyName.SklSR);

		var byOwner = 0f;
		if (skill.Owner is Character character)
			byOwner += character.Properties.GetFloat(PropertyName.SR);

		return Math.Max(1, baseValue + byOwner);
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
	[ScriptableFunction("SCR_Get_SkillFactor")]
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
	[ScriptableFunction("SCR_Get_SkillAtkAdd")]
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
	[ScriptableFunction("SCR_Get_SpendSP")]
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
	[ScriptableFunction("SCR_Skill_STA")]
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
	[ScriptableFunction("SCR_Get_WaveLength")]
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
	[ScriptableFunction("SCR_SPLANGLE")]
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
	[ScriptableFunction("SCR_Get_SplRange")]
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
	[ScriptableFunction("SCR_GET_DELAY_TIME")]
	public float SCR_GET_DELAY_TIME(Skill skill)
	{
		if (!(skill.Owner is IMonster monster))
			return skill.Properties.GetFloat(PropertyName.DelayTime);

		if (skill.Data.ClassType == SkillClassType.Missile || skill.Data.UseType == SkillUseType.Force || skill.Data.UseType == SkillUseType.ForceGround)
		{
			if (monster.Level < 75)
				return 3000;
			else if (monster.Level < 170)
				return 2500;
			else if (monster.Level < 220)
				return 2000;
			else
				return 1500;
		}
		else
		{
			if (monster.Level < 40)
				return 3000;
			else if (monster.Level < 75)
				return 2500;
			else if (monster.Level < 170)
				return 2000;
			else if (monster.Level < 220)
				return 1500;
			else
				return 1000;
		}
	}
}
