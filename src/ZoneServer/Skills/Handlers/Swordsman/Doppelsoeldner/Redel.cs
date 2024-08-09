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

namespace Melia.Zone.Skills.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Handler for the Doppelsoeldner skill Redel.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_Redel)]
	public class Doppelsoeldner_Redel : IGroundSkillHandler
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

			// Redel is a combo skill that can only be used if other skills added
			// the necessary buff before. The buff ends the moment the skill is
			// used.
			if (!caster.IsBuffActive(BuffId.Redel_Buff))
			{
				caster.ServerMessage(Localization.Get("Can't use this skill."));
				return;
			}

			caster.StopBuff(BuffId.Redel_Buff);

			skill.IncreaseOverheat();
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 70, width: 30, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(600);
			var damageDelay1 = TimeSpan.FromMilliseconds(50);
			var damageDelay2 = TimeSpan.FromMilliseconds(50);
			var delayBetweenHits = TimeSpan.FromMilliseconds(200);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var hits = new List<SkillHitInfo>();

			for (var i = 0; i < 5; i++)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var modifier = SkillModifier.MultiHit(2);

					if (caster.TryGetBuff(BuffId.DeedsOfValor, out var dovBuff))
						modifier.FinalDamageMultiplier = dovBuff.NumArg2;

					var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay1, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;

					hits.Add(skillHit);
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);

				hits.Clear();
				await Task.Delay(delayBetweenHits);
			}
		}
	}
}
