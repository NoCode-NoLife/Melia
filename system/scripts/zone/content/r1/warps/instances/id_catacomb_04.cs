//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Underground Grave of Ritinis
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class id_catacomb_04WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Underground Grave of Ritinis to Mokusul Chamber
		AddWarp("CATACOMB_04_CATACOMB_38_2", 90, From("id_catacomb_04", -332.5004, -1978.717), To("id_catacomb_38_2", -1620, -1495));

		// Underground Grave of Ritinis to Videntis Shrine
		AddWarp("CATACOMB_04_CATACOMB_38_1", 180, From("id_catacomb_04", 2267.073, 1353.261), To("id_catacomb_38_1", -1976, -920));

		// Underground Grave of Ritinis to Istora Ruins
		AddWarp("CATACOMB_04_REMAINS37_3", 235, From("id_catacomb_04", -2243.331, -429.943), To("f_remains_37_3", -3516, 1627));
	}
}
