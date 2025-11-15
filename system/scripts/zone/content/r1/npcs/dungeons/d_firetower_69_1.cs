//--- Melia Script ----------------------------------------------------------
// Zima Suecourt
//--- Description -----------------------------------------------------------
// NPCs found in and around Zima Suecourt.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower691NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(154081, "", "d_firetower_69_1", -1674.647, 0, -1202.516, 3.571429, "d_firetower_69_1_elt");
		AddTrackNPC(154081, "", "d_firetower_69_1", -1535.553, 0, -1129.915, 0, "d_firetower_69_1_elt");
		AddTrackNPC(154083, "", "d_firetower_69_1", -1689.049, 0, -965.8168, 0, "d_firetower_69_1_elt");
		AddTrackNPC(154083, "", "d_firetower_69_1", -1553.533, 0, -910.1417, 0, "d_firetower_69_1_elt");
	}
}
