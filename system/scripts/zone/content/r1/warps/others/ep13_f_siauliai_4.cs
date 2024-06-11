//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Issaugoti Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep13_f_siauliai_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Issaugoti Forest to Paupys Crossing
		AddWarp("WARP_EP13_F_SIAULIAI_4_TO_EP13_F_SIAULIAI_3", 6, From("ep13_f_siauliai_4", 126.3742, -1144.248), To("ep13_f_siauliai_3", -1240, 926));

		// Issaugoti Forest to Kirtimas Forest
		AddWarp("WARP_EP13_F_SIAULIAI_4_TO_EP13_F_SIAULIAI_5", 166, From("ep13_f_siauliai_4", 73.92236, 1200.827), To("ep13_f_siauliai_5", 30, -1025));
	}
}
