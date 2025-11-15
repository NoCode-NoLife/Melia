//--- Melia Script ----------------------------------------------------------
// Topes Fortress 1F
//--- Description -----------------------------------------------------------
// NPCs found in and around Topes Fortress 1F.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DCastle671NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153129, "", "d_castle_67_1", 183.9423, 277.7617, 330.8154, 0, "d_castle_67_1_elt");
	}
}
