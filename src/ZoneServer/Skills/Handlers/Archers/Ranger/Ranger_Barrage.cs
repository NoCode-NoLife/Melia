using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handles the Ranger skill Barrage.
	/// </summary>
	[SkillHandler(SkillId.Ranger_Barrage)]
	public class Ranger_Barrage : ITargetSkillHandler
	{
		/// <summary>
		/// Handles the skill, do two consecutive hits on the enemy.
		/// </summary>
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

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!caster.InSkillUseRange(skill, target))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			var damageDelay = TimeSpan.FromMilliseconds(200);
			var skillHitDelay = skill.Properties.HitDelay;

			var modifier = SkillModifier.MultiHit(3);

			// Wild throw reduces base hit rate by 70% but cuts cooldown
			// by 5s
			if (caster.IsAbilityActive(AbilityId.Ranger39))
			{
				modifier.HitRateMultiplier -= 0.7f;
				skill.ReduceCooldown(TimeSpan.FromSeconds(5));
			}

			var skillHitResult = SCR_SkillHit(caster, target, skill, SkillModifier.MultiHit(3));

			// Ability "Barrage: Knockback": Apply knock back on the last
			// hit before the skill goes on cooldown
			if (caster.TryGetActiveAbilityLevel(AbilityId.Ranger1, out var level) && skill.OverheatCounter == 0)
			{
				// TODO: The knockback power / scaling of this ability is
				// unknown.
				var velocity = 50 + 5 * level;

				skillHitResult.KnockBack.Type = KnockBackType.KnockBack;
				skillHitResult.KnockBack.Velocity = velocity;
			}

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

			skillHit.ApplyDamage();
			skillHit.ApplyKnockBack();

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);

			Ranger_CriticalShot.TryActivateDoubleTake(skill, caster, target);
			Ranger_CriticalShot.TryReduceCooldown(skill, caster, skillHitResult);
			Ranger_Strafe.TryApplyStrafeBuff(caster);
		}
	}
}
