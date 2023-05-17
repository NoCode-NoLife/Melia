//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Nheto Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_maple_25_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Nheto Forest to Inner Wall District 8
		AddWarp("MAPLE_25_1_TO_CASTLE_20_3", 90, From("f_maple_25_1", 1582.666, 943.1121), To("f_castle_20_3", -1602, -526));

		// Nheto Forest to Svalphinghas Forest
		AddWarp("MAPLE_25_1_TO_MAPLE_25_2", 266, From("f_maple_25_1", -2235.306, 744.4931), To("f_maple_25_2", 1239, 1037));
	}
}
