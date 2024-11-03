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

namespace Melia.Zone.Skills.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handler for the Outlaw skill Blindfire
	/// </summary>
	[SkillHandler(SkillId.OutLaw_FireBlindly)]
	public class OutLaw_FireBlindly : IGroundSkillHandler
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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 120, width: 40, angle: 80);
			var splashArea = skill.GetSplashArea(SplashType.Fan, splashParam);

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
			var hitDelay = TimeSpan.FromMilliseconds(360);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			// Outlaw9 gives guaranteed evade throughout the whole animation
			if (caster.IsAbilityActive(AbilityId.Outlaw9))
				caster.StartBuff(BuffId.FireBlindly_Buff, skill.Level, 0, TimeSpan.FromMilliseconds(600), caster);

			// First attack hits with no delay

			var hits = new List<SkillHitInfo>();
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(4);
				modifier.BonusCritChance += GetCritBonus(target);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				// Outlaw10 adds 30% damage on a critical
				if (caster.IsAbilityActive(AbilityId.Outlaw10) && skillHitResult.Result == HitResultType.Crit)
					skillHitResult.Damage *= 1.3f;

				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
			hits.Clear();
			await Task.Delay(hitDelay);

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(4);
				modifier.BonusCritChance += GetCritBonus(target);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				// Outlaw10 adds 30% damage on a critical
				if (caster.IsAbilityActive(AbilityId.Outlaw10) && skillHitResult.Result == HitResultType.Crit)
					skillHitResult.Damage *= 1.3f;

				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				// Description doesn't mention this, but it's in skill_bytool
				target.StartBuff(BuffId.MangleAndFireBlindly_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}


		/// <summary>
		/// Return the bonus damage
		/// Adds 20 to crit chance if target has any of Blind, Bleed, or Stun
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		private float GetCritBonus(ICombatEntity target)
		{
			if (target.IsBuffActive(BuffId.SprinkleSands_Debuff) || target.IsBuffActive(BuffId.HeavyBleeding) || target.IsBuffActive(BuffId.Behead_Debuff) || target.IsBuffActive(BuffId.Stun))
				return 20f;

			return 0f;
		}
	}
}
