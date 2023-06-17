//--- Melia Script ----------------------------------------------------------
// Skill Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate skill-related values, such as properties.
//---------------------------------------------------------------------------

using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;

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
