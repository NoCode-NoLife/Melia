//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Klaipeda
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class c_KlaipeWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Klaipeda to West Siauliai Woods
		AddWarp("WS_KLAPEDA_SIAULST1", -10, From("c_Klaipe", -201, -1182), To("f_siauliai_west", 1630, -733));

		// Klaipeda to East Siauliai Woods
		AddWarp("WS_KLAPEDA_SIAULST2", 135, From("c_Klaipe", 799, 331), To("f_siauliai_2", -2414, -1150));

		// Klaipeda to Bokor Master's Home
		AddWarp("WS_KLAPEDA_BOCORS", 225, From("c_Klaipe", -976, -502), To("c_voodoo", 24, -80));

		// Klaipeda to Highlander Master's Training Hall
		AddWarp("WS_KLAPEDA_HIGHLANDER", 225, From("c_Klaipe", 223, -95), To("c_highlander", 4, 173));

		// Klaipeda to Pyromancer Master's Lab
		AddWarp("WS_KLAPEDA_FIREMAGE", 200, From("c_Klaipe", -2, -290), To("c_firemage", 195, 5));

		// Klaipeda to Gytis Settlement Area
		AddWarp("KLAPEDA_TO_SIAUL50_1", 154, From("c_Klaipe", 240.6537, 895.663), To("f_siauliai_50_1", 1565, -1468));
	}
}
