//--- Melia Script ----------------------------------------------------------
// Topes Fortress 2F
//--- Description -----------------------------------------------------------
// NPCs found in and around Topes Fortress 2F.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DCastle672NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153130, "", "d_castle_67_2", -741.084, 95.06264, 125.5274, 0, "d_castle_67_2_elt", 3, 2);
		AddTrackNPC(153130, "", "d_castle_67_2", -865.5137, 93.15315, -926.0688, 16, "d_castle_67_2_elt2", 3, 2);
	}
}
