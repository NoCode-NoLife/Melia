//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Downtown
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_flash_63WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Downtown to Verkti Square
		AddWarp("FLASH63_FLASH59", 315, From("f_flash_63", -582, -2292), To("f_flash_59", 1329, 637));

		// Downtown to Inner Enceinte District
		AddWarp("FLASH63_FLASH64", 200, From("f_flash_63", -140, 1456), To("f_flash_64", -21, -2469));

		// Downtown to Coastal Fortress
		AddWarp("FLASH63_FLASH29_1", 126, From("f_flash_63", 1774.543, 1000.815), To("f_flash_29_1", -2039, -102));
	}
}
