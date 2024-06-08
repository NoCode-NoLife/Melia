using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Zone.World.Actors.Characters;
using Org.BouncyCastle.Asn1.X509;
using g3;

namespace Melia.Zone.Skills.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handler for the Swordsman skill Bash.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_RimBlow)]
	public class Bash : IGroundSkillHandler
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

			skill.IncreaseOverheat();
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 55, width: 25, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(50);
			var damageDelay = TimeSpan.FromMilliseconds(330);
			var skillHitDelay = TimeSpan.Zero;
			var delayBetweenHits = TimeSpan.FromMilliseconds(100);

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			float bonusPatk = 0;
			if (caster.IsBuffActive(BuffId.HighGuard_Abil_Buff) && caster is Character character)
			{
				// adds bonus Patk based on shield physical defense
				var buff = caster.Components.Get<BuffComponent>().Get(BuffId.HighGuard_Abil_Buff);
				var shield = character.Inventory.GetItem(EquipSlot.LeftHand).Data;
				bonusPatk = buff.NumArg1 * 0.06f * shield.Def;
			}

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = new SkillModifier();

				modifier.BonusPAtk = bonusPatk;

				// This skill always hits 4 times
				modifier.HitCount = 4;

				if (target.IsBuffActive(BuffId.SwashBuckling_Debuff))
				{
					// takes 10% more damage if under the effect of Swashbuckling from the caster
					var buff = target.Components.Get<BuffComponent>().Get(BuffId.SwashBuckling_Debuff);
					if (buff.Caster == caster)
						modifier.DamageMultiplier += 0.1f;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
				skillHit.HitInfo.Type = HitType.KnockBack;

				// Have to manually calculate knockback because the current formula doesn't take into account hitcount
				for (int i = 0; i < skillHit.HitCount; i++)
					target.Position = target.Position.GetRelative(skillHit.KnockBackInfo.Direction, 22f);

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
