using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
using Melia.Zone.World;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Base
{
	/// <summary>
	/// Buff Handler Interface
	/// </summary>
	public interface IBuffHandler
	{
		void OnStart(Buff buff);
		void WhileActive(Buff buff);
		void OnEnd(Buff buff);
	}

	/// <summary>
	/// Describes a buff handler that can modify combat calculations.
	/// </summary>
	public interface IBuffCombatBeforeCalcHandler
	{
		/// <summary>
		/// Called before the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		void OnBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);
	}

	/// <summary>
	/// Describes a buff handler that can modify combat calculations.
	/// </summary>
	public interface IBuffCombatAfterCalcHandler
	{
		/// <summary>
		/// Called after the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		void OnAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);
	}

	/// <summary>
	/// Describes a buff handler that can modify combat calculations.
	/// </summary>
	public interface IBuffCombatBeforeBonusesHandler
	{
		/// <summary>
		/// Called before the bonus damage calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		void OnBeforeBonuses(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);
	}

	/// <summary>
	/// Describes a buff handler that can modify combat calculations.
	/// </summary>
	public interface IBuffCombatAfterBonusesHandler
	{
		/// <summary>
		/// Called after the bonus damage calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		void OnAfterBonuses(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);
	}
}
