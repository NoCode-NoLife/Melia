//--- Melia Script ----------------------------------------------------------
// Outer Wall District 9
//--- Description -----------------------------------------------------------
// NPCs found in and around Outer Wall District 9.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle201NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157027, "", "f_castle_20_1", 405.7464, 150.6457, -274.809, 0, "f_castle_20_1_elt");
		AddTrackNPC(157028, "", "f_castle_20_1", -576.8862, 237.7089, -320.7311, 0, "f_castle_20_1_elt2");
	}
}
