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

namespace Melia.Zone.Skills.Handlers.Swordsmen.Doppelsoeldner
{
	/// <summary>
	/// Handler for the Doppelsoeldner skill Punish.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_Punish)]
	public class Doppelsoeldner_Punish : IGroundSkillHandler
	{
		private const float MaxTargetDistance = 30f;
		private const float MaxMoveDistance = 140f;
		private const float KnockdownMultiplier = 1.5f;
		private const float HealDebuffPerLevel = 33f;
		private readonly static TimeSpan HealDebuffDuration = TimeSpan.FromSeconds(5);

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			// Punish will attempt to move you towards the target before
			// it activates. The position is just in front of the target.
			var attackPosDist = caster.Position.Get2DDistance(target.Position) - MaxTargetDistance;

			// Check distance before spending SP	
			if (attackPosDist > MaxMoveDistance)
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			// If the caster is already in range, they won't move.
			if (attackPosDist > 0)
			{
				var endingPosition = caster.Position.GetRelative(caster.Direction, (float)attackPosDist);
				endingPosition = caster.Map.Ground.GetLastValidPosition(caster.Position, endingPosition);

				caster.Position = endingPosition;

				Send.ZC_SET_POS(caster);
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(target.Position);
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 30, width: 30, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

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
			var hitDelay = TimeSpan.FromMilliseconds(700);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = new SkillModifier();

				// TODO: Enable once we have a knock down state to check for.
				//if (target.IsKnockedDown)
				//	modifier.DamageMultiplier = KnockdownMultiplier;

				if (caster.TryGetBuff(BuffId.DeedsOfValor, out var dovBuff))
					modifier.FinalDamageMultiplier = dovBuff.NumArg2;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				// The debuff value is handled in hundreds, meaning we need to
				// multiply it by 100 for it to display correctly in the tooltip.
				var debuffVal = HealDebuffPerLevel * 100f * skill.Level;

				target.StartBuff(BuffId.DecreaseHeal_Debuff, skill.Level, debuffVal, HealDebuffDuration, caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}


