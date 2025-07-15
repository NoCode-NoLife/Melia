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
	/// Handler for the Outlaw skill Mangle.
	/// </summary>
	[SkillHandler(SkillId.OutLaw_Mangle)]
	public class OutLaw_Mangle : IGroundSkillHandler
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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 40, width: 20, angle: 0);
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
			var hitDelay1 = TimeSpan.FromMilliseconds(350);
			var hitDelay2 = TimeSpan.FromMilliseconds(600);
			var hitDelay3 = TimeSpan.FromMilliseconds(50);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			// Outlaw6 gives guaranteed evade throughout the whole animation
			if (caster.IsAbilityActive(AbilityId.Outlaw6))
				caster.StartBuff(BuffId.Mangle_Buff, skill.Level, 0, TimeSpan.FromMilliseconds(1300), caster);

			// First attack hits with no delay

			var hits = new List<SkillHitInfo>();
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(3);
				modifier.FinalDamageMultiplier += this.GetDamageBonus(target);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
			hits.Clear();
			await Task.Delay(hitDelay1);

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(2);

				// Outlaw7 adds 3 more hits
				if (caster.IsAbilityActive(AbilityId.Outlaw7))
					modifier.HitCount += 3;

				modifier.FinalDamageMultiplier += this.GetDamageBonus(target);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
			hits.Clear();
			await Task.Delay(hitDelay2);

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;
				modifier.FinalDamageMultiplier += this.GetDamageBonus(target);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
			hits.Clear();
			await Task.Delay(hitDelay3);

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(3);
				modifier.FinalDamageMultiplier += this.GetDamageBonus(target);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				target.StartBuff(BuffId.MangleAndFireBlindly_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}


		/// <summary>
		/// Return the bonus damage
		/// Adds 0.5 to final damage for each of Blind, Bleed, or Stun
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		private float GetDamageBonus(ICombatEntity target)
		{
			var damageBonus = 0f;

			if (target.IsBuffActive(BuffId.SprinkleSands_Debuff))
				damageBonus += 0.5f;

			if (target.IsBuffActive(BuffId.HeavyBleeding) || target.IsBuffActive(BuffId.Behead_Debuff))
				damageBonus += 0.5f;

			if (target.IsBuffActive(BuffId.Stun))
				damageBonus += 0.5f;

			return damageBonus;
		}
	}
}
