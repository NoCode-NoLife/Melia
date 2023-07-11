using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Shared.Data.Database;
using System.Threading;
using System.Collections.Generic;

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

			var character = caster as Character;
			var removeList = new List<Mob>();

			foreach (var trap in character.PlacedTraps)
			{
				Send.ZC_DEAD(trap, trap.Position);
				caster.Map.RemoveMonster(trap);
				if (character.PlacedTraps.Contains(trap))
				{
					removeList.Add(trap);
				}
				this.Explosion(caster, skill, trap.Position);
			}

			foreach (var mob in removeList)
			{
				if (character.PlacedTraps.Contains(mob))
				{
					character.PlacedTraps.Remove(mob);
				}				
			}
		}

		private void Explosion(ICombatEntity caster, Skill skill, Position position)
		{
			var splashArea = new Circle(position, 25);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			Debug.ShowShape(caster.Map, splashArea);

			foreach (var target in targets.LimitRandom(5))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var hit = new HitInfo(caster, target, skill, skillHitResult);

				Send.ZC_HIT_INFO(caster, target, skill, hit);
			}
		}
	}
}
