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
	/// Handler for the Doppelsoeldner skill Zornhau.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_Zornhau)]
	public class Doppelsoeldner_Zornhau : IGroundSkillHandler
	{
		private const int BuffRemoveChancePerLevel = 5;
		private readonly static TimeSpan DebuffDuration = TimeSpan.FromSeconds(5);

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
			var hitDelay = TimeSpan.FromMilliseconds(400);
			var damageDelay = TimeSpan.FromMilliseconds(150);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var hits = new List<SkillHitInfo>();
			var hitSomething = false;

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(2);

				if (caster.TryGetActiveAbilityLevel(AbilityId.Doppelsoeldner22, out var deepCutLevel))
					modifier.HitCount += deepCutLevel;

				if (caster.TryGetBuff(BuffId.DeedsOfValor, out var dovBuff))
					modifier.FinalDamageMultiplier = dovBuff.NumArg2;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				// TODO: On latest the game actually no longer applies this,
				// even though it still lists it in the description. Should
				// probably have some kind of feature to turn this on/off.
				target.StartBuff(BuffId.Common_Shock, skill.Level, 0, DebuffDuration, caster);

				if (caster.IsAbilityActive(AbilityId.Doppelsoeldner36))
					target.StartBuff(BuffId.Zornhau_Debuff, skill.Level, skillHitResult.Damage * 0.2f, DebuffDuration, caster);

				var buffRemoveChance = BuffRemoveChancePerLevel * skill.Level;
				target.RemoveRandomBuff(buffRemoveChance);

				hitSomething = true;
			}

			// Must hit at least 1 enemy to continue combo?
			if (hitSomething)
			{
				var duration = TimeSpan.FromSeconds(3);
				caster.StartBuff(BuffId.Zucken_Buff, skill.Level, 0, duration, caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}

