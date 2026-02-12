//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in EP18 Kadumel Cliff
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class ep18_1_f_tableland_73WarpsScript : GeneralScript
{
	protected override void Load()
	{
		// EP18 Kadumel Cliff to EP18 Sventimas Exile
		AddWarp("EP18_1_TABLELAND73_TABLELAND72", 90, From("ep18_1_f_tableland_73", 1480.685, -1197.682), To("ep18_1_f_tableland_72", 784, 1877));

		// EP18 Kadumel Cliff to EP18 Steel Heights
		AddWarp("EP18_1_TABLELAND73_TABLELAND74", 140, From("ep18_1_f_tableland_73", 1575.94, 1631.251), To("ep18_1_f_tableland_74", -2354, -1493));
	}
}
