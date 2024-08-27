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
using static Melia.Shared.Util.TaskHelper;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian skill Cleave.
	/// </summary>
	[SkillHandler(SkillId.Barbarian_Cleave)]
	public class Barbarian_Cleave : IGroundSkillHandler
	{
		public const float StunDamageBonus = 1.5f;

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
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 40, width: 45, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(100);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;

				// Wild Nature effects - 6% damage per stack
				// 10% crit chance per stack
				if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
				{
					modifier.DamageMultiplier += 0.06f * wildNature.OverbuffCounter;
					modifier.BonusCritChance += wildNature.OverbuffCounter * 10;
				}

				if (target.IsBuffActive(BuffId.Stun))
					modifier.DamageMultiplier += StunDamageBonus;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				if (caster.IsAbilityActive(AbilityId.Barbarian32))
				{
					skillHit.HitEffect = HitEffect.Impact;
				}
				else
				{
					skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
					skillHit.HitInfo.Type = skill.Data.KnockDownHitType;
					target.Position = skillHit.KnockBackInfo.ToPosition;
				}

				hits.Add(skillHit);

				// This skill used to apply this debuff, but it was swapped out for Aggressor_Buff
				if (!Feature.IsEnabled("CleaveApplyAggressor"))
					target.StartBuff(BuffId.Cleave_Debuff, skill.Level, 0, TimeSpan.FromSeconds(5), caster);
			}

			if (Feature.IsEnabled("CleaveApplyAggressor"))
				caster.StartBuff(BuffId.Aggressor_Buff, skill.Level, 0, TimeSpan.FromSeconds(5), caster);

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
