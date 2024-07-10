using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Extensions;
using Yggdrasil.Logging;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Shared.Data.Database;
using System.Linq;
using Melia.Zone.Buffs;
using System.Reflection.Metadata.Ecma335;

namespace Melia.Zone.Skills.Handlers.Archer
{
	/// <summary>
	/// Handler for the Archer skill Multishot.
	/// </summary>
	[SkillHandler(SkillId.Archer_Fulldraw)]
	public class Fulldraw : ITargetSkillHandler, IDynamicCasted
	{
		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			Send.ZC_PLAY_SOUND(caster, "voice_war_atk_long_cast");
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			Send.ZC_STOP_SOUND(caster, "voice_war_atk_long_cast");
		}

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			var originPos = caster.Position;
			var farPos = target.Position;

			skill.IncreaseOverheat();
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 150, width: 10, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(100);
			var damageDelay = TimeSpan.FromMilliseconds(100);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var skillHits = new List<SkillHitInfo>();

			var hitTargets = targets.LimitBySDR(caster, skill);

			foreach (var target in hitTargets)
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
				skillHit.HitInfo.Type = HitType.KnockBack;
				target.Position = skillHit.KnockBackInfo.ToPosition;

				skillHits.Add(skillHit);				

				var holdDuration = 5 + skill.Level;

				target.StartBuff(BuffId.Hold, skill.Level, 0, TimeSpan.FromSeconds(holdDuration), caster);
			}

			// Apply link if more than 1 target was hit
			if (hitTargets.Count() > 1) 
			{
				var linkDuration = 5 + skill.Level;

				foreach (var target in hitTargets)
				{
					// Can only be part of one link, end any existing links for all members
					if (target.TryGetBuff(BuffId.Link, out var existingLink)) {
						IEnumerable<ICombatEntity> existingTargets = (IEnumerable <ICombatEntity>)existingLink.Vars.Get("Melia.LinkMembers");
						foreach (var existingTarget in existingTargets)
						{
							existingTarget.StopBuff(BuffId.Link);
						}
					}

					var linkBuff = target.StartBuff(BuffId.Link, skill.Level, 0, TimeSpan.FromSeconds(linkDuration), caster);
					linkBuff.Vars.Set("Melia.LinkMembers", targets);
					Send.ZC_NORMAL.PlayTextEffect(target, caster, "SHOW_BUFF_TEXT", (float)BuffId.Link, null);
				}
			}

			Send.ZC_SKILL_HIT_INFO(caster, skillHits);
		}
	}
}
