//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Paupys Crossing
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep13_f_siauliai_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Paupys Crossing to Woods of the Linked Bridges
		AddWarp("WARP_EP13_F_SIAULIAI_3_TO_EP13_F_SIAULIAI_2", 61, From("ep13_f_siauliai_3", 2687.554, -591.4047), To("ep13_f_siauliai_2", 876, 1721));

		// Paupys Crossing to Issaugoti Forest
		AddWarp("WARP_EP13_F_SIAULIAI_3_TO_EP13_F_SIAULIAI_4", -78, From("ep13_f_siauliai_3", -1412.676, 868.9893), To("ep13_f_siauliai_4", 118, -1028));

		// Paupys Crossing to Ashaq Underground Prison 2F
		AddWarp("WARP_EP13_F_SIAULIAI_3_TO_EP13_2_D_PRISON_2", 135, From("ep13_f_siauliai_3", 1235.945, 1636.257), To("ep13_2_d_prison_2", 1859, 82));
	}
}
