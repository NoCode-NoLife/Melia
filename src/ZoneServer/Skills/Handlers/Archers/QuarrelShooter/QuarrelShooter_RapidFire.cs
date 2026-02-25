using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Buffs;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Handles the Quarrel Shooter skill Rapid Fire.
	/// </summary>
	[SkillHandler(SkillId.QuarrelShooter_RapidFire)]
	public class QuarrelShooter_RapidFire : ITargetSkillHandler
	{
		private const float knockbackRange = 75f;

		/// <summary>
		/// Handles the skill, dealing knockback and damage
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
			var hitDelay = TimeSpan.FromMilliseconds(200);
			var damageDelay = TimeSpan.FromMilliseconds(30);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			// The initial shot is a dummy hit.
			// This exists only to display the animation
			// and apply the knockback, it does not deal damage
			SkillHitResult skillHitResultDummy = new SkillHitResult();
			skillHitResultDummy.Result = HitResultType.Hit;
			skillHitResultDummy.Effect = HitEffect.Impact;
			skillHitResultDummy.HitCount = 1;
			skillHitResultDummy.Damage = 0;

			var skillHitDummy = new SkillHitInfo(caster, target, skill, skillHitResultDummy, damageDelay, skillHitDelay);
			skillHitDummy.ForceId = ForceId.GetNew();

			// Check to see if we do the knockback
			// This is only applied if you have a shield,
			// and the target is within 75 units

			if (caster.Components.TryGet<InventoryComponent>(out var inventory))
			{
				var lhItem = inventory.GetItem(EquipSlot.LeftHand);
				if (lhItem.Data.EquipType1 == EquipType.Shield && caster.Position.Get2DDistance(target.Position) <= knockbackRange)
				{
					// TODO: This is actually a Knockback: Motion
					// which isn't implemented yet
					skillHitDummy.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, HitType.KnockBack, skill.Data.KnockDownVelocity, skill.Data.KnockDownVAngle);
					skillHitDummy.ApplyKnockBack(target);

					// gain block buff on successful knockback
					caster.StartBuff(BuffId.RapidFire_Block_Buff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);
				}
			}
						
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHitDummy);

			// The actual damage is applied as a series of standard ground hitboxes

			var blastDelay = TimeSpan.FromMilliseconds(120);
			var delayBetweenHits = TimeSpan.FromMilliseconds(20);
			float[] blastSizes = { 0.5f, 1f, 1f, 1f, 1.2f };

			var splashArea = new Circle(target.Position, 50);

			var hits = new List<SkillHitInfo>();

			await Task.Delay(blastDelay);

			for (var i = 0; i < 5; i++)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				// play the animation
				Send.ZC_NORMAL.PlayEffect(target, "F_archer_caltrop_hit_explosion", blastSizes[i]);

				// there's a second animation on the last hit
				if (i == 4)
				{
					Send.ZC_NORMAL.PlayEffect(target, "F_explosion097", 1f);

					// QuarrelShooter23 gives a 50% chance to reduce crit dr
					if (caster.TryGetActiveAbilityLevel(AbilityId.QuarrelShooter23, out var level) && RandomProvider.Get().Next(2) == 1)
					{
						target.StartBuff(BuffId.RapidFire_Debuff, skill.Level, 0, TimeSpan.FromSeconds(3 * level), caster);
					}
				}

				foreach (var hitTarget in targets.LimitBySDR(caster, skill))
				{
					var skillHitResult = SCR_SkillHit(caster, hitTarget, skill);
					hitTarget.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, hitTarget, skill, skillHitResult, damageDelay, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;
					hits.Add(skillHit);
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);

				hits.Clear();

				if (i < 5)
					await Task.Delay(delayBetweenHits);
			}

			// Have to send a Cast cancel at the end
			Send.ZC_SKILL_CAST_CANCEL(caster);
		}
	}
}
