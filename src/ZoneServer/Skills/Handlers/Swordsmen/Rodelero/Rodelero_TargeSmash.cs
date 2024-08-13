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
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Rodelero
{
	/// <summary>
	/// Handler for the Rodelero skill Montano.
	/// </summary>
	[SkillHandler(SkillId.Rodelero_TargeSmash)]
	public class Rodelero_TargeSmash : IGroundSkillHandler
	{
		private readonly static TimeSpan FireDuration = TimeSpan.FromSeconds(10);
		private const float ShockDamageBonusMultiplier = 1f;

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 25, width: 50, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(250);
			var hitDelay2 = TimeSpan.FromMilliseconds(100);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			var hitTargets = targets.LimitBySDR(caster, skill);
			var fireDamage = 0f;

			foreach (var target in hitTargets)
			{
				var modifier = SkillModifier.MultiHit(6);
				modifier.BonusPAtk = Rodelero31.GetBonusPAtk(caster);
				modifier.MinCritChance = 20f;

				// This skill used to do bonus damage to shocked enemies
				//if (target.IsBuffActive(BuffId.Common_Shock)) 
				//{
				//	modifier.DamageMultiplier += ShockDamageBonusMultiplier;
				//}

				// If the target is frozen or petrified, Rodelero1 deals more
				// damage but ends the debuff
				if (caster.TryGetActiveAbilityLevel(AbilityId.Rodelero1, out var level))
				{
					if (target.IsBuffActive(BuffId.Frozen))
					{
						target.StopBuff(BuffId.Frozen);
						modifier.DamageMultiplier += 0.2f * level;
					}

					if (target.IsBuffActive(BuffId.Petrification))
					{
						target.StopBuff(BuffId.Petrification);
						modifier.DamageMultiplier += 0.2f * level;
					}
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				// In the past this skill inflicted the Blind status
				// target.StartBuff(BuffId.Blind, TimeSpan.FromSeconds(3));

				// If Targe Smash kills an enemy that is on fire
				// Rodelero6 spreads it to all of the other hit targets
				if (caster.IsAbilityActive(AbilityId.Rodelero6))
				{
					if (target.IsDead && target.TryGetBuff(BuffId.Fire, out var fire) && fire.NumArg2 > fireDamage)
						fireDamage = fire.NumArg2;
				}
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);

			if (fireDamage > 0f)
			{
				foreach (var target in hitTargets)
				{
					if (!target.IsDead)
						target.StartBuff(BuffId.Fire, skill.Level, fireDamage, FireDuration, caster);
				}
			}

			// The Ability Rodelero32 adds a second hitbox
			if (caster.IsAbilityActive(AbilityId.Rodelero32))
			{
				hits.Clear();

				await Task.Delay(hitDelay2);

				foreach (var target in this.GetTargetsForBreak(skill, caster, splashArea))
				{
					var modifier = SkillModifier.MultiHit(6);
					modifier.BonusPAtk = Rodelero31.GetBonusPAtk(caster);
					modifier.MinCritChance = 20f;

					var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;
					hits.Add(skillHit);
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);
			}
		}

		/// <summary>
		/// Gets the targets for Targe Smash: Break, a follow-up based on
		/// Rodelero32. It requires targets to have at least 1 debuff.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private List<ICombatEntity> GetTargetsForBreak(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			targets.RemoveAll(target => !target.Components.TryGet<BuffComponent>(out var buffs) || buffs.CountActive(a => a.Data.Type == BuffType.Debuff) == 0);

			return targets;
		}
	}
}
