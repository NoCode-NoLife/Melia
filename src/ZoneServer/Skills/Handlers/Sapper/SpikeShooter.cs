using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.SplashAreas;
using System.Threading;
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

			this.PlaceObject(caster, skill);
		}

		/// <summary>
		/// Places the trap object on the floor
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		private async void PlaceObject(ICombatEntity caster, Skill skill)
		{
			var character = caster as Character;
			var farPos = caster.Position.GetRelative(caster.Direction, 5);
			var direction = caster.Direction;
			var effectId = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect_59(character, "Archer_SpikeShooter", skill.Id, farPos, effectId, true);
			Send.ZC_SKILL_READY(caster, skill, farPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			await Task.Delay(200);

			var cancelationTokenSource = new CancellationTokenSource();
			this.Attack(caster, skill, farPos, direction, effectId, cancelationTokenSource.Token);

			await Task.Delay(TimeSpan.FromSeconds(20));

			cancelationTokenSource.Cancel();
			Send.ZC_NORMAL.GroundEffect_59(character, "Archer_SpikeShooter", skill.Id, farPos, effectId, false);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		/// <param name="effectId"></param>
		private async void Attack(ICombatEntity caster, Skill skill, Position farPos, Direction direction, int effectId, CancellationToken cancellationToken)
		{
			while(!cancellationToken.IsCancellationRequested)
			{
				var leftPos = farPos.GetRelative(direction.Left, 9);
				var rightPos = farPos.GetRelative(direction.Right, 9);

				leftPos = new Position(leftPos.X, leftPos.Y + 9, leftPos.Z);
				rightPos = new Position(rightPos.X, rightPos.Y + 9, rightPos.Z);

				var leftMovPos = leftPos.GetRelative(direction, 180);
				var rightMovPos = rightPos.GetRelative(direction, 180);

				Send.ZC_NORMAL.MoveEffect(caster, "I_arrow009", ForceId.GetNew(), "FAST", 500, leftPos, leftMovPos);
				Send.ZC_NORMAL.MoveEffect(caster, "I_arrow009", ForceId.GetNew(), "FAST", 500, rightPos, rightMovPos);

				await Task.Delay(TimeSpan.FromMilliseconds(500));

				leftPos = leftPos.GetRelative(direction.Left, 1);
				rightPos = rightPos.GetRelative(direction.Right, 1);

				var squareLeft = new Square(leftPos, direction, 180, 5);
				var squareRight = new Square(rightPos, direction, 180, 5);

				//Debug.ShowShape(caster.Map, squareLeft, edgePoints: false);
				Debug.ShowShape(caster.Map, squareRight, edgePoints: false);

				var targets = caster.Map.GetAttackableEntitiesIn(caster, squareLeft);

				foreach (var target in targets)
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult);

					Send.ZC_HIT_INFO(caster, target, skill, hit);
				}

				targets = caster.Map.GetAttackableEntitiesIn(caster, squareRight);

				foreach (var target in targets)
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult);

					Send.ZC_HIT_INFO(caster, target, skill, hit);
				}

				await Task.Delay(TimeSpan.FromMilliseconds(500));
			}
		}
	}
}
