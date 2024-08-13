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
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Highlander
{
	/// <summary>
	/// Handler for the Doppelsoldner skill Cyclone.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_Cyclone)]
	public class Doppelsoeldner_Cyclone : IGroundSkillHandler, IDynamicCasted
	{
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			caster.StartBuff(BuffId.Cyclone_EnableMovingShot_Buff, 1, 0, TimeSpan.Zero, caster);

			// This has to be sent here to set the MovingShotable Property
			// which isn't applied until after the character has the buff
			if (caster is Character character)
			{
				Send.ZC_OBJECT_PROPERTY(character);
				Send.ZC_MOVE_SPEED(character);
			}

			if (caster.TryGetActiveAbilityLevel(AbilityId.Doppelsoeldner17, out var level))
				caster.StartBuff(BuffId.Cyclone_Buff_ImmuneAbil, level, 0, TimeSpan.Zero, caster);
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			caster.StopBuff(BuffId.Cyclone_EnableMovingShot_Buff);
			caster.StopBuff(BuffId.Cyclone_Buff_ImmuneAbil);

			if (caster is Character character)
			{
				Send.ZC_OBJECT_PROPERTY(character);
				Send.ZC_MOVE_SPEED(character);
			}
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
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			this.Attack(skill, caster);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private async void Attack(Skill skill, ICombatEntity caster)
		{
			var hits = new List<SkillHitInfo>();
			var hitDelay = TimeSpan.FromMilliseconds(30);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var totalHits = 17;
			var attackWidth = 50f;
			var delayBetweenRepeats = TimeSpan.FromMilliseconds(200);

			// Doppelsoeldner35 makes a bigger but slower attack
			if (caster.IsAbilityActive(AbilityId.Doppelsoeldner35))
			{
				totalHits = 10;
				attackWidth = 75f;
				delayBetweenRepeats = TimeSpan.FromMilliseconds(330);
			}

			for (var i = 0; i < totalHits; ++i)
			{
				await Task.Delay(hitDelay);

				var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 0, width: attackWidth, angle: 0);
				var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
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
