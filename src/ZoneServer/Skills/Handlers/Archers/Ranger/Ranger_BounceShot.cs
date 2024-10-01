using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handles the Ranger skill Bounce Shot.
	/// </summary>
	[SkillHandler(SkillId.Ranger_BounceShot)]
	public class Ranger_BounceShot : ITargetSkillHandler
	{
		private const int MaxBounceTargets = 6;

		/// <summary>
		/// Handles the skill
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
		/// Handles the actual attack, shoot missile at enemy that spreads to other targets
		/// </summary>
		public async Task Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var modifier = SkillModifier.Default;

			var isIceVariant = false;
			var animationName = "I_archer_dividedarrow_force_fire";
			var blastName = "F_archer_dividedarrow_hit_explosion";
			var targets = new System.Collections.Generic.List<ICombatEntity>();
			var results = new System.Collections.Generic.List<SkillHitResult>();			
			targets.Add(target);


			// Because of the repurposed Ranger38, a visual error occurs when using
			// this skill if Ranger38 is known.  Set this flag to true to fix this issue.
			var alternateAnimation = false;

			// Ranger38 used to apply a freeze effect to Bounce Shot
			// This was repurposed for Blazing Arrow, so it's currently
			// disabled.  If you wish, you can re-enable this or remap
			// it to another ability, such as the unused Ranger3.
			//if (caster.IsAbilityActive(AbilityId.Ranger38))
			//{
			//    isIceVariant = true;
			//}

			if (isIceVariant)
			{
				modifier.AttackAttribute = SkillAttribute.Ice;
				animationName = "I_arrow003_blue";
				blastName = "F_explosion104_ice";
			}

			var damageDelay = TimeSpan.FromMilliseconds(100);
			var bounceHitDelay = TimeSpan.FromMilliseconds(500);
			var skillHitDelay = TimeSpan.Zero;

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			results.Add(skillHitResult);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.ForceId = ForceId.GetNew();

			if (!alternateAnimation)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);
			}
			else
			{
				Send.ZC_SKILL_FORCE_TARGET_DUMMY(caster, target, skill, SkillId.Archer_HighAnchoring2, skillHit.ForceId, null);

				await Task.Delay(damageDelay);
				bounceHitDelay = TimeSpan.FromMilliseconds(400);

				var hit = new HitInfo(caster, target, skill, skillHitResult);
				hit.ForceId = ForceId.GetNew();
				hit.ResultType = HitResultType.Unk8;

				Send.ZC_NORMAL.PlayEffect(target, blastName, 0.5f);
				Send.ZC_NORMAL.PlayForceEffect(hit.ForceId, caster, caster, target, animationName, 0.7f, "arrow_cast", "F_hit_good", 1, "arrow_blow", "SLOW", 800);
				Send.ZC_HIT_INFO(caster, target, hit);
			}

			if (isIceVariant)
			{
				// Guaranteed freeze on the primary target
				var duration = TimeSpan.FromMilliseconds(2500);
				target.StartBuff(BuffId.Freeze, skill.Level, 0, duration, caster);						
			}
			else
			{
				// Random chance to apply Slow debuff	
				if (RandomProvider.Next(100) < 50)
				{
					var duration = TimeSpan.FromSeconds(7);
					target.StartBuff(BuffId.Common_Slow, skill.Level, 0, duration, caster);
				}
			}
			
			await Task.Delay(bounceHitDelay);

			// bounce shot
			if (this.TryGetBounceTarget(caster, target, skill, out var bounceTargets))
			{
				var animationName2 = "I_archer_dividedarrow_force_fire#Dummy_Force";

				// Ranger38 also changes the animation.
				if (isIceVariant)
				{
					animationName2 = "I_arrow003_blue#Dummy_q_Force";
				}

				foreach (var bounceTarget in bounceTargets)
				{
					var modifier2 = SkillModifier.Default;
					if (isIceVariant)
					{
						modifier2.AttackAttribute = SkillAttribute.Ice;
					}

					var skillHitResult2 = SCR_SkillHit(caster, bounceTarget, skill, modifier2);
					bounceTarget.TakeDamage(skillHitResult2.Damage, caster);
					targets.Add(bounceTarget);

					results.Add(skillHitResult2);

					var hit2 = new HitInfo(caster, bounceTarget, skill, skillHitResult2);
					hit2.ForceId = ForceId.GetNew();
					hit2.ResultType = HitResultType.Unk8;

					Send.ZC_NORMAL.PlayForceEffect(hit2.ForceId, caster, target, bounceTarget, animationName2, 0.7f, "arrow_cast", "F_hit_good", 1, "arrow_blow", "SLOW", 800);
					Send.ZC_HIT_INFO(caster, bounceTarget, hit2);

					// Random chance to apply Slow debuff
					if (RandomProvider.Next(100) < 50)
					{
						var duration = TimeSpan.FromSeconds(7);
						bounceTarget.StartBuff(BuffId.Common_Slow, skill.Level, 0, duration, caster);
					}
				}
			}

			Ranger_CriticalShot.TryActivateDoubleTake(skill, caster, targets);
			Ranger_CriticalShot.TryReduceCooldown(skill, caster, results);
			Ranger_Strafe.TryApplyStrafeBuff(caster);
		}


		/// <summary>
		/// Returns the closest target to the main target to bounce the
		/// attack off to.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="mainTarget"></param>
		/// <param name="skill"></param>
		/// <param name="bounceTarget"></param>
		/// <returns></returns>
		private bool TryGetBounceTarget(ICombatEntity caster, ICombatEntity mainTarget, Skill skill, out System.Collections.Generic.IEnumerable<ICombatEntity> bounceTargets)
		{
			var splashPos = caster.Position;
			var splashRadius = 100;
			var splashArea = new Circle(mainTarget.Position, splashRadius);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			if (!targets.Any())
			{
				bounceTargets = null;
				return false;
			}

			bounceTargets = targets.LimitRandom(MaxBounceTargets);
			return true;
		}
	}
}
