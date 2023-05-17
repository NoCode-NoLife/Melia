//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Grynas Trails
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_45_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Grynas Trails to Gele Plateau
		AddWarp("KATYN45_1_GELE57_2", 270, From("f_katyn_45_1", -2572.086, -494.3665), To("f_gele_57_2", 1478, -380));

		// Grynas Trails to Thaumas Trail
		AddWarp("KATYN45_1_PILGRIM41_1", 180, From("f_katyn_45_1", -912, 1047), To("f_pilgrimroad_41_1", 1291, 19));

		// Grynas Trails to Grynas Training Camp
		AddWarp("KATYN45_1_KATYN45_2", 92, From("f_katyn_45_1", 1626.654, 606.5546), To("f_katyn_45_2", -1141, 1684));

		// Grynas Trails to Sekta Forest
		AddWarp("KATYN45_1_PILGRIM41_4", 178, From("f_katyn_45_1", 950.7331, 1053.388), To("f_pilgrimroad_41_4", 1852, -1244));
	}
}
