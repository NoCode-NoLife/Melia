using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Yggdrasil.Logging;

namespace Melia.Zone.Pads.Handlers.Archer.QuarrelShooter
{
	/// <summary>
	/// Handler for the ScatterCaltrop_Pad,
	/// which inflicts damage and status when stepped on
	/// </summary>
	[PadHandler(PadName.ScatterCaltrop_Pad)]
	public class ScatterCaltrop_Pad : ICreatePadHandler, IDestroyPadHandler
	{
		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, PadTriggerArgs args)
		{
			Send.ZC_NORMAL.PadUpdate(args.Creator, args.Trigger, PadName.ScatterCaltrop_Pad, -0.7853982f, 0, 30, true);
		}

		/// <summary>
		/// Called when the pad is destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Destroyed(object sender, PadTriggerArgs args)
		{
			Send.ZC_NORMAL.PadUpdate(args.Creator, args.Trigger, PadName.ScatterCaltrop_Pad, 0, 145.8735f, 30, false);
		}
	}
}
