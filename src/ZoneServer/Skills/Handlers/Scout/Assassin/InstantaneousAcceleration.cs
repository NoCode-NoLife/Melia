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
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scout.Assassin
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

			this.Attack(skill, caster, splashArea);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
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

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
