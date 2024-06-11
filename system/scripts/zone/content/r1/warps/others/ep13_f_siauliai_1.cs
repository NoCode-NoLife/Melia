//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Lemprasa Pond
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep13_f_siauliai_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Lemprasa Pond to Orsha
		AddWarp("WARP_EP13_F_SIAULIAI_1_TO_ORSHA", 122, From("ep13_f_siauliai_1", 2057.641, 336.1328), To("c_orsha", -1239, 336));

		// Lemprasa Pond to Woods of the Linked Bridges
		AddWarp("WARP_EP13_F_SIAULIAI_1_TO_EP13_F_SIAULIAI_2", -30, From("ep13_f_siauliai_1", -502.0264, -1813.892), To("ep13_f_siauliai_2", 3285, -693));

		// Lemprasa Pond to Khonot Forest
		AddWarp("WARP_EP13_F_SIAULIAI_1_TO_BRACKEN42_1", 164, From("ep13_f_siauliai_1", -439.4073, 1928.631), To("f_bracken_42_1", 113, 986));

		// Lemprasa Pond to Delmore Outskirts
		AddWarp("WARP_EP13_F_SIAULIAI_1_TO_EP14_1_F_CASTLE_3", 146, From("ep13_f_siauliai_1", 872.61, 2039.003), To("ep14_1_f_castle_3", -1982, 997));
	}
}
