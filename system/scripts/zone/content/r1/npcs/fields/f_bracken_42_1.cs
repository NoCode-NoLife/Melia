//--- Melia Script ----------------------------------------------------------
// Khonot Forest
//--- Description -----------------------------------------------------------
// NPCs found in and around Khonot Forest.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken421NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157042, "", "f_bracken_42_1", 782.5125, 558.6927, -747.0397, 0, "f_bracken_42_1_elt", 2, 1);
		AddTrackNPC(157043, "", "f_bracken_42_1", 1067.31, 557.06, -425.56, 0, "f_bracken_42_1_elt2", 2, 1);
	}
}
