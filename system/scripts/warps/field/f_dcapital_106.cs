//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Gliehel Memorial
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_dcapital_106WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Gliehel Memorial to City Wall District 4
		AddWarp("WARP_DCAPITAL106_TO_DCAPITAL192", 90, From("f_dcapital_106", -1650.401, -218.0122), To("d_castle_19_2", 0, 0));

		// Gliehel Memorial to Baltinel Memorial
		AddWarp("WARP_DCAPITAL106_TO_DCAPITAL105", 90, From("f_dcapital_106", 2339.093, 374.5684), To("f_dcapital_105", -1683, 102));

		// Gliehel Memorial to Frienel Memorial
		AddWarp("WARP_DCAPITAL106_TO_DCAPITAL107", 90, From("f_dcapital_106", 943.1763, 1711.521), To("f_dcapital_107", 388, -1379));
	}
}
