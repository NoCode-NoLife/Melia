using System;
using System.Collections.Generic;
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
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.Assassin
{
	/// <summary>
	/// Handler for the Assassin skill Instant Acceleration
	/// </summary>
	[SkillHandler(SkillId.Assassin_InstantaneousAcceleration)]
	public class Assassin_InstantaneousAcceleration : IGroundSkillHandler
	{
		private const float DashDistance = 100f;
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

			var endingPosition = caster.Position.GetRelative(caster.Direction, DashDistance);
			endingPosition = caster.Map.Ground.GetLastValidPosition(caster.Position, endingPosition);
			var actualDistance = (float)endingPosition.Get2DDistance(caster.Position);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: actualDistance, width: 30, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			caster.Position = endingPosition;
			Send.ZC_SET_POS(caster);

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
			var hitTime = TimeSpan.FromMilliseconds(100);
			var skillHitDelay = TimeSpan.Zero;
			var damageDelay = TimeSpan.FromMilliseconds(100);

			await Task.Delay(hitTime);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;
				modifier.HitCount = 4;

				// Assassin8 doubles the hit count in exchange for -25% damage
				if (caster.IsAbilityActive(AbilityId.Assassin8))
				{
					modifier.HitCount *= 2;
					modifier.FinalDamageMultiplier -= 0.25f;
				}

				// Increase damage by 10% if target is under the effect of
				// Assassination Target from the caster
				if (target.TryGetBuff(BuffId.Assassin_Target_Debuff, out var assassinTargetDebuff))
				{
					if (assassinTargetDebuff.Caster == caster)
						modifier.DamageMultiplier += 0.10f;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				hits.Add(skillHit);

				if (skillHitResult.Result != HitResultType.Dodge)
				{
					// Assassin9 adds 3 seconds of stun
					if (caster.IsAbilityActive(AbilityId.Assassin9))
						target.StartBuff(BuffId.Stun, skill.Level, 0, TimeSpan.FromSeconds(3), caster);
				}
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
