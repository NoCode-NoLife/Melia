//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Alemeth Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_orchard_34_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Alemeth Forest to Fasika Plateau
		AddWarp("ORCHARD_34_1_TO_PILGRIM_36_2", 61, From("f_orchard_34_1", 1160.276, -1071.142), To("f_pilgrimroad_36_2", -1543, 1282));

		// Alemeth Forest to Forest of Prayer
		AddWarp("ORCHARD34_1_PILGRIM51", 182, From("f_orchard_34_1", -478.7312, 1532.682), To("f_pilgrimroad_51", 1932, -1920));

		// Alemeth Forest to Barha Forest
		AddWarp("ORCHARD34_1_ORCHARD34_3", 90, From("f_orchard_34_1", 1067.457, 268.8473), To("f_orchard_34_3", -1519, 521));
	}
}
