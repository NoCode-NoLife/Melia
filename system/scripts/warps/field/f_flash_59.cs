//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Verkti Square
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_flash_59WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Verkti Square to Apsimesti Crossroads
		AddWarp("FLASH59_PILGRIM52", 220, From("f_flash_59", -452, 881), To("f_pilgrimroad_52", -472, 1920));

		// Verkti Square to Roxona Market
		AddWarp("FLASH59_FLASH60", 181, From("f_flash_59", 157, 765), To("f_flash_60", 1142, -123));

		// Verkti Square to Ruklys Street
		AddWarp("FLASH59_FLASH61", 184, From("f_flash_59", 1372.925, 1083.849), To("f_flash_61", -893, -233));

		// Verkti Square to Downtown
		AddWarp("FLASH59_FLASH63", 90, From("f_flash_59", 1425.89, 635.2833), To("f_flash_63", -466, -2211));
	}
}
