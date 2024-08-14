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
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Hoplite
{
	/// <summary>
	/// Handler for the Hoplite skill Stabbing.
	/// </summary>
	[SkillHandler(SkillId.Hoplite_Stabbing)]
	public class Hoplite_Stabbing : IGroundSkillHandler
	{
		// This represents 0.23% to remove 2 buffs per level per hit
		private const float BuffRemoveChancePerLevel = 23f;

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 90, width: 20, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			CallSafe(this.Attack(skill, caster, splashArea));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <remarks>
		/// This skill does a single hit, followed by 15 more hits in a loop
		/// </remarks>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(235);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;
			var delayBeforeLoop = TimeSpan.FromMilliseconds(210);
			var delayBetweenHits = TimeSpan.FromMilliseconds(140);
			await Task.Delay(hitDelay);

			var hits = new List<SkillHitInfo>();
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				target.StartBuff(BuffId.Stabbing_Debuff, TimeSpan.FromSeconds(3));

				var buffRemoveChance = BuffRemoveChancePerLevel * skill.Level;
				if (RandomProvider.Get().Next(10000) < buffRemoveChance)
				{
					if (target.Components.TryGet<BuffComponent>(out var buffComponent))
					{
						buffComponent.RemoveRandomBuff();
						buffComponent.RemoveRandomBuff();
					}
				}
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
			hits.Clear();

			await Task.Delay(delayBeforeLoop);

			for (var i = 0; i < 15; i++)
			{
				targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var modifier = SkillModifier.Default;
					if (target.TryGetBuff(BuffId.Stabbing_Debuff, out var stabbingDebuff))
					{
						modifier.DamageMultiplier += 0.1f * Math.Min(stabbingDebuff.OverbuffCounter, 5);
					}
					var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;
					hits.Add(skillHit);

					target.StartBuff(BuffId.Stabbing_Debuff, TimeSpan.FromSeconds(3));

					var buffRemoveChance = BuffRemoveChancePerLevel * skill.Level;
					if (RandomProvider.Get().Next(10000) < buffRemoveChance)
					{
						if (target.Components.TryGet<BuffComponent>(out var buffComponent))
						{
							buffComponent.RemoveRandomBuff();
							buffComponent.RemoveRandomBuff();
						}
					}
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);

				hits.Clear();

				if (i < 14)
					await Task.Delay(delayBetweenHits);
			}
		}
	}
}
