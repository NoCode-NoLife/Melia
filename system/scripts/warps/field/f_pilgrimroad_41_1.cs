//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Thaumas Trail
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_41_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Thaumas Trail to Grynas Trails
		AddWarp("PILGRIM41_1_KATYN45_1", 14, From("f_pilgrimroad_41_1", 1347.195, -117.8764), To("f_katyn_45_1", -930, 910));

		// Thaumas Trail to Nefritas Cliff
		AddWarp("PILGRIM41_1_GELE57_3", 270, From("f_pilgrimroad_41_1", -1203.814, -1055.994), To("f_gele_57_3", 1394, -690));

		// Thaumas Trail to Salvia Forest
		AddWarp("PILGRIM41_1_PILGRIM41_2", 90, From("f_pilgrimroad_41_1", 1291.276, 887.9922), To("f_pilgrimroad_41_2", -1742, 520));
	}
}
