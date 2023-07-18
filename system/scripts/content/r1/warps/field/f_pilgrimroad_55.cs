//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Penitence Route
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_55WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Penitence Route to Grand Corridor
		AddWarp("PILGRIM55_CATHEDRAL54", 150, From("f_pilgrimroad_55", 1614.564, 40.79414), To("d_cathedral_54", -1717, -563));

		// Penitence Route to Grand Corridor
		AddWarp("PILGRIM55_CATHEDRAL54_RE", 169, From("f_pilgrimroad_55", -576.0657, 776.1403), To("d_cathedral_54", -1478, 1000));

		// Penitence Route to Barha Forest
		AddWarp("PILGRIM55_ORCHARD34_3", 39, From("f_pilgrimroad_55", 1752.151, -636.6796), To("f_orchard_34_3", -586, 1235));
	}
}
