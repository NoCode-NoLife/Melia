//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Videntis Shrine
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class id_catacomb_38_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Videntis Shrine to Underground Grave of Ritinis
		AddWarp("CATACOMB_38_1_CATACOMB_04", 270, From("id_catacomb_38_1", -2118.84, -923.8241), To("id_catacomb_04", 2272, 1238));

		// Videntis Shrine to Valius' Eternal Resting Place
		AddWarp("CATACOMB_38_1_CATACOMB_02", 130, From("id_catacomb_38_1", 1796.833, 1596.425), To("id_catacomb_02", -721, -1718));

		// Videntis Shrine to Mokusul Chamber
		AddWarp("CATACOMB_38_1_CATACOMB_38_2", 90, From("id_catacomb_38_1", 2014.392, 49.25851), To("id_catacomb_38_2", -15, 1935));
	}
}
