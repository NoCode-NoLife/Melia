﻿using System;
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
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Components;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian skill Embowel.
	/// </summary>
	[SkillHandler(SkillId.Barbarian_Embowel)]
	public class Barbarian_Embowel : IGroundSkillHandler
	{
		public const float JumpDistance = 24.914738f;

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 40, width: 45, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			caster.StartBuff(BuffId.Skill_MomentaryImmune_Buff, skill.Level, 0, TimeSpan.FromSeconds(1), caster);
			caster.StartBuff(BuffId.Embowel_Buff, skill.Level, 0, skill.Data.ShootTime, caster);

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
			var hitDelay = TimeSpan.FromMilliseconds(50);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var jumpDelay = TimeSpan.FromMilliseconds(675);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;

				// Wild Nature effects - 6% damage per stack
				// 2 second stun per stack (25% duration to players)
				if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
				{
					modifier.DamageMultiplier += 0.06f * wildNature.OverbuffCounter;

					var debuffTime = 2f * wildNature.OverbuffCounter;
					if (target is Character)
						debuffTime /= 4;

					target.StartBuff(BuffId.Stun, skill.Level, 0, TimeSpan.FromSeconds(debuffTime), caster);
				}

				if (caster.IsBuffActive(BuffId.Embowel_PowerUp_Buff))
				{
					modifier.DamageMultiplier += 0.5f;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
				skillHit.HitInfo.Type = HitType.KnockBack;
				target.Position = skillHit.KnockBackInfo.ToPosition;

				hits.Add(skillHit);

				target.AddState(StateType.Stunned);
				target.StartBuff(BuffId.DecreaseHeal_Debuff, skill.Level, this.GetHealingReduction(skill), TimeSpan.FromSeconds(5), caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);

			await Task.Delay(jumpDelay);

			foreach (var target in hits.Select(a => a.Target))
				target.RemoveState(StateType.Stunned);

			// Caster performs a small backwards leap at the end.
			// You seem to jump only half the indicated distance.
			var targetPos = caster.Position.GetRelative(caster.Direction.Backwards, JumpDistance);
			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);

			caster.Position = targetPos;
			Send.ZC_NORMAL.LeapJump(caster, targetPos, 0.1f, 0.1f, 1f, 0.2f, 1f, 5);
		}

		/// <summary>
		/// Returns the skill's healing reduction value for use with the heal
		/// decrease debuff.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetHealingReduction(Skill skill)
		{
			return 3.3f * skill.Level * 1000;
		}
	}
}
