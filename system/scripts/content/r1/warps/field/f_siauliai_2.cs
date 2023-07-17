//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in East Siauliai Woods
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// East Siauliai Woods to Klaipeda
		AddWarp("WS_SIAULST2_KLAPEDA", -77, From("f_siauliai_2", -2463, -1168), To("c_Klaipe", 736, 266));

		// East Siauliai Woods to Miners' Village
		AddWarp("WS_SIAULST2_SIAULST3", 106, From("f_siauliai_2", 2684, 1144), To("f_siauliai_out", 526, -2169));
	}
}
