//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Woods of the Linked Bridges
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep13_f_siauliai_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Woods of the Linked Bridges to Lemprasa Pond
		AddWarp("WARP_EP13_F_SIAULIAI_2_TO_EP13_F_SIAULIAI_1", 90, From("ep13_f_siauliai_2", 3378.182, -671.4368), To("ep13_f_siauliai_1", -452, -1728));

		// Woods of the Linked Bridges to Paupys Crossing
		AddWarp("WARP_EP13_F_SIAULIAI_2_TO_EP13_F_SIAULIAI_3", 166, From("ep13_f_siauliai_2", 898.933, 1795.521), To("ep13_f_siauliai_3", 2597, -580));

		// Woods of the Linked Bridges to Novaha Institute
		AddWarp("WARP_EP13_F_SIAULIAI_2_TO_EP15_1_FABBEY_1", 94, From("ep13_f_siauliai_2", 2048.08, 1031.038), To("ep15_1_f_abbey_1", 1460, 223));
	}
}
