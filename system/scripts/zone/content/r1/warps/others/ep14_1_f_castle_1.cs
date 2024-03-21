//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Delmore Hamlet
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep14_1_f_castle_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Delmore Hamlet to Delmore Manor
		AddWarp("WARP_EP14_1_F_CASTLE_1_TO_EP14_1_F_CASTLE_2", 249, From("ep14_1_f_castle_1", -709.1204, -426.1506), To("ep14_1_f_castle_2", 2288, -143));

		// Delmore Hamlet to Kirtimas Forest
		AddWarp("WARP_EP14_1_F_CASTLE_1_TO_EP13_F_SIAULIAI_5", 90, From("ep14_1_f_castle_1", 1584.229, -762.3168), To("ep13_f_siauliai_5", 152, 909));
	}
}
