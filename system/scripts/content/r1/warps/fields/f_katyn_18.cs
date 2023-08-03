//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Kule Peak
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_18WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Kule Peak to Svalphinghas Forest
		AddWarp("WS_KATYN18_TO_MAPLE25_2", 90, From("f_katyn_18", 3248, -1961), To("f_maple_25_2", -706, -881));

		// Kule Peak to Emmet Forest
		AddWarp("WS_KATYN18_TO_WHITETREES23_1", -72, From("f_katyn_18", -1322.259, -2179.218), To("f_whitetrees_23_1", 1601, 1313));
	}
}
