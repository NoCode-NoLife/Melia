//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Delmore Outskirts
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep14_1_f_castle_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Delmore Outskirts to Lemprasa Pond
		AddWarp("WARP_EP14_1_F_CASTLE_3_TO_EP13_F_SIAULIAI_1", 256, From("ep14_1_f_castle_3", -2068.512, 1043.251), To("ep13_f_siauliai_1", 862, 1921));

		// Delmore Outskirts to Delmore Manor
		AddWarp("WARP_EP14_1_F_CASTLE_3_TO_EP14_1_F_CASTLE_2", -43, From("ep14_1_f_castle_3", 240.8775, -1763.283), To("ep14_1_f_castle_2", 1121, 2362));

		// Delmore Outskirts to Delmore Citadel
		AddWarp("WARP_EP14_1_F_CASTLE_3_TO_EP14_1_F_CASTLE_4", 189, From("ep14_1_f_castle_3", 1134.802, 315.485), To("ep14_1_f_castle_4", 1107, -2096));
	}
}
