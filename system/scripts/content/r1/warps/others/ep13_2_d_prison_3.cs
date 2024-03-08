//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Ashaq Underground Prison Containment Area
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep13_2_d_prison_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Ashaq Underground Prison Containment Area to Ashaq Underground Prison 2F
		AddWarp("WARP_EP13_2_D_PRISON_3_TO_EP13_2_D_PRISON_2", 90, From("ep13_2_d_prison_3", 848.7574, -1027.19), To("ep13_2_d_prison_2", -1794, 1800));

		// Ashaq Underground Prison Containment Area to Ashaq Underground Prison 1F
		AddWarp("WARP_EP13_2_D_PRISON_3_TO_EP13_2_D_PRISON_1", 179, From("ep13_2_d_prison_3", -507.2418, 1093.708), To("ep13_2_d_prison_1", -563, 269));
	}
}
