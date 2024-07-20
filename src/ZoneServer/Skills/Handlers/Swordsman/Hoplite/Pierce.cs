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
using Melia.Zone.World.Actors.Characters.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman.Hoplite
{
	/// <summary>
	/// Handler for the Hoplite skill Pierce.
	/// </summary>
	[SkillHandler(SkillId.Hoplite_Pierce)]
	public class Hoplite_Pierce : IGroundSkillHandler
	{
		private const float HealDebuffPerLevel = 26f;
		private readonly static TimeSpan HealDebuffDuration = TimeSpan.FromSeconds(3);

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 90, width: 20, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(325);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var hitCount = 4;

				if (!Feature.IsEnabled("PierceNoSizeEffect")) { 
					var targetSize = target.GetEffectiveSize();
					if (targetSize == SizeType.M)
						hitCount = 2;
					if (targetSize == SizeType.L)
						hitCount = 3;
					if (targetSize == SizeType.XL || targetSize == SizeType.XXL)
						hitCount = 4;
				}

				var modifier = SkillModifier.MultiHit(hitCount);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				if (skillHitResult.Result == HitResultType.Crit && caster.Components.TryGet<SkillComponent>(out var skills)
					&& skills.TryGet(SkillId.Hoplite_SharpSpear, out var sharpSpear))
				{
					skillHitResult.Damage += skillHitResult.Damage *= (0.1f + sharpSpear.Level * 0.02f);
				}

				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);


				// The debuff value is handled in hundreds, meaning we need to
				// multiply it by 100 for it to display correctly in the tooltip.
				var debuffVal = HealDebuffPerLevel * 100f * skill.Level;

				target.StartBuff(BuffId.DecreaseHeal_Debuff, skill.Level, debuffVal, HealDebuffDuration, caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
