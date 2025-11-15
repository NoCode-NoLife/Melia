//--- Melia Script ----------------------------------------------------------
// Seir Rainforest
//--- Description -----------------------------------------------------------
// NPCs found in and around Seir Rainforest.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FOrchard324NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(156037, "", "f_orchard_32_4", 1402.254, 135.6041, 557.9661, 0, "f_orchard_32_4_wheel");
		AddTrackNPC(156038, "", "f_orchard_32_4", -333.8946, 19.81506, 796.1085, 90, "f_orchard_32_4_elt");
	}
}
