//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Miners' Village
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_outWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Miners' Village to East Siauliai Woods
		AddWarp("WS_SIAULST3_SIAULST2", -19, From("f_siauliai_out", 500, -2241), To("f_siauliai_2", 2560, 1058));

		// Miners' Village to Crystal Mine 1F
		AddWarp("WS_ACT3_ACT4_1", -75, From("f_siauliai_out", -213, -17), To("d_cmine_01", -1174, -1628));

		// Miners' Village to Srautas Gorge
		AddWarp("SIALLAIOUT_GELE571", 85, From("f_siauliai_out", 1832, -578), To("f_gele_57_1", -1560, -1131));
	}
}
