using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Pads.Handlers.Archer.Wugushi
{
	/// <summary>
	/// Handler for the Poison Pot pad, creates and disables the effect
	/// </summary>
	[PadHandler(PadName.Archer_VerminPot)]
	public class Archer_VerminPot : ICreatePadHandler, IDestroyPadHandler
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Archer_VerminPot, -0.2758004f, 70.14826f, 50, true);
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Archer_VerminPot, -0.2758004f, 70.14826f, 50, false);
		}
	}
}
