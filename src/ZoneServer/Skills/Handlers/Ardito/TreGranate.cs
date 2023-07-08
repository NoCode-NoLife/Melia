using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using g3;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Granata.
	/// </summary>
	[SkillHandler(SkillId.Arditi_TreGranata)]
	public class TreGranate : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
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

			// Ability "Granata: Aim"
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi20))
			{
				// TODO: Implement this
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var character = caster as Character;
			character.Rotate(originPos.GetDirection(farPos));

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, originPos.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			Task.Run(() => this.AreaEffect(skill, caster, originPos, farPos, caster.Position.GetDirection(farPos)));
		}

		private async void AreaEffect(Skill skill, ICombatEntity caster, Position originPos, Position farPos, Direction direction)
		{
			await Task.Delay(100);

			var position1 = farPos;
			var position2 = this.CalculateNextPosition(position1, direction.Sin, direction.Cos, 0, 50f);
			var position3 = this.CalculateNextPosition(position2, direction.Sin, direction.Cos, 0, 50f);
			var position4 = this.CalculateNextPosition(position3, direction.Sin, direction.Cos, 0, 50f);

			Send.ZC_NORMAL.Skill_6(caster as Character, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, position1);
			Send.ZC_NORMAL.Skill_6(caster as Character, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, position2);
			Send.ZC_NORMAL.Skill_6(caster as Character, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, position3);

			Send.ZC_NORMAL.Skill_6(caster as Character, "", 0.75f, "", 2.5f, position1);

			await Task.Delay(400);

			Send.ZC_NORMAL.Skill_59(caster as Character, "Arditi_TreGranata", skill.Id, position1, true);
			Send.ZC_NORMAL.Skill_59(caster as Character, "Arditi_TreGranata", skill.Id, position2, true);
			Send.ZC_NORMAL.Skill_59(caster as Character, "Arditi_TreGranata", skill.Id, position3, true);

			Send.ZC_NORMAL.Skill_59(caster as Character, "Arditi_TreGranata_DamagePad", skill.Id, position1, true);

			this.Attack(skill, caster, originPos, position1, position2, position3, position4);

			await Task.Delay(12000);

			Send.ZC_NORMAL.Skill_59(caster as Character, "Arditi_TreGranata", skill.Id, position1, false);
			Send.ZC_NORMAL.Skill_59(caster as Character, "Arditi_TreGranata", skill.Id, position2, false);
			Send.ZC_NORMAL.Skill_59(caster as Character, "Arditi_TreGranata", skill.Id, position3, false);
		}

		private async void Attack(Skill skill, ICombatEntity caster, Position originPos, Position position1, Position position2, Position position3, Position position4)
		{
			var splashParam1 = skill.GetSplashParameters(caster, position1, position2, length: 50, width: 50, angle: 0);
			var splashArea1 = skill.GetSplashArea(SplashType.Circle, splashParam1);

			var circle = new Circle(position2, 50);
			var circle2 = new Circle(position3, 50);
			var circle3 = new Circle(position4, 50);

			Debug.ShowShape(caster.Map, circle, edgePoints: false);
			Debug.ShowShape(caster.Map, circle2, edgePoints: false);
			Debug.ShowShape(caster.Map, circle3, edgePoints: false);

			while (true)
			{
				await Task.Delay(1000);

				var targets1 = caster.Map.GetAttackableEntitiesIn(caster, splashArea1);
				var targets2 = caster.Map.GetAttackableEntitiesIn(caster, splashArea1);
				var targets3 = caster.Map.GetAttackableEntitiesIn(caster, splashArea1);

				var targets = targets1.Concat(targets2).Concat(targets3).ToList();

				foreach (var target in targets.LimitRandom(10))
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult);

					Send.ZC_HIT_INFO(caster, target, skill, hit);
				}
			}
		}

		public Position CalculateNextPosition(Position currentPosition, float directionSin, float directionCos, float angleInDegrees, float distance)
		{
			// Convert the angle from degrees to radians
			float angleInRadians = angleInDegrees * (float)Math.PI / 180;

			// Calculate the directional components scaled by the distance
			float deltaX = directionCos * distance;
			float deltaY = directionSin * distance;

			// Rotate the directional components based on the angle
			float rotatedX = deltaX * (float)Math.Cos(angleInRadians) - deltaY * (float)Math.Sin(angleInRadians);
			float rotatedY = deltaX * (float)Math.Sin(angleInRadians) + deltaY * (float)Math.Cos(angleInRadians);

			// Calculate the next position
			float nextX = currentPosition.X + rotatedX;
			float nextY = currentPosition.Y + rotatedY;
			float nextZ = currentPosition.Z; // Assuming no change in the Z-axis

			return new Position(nextX, nextY, nextZ);
		}
	}
}
