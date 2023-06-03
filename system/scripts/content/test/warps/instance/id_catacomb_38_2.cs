//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Mokusul Chamber
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class id_catacomb_38_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Mokusul Chamber to Laukyme Swamp
		AddWarp("CATACOMB_38_2_THORN_39_3", 0, From("id_catacomb_38_2", 1229.425, -1377.15), To("d_thorn_39_3", 311, -1027));

		// Mokusul Chamber to Underground Grave of Ritinis
		AddWarp("CATACOMB_38_2_CATACOMB_04", 270, From("id_catacomb_38_2", -1723.054, -1487.192), To("id_catacomb_04", -428, -2010));

		// Mokusul Chamber to Videntis Shrine
		AddWarp("CATACOMB_38_2_CATACOMB_38_1", 180, From("id_catacomb_38_2", -12.98169, 2080.463), To("id_catacomb_38_1", 1883, 59));
	}
}
