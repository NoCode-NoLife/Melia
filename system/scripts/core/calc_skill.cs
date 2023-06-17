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
}
