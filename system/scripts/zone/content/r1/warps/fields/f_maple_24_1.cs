//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Central Parias Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_maple_24_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Central Parias Forest to Syla Forest
		AddWarp("F_MAPLE_241_TO_WHITETREES23_3", -17, From("f_maple_24_1", -1509.651, 584.4486), To("f_whitetrees_23_3", -1831, -429));

		// Central Parias Forest to Northern Parias Forest
		AddWarp("F_MAPLE_241_TO_F_MAPLE_243", 126, From("f_maple_24_1", 1663.549, 1391.811), To("f_maple_24_3", -1775, -1427));

		// Central Parias Forest to Southern Parias Forest
		AddWarp("F_MAPLE_241_TO_F_MAPLE_242", 67, From("f_maple_24_1", 1824.936, -230.344), To("f_maple_24_2", 1412, 1202));
	}
}
