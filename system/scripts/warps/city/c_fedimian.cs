//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Fedimian
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class c_fedimianWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Fedimian to Fedimian Suburbs
		AddWarp("FEDMIAN_TO_REMAINS40", 80, From("c_fedimian", 782, -160), To("f_remains_40", -2359, -1457));

		// Fedimian to Starving Demon's Way
		AddWarp("FEDMIAN_PILGRIM46", 166, From("c_fedimian", 846.02, 1136.69), To("f_pilgrimroad_46", -1980, -2354));

		// Fedimian to Fedimian Public House
		AddWarp("FEDIMIAN_REQUEST1", 180, From("c_fedimian", -844, -100), To("c_request_1", 122, -127));
	}
}
