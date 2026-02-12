//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP18 Sventimas Exile
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep18_1_f_tableland_72WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP18 Sventimas Exile to EP18 Kadumel Cliff
		AddWarp("EP18_1_TABLELAND72_TABLELAND73", 183, From("ep18_1_f_tableland_72", 777.5479, 2020.532), To("ep18_1_f_tableland_73", 1321, -1205));

		// EP18 Sventimas Exile to Grand Yard Mesa
		AddWarp("EP18_1_TABLELAND72_TABLELAND71", 48, From("ep18_1_f_tableland_72", 1029.782, -1489.055), To("f_tableland_71", -797, 1233));

		// EP18 Sventimas Exile to Sentry Bailey
		AddWarp("EP18_1_TABLELAND72_UNDERFORTRESS65", 99, From("ep18_1_f_tableland_72", 2131.741, 222.4766), To("d_underfortress_65", -1677, 1114));
	}
}
