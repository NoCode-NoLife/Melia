//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Crystal Mine 1F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_cmine_01WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Crystal Mine 1F to Miners' Village
		AddWarp("WS_ACT4_1_ACT3", -76, From("d_cmine_01", -1294, -1710), To("f_siauliai_out", -162, 31));

		// Crystal Mine 1F to Crystal Mine 2F
		AddWarp("WS_ACT4_1_ACT4_2", 241, From("d_cmine_01", -1412, 679), To("d_cmine_02", -2365, -808));
	}
}
