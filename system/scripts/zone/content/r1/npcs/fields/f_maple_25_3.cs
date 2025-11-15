//--- Melia Script ----------------------------------------------------------
// Lhadar Forest
//--- Description -----------------------------------------------------------
// NPCs found in and around Lhadar Forest.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple253NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157036, "", "f_maple_25_3", -917.34, 36.80652, -444.9715, 0, "f_maple_25_3_elt");
	}
}
