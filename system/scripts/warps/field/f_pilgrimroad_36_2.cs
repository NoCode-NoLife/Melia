//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Fasika Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_36_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Fasika Plateau to Galeed Plateau
		AddWarp("PILGRIM_36_2_TO_ROKAS_36_1", 76, From("f_pilgrimroad_36_2", 1701.768, -604.2138), To("f_rokas_36_1", 49, 1076));

		// Fasika Plateau to Manahas
		AddWarp("PILGRIM_36_2_TO_PILGRIM_48", 4, From("f_pilgrimroad_36_2", -28.12843, -999.9745), To("f_pilgrimroad_48", -481, 1426));

		// Fasika Plateau to Nahash Forest
		AddWarp("PILGRIM_36_2_TO_SIAULIAI_35_1", 187, From("f_pilgrimroad_36_2", 560.5924, 1585.883), To("f_siauliai_35_1", -1842, -237));

		// Fasika Plateau to Alemeth Forest
		AddWarp("PILGRIM_36_2_TO_ORCHARD_34_1", 269, From("f_pilgrimroad_36_2", -1702.741, 1343.997), To("f_orchard_34_1", 1061, -1006));
	}
}
