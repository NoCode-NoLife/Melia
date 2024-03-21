//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Grand Yard Mesa
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_tableland_71WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Grand Yard Mesa to Ibre Plateau
		AddWarp("TABLELAND71_TABLELAND70", 33, From("f_tableland_71", 1939.665, 302.0853), To("f_tableland_70", 895, -2999));

		// Grand Yard Mesa to Sventimas Exile
		AddWarp("TABLELAND71_TABLELAND72", 220, From("f_tableland_71", -867.9552, 1306.76), To("f_tableland_72", 892, -1355));

		// Grand Yard Mesa to Vedas Plateau
		AddWarp("TABLELAND71_TABLELAND11_1", 0, From("f_tableland_71", -205.1074, -1327.921), To("f_tableland_11_1", 426, 2167));
	}
}
