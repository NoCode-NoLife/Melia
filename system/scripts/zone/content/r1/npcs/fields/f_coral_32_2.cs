//--- Melia Script ----------------------------------------------------------
// Igti Coast
//--- Description -----------------------------------------------------------
// NPCs found in and around Igti Coast.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral322NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157003, "", "f_coral_32_2", -641.0241, -36.33413, 1405.18, 21, "f_coral_32_2_elt", 3, 2);
	}
}
