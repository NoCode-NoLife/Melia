//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Resident Quarter
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_67WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Resident Quarter to Drill Ground of Confliction
		AddWarp("UNDERFORTRESS67_UNDERFORTRESS66", -33, From("d_underfortress_67", 31.74275, -1661.218), To("d_underfortress_66", -538, -79));

		// Resident Quarter to Storage Quarter
		AddWarp("UNDERFORTRESS67_UNDERFORTRESS68", 176, From("d_underfortress_67", 350.6508, 545.6928), To("d_underfortress_68", -2831, -1240));

		// Resident Quarter to Ruklys Hall of Fame
		AddWarp("UNDERFORTRESS67_UNDERFORTRESS30_1", -23, From("d_underfortress_67", 884.1856, 2.983585), To("d_underfortress_30_1", -85, 1818));
	}
}
