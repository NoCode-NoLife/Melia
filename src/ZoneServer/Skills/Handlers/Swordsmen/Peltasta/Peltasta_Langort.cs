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
using Melia.Zone.Skills.Handlers.Swordsmen.Peltasta;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Hoplite
{
	/// <summary>
	/// Handler for the Hoplite Skill Synchro Thrusting.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_Langort)]
	public class Peltasta_Langort : IGroundSkillHandler
	{
		private readonly static TimeSpan BlockDuration = TimeSpan.FromMilliseconds(750);
		private readonly static TimeSpan DebuffDuration = TimeSpan.FromSeconds(10);

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 70, width: 20, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			if (caster.Components.TryGet<InventoryComponent>(out var inv))
			{
				var lhItem = inv.GetItem(EquipSlot.LeftHand);
				if (lhItem.Data.EquipType1 == EquipType.Shield)
					caster.StartBuff(BuffId.Langort_BlkAbil, BlockDuration);
			}

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
			var hitDelay = TimeSpan.FromMilliseconds(250);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var delayBetweenHits = TimeSpan.FromMilliseconds(100);

			await Task.Delay(hitDelay);

			var hits = new List<SkillHitInfo>();

			for (var i = 0; i < 4; i++)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var modifier = SkillModifier.Default;
					modifier.BonusPAtk = Peltasta38.GetBonusPAtk(caster);

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
					skillHit.HitEffect = HitEffect.Impact;
					hits.Add(skillHit);

					if (i == 3)
					{
						// The description says it inflicts this, but no duration
						// is given and it's not in skill bytool so it may not
						target.StartBuff(BuffId.Silence_Debuff, skill.Level, 0, DebuffDuration, caster);
					}
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);
				hits.Clear();

				if (i < 3)
					await Task.Delay(delayBetweenHits);
			}
		}
	}
}
