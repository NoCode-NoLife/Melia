//--- Melia Script ----------------------------------------------------------
// Monster Combat Calculation Script
//--- Description -----------------------------------------------------------
// Functions that override default combat calculations for specific
// monsters.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

public class MonsterCombatCalculationsScript : GeneralScript
{
	// Example for overriding all damage dealt to anvils. We might want to
	// implement more flexible ways to do this, but this does demonstrate
	// one way of doing it.

	[ScriptableFunction("SCR_CalculateDamage_Monster_Anvil")]
	[ScriptableFunction("SCR_CalculateDamage_Monster_anvil_mon")]
	[ScriptableFunction("SCR_CalculateDamage_Monster_anvil_gold_mon")]
	[ScriptableFunction("SCR_CalculateDamage_Monster_anvil_platinum_mon")]
	[ScriptableFunction("SCR_CalculateDamage_Monster_anvil_ruby_mon")]
	[ScriptableFunction("SCR_CalculateDamage_Monster_anvil_diamond_mon")]
	public float DamageFixedTo1(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		skillHitResult.Damage = 1;
		return 0;
	}
}
