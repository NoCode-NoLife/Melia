using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using Yggdrasil.Logging;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Scout.Assassin
{
	/// <summary>
	/// Handler for the Assassin skill Behead.
	/// </summary>
	[SkillHandler(SkillId.Assassin_Behead)]
	public class Behead : IGroundSkillHandler
	{
		private const float MaxMoveDistance = 150f;  // Will attempt to move up to 150 units

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

			// If the target is a player, Behead will teleport behind them
			// If any of these conditions fail, you just swing normally
			if (target is Character playerTarget)
			{
				// the target position is 10 units behind the target
				var targetPosition = playerTarget.Position.GetRelative(playerTarget.Direction, -10f);
				if (caster.Map.Ground.IsValidPosition(targetPosition)) 
				{
					// the teleport only occurs if the target position is within 150 units
					var distanceToTarget = originPos.Get2DDistance(targetPosition);

					if (distanceToTarget > 0 && distanceToTarget <= MaxMoveDistance)
					{
						caster.Position = targetPosition;
						caster.TurnTowards(target);
						Send.ZC_SET_POS(caster);
					}
				}
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 60, width: 35, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

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
			var hitDelay = TimeSpan.FromMilliseconds(30);
			// The damage delay1 is unusually long, but confirmed with official
			var damageDelay1 = TimeSpan.FromMilliseconds(240);
			var damageDelay2 = TimeSpan.FromMilliseconds(80);
			var delayBetweenHits = TimeSpan.FromMilliseconds(330);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = new SkillModifier();
				modifier.HitCount = 3;
				modifier.DefensePenetrationRate = 0.15f;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay1, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);
				Send.ZC_SKILL_HIT_INFO(caster, hits);
			}

			await Task.Delay(delayBetweenHits);
			hits.Clear();

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = new SkillModifier();
				modifier.HitCount = 3;
				modifier.DefensePenetrationRate = 0.15f;

				var skillHitResult2 = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult2.Damage, caster);

				var skillHit2 = new SkillHitInfo(caster, target, skill, skillHitResult2, damageDelay2, skillHitDelay);
				skillHit2.HitEffect = HitEffect.Impact;
				hits.Add(skillHit2);
				Send.ZC_SKILL_HIT_INFO(caster, hits);

				// Behead Debuff deals 5% of the damage every 1.5s for 30s
				target.StartBuff(BuffId.Behead_Debuff, skill.Level, skillHitResult2.Damage * 0.05f, TimeSpan.FromSeconds(30), caster);
			}
		}
	}
}
