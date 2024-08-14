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
using Melia.Zone.Skills.Handlers.Swordsmen.Peltasta.Abilities;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Peltasta
{
	/// <summary>
	/// Handler for the Peltasta Skill Umbo Blow.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_UmboBlow)]
	public class Peltasta_UmboBlow : IGroundSkillHandler
	{
		private readonly static TimeSpan StunDuration = TimeSpan.FromSeconds(3);
		private const int BuffRemoveChancePerLevel = 8;
		private const float LoopholeDamageMultiplier = 0.5f;
		private const float StunChancePerLevel = 5f;

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 25, width: 45, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(400);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;
				modifier.BonusPAtk = Peltasta38.GetBonusPAtk(caster);

				// At one point this seemed to instead use a status that was applied
				// by the removed Peltasta7 ability and the bonus was 200%
				if (caster.IsBuffActive(BuffId.Peltasta5_Guard_Buff))
					modifier.DamageMultiplier += LoopholeDamageMultiplier;

				// Increase damage by 10% if target is under the effect of
				// Swashbuckling from the caster
				if (target.TryGetBuff(BuffId.SwashBuckling_Debuff, out var swashBuckingDebuff))
				{
					if (swashBuckingDebuff.Caster == caster)
						modifier.DamageMultiplier += 0.10f;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				if (caster.TryGetActiveAbilityLevel(AbilityId.Peltasta8, out var knockdownLevel))
				{
					// Knockback power is 40 * level
					skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
					skillHit.HitInfo.Type = skill.Data.KnockDownHitType;
					target.Position = skillHit.KnockBackInfo.ToPosition;
				}
				else
				{
					skillHit.HitEffect = HitEffect.Impact;
				}

				hits.Add(skillHit);

				// Note: This ability was repurposed to Rim Blow after Umbo Blow was removed,
				// which is why the description mentions it affects Umbo Blow.
				if (caster.TryGetActiveAbilityLevel(AbilityId.Impact, out var stunLevel) && RandomProvider.Get().Next(100) < stunLevel * StunChancePerLevel)
					target.StartBuff(BuffId.Stun, stunLevel, 0, StunDuration, caster);

				var buffRemoveChance = BuffRemoveChancePerLevel * skill.Level;
				target.RemoveRandomBuff(buffRemoveChance);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
