//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Ashaq Underground Prison 1F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep13_2_d_prison_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Ashaq Underground Prison 1F to Ashaq Underground Prison Containment Area
		AddWarp("WARP_EP13_2_D_PRISON_1_TO_EP13_2_D_PRISON_3", 177, From("ep13_2_d_prison_1", -574.8887, 392.7252), To("ep13_2_d_prison_3", -509, 1011));
	}
}
