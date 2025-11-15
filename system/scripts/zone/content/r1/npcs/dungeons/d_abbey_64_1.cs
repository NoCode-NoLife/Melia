//--- Melia Script ----------------------------------------------------------
// Novaha Assembly Hall
//--- Description -----------------------------------------------------------
// NPCs found in and around Novaha Assembly Hall.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey641NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153102, "", "d_abbey_64_1", -1017.423, 366.9117, -465.3019, 0, "d_abbey_64_1_elt2", 3, 5);
	}
}
