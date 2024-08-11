using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Pads.Handlers.Swordsman.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian_Pouncing_Abil pad, creates and disables the effect.
	/// </summary>
	[PadHandler(PadName.Barbarian_Pouncing_Abil)]
	public class Barbarian_Pouncing_Abil : ICreatePadHandler, IDestroyPadHandler, IUpdatePadHandler
	{
		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			Send.ZC_NORMAL.PadUpdate(creator, pad, "Barbarian_Pouncing_Abil", 0, 0, 150, true);
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, "Barbarian_Pouncing_Abil", 0, 0, 150, false);
		}

		/// <summary>
		/// Called in regular intervals while the pad is on a map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Updated(object sender, PadTriggerArgs args)
		{
			if (!args.Creator.IsBuffActive(BuffId.Pouncing_Buff))
			{
				args.Trigger.Destroy();
				return;
			}

			args.Trigger.Position = args.Creator.Position;
			args.Trigger.Direction = args.Creator.Direction;
		}
	}
}
