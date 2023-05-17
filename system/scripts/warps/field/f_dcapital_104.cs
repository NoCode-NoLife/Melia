//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Path of Desition
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_dcapital_104WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Path of Desition to Rinksmas Ruins
		AddWarp("WARP_DCAPITAL104_TO_DCAPITAL53_1", 80, From("f_dcapital_104", 1795.006, -2063.198), To("f_desolated_capital_53_1", 3115, 3393));

		// Path of Desition to Sacred Atspalvis 
		AddWarp("WARP_DCAPITAL104_TO_F_DCAPITAL_101", 17, From("f_dcapital_104", 742.0436, 1998.778), To("f_castle_101", 324, -1686));
	}
}
