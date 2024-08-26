using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Cataphract
{
	/// <summary>
	/// Handler for the Cataphract skill Rush.
	/// </summary>
	[SkillHandler(SkillId.Cataphract_Rush)]
	public class Cataphract_Rush : IGroundSkillHandler, IDynamicCasted
	{
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			caster.StartBuff(BuffId.Warrior_RushMove_Buff, 1, 0, TimeSpan.Zero, caster);
			caster.StartBuff(BuffId.Warrior_EnableMovingShot_Buff, 2, 0, TimeSpan.Zero, caster);
			
			// This has to be sent here to set the MovingShotable Property
			// which isn't applied until after the character has the buff
			if (caster is Character character)
			{
				Send.ZC_OBJECT_PROPERTY(character);
				Send.ZC_MOVE_SPEED(character);				
			}			

			Send.ZC_PLAY_SOUND(caster, "voice_war_atk_long_cast");
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			caster.StopBuff(BuffId.Warrior_RushMove_Buff);
			caster.StopBuff(BuffId.Warrior_EnableMovingShot_Buff);

			if (caster is Character character)
			{
				Send.ZC_OBJECT_PROPERTY(character);
				Send.ZC_MOVE_SPEED(character);
			}

			Send.ZC_STOP_SOUND(caster, "voice_war_atk_long_cast");
		}


		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			CallSafe(this.Attack(skill, caster));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private async Task Attack(Skill skill, ICombatEntity caster)
		{
			var hits = new List<SkillHitInfo>();
			var hitDelay = TimeSpan.FromMilliseconds(30);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var totalHits = 10;
			var attackWidth = 40f;
			var delayBetweenRepeats = TimeSpan.FromMilliseconds(270);

			for (var i = 0; i < totalHits; ++i)
			{
				await Task.Delay(hitDelay);

				if (!caster.TrySpendSp(10 + skill.Level))
				{
					caster.ServerMessage(Localization.Get("Not enough SP."));
					Send.ZC_SKILL_CAST_CANCEL(caster);
					return;
				}

				if (caster.IsAbilityActive(AbilityId.Cataphract34))
				{
					// TODO: this art changes this move into a kind of vaccuum effect
				}

				var bonusMultiplier = 0f;
				if (caster.TryGetSkill(SkillId.Cataphract_AcrobaticMount, out var acrobaticMount))
				{
					bonusMultiplier = 0.5f + acrobaticMount.Level * 0.06f;
				}

				var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 0, width: attackWidth, angle: 0);
				var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var modifier = SkillModifier.Default;
					modifier.Unblockable = true;
					modifier.DamageMultiplier += bonusMultiplier;

					// double crit rate if they have fear
					if (target.IsBuffActive(BuffId.Common_Fear))
					{
						modifier.BonusCritChance = caster.Properties.GetFloat(PropertyName.CRTHR);
					}

					if (caster.TryGetActiveAbilityLevel(AbilityId.Cataphract1, out var level))
					{
						var stunChance = level * 5f;
						if (RandomProvider.Get().Next(100) < stunChance)
						{
							target.StartBuff(BuffId.Stun, TimeSpan.FromSeconds(2));
						}
					}					

					var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;

					hits.Add(skillHit);
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);

				if (i < totalHits - 1)
					await Task.Delay(delayBetweenRepeats);

				hits.Clear();

				if (!caster.IsCasting())
					break;
			}

			Send.ZC_SKILL_DISABLE(caster as Character);
		}
	}
}
