//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Namu Temple Ruins
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_remains_37_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Namu Temple Ruins to Nuoridin Falls
		AddWarp("REMAINS37_2_REMAINS37_1", 172, From("f_remains_37_2", 1862.454, -378.2695), To("f_remains_37_1", -2700, 1464));

		// Namu Temple Ruins to Istora Ruins
		AddWarp("REMAINS37_2_REMAINS37_3", 173, From("f_remains_37_2", -775.99, 1604.21), To("f_remains_37_3", -545, -1476));
	}
}
