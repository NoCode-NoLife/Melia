//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Ibre Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_tableland_70WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Ibre Plateau to Inner Enceinte District
		AddWarp("TABLELAND70_FLASH64", 65, From("f_tableland_70", 4605.454, -4493.095), To("f_flash_64", -351, 1978));

		// Ibre Plateau to Grand Yard Mesa
		AddWarp("TABLELAND70_TABLELAND71", 270, From("f_tableland_70", 780.3466, -3002.338), To("f_tableland_71", 1861, 430));
	}
}
