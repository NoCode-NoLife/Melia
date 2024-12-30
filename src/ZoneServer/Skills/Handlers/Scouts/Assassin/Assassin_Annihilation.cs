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
using Yggdrasil.Logging;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.Assassin
{
	/// <summary>
	/// Handler for the Assassin Skill Annihilation
	/// </summary>
	[SkillHandler(SkillId.Assassin_Annihilation)]
	public class Assassin_Annihilation : IGroundSkillHandler
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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 0, width: 100, angle: 0);
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

			var delayBetweenHits = TimeSpan.FromMilliseconds(400);

			// first hit hits instantly

			var hits = new List<SkillHitInfo>();

			// Assassin23 is a slight variation of this skill
			var isFastVariant = caster.IsAbilityActive(AbilityId.Assassin23);

			// Caster has invincibility during the normal version
			if (!isFastVariant)
				caster.StartBuff(BuffId.Skill_NoDamage_Buff, skill.Level, 0, TimeSpan.FromMilliseconds(2600), caster);

			for (var i = 0; i < 7; i++)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var modifier = SkillModifier.MultiHit(2);

					// Fast variant does 10 hits
					if (isFastVariant)
						modifier.HitCount = 10;

					// Assassin17 adds double crit rate to bleeding targets
					if (caster.IsAbilityActive(AbilityId.Assassin17) && (target.IsBuffActive(BuffId.HeavyBleeding) || target.IsBuffActive(BuffId.Behead_Debuff)))
					{
						modifier.CritRateMultiplier++;
					}

					// Increase damage by 10% if target is under the effect of
					// Assassination Target from the caster
					if (target.TryGetBuff(BuffId.Assassin_Target_Debuff, out var assassinTargetDebuff))
					{
						if (assassinTargetDebuff.Caster == caster)
							modifier.DamageMultiplier += 0.10f;
					}

					var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;
					hits.Add(skillHit);
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);

				hits.Clear();

				// we actually have to wait for the last hit here as well
				// due to the animation cancel and cloaking effect
				if (i < 7)
					await Task.Delay(delayBetweenHits);
			}

			// Have to send this to make you reappear afterwards			
			Send.ZC_NORMAL.SkillCancelCancel(caster, skill.Id);
			Send.ZC_PLAY_ANI(caster, "idle1");

			// Assassin16 gives cloak after the slow version
			if (!isFastVariant && caster.TryGetActiveAbilityLevel(AbilityId.Assassin16, out var level))
			{
				caster.StartBuff(BuffId.Cloaking_Buff, skill.Level, 0, TimeSpan.FromSeconds(level), caster);
			}
		}
	}
}
