//--- Melia Script ----------------------------------------------------------
// Inner Wall District 8
//--- Description -----------------------------------------------------------
// NPCs found in and around Inner Wall District 8.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle203NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157030, "", "f_castle_20_3", 467.1729, 139.2464, -586.9828, 0, "f_castle_20_3_elt");
	}
}
