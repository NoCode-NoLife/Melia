using System;
using System.Collections.Generic;
using Melia.Shared.World;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Base
{
	public interface ISkillHandler
	{
	}

	public interface ITargetSkillHandler : ISkillHandler
	{
		void Handle(Skill skill, ICombatEntity caster, ICombatEntity target);
	}

	public interface ITargetAniSkillHandler : ISkillHandler
	{
		void Handle(Skill skill, ICombatEntity caster, Direction dir);
	}

	public interface IGroundSkillHandler : ISkillHandler
	{
		void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target);
	}

	public interface IMeleeGroundSkillHandler : ISkillHandler
	{
		void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, IList<ICombatEntity> targets);
	}

	public interface IForceSkillHandler : ISkillHandler
	{
		void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, IList<ICombatEntity> targets);
	}

	public interface ISelfSkillHandler : ISkillHandler
	{
		void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir);
	}

	public interface IDynamicCasted : ISkillHandler
	{
		void StartDynamicCast(Skill skill, ICombatEntity caster);
		void EndDynamicCast(Skill skill, ICombatEntity caster);
	}

	[Obsolete("Use CombatCalcModifierAttribute instead.")] public interface ISkillCombatAttackBeforeCalcHandler { void OnAttackBeforeCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult); }
	[Obsolete("Use CombatCalcModifierAttribute instead.")] public interface ISkillCombatDefenseBeforeCalcHandler { void OnDefenseBeforeCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult); }

	[Obsolete("Use CombatCalcModifierAttribute instead.")] public interface ISkillCombatAttackAfterCalcHandler { void OnAttackAfterCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult); }
	[Obsolete("Use CombatCalcModifierAttribute instead.")] public interface ISkillCombatDefenseAfterCalcHandler { void OnDefenseAfterCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult); }

	[Obsolete("Use CombatCalcModifierAttribute instead.")] public interface ISkillCombatAttackBeforeBonusesHandler { void OnAttackBeforeBonuses(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult); }
	[Obsolete("Use CombatCalcModifierAttribute instead.")] public interface ISkillCombatDefenseBeforeBonusesHandler { void OnDefenseBeforeBonuses(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult); }

	[Obsolete("Use CombatCalcModifierAttribute instead.")] public interface ISkillCombatAttackAfterBonusesHandler { void OnAttackAfterBonuses(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult); }
	[Obsolete("Use CombatCalcModifierAttribute instead.")] public interface ISkillCombatDefenseAfterBonusesHandler { void OnDefenseAfterBonuses(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult); }
}
