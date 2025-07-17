using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Melia.Shared.World;
using static Melia.Shared.Util.TaskHelper;

namespace Melia.Zone.Pads.Handlers.Swordsman.Matador
{
	/// <summary>
	/// Handler for the Corrida Finale pad, spawning a model of a monster and move it foward
	/// </summary>
	[PadHandler(PadName.Matador_CorridaFinale)]
	public class Matador_CorridaFinale : ICreatePadHandler, IDestroyPadHandler
	{
		private const float MoveDistance = 400;
		private const float SpeedForward = 175;

		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			pad.Movement.Speed = SpeedForward;
			pad.Trigger.MaxActorCount = 15;

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Matador_CorridaFinale, 0, 250, 70, true);

			CallSafe(this.MoveForward(pad, creator));
		}

		/// <summary>
		/// Called when the pad is destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Destroyed(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Matador_CorridaFinale, 0, 250, 70, false);
		}

		/// <summary>
		/// Moves the pad forward on the oposide creator's direction
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		/// <returns></returns>
		private async Task MoveForward(Pad pad, ICombatEntity creator)
		{
			var oppositeDirection = pad.Variables.GetBool("OppositeDirection");
			var destination = creator.Position.GetRelative(oppositeDirection ? creator.Direction : creator.Direction.Backwards, MoveDistance);
			var moveTime = pad.Movement.MoveTo(destination);

			// If the ART is not activated.
			if (!creator.IsAbilityActive(AbilityId.Matador21))
			{
				await Task.Delay(moveTime);
				return;
			}

			// [Arts] Corrida Finale: Raging Bull
			// Makes the Bull leave an fire effect that damages enemies inside
			if (!creator.TryGetSkill(SkillId.Matador_CorridaFinale, out var skill))
				return;

			// Number of positions to calculate between points
			var numberOfPositions = 14;

			// Reference positions
			var startRef = pad.Position.GetRelative(oppositeDirection ? creator.Direction : creator.Direction.Backwards, 80);
			var endRef = destination.GetRelative(oppositeDirection ? creator.Direction.Backwards : creator.Direction, 300);

			// Calculate step size
			var stepX = (endRef.X - startRef.X) / (numberOfPositions + 1);
			var stepY = (endRef.Y - startRef.Y) / (numberOfPositions + 1);
			var stepZ = (endRef.Z - startRef.Z) / (numberOfPositions + 1);

			var direction = oppositeDirection ? creator.Direction : creator.Direction.Backwards;

			await Task.Delay(TimeSpan.FromMilliseconds(550));

			for (var i = 1; i <= numberOfPositions; i++)
			{
				// Calculate main step position
				var basePos = new Position(
					startRef.X + stepX * i,
					startRef.Y + stepY * i,
					startRef.Z + stepZ * i
				);

				// Calculate Left and Right positions relative to basePos
				var leftPos = basePos.GetRelative(direction.Left, 18);
				var rightPos = basePos.GetRelative(direction.Right, 18);

				await Task.Delay(TimeSpan.FromMilliseconds(60));

				this.SpawnFireFloorPad(skill, creator, leftPos, oppositeDirection);
				this.SpawnFireFloorPad(skill, creator, rightPos, oppositeDirection);
			}
		}

		/// <summary>
		/// Creates a new fire pad on the floor
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="creator"></param>
		/// <param name="position"></param>
		/// <param name="opposite"></param>
		/// <returns></returns>
		private Pad SpawnFireFloorPad(Skill skill, ICombatEntity creator, Position position, bool opposite)
		{
			var pad = new Pad(PadName.Matador_CorridaFinale_Hidden, creator, skill, new Square(creator.Position, creator.Direction, 10, 10));
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(5);
			pad.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
			pad.Position = position;
			pad.Direction = creator.Direction;			
			pad.Variables.SetBool("OppositeDirection", opposite);

			creator.Map.AddPad(pad);

			return pad;
		}
	}
}
