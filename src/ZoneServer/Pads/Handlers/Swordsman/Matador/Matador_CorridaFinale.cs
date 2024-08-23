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
using System.Collections.Generic;

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
			var dest = creator.Position.GetRelative(pad.Variables.GetBool("OpositeDirection") ? creator.Direction : creator.Direction.Backwards, MoveDistance);
			var moveTime = pad.Movement.MoveTo(dest);

			// [Arts] Corrida Finale: Raging Bull
			// Makes the Bull leave an fire effect that damages enemies inside
			if (creator.IsAbilityActive(AbilityId.Matador21))
			{
				if (!creator.TryGetSkill(SkillId.Matador_CorridaFinale, out var skill))
					return;

				// Number of positions to calculate between points
				int numberOfPositions = 14;

				// List to store the new positions
				var stepPositions = new List<Position>();
				var padReferencePos = pad.Position.GetRelative(pad.Variables.GetBool("OpositeDirection") ? creator.Direction : creator.Direction.Backwards, 80);
				var destReferencePos = dest.GetRelative(pad.Variables.GetBool("OpositeDirection") ? creator.Direction.Backwards : creator.Direction, 300);

				// Calculate step size
				var stepX = (destReferencePos.X - padReferencePos.X) / (numberOfPositions + 1);
				var stepY = (destReferencePos.Y - padReferencePos.Y) / (numberOfPositions + 1);
				var stepZ = (destReferencePos.Z - padReferencePos.Z) / (numberOfPositions + 1);

				// Calculate the new positions
				for (int i = 1; i <= numberOfPositions; i++)
				{
					var newX = padReferencePos.X + stepX * i;
					var newY = padReferencePos.Y + stepY * i;
					var newZ = padReferencePos.Z + stepZ * i;

					stepPositions.Add(new Position(newX, newY, newZ));
				}

				await Task.Delay(TimeSpan.FromMilliseconds(550));

				var direction = pad.Variables.GetBool("OpositeDirection") ? creator.Direction : creator.Direction.Backwards;

				// Iterate throught the new positions
				foreach (var position in stepPositions)
				{
					await Task.Delay(TimeSpan.FromMilliseconds(60));
					
					this.SpawnFireFloorPad(skill, creator, position.GetRelative(direction.Left, 18), pad.Variables.GetBool("OpositeDirection"));
					this.SpawnFireFloorPad(skill, creator, position.GetRelative(direction.Right, 18), pad.Variables.GetBool("OpositeDirection"));
				}
			} else
			{
				await Task.Delay(moveTime);
			}
		}

		/// <summary>
		/// Creates a new fire pad on the floor
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="creator"></param>
		/// <param name="position"></param>
		/// <param name="oposite"></param>
		/// <returns></returns>
		private Pad SpawnFireFloorPad(Skill skill, ICombatEntity creator, Position position, bool oposite)
		{
			var pad = new Pad(PadName.Matador_CorridaFinale_Hidden, creator, skill, new Square(creator.Position, creator.Direction, 10, 10));
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(5);
			pad.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
			pad.Position = position;
			pad.Direction = creator.Direction;			
			pad.Variables.SetBool("OpositeDirection", oposite);

			creator.Map.AddPad(pad);

			return pad;
		}
	}
}
