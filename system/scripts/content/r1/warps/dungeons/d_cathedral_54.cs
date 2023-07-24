//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Grand Corridor
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_cathedral_54WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Grand Corridor to Main Building
		AddWarp("CATHEDRAL54_CATHEDRAL53", 92, From("d_cathedral_54", 1218.897, -380.2193), To("d_cathedral_53", 1048, -279));

		// Grand Corridor to Penitence Route
		AddWarp("CATHEDRAL54_PILGRIM55", 270, From("d_cathedral_54", -1824, -566), To("f_pilgrimroad_55", 1579, -141));

		// Grand Corridor to Penitence Route
		AddWarp("CATHEDRAL54_PILGRIM55_RE", 180, From("d_cathedral_54", -1474, 1122), To("f_pilgrimroad_55", -619, 662));

		// Grand Corridor to Sanctuary
		AddWarp("CATHEDRAL54_CATHEDRAL56", 87, From("d_cathedral_54", 1176.995, 593.0758), To("d_cathedral_56", 2110, 464));
	}
}
