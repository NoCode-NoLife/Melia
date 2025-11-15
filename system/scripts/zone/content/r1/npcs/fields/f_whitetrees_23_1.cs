//--- Melia Script ----------------------------------------------------------
// Emmet Forest
//--- Description -----------------------------------------------------------
// NPCs found in and around Emmet Forest.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees231NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157041, "", "f_whitetrees_23_1", 527.8957, -140.5882, 190.1657, 43, "f_whitetrees_23_1_elt", 2, 1);
	}
}
