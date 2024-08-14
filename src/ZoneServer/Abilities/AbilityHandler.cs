using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Abilities
{
	/// <summary>
	/// Base interface for ability handlers.
	/// </summary>
	/// <remarks>
	/// The ability handlers are primarily intended for use with combat
	/// event handlers, as the abilities themself rarely have any actual
	/// behavior. Though when they do, an ability handler might be the
	/// place to put it.
	/// </remarks>
	public interface IAbilityHandler
	{
	}

	public interface IAbilityCombatAttackBeforeCalcHandler { void OnAttackBeforeCalc(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
	public interface IAbilityCombatDefenseBeforeCalcHandler { void OnDefenseBeforeCalc(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }

	public interface IAbilityCombatAttackAfterCalcHandler { void OnAttackAfterCalc(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
	public interface IAbilityCombatDefenseAfterCalcHandler { void OnDefenseAfterCalc(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }

	public interface IAbilityCombatAttackBeforeBonusesHandler { void OnAttackBeforeBonuses(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
	public interface IAbilityCombatDefenseBeforeBonusesHandler { void OnDefenseBeforeBonuses(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }

	public interface IAbilityCombatAttackAfterBonusesHandler { void OnAttackAfterBonuses(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
	public interface IAbilityCombatDefenseAfterBonusesHandler { void OnDefenseAfterBonuses(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
}
