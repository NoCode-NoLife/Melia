//--- Melia Script ----------------------------------------------------------
// Skill Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate skill-related values, such as properties,
// and override general purpose functions for specific skills.
//--- Notes -----------------------------------------------------------------
// Skill calculation functions automatically switch to override functions
// if they exist. For example, if the property SpendSP is calculated, set
// up as a calculated property that is to use the function
// "SCR_Get_SpendSP", that function will be used by default. However, if
// the skill's class name is "Wizard_EarthQuake", and a function named
// "SCR_Get_SpendSP_Wizard_EarthQuake" exists, that function will be used
// instead of the default one.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;

public class SkillOverrideCalculationsScript : GeneralScript
{
	// [ScriptableFunction]
	// public float SCR_Get_SpendSP_<SkillId>(Skill skill)
	// {
	//     var SCR_Get_SpendSP = ScriptableFunctions.Skill.Get("SCR_Get_SpendSP");
	//     
	//     var value = SCR_Get_SpendSP(skill);
	//     
	//     // ...
	//     
	//     return value;
	// }
}
