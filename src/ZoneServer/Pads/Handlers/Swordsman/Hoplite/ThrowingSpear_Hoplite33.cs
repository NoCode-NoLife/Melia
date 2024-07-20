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

namespace Melia.Zone.Pads.Handlers.Swordsman.Hoplite
{
	/// <summary>
	/// Handler for the ThrouwingSpear_Hoplite33_Pad,
	/// which displays an explosion effect in a given position
	/// </summary>
	[PadHandler("ThrouwingSpear_Hoplite33_Pad")]
	public class ThrouwingSpear_Hoplite33_Pad : ICreatePadHandler, IUpdatePadHandler, IDestroyPadHandler
	{
		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, TriggerArgs args)
		{
			if (args.Trigger is not Pad pad) return;
			if (pad.Creator is not ICombatEntity creator) return;

			Send.ZC_NORMAL.PadUpdate(creator, pad, "ThrouwingSpear_Hoplite33_Pad", -0.7853982f, 0, 30, true);
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

			var spearMonster = pad.Variables.Get<Mob>("spearMonster");

			Send.ZC_NORMAL.PadUpdate(creator, pad, "ThrouwingSpear_Hoplite33_Pad", 0, 145.8735f, 30, false);
		}


		/// <summary>
		/// Called when the pad is destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Updated(object sender, TriggerArgs args)
		{
			if (args.Trigger is not Pad pad) return;
			if (pad.Creator is not ICombatEntity creator) return;

			pad.Destroy();
		}
	}
}
