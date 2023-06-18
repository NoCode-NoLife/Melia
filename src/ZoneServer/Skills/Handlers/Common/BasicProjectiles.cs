using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.General
{
	/// <summary>
	/// Handles skills of use type Force.
	/// </summary>
	[SkillHandler(SkillId.Bow_Attack, SkillId.Magic_Attack)]
	public class BasicProjectiles : ITargetSkillHandler
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
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			//Send.ZC_SKILL_READY(caster, skill, target.Position, Position.Zero);
			//Send.ZC_NORMAL.Unkown_1c(caster, target.Handle, target.Position, caster.Position.GetDirection(target.Position), Position.Zero);

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, 0, null);
				return;
			}

			// This value needs to be set on both the skill hits and
			// ZC_SKILL_FORCE_TARGET for the client to connect the
			// pieces and stop arrows from flying past the targets.
			// We'll just set this to whatever for now, but it
			// probably needs to be a sequential id.
			var unkForceId = 179069;

			var damageDelay = TimeSpan.FromMilliseconds(500);
			var skillHitDelay = skill.Properties.HitDelay;

			var damage = SCR_CalculateDamage(caster, target, skill);
			target.TakeDamage(damage, caster);

			var hit = new SkillHitInfo(caster, target, skill, damage, damageDelay, skillHitDelay);
			hit.UnkForceId = unkForceId;

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, unkForceId, new[] { hit });
		}
	}
}
