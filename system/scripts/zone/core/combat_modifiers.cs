//--- Melia Script ----------------------------------------------------------
// Combat Modifier Script
//--- Description -----------------------------------------------------------
// Collection of functions that modify combat calculations based on
// combatants's buffs and other properties.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

public class CombatModifierCalculationsScript : GeneralScript
{
	/// <summary>
	/// Calls scriptable functions for all active buffs before combat calculations.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Combat_BeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		CallForBuffs(nameof(SCR_Combat_BeforeCalc), attacker, attacker, target, skill, modifier, skillHitResult);
		CallForBuffs(nameof(SCR_Combat_BeforeCalc), target, attacker, target, skill, modifier, skillHitResult);

		return 0;
	}

	/// <summary>
	/// Calls scriptable functions for all active buffs after combat calculations.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Combat_AfterCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		CallForBuffs(nameof(SCR_Combat_AfterCalc), attacker, attacker, target, skill, modifier, skillHitResult);
		CallForBuffs(nameof(SCR_Combat_AfterCalc), target, attacker, target, skill, modifier, skillHitResult);

		return 0;
	}

	/// <summary>
	/// Calls scriptable functions for all active buffs before bonuses such
	/// as sizes and elements are applied during combat calculations.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Combat_BeforeBonuses(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		CallForBuffs(nameof(SCR_Combat_BeforeBonuses), attacker, attacker, target, skill, modifier, skillHitResult);
		CallForBuffs(nameof(SCR_Combat_BeforeBonuses), target, attacker, target, skill, modifier, skillHitResult);

		return 0;
	}

	/// <summary>
	/// Calls scriptable functions for all active buffs after bonuses such
	/// as sizes and elements were applied during combat calculations.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_Combat_AfterBonuses(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		CallForBuffs(nameof(SCR_Combat_AfterBonuses), attacker, attacker, target, skill, modifier, skillHitResult);
		CallForBuffs(nameof(SCR_Combat_AfterBonuses), target, attacker, target, skill, modifier, skillHitResult);

		return 0;
	}

	/// <summary>
	/// Calls the given scriptable function for all active buffs on the given entity.
	/// </summary>
	/// <param name="funcName"></param>
	/// <param name="entity"></param>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	private void CallForBuffs(string baseFuncName, ICombatEntity entity, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		if (!entity.Components.TryGet<BuffComponent>(out var buffs))
			return;

		var activeBuffs = buffs.GetList();

		foreach (var buff in activeBuffs)
		{
			var funcName = baseFuncName + "_" + buff.Data.ClassName;

			if (!ScriptableFunctions.Combat.TryGet(funcName, out var func))
				continue;

			func(attacker, target, skill, modifier, skillHitResult);
		}
	}
}
