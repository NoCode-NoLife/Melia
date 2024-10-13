using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
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
	/// Handler for the Ranger skill High Anchoring.
	/// </summary>
	[SkillHandler(SkillId.Ranger_HighAnchoring)]
	public class Ranger_HighAnchoring : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 200, width: 50, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			CallSafe(this.Attack(skill, caster, splashArea));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(150);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var results = new List<SkillHitResult>();
			var hits = new List<SkillHitInfo>();

			var hitTargets = targets.LimitBySDR(caster, skill);

			foreach (var target in hitTargets)
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				results.Add(skillHitResult);
				hits.Add(skillHit);

				// Note: This debuff was originally applied by Ranger31,
				// but when that ability was removed it just got it by default
				target.StartBuff(BuffId.HighAnchoring_Debuff, skill.Level, 0, TimeSpan.FromSeconds(5), caster);
			}

			// Ranger34 reduces the cooldown of Time Bomb Arrow,
			// Bounce Shot, and Spiral Arrow by one second per target hit
			var totalTargetsHit = hitTargets.Count();
			if (totalTargetsHit != 0 && caster.IsAbilityActive(AbilityId.Ranger34))
			{
				if (caster.TryGetSkill(SkillId.Ranger_TimeBombArrow, out var timeBombArrow))
				{
					timeBombArrow.ReduceCooldown(TimeSpan.FromSeconds(totalTargetsHit));
				}

				if (caster.TryGetSkill(SkillId.Ranger_BounceShot, out var bounceShot))
				{
					bounceShot.ReduceCooldown(TimeSpan.FromSeconds(totalTargetsHit));
				}

				if (caster.TryGetSkill(SkillId.Ranger_SpiralArrow, out var spiralArrow))
				{
					spiralArrow.ReduceCooldown(TimeSpan.FromSeconds(totalTargetsHit));
				}
			}

			// Ranger37 is almost the exact same, but it only activates
			// if you hit only one target with the skill.
			if (totalTargetsHit == 1 && caster.IsAbilityActive(AbilityId.Ranger37))
			{
				if (caster.TryGetSkill(SkillId.Ranger_Barrage, out var timeBombArrow))
				{
					timeBombArrow.ReduceCooldown(TimeSpan.FromSeconds(15));
				}

				if (caster.TryGetSkill(SkillId.Ranger_BounceShot, out var bounceShot))
				{
					bounceShot.ReduceCooldown(TimeSpan.FromSeconds(15));
				}

				if (caster.TryGetSkill(SkillId.Ranger_SpiralArrow, out var spiralArrow))
				{
					spiralArrow.ReduceCooldown(TimeSpan.FromSeconds(15));
				}
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);


			Ranger_CriticalShot.TryActivateDoubleTake(skill, caster, targets);
			Ranger_CriticalShot.TryReduceCooldown(skill, caster, results);
			Ranger_Strafe.TryApplyStrafeBuff(caster);
		}
	}
}
