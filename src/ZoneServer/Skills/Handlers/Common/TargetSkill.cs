using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Common
{
	/// <summary>
	/// Handles ranged skills that target a single entity.
	/// </summary>
	[SkillHandler(SkillId.Bow_Attack, SkillId.Magic_Attack, SkillId.Pistol_Attack)]
	public class TargetSkill : ITargetSkillHandler
	{
		/// <summary>
		/// Handles usage of the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(target);
			caster.SetAttackState(true);

			//Send.ZC_SKILL_READY(caster, skill, target.Position, Position.Zero);
			//Send.ZC_NORMAL.Unkown_1c(caster, target.Handle, target.Position, caster.Position.GetDirection(target.Position), Position.Zero);

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			var damageDelay = TimeSpan.FromMilliseconds(500);
			var skillHitDelay = skill.Properties.HitDelay;

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);
		}
	}
}
