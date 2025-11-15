//--- Melia Script ----------------------------------------------------------
// Novaha Institute
//--- Description -----------------------------------------------------------
// NPCs found in and around Novaha Institute.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey643NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153114, "", "d_abbey_64_3", -1155.956, 411.8994, -1264.598, 90, "d_abbey_64_3_elt", 2, 1);
	}
}
