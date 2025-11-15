//--- Melia Script ----------------------------------------------------------
// Vera Coast
//--- Description -----------------------------------------------------------
// NPCs found in and around Vera Coast.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral352NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(156034, "", "f_coral_35_2", 401.4194, 224.4277, 717.4001, 0, "f_coral_35_2_elt");
	}
}
