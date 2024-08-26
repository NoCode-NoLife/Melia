using System;
using System.Collections.Generic;
using System.Linq;
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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Cataphract
{
	/// <summary>
	/// Handler for the Cataphract skill Impaler.
	/// </summary>
	[SkillHandler(SkillId.Cataphract_Impaler)]
	public class Cataphract_Impaler : IGroundSkillHandler
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
			
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			if (!caster.IsBuffActive(BuffId.Impaler_Buff))
			{
				var grabParam = skill.GetSplashParameters(caster, originPos, farPos, length: 15, width: 50, angle: 0);
				var grabArea = skill.GetSplashArea(SplashType.Circle, grabParam);

				Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
				Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

				CallSafe(Grab(skill, caster, grabArea));
			}
			else
			{
				var slamParam = skill.GetSplashParameters(caster, originPos, farPos, length: 25, width: 35, angle: 0);
				var slamArea = skill.GetSplashArea(SplashType.Circle, slamParam);

				Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
				Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

				CallSafe(Slam(skill, caster, slamArea));
			}
		}

		/// <summary>
		/// Attempts to grab a target
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private static async Task Grab(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(250);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();			

			var grabbedSomething = false;

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var targetSize = target.EffectiveSize;

				if (targetSize != SizeType.PC && targetSize >= SizeType.L)
					continue;

				target.StartBuff(BuffId.Impaler_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);
				var impalerBuff = caster.StartBuff(BuffId.Impaler_Buff, skill.Level, 0, TimeSpan.FromSeconds(10), target);

				impalerBuff.UpdateTime = TimeSpan.FromMilliseconds(100);
				grabbedSomething = true;
				break;
			}

			// Only overheat here on a miss
			if (!grabbedSomething)
			{
				skill.IncreaseOverheat();
				return;
			}
		}

		/// <summary>
		/// Slam the target to deal damage
		/// </summary>
		/// <remarks>
		/// This does not play the right animation.  It should play SKL_IMPALER_THROW_RIDE.
		/// </remarks>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private static async Task Slam(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(200);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var bonusMultiplier = 0f;
			if (caster.TryGetSkill(SkillId.Cataphract_AcrobaticMount, out var acrobaticMount))
			{
				bonusMultiplier = 0.5f + acrobaticMount.Level * 0.06f;
			}

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			// remove the skewered mob from the list of targets if they're present
			// They get hit separately at the end.
			if (caster.TryGetBuff(BuffId.Impaler_Buff, out var buff))
			{
				var skewered = buff.Caster;
				targets.Remove(skewered);


				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var modifier = SkillModifier.MultiHit(3);
					modifier.DamageMultiplier += bonusMultiplier;

					if (caster.IsAbilityActive(AbilityId.Cataphract26))
					{
						modifier.OverrideAttackAttribute = true;
						modifier.AttackAttribute = SkillAttribute.Earth;
					}

					var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;
					hits.Add(skillHit);
				}


				var modifier2 = SkillModifier.MultiHit(3);
				modifier2.ForcedCritical = true;
				modifier2.DamageMultiplier += bonusMultiplier;

				var skillHitResult2 = SCR_SkillHit(caster, skewered, skill, modifier2);
				skewered.TakeDamage(skillHitResult2.Damage, caster);

				var skillHit2 = new SkillHitInfo(caster, skewered, skill, skillHitResult2, damageDelay, skillHitDelay);
				skillHit2.HitEffect = HitEffect.Impact;
				hits.Add(skillHit2);

			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
