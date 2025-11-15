//--- Melia Script ----------------------------------------------------------
// Veja Ravine
//--- Description -----------------------------------------------------------
// NPCs found in and around Veja Ravine.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FHuevillage581NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153008, "", "f_huevillage_58_1", 638.2, 129.74, 468.58, 0, "f_huevillage58_1_cablecar");
	}
}
