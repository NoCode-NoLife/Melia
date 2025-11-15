//--- Melia Script ----------------------------------------------------------
// Tekel Shelter
//--- Description -----------------------------------------------------------
// NPCs found in and around Tekel Shelter.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees222NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153189, "", "f_whitetrees_22_2", 990.0172, 125.708, -499.8661, 0, "f_whitetrees_22_2_elt");
	}
}
