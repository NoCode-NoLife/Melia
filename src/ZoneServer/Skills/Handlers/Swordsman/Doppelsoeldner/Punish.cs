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
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Handler for the Doppelsoeldner skill Punish.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_Punish)]
	public class Punish : IGroundSkillHandler
	{
		private const float MaxMoveDistance = 140f;  // Will attempt to move up to 140 units
		private const float KnockdownMultiplier = 1.5f;  // 50% bonus damage against knocked down enemies
		private const float HealDebuffPerLevel = 3300f;  // Packet needs this passed in at 100x the amount to display in the tooltip
		private const float HealDebuffDuration = 5;

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			// Punish will attempt to move you to towards the target before it activates.  We subtract 30 so the center of the circle hits the enemy
			var distanceToTarget = caster.Position.Get2DDistance(target.Position) - 30d;

			// On official, the skill fails if the target is too far away.  It should do this before spending SP.
			if (distanceToTarget > MaxMoveDistance)
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

			skill.IncreaseOverheat();
			caster.TurnTowards(target.Position);
			caster.SetAttackState(true);

			// If the distance to jump is < 0 (ie, the target is already within range), you don't move
			if (distanceToTarget > 0)
			{
				var movementDistance = Math.Min(distanceToTarget, MaxMoveDistance);
				caster.Position = caster.Position.GetRelative(caster.Direction, (float)movementDistance);
				Send.ZC_SET_POS(caster);
			}

			var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 30, width: 30, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

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
			var hitDelay = TimeSpan.FromMilliseconds(350);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;
			var deedsOfValorBonus = 1.0f;

			if (caster.IsBuffActive(BuffId.DeedsOfValor))
			{
				var buff = caster.Components.Get<BuffComponent>().Get(BuffId.DeedsOfValor);
				deedsOfValorBonus = buff.NumArg2;
			}

			await Task.Delay(hitDelay);

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = new SkillModifier();

				// TODO: This should do extra damage if the enemy is in a knockdown state
				// but knockdown is not fully implemented so there's no way to check for it

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				skillHitResult.Damage *= deedsOfValorBonus;
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				target.StartBuff(BuffId.DecreaseHeal_Debuff, skill.Level, HealDebuffPerLevel * skill.Level, TimeSpan.FromSeconds(HealDebuffDuration), caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}


