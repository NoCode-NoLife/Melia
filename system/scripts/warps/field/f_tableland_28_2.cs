//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Stogas Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_tableland_28_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Stogas Plateau to Mesafasla
		AddWarp("TABLELAND282_TO_TABLELAND281", 160, From("f_tableland_28_2", 1693.931, 1816.277), To("f_tableland_28_1", -2923, 766));

		// Stogas Plateau to Roxona Market
		AddWarp("TABLELAND282_TO_FLASH60", -6, From("f_tableland_28_2", -13.09026, -2126.216), To("f_flash_60", -1313, 654));

		// Stogas Plateau to Vedas Plateau
		AddWarp("TABLELAND28_2_TABLELAND11_1", 170, From("f_tableland_28_2", 2112.74, 553.528), To("f_tableland_11_1", -985, -1336));
	}
}
