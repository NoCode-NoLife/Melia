//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Svalphinghas Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_maple_25_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Svalphinghas Forest to Nheto Forest
		AddWarp("MAPLE_25_2_TO_MAPLE_25_1", 111, From("f_maple_25_2", 1346.154, 1102.859), To("f_maple_25_1", -2137, 751));

		// Svalphinghas Forest to Mesafasla
		AddWarp("MAPLE_25_2_TO_TALBELAND_28_1", 90, From("f_maple_25_2", 1821.32, -354.89), To("f_tableland_28_1", -850, 1698));

		// Svalphinghas Forest to Kule Peak
		AddWarp("MAPLE_25_2_TO_KATYN_18", -32, From("f_maple_25_2", -783.61, -1004.08), To("f_katyn_18", 3114, -1976));

		// Svalphinghas Forest to Lhadar Forest
		AddWarp("MAPLE_25_2_TO_MAPLE_25_3", -70, From("f_maple_25_2", -1756.323, -432.7503), To("f_maple_25_3", 1645, 641));
	}
}
