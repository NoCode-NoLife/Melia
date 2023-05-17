//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Crystal Mine Lot 2 - 2F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_cmine_9WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Crystal Mine Lot 2 - 2F to Crystal Mine Lot 2 - 1F
		AddWarp("WS_CMINE9_CMINE8", -78, From("d_cmine_9", -1959.291, 249.3477), To("d_cmine_8", 960, 1310));
	}
}
