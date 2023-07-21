//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Southern Parias Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_maple_24_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Southern Parias Forest to Central Parias Forest
		AddWarp("F_MAPLE_242_TO_F_MAPLE_241", 225, From("f_maple_24_2", 1376.938, 1265.504), To("f_maple_24_1", 1726, -155));
	}
}
