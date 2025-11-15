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
		AddTrackNPC(154081, "", "d_firetower_69_1", -1674.647, -875.7016, -1202.516, 1, "d_firetower_69_1_elt", 2, 1);
		AddTrackNPC(154081, "", "d_firetower_69_1", -1535.553, -878.40466, -1129.915, 1, "d_firetower_69_1_elt", 3, 1);
		AddTrackNPC(154083, "", "d_firetower_69_1", -1689.049, -873.08508, -965.8168, 1, "d_firetower_69_1_elt", 4, 1);
		AddTrackNPC(154083, "", "d_firetower_69_1", -1553.533, -880.21301, -910.1417, 182, "d_firetower_69_1_elt", 5, 1);
	}
}
