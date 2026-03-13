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

namespace Melia.Zone.Skills.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handler for the Swordsman skill Pommel Beat.
	/// </summary>
	[SkillHandler(SkillId.Swordman_PommelBeat)]
	public class Swordman_PommelBeat : IGroundSkillHandler
	{
		private const float StunDamageMultiplier = 3f;
		private const float DefPierceRate = 0.01f;
		private const float DefPierceRatePerLevel = 0.005f;

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 50, width: 25, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			skill.Run(this.Attack(skill, caster, splashArea));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var attackTime = TimeSpan.FromMilliseconds(300);
			var aniTime = TimeSpan.FromMilliseconds(150);
			var hitDelay = skill.Properties.HitDelay;

			await skill.Wait(attackTime);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;

				if (target.IsBuffActive(BuffId.Stun))
					modifier.DamageMultiplier = StunDamageMultiplier;

				if (target.EffectiveSize >= SizeType.S && target.EffectiveSize <= SizeType.M)
					modifier.DefensePenetrationRate = DefPierceRate + skill.Level * DefPierceRatePerLevel;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, aniTime, hitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				skillHit.ApplyDamage();
				skillHit.ApplyKnockBack();

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
