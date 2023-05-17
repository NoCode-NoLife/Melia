//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Baltinel Memorial
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_dcapital_105WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Baltinel Memorial to Taniel I Commemorative Orb
		AddWarp("WARP_DCAPITAL105_TO_DCAPITAL103", -2, From("f_dcapital_105", -950.0858, -1317.412), To("f_dcapital_103", -1508, 214));

		// Baltinel Memorial to Path of Desition
		AddWarp("WARP_DCAPITAL105_TO_DCAPITAL104", 196, From("f_dcapital_105", -325.7116, 2083.584), To("f_dcapital_104", 0, 0));

		// Baltinel Memorial to Gliehel Memorial
		AddWarp("WARP_DCAPITAL105_TO_DCAPITAL106", -42, From("f_dcapital_105", -1795.635, 63.40304), To("f_dcapital_106", 2185, 372));
	}
}
