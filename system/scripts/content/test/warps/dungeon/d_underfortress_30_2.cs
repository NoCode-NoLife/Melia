//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Extension
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_30_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Extension to Ruklys Hall of Fame
		AddWarp("UNDERFORTRESS30_2_UNDERFORTRESS30_1", 90, From("d_underfortress_30_2", 1214.862, -704.8499), To("d_underfortress_30_1", 929, -952));

		// Extension to Evacuation Residential District
		AddWarp("UNDERFORTRESS30_2_UNDERFORTRESS30_3", -87, From("d_underfortress_30_2", -1696.534, -697.921), To("d_underfortress_30_3", 1470, -770));
	}
}
