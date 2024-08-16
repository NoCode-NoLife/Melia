//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Yudejan Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_whitetrees_21_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Yudejan Forest to Nobreer Forest
		AddWarp("WHITETREES_21_1_WHITETREES_21_2", 270, From("f_whitetrees_21_1", -2067.427, 995.0537), To("f_whitetrees_21_2", 1021, -1203));

		// Yudejan Forest to Sajunga Road
		AddWarp("WHITETREES_21_1_CASTLE_19_1", 165, From("f_whitetrees_21_1", 1871.44, 562.28), To("d_castle_19_1", 0, 0));
	}
}
