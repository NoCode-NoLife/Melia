using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handles the Bullet Maker's skill Napalm Bullet.
	/// </summary>
	[SkillHandler(SkillId.Bulletmarker_NapalmBullet)]
	public class Bulletmarker_NapalmBullet : ITargetSkillHandler
	{
		/// <summary>
		/// Handles the skill, shoot with the pistol at the enemy and hit others on the way.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			if (!caster.IsBuffActive(BuffId.DoubleGunStance_Buff))
				return;

			skill.IncreaseOverheat();
			caster.TurnTowards(target);
			caster.SetAttackState(true);

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!caster.InSkillUseRange(skill, target))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			Send.ZC_SKILL_READY(caster, skill, caster.Position, target.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, Position.Zero);

			// Increase by one the stack count for Overheating buff
			if (!caster.IsBuffActive(BuffId.Outrage_Buff))
				caster.StartBuff(BuffId.Overheating_Buff, TimeSpan.FromSeconds(35));
			
			var skillHits = new List<SkillHitInfo>();
			this.AddSkillHitInfo(caster, target, skill, skillHits);

			var splashArea = new Square(caster.Position, caster.Direction, 130, 45);

			var otherTargets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var otherTarget in otherTargets.LimitBySDR(caster, skill))
			{
				if (otherTarget.Handle == target.Handle)
					continue;

				this.AddSkillHitInfo(caster, otherTarget, skill, skillHits);
			}
		
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHits);

			if (caster.TryGetBuff(BuffId.Outrage_Buff, out var outrageBuff))
			{
				if (outrageBuff.OverbuffCounter > 0)
				{
					foreach (var otherTarget in otherTargets.LimitBySDR(caster, skill))
					{
						var skillHitResult = SCR_SkillHit(caster, otherTarget, skill);
						otherTarget.TakeDamage(skillHitResult.Damage, caster);
						var hit = new HitInfo(caster, otherTarget, skill, skillHitResult.Damage, skillHitResult.Result);
						Send.ZC_HIT_INFO(caster, otherTarget, hit);
						otherTarget.StartBuff(BuffId.Tase_Debuff, TimeSpan.FromSeconds(10));						
					}

					caster.Components.Get<BuffComponent>().Overbuff(outrageBuff, -1);
				}					
			}
		}

		/// <summary>
		/// Adds a new HitInfo to the processing list
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="skillHits"></param>
		private void AddSkillHitInfo(ICombatEntity caster, ICombatEntity target, Skill skill, List<SkillHitInfo> skillHits)
		{			
			var damageDelay = TimeSpan.FromMilliseconds(200);
			var skillHitDelay = TimeSpan.FromMilliseconds(300);
			var modifier = SkillModifier.Default;
			modifier.HitCount = 2;

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHits.Add(skillHit);
		}
	}
}
