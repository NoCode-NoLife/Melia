//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Mollogheo Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_bracken_43_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Mollogheo Forest to Ziburynas Forest
		AddWarp("BRACKEN434_BRACKEN433", 176, From("f_bracken_43_4", 395.3182, 1195.019), To("f_bracken_43_3", 181, -1292));
	}
}
