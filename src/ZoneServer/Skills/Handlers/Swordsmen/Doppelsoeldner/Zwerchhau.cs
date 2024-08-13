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

namespace Melia.Zone.Skills.Handlers.Swordsmen.Doppelsoeldner
{
	/// <summary>
	/// Handler for the Doppelsoeldner skill Zwerchhau.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_Zwerchhau)]
	public class Doppelsoeldner_Zwerchhau : IGroundSkillHandler
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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 90, width: 0, angle: 50);
			var splashArea = skill.GetSplashArea(SplashType.Fan, splashParam);

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
			var hitDelay = TimeSpan.FromMilliseconds(170);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var hits = new List<SkillHitInfo>();

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hitSomething = false;

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(3);

				if (caster.TryGetBuff(BuffId.DeedsOfValor, out var dovBuff))
					modifier.FinalDamageMultiplier = dovBuff.NumArg2;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				if (caster.IsAbilityActive(AbilityId.Doppelsoeldner38))
				{
					// TODO: This knockdown effect pulls the enemies towards you
					skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
					skillHit.HitInfo.Type = skill.Data.KnockDownHitType;
					target.Position = skillHit.KnockBackInfo.ToPosition;
				}
				else
				{ 
					skillHit.HitEffect = HitEffect.Impact;
				}


				hits.Add(skillHit);

				hitSomething = true;
			}

			if (caster.IsAbilityActive(AbilityId.Doppelsoeldner26) && hitSomething)
			{
				var duration = TimeSpan.FromSeconds(3);
				caster.StartBuff(BuffId.Zucken_Buff, skill.Level, 0, duration, caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
