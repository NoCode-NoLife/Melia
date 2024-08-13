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

namespace Melia.Zone.Skills.Handlers.Swordsmen.Rodelero
{
	/// <summary>
	/// Handler for the Rodelero skill Shield Push.
	/// </summary>
	[SkillHandler(SkillId.Rodelero_ShieldPush)]
	public class Rodelero_ShieldPush : IGroundSkillHandler
	{
		private readonly static TimeSpan DefDownDuration = TimeSpan.FromSeconds(10);
		private readonly static TimeSpan UnbalanceDuration = TimeSpan.FromSeconds(3);
		private const int BuffRemoveChancePerLevel = 6;

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 55, width: 20, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(80);
			var damageDelay = TimeSpan.FromMilliseconds(20);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(3);
				modifier.BonusPAtk = Rodelero31.GetBonusPAtk(caster);

				// Deals double damage if behind the enemy
				if (caster.IsBehind(target))
				{
					modifier.DamageMultiplier += 1f;
				}
				// If the back attack fails, it changes the target's direction
				else
				{
					target.TurnTowards(caster.Direction);
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				target.StartBuff(BuffId.ShieldPush_DEF_Debuff, skill.Level, 0, DefDownDuration, caster);

				var inflictUnbalance = (target.Rank == MonsterRank.Boss);
				if (inflictUnbalance)
					target.StartBuff(BuffId.ShieldPush_Debuff, skill.Level, 0, UnbalanceDuration, caster);

				var buffRemoveChance = BuffRemoveChancePerLevel * skill.Level;
				target.RemoveRandomBuff(buffRemoveChance);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
