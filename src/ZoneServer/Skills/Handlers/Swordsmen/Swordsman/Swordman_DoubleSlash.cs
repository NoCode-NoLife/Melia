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
	/// Handler for the Highlander skill Crosscut.
	/// </summary>
	[SkillHandler(SkillId.Swordman_DoubleSlash)]
	public class Swordman_DoubleSlash : IGroundSkillHandler
	{
		private const float BleedDamageMultiplier = 3f;

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 45, width: 40, angle: 0);
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
			var attackTime1 = TimeSpan.FromMilliseconds(100);
			var attackTime2 = TimeSpan.FromMilliseconds(250);
			var aniTime1 = TimeSpan.FromMilliseconds(50);
			var aniTime2 = TimeSpan.FromMilliseconds(100);
			var hitDelay = skill.Properties.HitDelay;

			await skill.Wait(attackTime1);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;

				if (target.IsBuffActive(BuffId.HeavyBleeding))
					modifier.DamageMultiplier = BleedDamageMultiplier;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, aniTime1, hitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				skillHit.ApplyDamage();
				skillHit.ApplyKnockBack();

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);

			await skill.Wait(attackTime2);

			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			hits.Clear();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;

				if (target.IsBuffActive(BuffId.HeavyBleeding))
					modifier.DamageMultiplier = BleedDamageMultiplier;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, aniTime2, hitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				skillHit.ApplyDamage();
				skillHit.ApplyKnockBack();

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
