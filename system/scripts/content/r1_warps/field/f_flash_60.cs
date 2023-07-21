//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Roxona Market
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_flash_60WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Roxona Market to Verkti Square
		AddWarp("FLASH60_FLASH59", 97, From("f_flash_60", 1231.594, -103.5576), To("f_flash_59", 156, 671));

		// Roxona Market to Ruklys Street
		AddWarp("FLASH60_FLASH61", 126, From("f_flash_60", 1004.703, 1643.674), To("f_flash_61", -93, 1462));

		// Roxona Market to Stogas Plateau
		AddWarp("FLASH60_TABLELAND28_2", 225, From("f_flash_60", -1377.118, 715.1829), To("f_tableland_28_2", 33, -2000));
	}
}
