﻿using System.Collections.Generic;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;
using System.Linq;
using System;

namespace Melia.Zone.Skills.Handlers.Sapper
{
	/// <summary>
	/// Handler for the Sapper skill Detonate Traps.
	/// </summary>
	[SkillHandler(SkillId.Sapper_DetonateTraps)]
	public class DetonateTraps : IGroundSkillHandler
	{
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			if (!caster.Position.InRange2D(farPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			var removeList = new List<Mob>();

			foreach (var trap in caster.PlacedTraps.FindAll(mob => mob.Id == 300010).ToList())
			{
				caster.Map.RemoveMonster(trap);
				removeList.Add(trap);
				this.Explosion(caster, skill, trap.Position);
			}

			foreach (var mob in removeList)
			{
				if (caster.PlacedTraps.Contains(mob))				
					caster.PlacedTraps.Remove(mob);							
			}
		}

		private void Explosion(ICombatEntity caster, Skill skill, Position position)
		{
			var splashArea = new Circle(position, 45);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var damageDelay = TimeSpan.FromMilliseconds(45);
			var skillHitDelay = skill.Properties.HitDelay;

			foreach (var target in targets.LimitRandom(5))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				Send.ZC_SKILL_HIT_INFO(target, skillHit);
			}
		}
	}
}