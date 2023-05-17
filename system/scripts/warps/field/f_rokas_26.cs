//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Overlong Bridge Valley
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_rokas_26WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Overlong Bridge Valley to Ramstis Ridge
		AddWarp("ROKAS26_ROKAS25", 0, From("f_rokas_26", 483, -2502), To("f_rokas_25", 2714, -1106));

		// Overlong Bridge Valley to Akmens Ridge
		AddWarp("ROKAS26_ROKAS27", 268, From("f_rokas_26", -1090, -1740), To("f_rokas_27", -187, -3475));
	}
}
