//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Northern Parias Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_maple_24_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Northern Parias Forest to Central Parias Forest
		AddWarp("F_MAPLE_243_TO_F_MAPLE_241", 26, From("f_maple_24_3", -1723.223, -1497.027), To("f_maple_24_1", 1584, 1369));

		// Northern Parias Forest to Pystis Forest
		AddWarp("F_MAPLE_243_TO_MAPLE23_2", -83, From("f_maple_24_3", -1443.086, 1226.063), To("f_maple_23_2", -1051, -1591));

		// Northern Parias Forest to Lhadar Forest
		AddWarp("F_MAPLE_243_TO_MAPLE25_3", 86, From("f_maple_24_3", 1004.863, 12.73128), To("f_maple_25_3", 1634, 36));
	}
}
