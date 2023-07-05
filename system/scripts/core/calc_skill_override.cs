//--- Melia Script ----------------------------------------------------------
// Skill Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate skill-related values, such as properties.
//---------------------------------------------------------------------------

using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;

public class SkillOverrideCalculationsScript : GeneralScript
{
	/// <summary>
	/// Returns the amount of SP spent when using the skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SpendSP_Cleric_Heal(Skill skill)
	{
		var SCR_Get_SpendSP = ScriptableFunctions.Skill.Get("SCR_Get_SpendSP");

		// Not sure if this is correct in any shape or form
		var value = SCR_Get_SpendSP(skill);

		var overloadBuffCount = skill.Owner.Components.Get<BuffComponent>().GetOverbuffCount(BuffId.Heal_Overload_Buff);
		value += (value * 0.5f * overloadBuffCount);

		return value;
	}

	/// <summary>
	/// Returns the amount of SP spent when using the skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SpendSP_Cleric_Cure(Skill skill)
	{
		var SCR_Get_SpendSP = ScriptableFunctions.Skill.Get("SCR_Get_SpendSP");

		var value = SCR_Get_SpendSP(skill);

		var overloadBuffCount = skill.Owner.Components.Get<BuffComponent>().GetOverbuffCount(BuffId.Cure_Overload_Buff);
		value += (value * 0.5f * overloadBuffCount);

		return value;
	}

	/// <summary>
	/// Returns the amount of SP spent when using the skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Get_SpendSP_Wizard_EarthQuake(Skill skill)
	{
		var SCR_Get_SpendSP = ScriptableFunctions.Skill.Get("SCR_Get_SpendSP");

		var value = SCR_Get_SpendSP(skill);

		// Ability "Earthquake: Remove Knockdown"
		if (skill.Owner.Components.Get<AbilityComponent>().IsActive(AbilityId.Wizard23))
			value += value * 0.10f;

		return value;
	}
}
