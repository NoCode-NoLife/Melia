﻿using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using System.Threading.Tasks;

namespace Melia.Zone.Skills.Handlers.Scout
{
	/// <summary>
	/// Handler for the Scout skill Dagger Slash.
	/// </summary>
	[SkillHandler(SkillId.Scout_DaggerSlash)]
	public class DaggerSlash : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, do a slash attack to the nearby enemies.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="designatedTarget"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(designatedTarget);
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			// Get splash area
			var splashAreaHeight = 40;
			var splashAreaWidth = 25;

			// We'll ignore the data sent by the client and get the positions ourselves
			originPos = caster.Position;
			farPos = originPos.GetRelative(caster.Direction, splashAreaHeight);

			var splashArea = new Square(originPos, caster.Direction, splashAreaHeight, splashAreaWidth);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);

			this.Attack(skill, caster, splashArea, farPos);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea, Position farPos)
		{
			var hits = new List<SkillHitInfo>();

			//HardCoded Values - @TODO: Make it dynamic
			var AoeAttackRatio = 6;

			var damageDelay = TimeSpan.Zero;
			var secondHitTime = TimeSpan.FromMilliseconds(100);
			var damageSecondDelay = TimeSpan.FromMilliseconds(100);
			var skillHitDelay = TimeSpan.Zero;

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			if (targets.Count > AoeAttackRatio)
			{
				targets = targets.GetRange(0, AoeAttackRatio);
			}

			foreach (var target in targets)
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				var damage = skillHitResult.Damage / 2;

				target.TakeDamage(damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, hits);

			await Task.Delay(secondHitTime);

			hits.Clear();

			foreach (var target in targets)
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				var damage = skillHitResult.Damage / 2;

				target.TakeDamage(damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageSecondDelay, skillHitDelay);
				hits.Add(skillHit);

				target.Components.Get<BuffComponent>().Start(BuffId.DaggerSlash_Buff, skill.Level, 0, TimeSpan.FromSeconds(2), target);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}