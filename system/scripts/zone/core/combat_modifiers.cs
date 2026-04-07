//--- Melia Script ----------------------------------------------------------
// Combat Modifier Script
//--- Description -----------------------------------------------------------
// Collection of functions that modify combat calculations based on
// combatants's buffs, skills, abilities, and other properties.
//---------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;

public class CombatModifierCalculationsScript : GeneralScript
{
	/// <summary>
	/// Calls scriptable functions for active buffs, skills, abilities, etc,
	/// before combat calculations.
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
		CallAll(nameof(SCR_Combat_BeforeCalc), attacker, target, skill, modifier, skillHitResult);
		return 0;
	}

	/// <summary>
	/// Calls scriptable functions for active buffs, skills, abilities, etc,
	/// after combat calculations.
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
		CallAll(nameof(SCR_Combat_AfterCalc), attacker, target, skill, modifier, skillHitResult);
		return 0;
	}

	/// <summary>
	/// Calls scriptable functions for active buffs, skills, abilities, etc,
	/// during combat calculations.
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
		CallAll(nameof(SCR_Combat_BeforeBonuses), attacker, target, skill, modifier, skillHitResult);
		return 0;
	}

	/// <summary>
	/// Calls scriptable functions for active buffs, skills, abilities, etc,
	/// during combat calculations.
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
		CallAll(nameof(SCR_Combat_AfterBonuses), attacker, target, skill, modifier, skillHitResult);
		return 0;
	}

	/// <summary>
	/// Calls scriptable functions for buffs, skills, abilities, etc. for both
	/// the attacker and target.
	/// </summary>
	/// <param name="baseFuncName"></param>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	private void CallAll(string baseFuncName, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		CallForBuffs(baseFuncName, attacker, target, skill, modifier, skillHitResult);
		CallForPassiveSkills(baseFuncName, attacker, target, skill, modifier, skillHitResult);
		CallForAbilities(baseFuncName, attacker, target, skill, modifier, skillHitResult);
		CallForEquip(baseFuncName, attacker, target, skill, modifier, skillHitResult);
	}

	/// <summary>
	/// Calls the given scriptable function for all active buffs.
	/// </summary>
	/// <param name="baseFuncName"></param>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	private void CallForBuffs(string baseFuncName, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		var buffIds = new HashSet<BuffId>();

		if (attacker.Components.TryGet<BuffComponent>(out var buffs))
			buffIds.UnionWith(buffs.GetList().Select(b => b.Id));

		if (target.Components.TryGet<BuffComponent>(out buffs))
			buffIds.UnionWith(buffs.GetList().Select(b => b.Id));

		foreach (var buffId in buffIds)
		{
			var funcName = baseFuncName + "_" + buffId;

			if (ScriptableFunctions.CombatModifier.TryGet(funcName, out var func))
				func(attacker, target, skill, modifier, skillHitResult);
		}
	}

	/// <summary>
	/// Calls the given scriptable function for all passive skills.
	/// </summary>
	/// <param name="baseFuncName"></param>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	private void CallForPassiveSkills(string baseFuncName, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		var skillIds = new HashSet<SkillId>();

		if (attacker.Components.TryGet<SkillComponent>(out var skills))
			skillIds.UnionWith(skills.GetList(a => a.IsPassive).Select(s => s.Id));

		if (target.Components.TryGet<SkillComponent>(out skills))
			skillIds.UnionWith(skills.GetList(a => a.IsPassive).Select(s => s.Id));

		foreach (var skillId in skillIds)
		{
			var funcName = baseFuncName + "_" + skillId;

			if (ScriptableFunctions.CombatModifier.TryGet(funcName, out var func))
				func(attacker, target, skill, modifier, skillHitResult);
		}
	}

	/// <summary>
	/// Calls the given scriptable function for all active abilities.
	/// </summary>
	/// <param name="baseFuncName"></param>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	private void CallForAbilities(string baseFuncName, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		var abilityIds = new HashSet<AbilityId>();

		if (attacker.Components.TryGet<AbilityComponent>(out var abilities))
			abilityIds.UnionWith(abilities.GetList(a => a.Active).Select(a => a.Id));

		if (target.Components.TryGet<AbilityComponent>(out abilities))
			abilityIds.UnionWith(abilities.GetList(a => a.Active).Select(a => a.Id));

		foreach (var abilityId in abilityIds)
		{
			var funcName = baseFuncName + "_" + abilityId;

			if (ScriptableFunctions.CombatModifier.TryGet(funcName, out var func))
				func(attacker, target, skill, modifier, skillHitResult);
		}
	}

	/// <summary>
	/// Calls the given scriptable function for all active abilities.
	/// </summary>
	/// <param name="baseFuncName"></param>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="modifier"></param>
	/// <param name="skillHitResult"></param>
	private void CallForEquip(string baseFuncName, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		var equipIds = new HashSet<int>();

		if (attacker.Components.TryGet<InventoryComponent>(out var inventory))
			equipIds.UnionWith(inventory.GetActualEquipIds());

		if (target.Components.TryGet<InventoryComponent>(out inventory))
			equipIds.UnionWith(inventory.GetActualEquipIds());

		foreach (var equipId in equipIds)
		{
			var funcName = baseFuncName + "_" + equipId;

			if (ScriptableFunctions.CombatModifier.TryGet(funcName, out var func))
				func(attacker, target, skill, modifier, skillHitResult);
		}
	}
}
