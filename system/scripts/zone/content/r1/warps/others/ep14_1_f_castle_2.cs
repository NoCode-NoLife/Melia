//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Delmore Manor
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep14_1_f_castle_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Delmore Manor to Delmore Hamlet
		AddWarp("WARP_EP14_1_F_CASTLE_2_TO_EP14_1_F_CASTLE_1", 90, From("ep14_1_f_castle_2", 2373.521, -149.7171), To("ep14_1_f_castle_1", -640, -455));

		// Delmore Manor to Delmore Outskirts
		AddWarp("WARP_EP14_1_F_CASTLE_2_TO_EP14_1_F_CASTLE_3", 174, From("ep14_1_f_castle_2", 1126.129, 2460.187), To("ep14_1_f_castle_3", 313, -1705));
	}
}
