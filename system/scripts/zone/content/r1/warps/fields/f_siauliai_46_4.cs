//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Dina Bee Farm
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_siauliai_46_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Dina Bee Farm to Uskis Arable Land
		AddWarp("SIAULIAI46_4_SIAULIAI46_2", 91, From("f_siauliai_46_4", 1478, 343), To("f_siauliai_46_2", -1205, 3290));

		// Dina Bee Farm to Septyni Glen
		AddWarp("SIAULIAI46_4_HUEVILLAGE58_4", 360, From("f_siauliai_46_4", 303, -1135), To("f_huevillage_58_4", 477, 817));

		// Dina Bee Farm to Vilna Forest
		AddWarp("SIAULIAI46_4_SIAULIAI46_3", 180, From("f_siauliai_46_4", -282, 1041), To("f_siauliai_46_3", -1508, -1379));

		// Dina Bee Farm to Shaton Farm
		AddWarp("SIAULIAI46_4_FARM492", 270, From("f_siauliai_46_4", -555.3397, -1059.353), To("f_farm_49_2", 1965, 1367));
	}
}
