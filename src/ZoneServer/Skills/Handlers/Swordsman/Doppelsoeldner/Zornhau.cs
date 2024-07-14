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
using Yggdrasil.Logging;
using Yggdrasil.Util;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Skills.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Handler for the Doppelsoeldner skill Zornhau.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_Zornhau)]
	public class Doppelsoeldner_Zornhau : IGroundSkillHandler
	{
		private const int BuffRemoveChancePerLevel = 5;
		private const int DebuffDuration = 5;

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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 70, width: 30, angle: 0);
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
			var hitDelay = TimeSpan.FromMilliseconds(400);
			var damageDelay = TimeSpan.FromMilliseconds(150);
			var skillHitDelay = TimeSpan.Zero;
			var deedsOfValorBonus = 1.0f;
			
			if (caster.IsBuffActive(BuffId.DeedsOfValor))
			{
				var buff = caster.Components.Get<BuffComponent>().Get(BuffId.DeedsOfValor);
				deedsOfValorBonus = buff.NumArg2;
			}

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = SkillModifier.Default;
				modifier.HitCount = 2;

				// Deeds of Valor specifically influences final damage so we just multiply the damage after calculation

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				skillHitResult.Damage *= deedsOfValorBonus;
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);

				// TODO: On latest the game actually no longer applies this, even though it still lists it in the description.
				// Should probably have some kind of feature to turn this on / off.
				target.StartBuff(BuffId.Common_Shock, skill.Level, 0, TimeSpan.FromSeconds(DebuffDuration), caster);

				// If the caster has ability Doppelsoeldner36, this ability inflicts a second debuff that deals damage over time equal to 20% of the attack's damage
				// (actually 40% of its single-hit damage)
				if (caster.Components.TryGet<AbilityComponent>(out var abilities) && abilities.TryGetActive(AbilityId.Doppelsoeldner36, out var ability))
					target.StartBuff(BuffId.Zornhau_Debuff, skill.Level, skillHitResult.Damage * 0.2f, TimeSpan.FromSeconds(DebuffDuration), caster);

				// Also need to potentially remove a buff from the target
				var buffRemoveChance = BuffRemoveChancePerLevel * skill.Level;
				var rnd = RandomProvider.Get();
				if (rnd.Next(100) < buffRemoveChance)
				{
					if (target.Components.TryGet<BuffComponent>(out var buffComponent))
					{
						buffComponent.RemoveRandomBuff();
					}
				}
			}

			// Must hit at least 1 enemy to continue combo?
			if (targets.Count > 0)
			{
				var duration = TimeSpan.FromSeconds(3);
				caster.StartBuff(BuffId.Zucken_Buff, skill.Level, 0, duration, caster);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}

