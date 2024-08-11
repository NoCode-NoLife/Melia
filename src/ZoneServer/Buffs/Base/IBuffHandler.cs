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
		void OnOverbuff(Buff buff);
		void WhileActive(Buff buff);
		void OnEnd(Buff buff);
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
