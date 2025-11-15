//--- Melia Script ----------------------------------------------------------
// Nheto Forest
//--- Description -----------------------------------------------------------
// NPCs found in and around Nheto Forest.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple251NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157034, "", "f_maple_25_1", -953.6499, -38.68602, 177.3624, 342, "f_maple_25_1_elt", 2, 1);
	}
}
