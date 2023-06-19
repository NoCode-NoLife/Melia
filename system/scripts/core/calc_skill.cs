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
using Melia.Zone.World.Actors.CombatEntities.Components;

public class SkillCalculationsScript : GeneralScript
{
	/// <summary>
	/// Returns skill's splash range.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_GET_SR_LV")]
	public float SCR_GET_SR_LV(Skill skill)
	{
		var baseValue = skill.Properties.GetFloat(PropertyName.SklSR);
		var byOwner = skill.Character.Properties.GetFloat(PropertyName.SR);

		return baseValue + byOwner;
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

		var ownerLevel = skill.Character.Level;
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
	/// Returns the amount of SP spent when using the skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_Get_SpendSP_Cleric_Heal")]
	public float SCR_Get_SpendSP_Cleric_Heal(Skill skill)
	{
		var SCR_Get_SpendSP = ScriptableFunctions.Skill.Get("SCR_Get_SpendSP");

		// Not sure if this is correct in any shape or form
		var value = SCR_Get_SpendSP(skill);

		var overloadBuffCount = skill.Character.Components.Get<BuffCollection>().GetOverbuffCount(BuffId.Heal_Overload_Buff);
		value += (value * 0.5f * overloadBuffCount);

		return value;
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
		var baseValue = skill.Data.WaveLength;

		var byOwner = 0f;
		if (skill.Data.SplashType == SplashType.Square)
		{
			byOwner += skill.Character.Properties.GetFloat(PropertyName.SkillRange);
			byOwner += skill.Character.Properties.GetFloat(skill.Data.AttackType + "_Range");
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
			return skill.Data.SplashAngle;

		var baseValue = skill.Data.SplashAngle;
		var byOwner = skill.Character.Properties.GetFloat(PropertyName.SkillAngle);

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
		var baseValue = skill.Data.SplashRange;

		var byOwner = 0f;
		if (skill.Data.SplashType == SplashType.Fan)
		{
			byOwner += skill.Character.Properties.GetFloat(PropertyName.SkillRange);
			byOwner += skill.Character.Properties.GetFloat(skill.Data.AttackType + "_Range");
		}
		else if (skill.Data.SplashType == SplashType.Square)
		{
			byOwner += skill.Character.Properties.GetFloat(PropertyName.SkillAngle);
		}

		return baseValue + byOwner;
	}
}
