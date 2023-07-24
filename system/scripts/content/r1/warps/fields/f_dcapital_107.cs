//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Frienel Memorial
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_dcapital_107WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Frienel Memorial to Gliehel Memorial
		AddWarp("WARP_DCAPITAL107_TO_DCAPITAL106", 0, From("f_dcapital_107", 385.8596, -1490.129), To("f_dcapital_106", 855, 1717));

		// Frienel Memorial to Sajunga Road
		AddWarp("WARP_DCAPITAL107_TO_DCAPITAL181", 90, From("f_dcapital_107", 98.4219, 1686.794), To("d_castle_19_1", 20, 907));
	}
}
