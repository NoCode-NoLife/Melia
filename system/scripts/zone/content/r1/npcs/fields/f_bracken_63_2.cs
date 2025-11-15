//--- Melia Script ----------------------------------------------------------
// Knidos Jungle
//--- Description -----------------------------------------------------------
// NPCs found in and around Knidos Jungle.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken632NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153112, "", "f_bracken_63_2", -47.54993, 253.4295, -541.7952, 0, "f_bracken_63_2_elt");
	}
}
