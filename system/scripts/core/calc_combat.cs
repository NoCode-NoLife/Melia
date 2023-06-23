//--- Melia Script ----------------------------------------------------------
// Combat Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate combat-related values, such as damage.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Yggdrasil.Extensions;
using Yggdrasil.Util;

public class CombatCalculationsScript : GeneralScript
{
	/// <summary>
	/// Returns a random attack value between the min and max values
	/// for the type that matches the given skill (PATK or MATK).
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_GetRandomAtk")]
	public float SCR_GetRandomAtk(ICombatEntity attacker, ICombatEntity target, Skill skill)
	{
		var rnd = RandomProvider.Get();

		float min, max;

		if (skill.Data.ClassType <= SkillClassType.Missile)
		{
			min = attacker.Properties.GetFloat(PropertyName.MINPATK);
			max = attacker.Properties.GetFloat(PropertyName.MAXPATK);
		}
		else
		{
			min = attacker.Properties.GetFloat(PropertyName.MINMATK);
			max = attacker.Properties.GetFloat(PropertyName.MAXMATK);
		}

		return rnd.Between(min, max);
	}

	/// <summary>
	/// Calculates the damage for the given skill if used by the attacker
	/// on the target, factoring in attack and defense properties.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_CalculateDamage")]
	public float SCR_CalculateDamage(ICombatEntity attacker, ICombatEntity target, Skill skill)
	{
		var SCR_GetRandomAtk = ScriptableFunctions.SkillUse.Get("SCR_GetRandomAtk");

		var damage = SCR_GetRandomAtk(attacker, target, skill);

		var skillFactor = skill.Properties.GetFloat(PropertyName.SkillFactor);
		damage *= skillFactor / 100f;

		var defPropertyName = skill.Data.ClassType != SkillClassType.Magic ? PropertyName.DEF : PropertyName.MDEF;
		var def = target.Properties.GetFloat(defPropertyName);

		damage = Math.Max(1, damage - def);

		return (int)damage;
	}
}
