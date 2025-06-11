using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Pads.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Sadhu Prakriti Pad, creates and disables the effect
	/// </summary>
	[PadHandler(PadName.Sadhu_Prakriti_Pad)]
	public class Sadhu_Prakriti_Pad : ICreatePadHandler, IDestroyPadHandler
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Sadhu_Prakriti_Pad, 1.570796f, 0, 70, true);
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

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Sadhu_Prakriti_Pad, 1.570796f, 0, 70, false);
		}
	}
}
