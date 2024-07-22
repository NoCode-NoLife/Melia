using System.Collections.Generic;
using Melia.Shared.World;
using Melia.Zone.Buffs;
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

	public interface ISkillCombatBeforeCalcHandler
	{
		/// <summary>
		/// Called before the combat calculations.
		/// </summary>
		/// <param name="passiveSkill">The </param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		void OnBeforeCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult);
	}
}
