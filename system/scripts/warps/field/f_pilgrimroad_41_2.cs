//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Salvia Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_41_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Salvia Forest to Thaumas Trail
		AddWarp("PILGRIM41_2_PILGRIM41_1", 238, From("f_pilgrimroad_41_2", -1859.174, 597.5132), To("f_pilgrimroad_41_1", 1170, 900));

		// Salvia Forest to Sekta Forest
		AddWarp("PILGRIM41_2_PILGRIM41_4", 5, From("f_pilgrimroad_41_2", 7.247588, -1548.198), To("f_pilgrimroad_41_4", -20, 1190));

		// Salvia Forest to Rasvoy Lake
		AddWarp("PILGRIM41_2_PILGRIM41_3", 90, From("f_pilgrimroad_41_2", 2007.936, -1021.727), To("f_pilgrimroad_41_3", -1422, 696));

		// Salvia Forest to Khonot Forest
		AddWarp("PILGRIM41_2_TO_BRACKEN42_1", 188, From("f_pilgrimroad_41_2", 107.4228, 1605.379), To("f_bracken_42_1", -1016, -626));
	}
}
