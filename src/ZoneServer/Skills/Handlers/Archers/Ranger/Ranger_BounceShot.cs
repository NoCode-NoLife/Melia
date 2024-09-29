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
		/// Handles the skill, shoot missile at enemy that spreads to other targets
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

			var modifier = SkillModifier.Default;

			// Ranger38 used to apply a freeze effect to Bounce Shot
			// This was repurposed for Blazing Arrow, but the code
			// in Skill_Bytool still checks for it.
			if (caster.IsAbilityActive(AbilityId.Ranger38))
			{
				modifier.OverrideAttribute = SkillAttribute.Ice;
			}

			var damageDelay = TimeSpan.FromMilliseconds(45);
			var skillHitDelay = TimeSpan.Zero;

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);


			if (caster.IsAbilityActive(AbilityId.Ranger38))
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
			CallSafe(this.Bounce(skill, caster, target));
		}

		private async Task Bounce(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			// Bounce shot
			if (this.TryGetBounceTarget(caster, target, skill, out var bounceTargets))
			{
				var skillHitResults = new Dictionary<ICombatEntity, SkillHitResult>();

				foreach (var bounceTarget in bounceTargets)
				{
					var modifier = SkillModifier.Default;
					if (caster.IsAbilityActive(AbilityId.Ranger38))
					{
						modifier.OverrideAttribute = SkillAttribute.Ice;
					}

					var skillHitResult = SCR_SkillHit(caster, bounceTarget, skill, modifier);					
					skillHitResults.Add(bounceTarget, skillHitResult);

					// Random chance to apply Slow debuff
					if (RandomProvider.Next(100) < 50)
					{
						var duration = TimeSpan.FromSeconds(7);
						bounceTarget.StartBuff(BuffId.Common_Slow, skill.Level, 0, duration, caster);
					}
				}

				// We delay here to sync the animation.
				// Double take activates when the damage is calculated,
				// not when it applies, so this way it hits all targets
				var bounceHitDelay = TimeSpan.FromMilliseconds(420);
				await Task.Delay(bounceHitDelay);

				var animationName = "I_archer_dividedarrow_force_fire#Dummy_Force";

				// Ranger38 also changes the animation.
				if (caster.IsAbilityActive(AbilityId.Ranger38))
				{
					animationName = "I_arrow003_blue#Dummy_Force_effect";
				}

				foreach (var bounceTarget in skillHitResults.Keys)
				{
					var skillHitResult = skillHitResults[bounceTarget];
					bounceTarget.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, bounceTarget, skill, skillHitResult);
					hit.ForceId = ForceId.GetNew();
					hit.ResultType = HitResultType.Unk8;

					Send.ZC_NORMAL.PlayForceEffect(hit.ForceId, caster, target, bounceTarget, animationName, 0.7f, "arrow_cast", "F_hit_good", 1, "arrow_blow", "SLOW", 800);
					Send.ZC_HIT_INFO(caster, bounceTarget, hit);
				}
			}
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
