//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Ashaq Underground Prison 2F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep13_2_d_prison_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Ashaq Underground Prison 2F to Paupys Crossing
		AddWarp("WARP_EP13_2_D_PRISON_2_TO_EP13_F_SIAULIAI_3", 90, From("ep13_2_d_prison_2", 1980.626, 79.96671), To("ep13_f_siauliai_3", 1165, 1562));

		// Ashaq Underground Prison 2F to Ashaq Underground Prison Containment Area
		AddWarp("WARP_EP13_2_D_PRISON_2_TO_EP13_2_D_PRISON_3", -84, From("ep13_2_d_prison_2", -1911.783, 1812.052), To("ep13_2_d_prison_3", 734, -1019));
	}
}
