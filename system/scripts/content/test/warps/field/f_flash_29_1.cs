//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Coastal Fortress
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_flash_29_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Coastal Fortress to Downtown
		AddWarp("FLASH_29_1_TO_FLASH_63", 177, From("f_flash_29_1", -2077.423, -42.84209), To("f_flash_63", 1702, 967));

		// Coastal Fortress to Dingofasil District
		AddWarp("FLASH_29_1_TO_FLASH_58", 182, From("f_flash_29_1", 58.00917, 1352.981), To("f_flash_58", -163, -1932));
	}
}
