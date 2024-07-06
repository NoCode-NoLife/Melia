using System;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.SplashAreas;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Sapper
{
	/// <summary>
	/// Handler for the Sapper skill Spike Shooter.
	/// </summary>
	[SkillHandler(SkillId.Sapper_SpikeShooter)]
	public class SpikeShooter : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creates an object on the floor that continues to fire arrows
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

			if (!caster.Position.InRange2D(farPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			this.PlaceObject(skill, caster);
		}

		/// <summary>
		/// Places the trap object on the floor
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private async void PlaceObject(Skill skill, ICombatEntity caster)
		{
			var farPos = caster.Position.GetRelative(caster.Direction, 12);
			var direction = caster.Direction;
			var effectId = ForceId.GetNew();

			var leftPos = farPos.GetRelative(caster.Direction.Left, 16);
			var rightPos = farPos.GetRelative(caster.Direction.Right, 16);

			leftPos = new Position(leftPos.X, leftPos.Y + 15, leftPos.Z);
			rightPos = new Position(rightPos.X, rightPos.Y + 15, rightPos.Z);

			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "Archer_SpikeShooter", skill.Id, farPos, effectId, true);
			Send.ZC_SKILL_READY(caster, skill, farPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);
			Send.ZC_NORMAL.ChainEffect(caster, "SpikeShooter", leftPos, rightPos, effectId, 57710);

			await Task.Delay(TimeSpan.FromMilliseconds(200));

			var cancelationTokenSource = new CancellationTokenSource();
			this.Attack(skill, caster, farPos, direction, effectId, cancelationTokenSource.Token);

			await Task.Delay(TimeSpan.FromSeconds(20));

			cancelationTokenSource.Cancel();
			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "Archer_SpikeShooter", skill.Id, farPos, effectId, false);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="farPos"></param>
		/// <param name="effectId"></param>
		/// <param name="cancellationToken"></param>
		private async void Attack( Skill skill, ICombatEntity caster, Position farPos, Direction direction, int effectId, CancellationToken cancellationToken)
		{
			while(!cancellationToken.IsCancellationRequested)
			{
				var leftPos = farPos.GetRelative(direction.Left, 9);
				var rightPos = farPos.GetRelative(direction.Right, 9);

				leftPos = new Position(leftPos.X, leftPos.Y + 9, leftPos.Z);
				rightPos = new Position(rightPos.X, rightPos.Y + 9, rightPos.Z);

				var leftMovPos = leftPos.GetRelative(direction, 160);
				var rightMovPos = rightPos.GetRelative(direction, 160);

				leftPos = leftPos.GetRelative(direction.Left, 1);
				rightPos = rightPos.GetRelative(direction.Right, 1);

				var squareLeft = new Square(leftPos, direction, 160, 8);
				var squareRight = new Square(rightPos, direction, 160, 8);

				Debug.ShowShape(caster.Map, squareRight, edgePoints: false);

				// Abillity - Spike Shooter: Penetration
				// Fires an arrow that pierces enemies{nl}* Increases cooldown by 5 seconds
				if (caster is Character casterCharacter && casterCharacter.Abilities.IsActive(AbilityId.Sapper51))
				{
					var targets = caster.Map.GetAttackableEntitiesIn(caster, squareLeft);

					foreach (var target in targets)
					{
						var skillHitResult = SCR_SkillHit(caster, target, skill);
						target.TakeDamage(skillHitResult.Damage, caster);

						var hit = new HitInfo(caster, target, skill, skillHitResult);

						Send.ZC_HIT_INFO(caster, target, skill, hit);
					}

					targets = caster.Map.GetAttackableEntitiesIn(caster, squareRight);
					var damageDelay = TimeSpan.FromMilliseconds(45);
					var skillHitDelay = skill.Properties.HitDelay;

					foreach (var target in targets)
					{
						var skillHitResult = SCR_SkillHit(caster, target, skill);
						target.TakeDamage(skillHitResult.Damage, caster);

						var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

						Send.ZC_SKILL_HIT_INFO(target, skillHit);
					}

					Send.ZC_NORMAL.PlayForceEffect(caster, "I_arrow009", ForceId.GetNew(), "FAST", 500, leftPos, leftMovPos);
					Send.ZC_NORMAL.PlayForceEffect(caster, "I_arrow009", ForceId.GetNew(), "FAST", 500, rightPos, rightPos);
				}
				else //Stops on the first hit
				{
					var targets = caster.Map.GetAttackableEntitiesIn(caster, squareLeft);

					var lowestDistanceLeft = int.MaxValue;
					var lowestPosLeft = leftMovPos;
					ICombatEntity targetLeftHit = null;

					foreach (var target in targets)
					{
						var distance = target.Position.Get2DDistance(leftPos);
						if (distance < lowestDistanceLeft)
						{
							targetLeftHit = target;
							lowestPosLeft = target.Position;
							lowestDistanceLeft = (int)distance;
						}
					}

					targets = caster.Map.GetAttackableEntitiesIn(caster, squareRight);

					var lowestDistanceRight = int.MaxValue;
					var lowestPosRight = rightMovPos;
					ICombatEntity targetRightHit = null;

					foreach (var target in targets)
					{
						var distance = target.Position.Get2DDistance(rightPos);
						if (distance < lowestDistanceRight)
						{
							targetRightHit = target;
							lowestPosRight = target.Position;
							lowestDistanceRight = (int)distance;
						}
					}

					if (targetLeftHit != null)
					{
						var skillHitResult = SCR_SkillHit(caster, targetLeftHit, skill);
						targetLeftHit.TakeDamage(skillHitResult.Damage, caster);

						var hit = new HitInfo(caster, targetLeftHit, skill, skillHitResult);

						Send.ZC_HIT_INFO(caster, targetLeftHit, skill, hit);
					}

					if (targetRightHit != null)
					{
						var skillHitResult = SCR_SkillHit(caster, targetRightHit, skill);
						targetRightHit.TakeDamage(skillHitResult.Damage, caster);

						var hit = new HitInfo(caster, targetRightHit, skill, skillHitResult);

						Send.ZC_HIT_INFO(caster, targetRightHit, skill, hit);
					}

					Send.ZC_NORMAL.PlayForceEffect(caster, "I_arrow009", ForceId.GetNew(), "FAST", 500, leftPos, lowestPosLeft);
					Send.ZC_NORMAL.PlayForceEffect(caster, "I_arrow009", ForceId.GetNew(), "FAST", 500, rightPos, lowestPosRight);
				}

				await Task.Delay(TimeSpan.FromSeconds(1));
			}
		}
	}
}
