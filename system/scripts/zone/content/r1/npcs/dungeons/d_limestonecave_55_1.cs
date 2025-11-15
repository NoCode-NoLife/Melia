//--- Melia Script ----------------------------------------------------------
// Alembique Cave
//--- Description -----------------------------------------------------------
// NPCs found in and around Alembique Cave.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave551NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(154099, "", "d_limestonecave_55_1", 1227.525, 151.018, 529.8058, 16, "d_limestonecave_55_1_elt");
	}
}
