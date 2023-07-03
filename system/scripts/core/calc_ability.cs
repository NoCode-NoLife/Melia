//--- Melia Script ----------------------------------------------------------
// Ability Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate ability-related values, such as properties.
//---------------------------------------------------------------------------

using System.Collections.Generic;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;

public class AbilityCalculationsScript : GeneralScript
{
	/// <summary>
	/// Originaly made based on SCR_REINFORCEABILITY_TOOLTIP (from the client)
	/// </summary>
	private float Src_ReinforceAbilityBonus(Ability ability, string SkillClassName)
	{
		// These Skills can be ignored (Based on client original script)
		var ignoreSkillList = new List<string>(){
			"Oracle_CounterSpell",
			"Dievdirbys_CarveAustrasKoks"
		};

		// Those Abilities have 0 of FactorByLevel
		var ignoreAbiltyList = new List<string>(){
			"Barbarian35",
			"Sadhu26",
			"Exorcist20",
			"Thaumaturge20",
			"Thaumaturge21",
			"Arbalester19",
			"Schwarzereiter32",
		};

		var skillData = ZoneServer.Instance.Data.SkillDb.Find(SkillClassName);

		var addAbilityRate = 1f;
		var abilityClassName = skillData.ReinforceAbility;

		if (!ignoreAbiltyList.Contains(abilityClassName))
		{
			if (ability != null)
			{
				var masterAddValue = 0f;

				if (ability.Level == 100)
				{
					masterAddValue = 0.1f;
				}

				addAbilityRate = 1 + (ability.Level * 0.005f + masterAddValue);

				if (!ignoreSkillList.Contains(SkillClassName) && ability.Level >= 65)
				{
					var abilLevel = ability.Level;
					var addFactor = 1.25f * 0.01f;
					addAbilityRate = addAbilityRate * (1 + (abilLevel * addFactor));
				}
			}
		}

		return addAbilityRate;
	}
}
