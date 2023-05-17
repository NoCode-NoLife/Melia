//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Nahash Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_35_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Nahash Forest to Fasika Plateau
		AddWarp("SIAULIAI_35_1_TO_PILGRIM_36_2", -74, From("f_siauliai_35_1", -1946.602, -299.9609), To("f_pilgrimroad_36_2", 598, 1431));

		// Nahash Forest to Barha Forest
		AddWarp("SIAULIAI_35_1_ORCHARD34_3", 170, From("f_siauliai_35_1", 209.5504, 1970.083), To("f_orchard_34_3", -339, -996));

		// Nahash Forest to Elgos Monastery Annex
		AddWarp("SIAULIAI_35_1_ABBEY_35_3", 5, From("f_siauliai_35_1", 3.234997, -1347.529), To("d_abbey_35_3", 21, 1520));

		// Nahash Forest to Vera Coast
		AddWarp("SIAULIAI_35_1_CORAL35_2", 90, From("f_siauliai_35_1", 1624.786, 358.7577), To("f_coral_35_2", -1314, 1167));
	}
}
