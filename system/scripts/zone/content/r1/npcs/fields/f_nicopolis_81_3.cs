//--- Melia Script ----------------------------------------------------------
// Spell Tome Town
//--- Description -----------------------------------------------------------
// NPCs found in and around Spell Tome Town.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FNicopolis813NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153233, "", "f_nicopolis_81_3", -372.14, -157.52, -888.32, 1, "f_nicopolis_81_3_elt", 4, 1);
	}
}
