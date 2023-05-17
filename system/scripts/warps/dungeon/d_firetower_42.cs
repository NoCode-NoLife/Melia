//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Mage Tower 2F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_firetower_42WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Mage Tower 2F to Mage Tower 3F
		AddWarp("FIRETOWER42_TO_FIRETOWER43", 95, From("d_firetower_42", -933, -2391), To("d_firetower_43", -2508, -258));
	}
}
