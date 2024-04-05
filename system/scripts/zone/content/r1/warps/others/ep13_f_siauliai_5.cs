//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Kirtimas Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep13_f_siauliai_5WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Kirtimas Forest to Issaugoti Forest
		AddWarp("WARP_EP13_F_SIAULIAI_5_TO_EP13_F_SIAULIAI_4", -33, From("ep13_f_siauliai_5", -60.30424, -1271.741), To("ep13_f_siauliai_4", 69, 1063));

		// Kirtimas Forest to Delmore Hamlet
		AddWarp("WARP_EP13_F_SIAULIAI_5_TO_EP14_1_F_CASTLE_1", 169, From("ep13_f_siauliai_5", 165.2721, 984.2814), To("ep14_1_f_castle_1", 1504, -760));
	}
}
