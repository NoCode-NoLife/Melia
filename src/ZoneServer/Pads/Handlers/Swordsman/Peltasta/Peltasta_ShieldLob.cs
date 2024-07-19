using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;

namespace Melia.Zone.Pads.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handler for the Shield Lob pad, spawning a shield modeled after the
	/// caster's shield, that flies forward and then back, Captain America
	/// style.
	/// </summary>
	[PadHandler("Peltasta_ShieldLob")]
	public class Peltasta_ShieldLob : ICreatePadHandler, IDestroyPadHandler
	{
		private const float ShieldFlyDistance = 100;
		private const float ShieldFlySpeedForward = 150;
		private readonly static TimeSpan HomingTickTime = TimeSpan.FromMilliseconds(250);

		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, TriggerArgs args)
		{
			if (args.Trigger is not Pad pad) return;
			if (pad.Creator is not ICombatEntity creator) return;

			pad.Movement.Speed = ShieldFlySpeedForward;
			pad.Trigger.MaxActorCount = 8;

			//if (creator.Map.IsPvp)
			//	pad.Trigger.ActorMaxCount = 4;

			Send.ZC_NORMAL.PadUpdate(creator, pad, "Peltasta_ShieldLob2", -0.7853982f, 0, 30, true);

			var shieldMonster = new Mob(57001, MonsterType.Friendly);
			shieldMonster.Components.Add(new MovementComponent(shieldMonster));
			shieldMonster.Position = pad.Position;
			shieldMonster.Direction = pad.Direction;
			shieldMonster.AttachEffect("I_light004_violet", 1.5f);
			creator.Map.AddMonster(shieldMonster);

			pad.Variables.Set("shieldMonster", shieldMonster);

			if (creator is Character character)
			{
				var lhItem = character.Inventory.GetItem(EquipSlot.LeftHand).Data;
				Send.ZC_NORMAL.PadSetModel(shieldMonster, "warrior_f_", lhItem.Id);
			}

			Send.ZC_NORMAL.ActorRotate(shieldMonster, 90, 0, 0);
			Send.ZC_NORMAL.SpinObject(shieldMonster);
			Send.ZC_NORMAL.PadSetMonsterAltitude(pad, shieldMonster, 22);

			this.FlyShieldFly(pad, creator);
		}

		/// <summary>
		/// Called when the pad is destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Destroyed(object sender, TriggerArgs args)
		{
			if (args.Trigger is not Pad pad) return;
			if (pad.Creator is not ICombatEntity creator) return;

			var shieldMonster = pad.Variables.Get<Mob>("shieldMonster");

			Send.ZC_NORMAL.PadUpdate(creator, pad, "Peltasta_ShieldLob2", 0, 145.8735f, 30, false);
			creator.Map.RemoveMonster(shieldMonster);
		}

		/// <summary>
		/// Makes shield fly forward, away from the caster, and then back.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		private async void FlyShieldFly(Pad pad, ICombatEntity creator)
		{
			// Forward and back, hovering a moment in between.
			await this.FlyForward(pad, creator);
			await Task.Delay(500);
			await this.FlyBack(pad, creator);

			pad.Destroy();
		}

		/// <summary>
		/// Makes shield fly a certain distance forward, in the direction the
		/// creator is facing.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		/// <returns></returns>
		private async Task FlyForward(Pad pad, ICombatEntity creator)
		{
			var dest = creator.Position.GetRelative(creator.Direction, ShieldFlyDistance);
			var moveTime = pad.Movement.MoveTo(dest);
			await Task.Delay(moveTime);
		}

		/// <summary>
		/// Makes shield fly back to the creator.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		/// <returns></returns>
		private async Task FlyBack(Pad pad, ICombatEntity creator)
		{
			// Try homing in on the creator for a while
			for (var i = 0; i < 20; ++i)
			{
				// Stop if the pad is close enough to get to the creator
				// in one tick
				var moveTimeToCreator = pad.Movement.CalcMoveToTime(creator.Position);
				if (moveTimeToCreator <= HomingTickTime)
					break;

				// Aim past the creator to ensure smooth movement if they're
				// moving away during the wait time
				var dest = pad.Position.GetRelative(creator.Position, 300);
				pad.Movement.MoveTo(dest);

				await Task.Delay(HomingTickTime);
			}

			// Final push to get back to the creator. Aim past the creator
			// if they're moving, to close the gap between them and where
			// the shield will disappear
			var finalDest = creator.Position;
			if (creator.Components.TryGet<MovementComponent>(out var movement) && movement.IsMoving)
				finalDest = creator.Position.GetRelative(creator.Direction, 50);

			var moveTime = pad.Movement.MoveTo(finalDest);
			await Task.Delay(moveTime);
		}
	}
}
