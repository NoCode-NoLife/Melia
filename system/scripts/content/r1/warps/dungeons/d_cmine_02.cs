//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Crystal Mine 2F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_cmine_02WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Crystal Mine 2F to Crystal Mine 1F
		AddWarp("WS_ACT4_2_ACT4_1", 250, From("d_cmine_02", -2419.326, -882.054), To("d_cmine_01", -1362, 640));

		// Crystal Mine 2F to Crystal Mine 3F
		AddWarp("WS_ACT4_2_ACT4_3", 167, From("d_cmine_02", 1821, 1924), To("d_cmine_6", -2115, -1685));
	}
}
