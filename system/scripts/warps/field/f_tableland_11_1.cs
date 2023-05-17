//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Vedas Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_tableland_11_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Vedas Plateau to Ruklys Street
		AddWarp("TABLELAND11_1_FLASH61", 23, From("f_tableland_11_1", 615.5692, -1536.742), To("f_flash_61", 358, 1547));

		// Vedas Plateau to Mesafasla
		AddWarp("TABLELAND11_1_TABLELAND28_1", 195, From("f_tableland_11_1", -2260.602, 2342.318), To("f_tableland_28_1", 572, -759));

		// Vedas Plateau to Stogas Plateau
		AddWarp("TABLELAND11_1_TABLELAND28_2", 270, From("f_tableland_11_1", -1070.479, -1326.732), To("f_tableland_28_2", 2080, 439));

		// Vedas Plateau to Grand Yard Mesa
		AddWarp("TABLELAND11_1_TABLELAND71", 162, From("f_tableland_11_1", 486.9811, 2231.2), To("f_tableland_71", -213, -1246));
	}
}
