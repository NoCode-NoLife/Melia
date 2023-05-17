//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Barha Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_orchard_34_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Barha Forest to Alemeth Forest
		AddWarp("ORCHARD34_3_ORCHARD34_1", 270, From("f_orchard_34_3", -1649.754, 523.5295), To("f_orchard_34_1", 938, 280));

		// Barha Forest to Penitence Route
		AddWarp("ORCHARD34_3_PILGRIM55", 200, From("f_orchard_34_3", -639.8013, 1358.713), To("f_pilgrimroad_55", 1685, -634));

		// Barha Forest to Cranto Coast
		AddWarp("ORCHARD34_3_CORAL32_1", 55, From("f_orchard_34_3", 1286.19, -1034.503), To("f_coral_32_1", -172, -1615));

		// Barha Forest to Nahash Forest
		AddWarp("ORCHARD34_3_SIAULIAI_35_1", 35, From("f_orchard_34_3", -226.9505, -1173.142), To("f_siauliai_35_1", 180, 1857));
	}
}
