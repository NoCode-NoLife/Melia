//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Ruklys Street
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_flash_61WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Ruklys Street to Roxona Market
		AddWarp("FLASH61_FLASH60", 180, From("f_flash_61", -100, 1555), To("f_flash_60", 924, 1567));

		// Ruklys Street to Verkti Square
		AddWarp("FLASH61_FLASH59", 360, From("f_flash_61", -875, -378), To("f_flash_59", 1371, 1003));

		// Ruklys Street to Vedas Plateau
		AddWarp("FLASH61_TABLELAND11_1", 132, From("f_flash_61", 452.1687, 1631.381), To("f_tableland_11_1", 583, -1462));
	}
}
