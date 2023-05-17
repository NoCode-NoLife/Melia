//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Crystal Mine Lot 2 - 1F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_cmine_8WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Crystal Mine Lot 2 - 1F to Crystal Mine 3F
		AddWarp("CMINE_8_CMINE_6", 251, From("d_cmine_8", -2956, -328), To("d_cmine_6", 1611, 1284));

		// Crystal Mine Lot 2 - 1F to Crystal Mine Lot 2 - 2F
		AddWarp("WS_CMINE8_CMINE9", 180, From("d_cmine_8", 972, 1375), To("d_cmine_9", -1870, 288));
	}
}
