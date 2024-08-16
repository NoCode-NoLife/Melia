//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Rinksmas Ruins
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_desolated_capital_53_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Rinksmas Ruins to Skalda Outskirts
		AddWarp("WARP_DCAPITAL53_1_TO_CASTLE102", 90, From("f_desolated_capital_53_1", 3608.171, 1241.829), To("f_castle_102", -3056, 266));

		// Rinksmas Ruins to Path of Desition
		AddWarp("WARP_DCAPITAL53_1_TO_DCAPITAL104", 90, From("f_desolated_capital_53_1", 3178.219, 3389.617), To("f_dcapital_104", 1722, -2048));
	}
}
