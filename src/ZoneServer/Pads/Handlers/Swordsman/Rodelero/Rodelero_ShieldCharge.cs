using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;

namespace Melia.Zone.Pads.Handlers.Scout.Rodelero
{
	/// <summary>
	/// Handler for the Rodelero_ShieldCharge pad, creates and disables the effect
	/// </summary>
	[PadHandler(PadName.Rodelero_ShieldCharge)]
	public class Rodelero_ShieldCharge : ICreatePadHandler, IDestroyPadHandler, IUpdatePadHandler
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, "Rodelero_ShieldCharge", 0, 0, 150, true);
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, "Rodelero_ShieldCharge", 0, 0, 150, false);
		}

		/// <summary>
		/// Called in regular intervals while the pad is on a map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Updated(object sender, PadTriggerArgs args)
		{
			if (!args.Creator.IsBuffActive(BuffId.ShieldCharge_Buff))
			{
				args.Trigger.Destroy();
				return;
			}
			var dest = args.Creator.Position;
			args.Trigger.Position = dest;
		}
	}
}
