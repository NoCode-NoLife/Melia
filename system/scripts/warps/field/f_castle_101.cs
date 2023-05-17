//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Sacred Atspalvis 
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_101WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Sacred Atspalvis  to Path of Desition
		AddWarp("WARP_F_DCAPITAL_101_TO_DCAPITAL104", -4, From("f_castle_101", 305.3575, -1756.758), To("f_dcapital_104", 629, 1905));
	}
}
