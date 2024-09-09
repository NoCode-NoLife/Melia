using System;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Base
{
	/// <summary>
	/// Buff Handler Interface
	/// </summary>
	public interface IBuffHandler
	{
		/// <summary>
		/// Callback for when the buff is started or overbuffed. Not called
		/// once the max overbuff count is reached.
		/// </summary>
		/// <param name="buff"></param>
		[Obsolete("Use OnActivate instead.")]
		void OnStart(Buff buff);

		/// <summary>
		/// Callback for when the buff is activated, either by starting or
		/// overbuffing it. Not called once the max overbuff count is reached.
		/// </summary>
		/// <remarks>
		/// This callback is usually the right choice for most buffs that
		/// apply a simple bonus that stacks up until the max overbuff count
		/// is reached.
		/// </remarks>
		/// <param name="buff"></param>
		/// <param name="activationType"></param>
		void OnActivate(Buff buff, ActivationType activationType);

		/// <summary>
		/// Callback for when the buff's duration is extended, regardless of
		/// whether the overbuff max count was reached or not.
		/// </summary>
		/// <remarks>
		/// This callback presents an alternative to OnActivate, in case it's
		/// ever necessary for the handler to react to continued extensions
		/// after the max overbuff count was reached.
		/// 
		/// OnExtend is called in addition to OnActivate up until the max
		/// overbuff count is reached. Afterwards, OnExtend is the only
		/// callback that is called.
		/// </remarks>
		/// <param name="buff"></param>
		void OnExtend(Buff buff);

		/// <summary>
		/// Callback for regular updates while the buff is active. Only called
		/// for buffs that have an update time.
		/// </summary>
		/// <param name="buff"></param>
		void WhileActive(Buff buff);

		/// <summary>
		/// Callback for when the buff runs out or is manually stopped.
		/// </summary>
		/// <param name="buff"></param>
		void OnEnd(Buff buff);
	}

	/// <summary>
	/// Defines how 
	/// </summary>
	public enum ActivationType
	{
		Start,
		Overbuff,
	}

	public interface IBuffCombatAttackBeforeCalcHandler { void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
	public interface IBuffCombatDefenseBeforeCalcHandler { void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }

	public interface IBuffCombatAttackAfterCalcHandler { void OnAttackAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
	public interface IBuffCombatDefenseAfterCalcHandler { void OnDefenseAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }

	public interface IBuffCombatAttackBeforeBonusesHandler { void OnAttackBeforeBonuses(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
	public interface IBuffCombatDefenseBeforeBonusesHandler { void OnDefenseBeforeBonuses(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }

	public interface IBuffCombatAttackAfterBonusesHandler { void OnAttackAfterBonuses(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
	public interface IBuffCombatDefenseAfterBonusesHandler { void OnDefenseAfterBonuses(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult); }
}
