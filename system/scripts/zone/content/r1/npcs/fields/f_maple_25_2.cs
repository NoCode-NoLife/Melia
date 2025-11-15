//--- Melia Script ----------------------------------------------------------
// Tiltas Forest
//--- Description -----------------------------------------------------------
// NPCs found in and around Tiltas Forest.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple252NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157035, "", "f_maple_25_2", -78.02134, 34.58647, 382.6509, 320, "f_maple_25_2_elt", 0);
	}
}
