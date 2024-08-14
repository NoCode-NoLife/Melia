//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Skalda Outskirts
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_102WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Skalda Outskirts to Rinksmas Ruins
		AddWarp("WARP_CASTLE102_TO_DCAPITAL53_1", 260, From("f_castle_102", -3141.893, 277.3966), To("f_desolated_capital_53_1", 3536, 1240));

		// Skalda Outskirts to Tvirtumas Fortress
		AddWarp("WARP_CASTLE102_TO_CASTLE99", 0, From("f_castle_102", -1473.447, -1715.916), To("f_castle_99", 2266, 1119));
	}
}
