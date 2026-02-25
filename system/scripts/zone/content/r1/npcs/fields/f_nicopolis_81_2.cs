//--- Melia Script ----------------------------------------------------------
// Feline Post Town
//--- Description -----------------------------------------------------------
// NPCs found in and around Feline Post Town.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis812NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153232, "", "f_nicopolis_81_2", 60.4, 2.22, -1645, 0, "f_nicopolis_81_2_elt", 2, 1);
	}
}
