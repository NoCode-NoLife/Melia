using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Pads.Handlers.Archer.Wugushi
{
	/// <summary>
	/// Handler for the Arditi_TreGranata pad, creates and disables the effect
	/// </summary>
	[PadHandler(PadName.Archer_Zhendu)]
	public class Archer_Zhendu : ICreatePadHandler, IDestroyPadHandler
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Archer_Zhendu, 0.6774842f, 0.4766329f, 150, true);
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Archer_Zhendu, 0.6774842f, 0.4766329f, 150, false);
		}
	}
}
