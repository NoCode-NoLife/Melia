using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Handles the Quarrel Shooter skill Stone Shot.
	/// </summary>
	[SkillHandler(SkillId.QuarrelShooter_StoneShot)]
	public class QuarrelShooter_StoneShot : ITargetSkillHandler
	{
		private const int StoneBulletId = 645503;
		private const float StunDuration = 4f;

		/// <summary>
		/// Handles the skill, shoot enemy and apply debuff
		/// </summary>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!this.UseAmmo(caster))
			{
				caster.ServerMessage(Localization.Get("You need a Stone Bullet."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if (!caster.InSkillUseRange(skill, target))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(target);
			caster.SetAttackState(true);

			CallSafe(this.Attack(skill, caster, target));
		}

		/// <summary>
		/// Executes the actual attack.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var damageDelay = TimeSpan.FromMilliseconds(280);
			var animationDelay = TimeSpan.FromMilliseconds(300);
			var skillHitDelay = TimeSpan.Zero;

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);
			hit.ForceId = ForceId.GetNew();
			hit.ResultType = HitResultType.Unk8;

			Send.ZC_NORMAL.PlayForceEffect(hit.ForceId, caster, caster, target, "I_archer_stonearrow_force_circle#Dummy_q_Force", 1f, "arrow_cast", "F_archer_stonearrow_hit_spread_out", 1, "arrow_blow", "SLOW", 600);
			Send.ZC_HIT_INFO(caster, target, hit);


			if (skillHitResult.Damage > 0)
			{
				var duration = TimeSpan.FromSeconds(10);
				target.StartBuff(BuffId.StoneShot_Debuff, skill.Level, 0, duration, caster);

				// QuarrelShooter34 adds a chance to inflict Disarm Shield
				if (caster.TryGetActiveAbilityLevel(AbilityId.QuarrelShooter34, out var level) && RandomProvider.Get().Next(100) < 2 * level)
				{
					target.StartBuff(BuffId.Common_ShieldDesrption, skill.Level, 0, TimeSpan.FromSeconds(5), caster);
				}
			}

			await Task.Delay(animationDelay);


			// If the buff has reached max overbuff, we trigger the explosion
			// and remove the buff
			if (target.TryGetBuff(BuffId.StoneShot_Debuff, out var buff))
			{
				if (buff.IsFullyOverbuffed)
				{
					StoneBurst(skill.Level, caster, target);
					target.StopBuff(BuffId.StoneShot_Debuff);
				}
			}			

			// This skill has an unusually long aftercast immobilization
			// that probably requires this packet
			Send.ZC_SKILL_CAST_CANCEL(caster);
		}


		/// <summary>
		/// Uses one Stone Bullet if applicable. Returns false if consumption
		/// failed and the skill should not be used.
		/// </summary>
		/// <param name="caster"></param>
		/// <returns></returns>
		private bool UseAmmo(ICombatEntity caster)
		{
			if (Feature.IsEnabled("StoneShotNoAmmo"))
				return true;

			if (caster.Components.TryGet<InventoryComponent>(out var inventory))
			{
				var removedCount = inventory.Remove(StoneBulletId, 1, InventoryItemRemoveMsg.Used);
				if (removedCount == 0)
					return false;
			}

			return true;
		}

		/// <summary>
		/// Handles the Burst effect when the debuff hits 3 stacks
		/// </summary>
		/// <param name="level"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void StoneBurst(float level, ICombatEntity caster, ICombatEntity target)
		{
			BurstTarget(level, caster, target);
			BurstSplash(level, caster, target);
		}

		/// <summary>
		/// Handles the burst on the primary target
		/// </summary>
		/// <param name="level"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void BurstTarget(float level, ICombatEntity caster, ICombatEntity target)
		{
			// Animation is unknown
			Send.ZC_NORMAL.PlayEffect(target, "F_archer_explosiontrap_hit_explosion", 1);

			// Always stuns primary target?
			target.StartBuff(BuffId.Stun, level, 0, TimeSpan.FromSeconds(StunDuration), caster);
		}

		/// <summary>
		/// Handles the burst effect on nearby targets.
		/// </summary>
		/// <param name="level"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void BurstSplash(float level, ICombatEntity caster, ICombatEntity target)
		{
			// Range is unknown
			var splashArea = new Circle(target.Position, 50);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			// Exclude main target from potential splash targets
			targets.Remove(target);

			var burstTargets = targets.LimitRandom(6);

			foreach (var burstTarget in burstTargets)
			{
				if (RandomProvider.Get().Next(100) < 25 + 5 * level)
				{
					burstTarget.StartBuff(BuffId.Stun, level, 0, TimeSpan.FromSeconds(StunDuration), caster);
				}				
			}
		}
	}
}
