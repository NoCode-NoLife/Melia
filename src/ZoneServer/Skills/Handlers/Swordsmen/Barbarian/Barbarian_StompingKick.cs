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
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using static Melia.Shared.Util.TaskHelper;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian skill Stomping Kick.
	/// </summary>
	[SkillHandler(SkillId.Barbarian_StompingKick)]
	public class Barbarian_StompingKick : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public async void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			var splashWidth = 55;

			// Wild Nature effects - +2 range per stack
			if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
			{
				splashWidth += 2 * wildNature.OverbuffCounter;
			}

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 0, width: splashWidth, angle: 0);
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
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await this.WaitUntilGrounded(caster);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;

				// Wild Nature effects - 6% damage per stack
				if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
				{
					modifier.DamageMultiplier += 0.06f * wildNature.OverbuffCounter;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);

			// Barbarian 31 triggers a rejump afterwards
			if (caster.IsAbilityActive(AbilityId.Barbarian31))
			{
				await Task.Delay(100);

				if (caster.Components.TryGet<MovementComponent>(out var movementComponent))
				{
					// TODO: This doesn't work, may need another way to trigger a jump
					movementComponent.NotifyJump(caster.Position, caster.Direction, 0, 0);
				}
			}
		}

		/// <summary>
		/// Returns as soon as the caster is grounded.
		/// </summary>
		/// <param name="caster"></param>
		/// <returns></returns>
		private async Task WaitUntilGrounded(ICombatEntity caster)
		{
			if (!caster.Components.TryGet<MovementComponent>(out var movementComponent))
				return;

			while (!movementComponent.IsGrounded)
				await Task.Delay(30);
		}
	}
}
