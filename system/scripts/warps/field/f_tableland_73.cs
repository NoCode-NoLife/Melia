//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Kadumel Cliff
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_tableland_73WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Kadumel Cliff to Sventimas Exile
		AddWarp("TABLELAND73_TABLELAND72", 90, From("f_tableland_73", 1480.685, -1197.682), To("f_tableland_72", 784, 1877));

		// Kadumel Cliff to Steel Heights
		AddWarp("TABLELAND73_TABLELAND74", 140, From("f_tableland_73", 1575.94, 1631.251), To("f_tableland_74", -2354, -1493));
	}
}
