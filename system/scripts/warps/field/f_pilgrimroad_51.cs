//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Forest of Prayer
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_51WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Forest of Prayer to Apsimesti Crossroads
		AddWarp("PILGRIM51_PILGRIM52", 180, From("f_pilgrimroad_51", -1496, 1415), To("f_pilgrimroad_52", -1135, -3182));

		// Forest of Prayer to Altar Way
		AddWarp("PILGRIM51_PILGRIM50", 360, From("f_pilgrimroad_51", -942, -2184), To("f_pilgrimroad_50", 2140, -1250));

		// Forest of Prayer to Residence of the Fallen Legwyn Family
		AddWarp("PILGRIMROAD_51_TO_STOWERTOWER_60_1", 180, From("f_pilgrimroad_51", 1331.8, 2181.597), To("d_startower_60_1", 20, -2125));

		// Forest of Prayer to Alemeth Forest
		AddWarp("PILGRIM51_ORCHARD34_1", 49, From("f_pilgrimroad_51", 2022.333, -2034.335), To("f_orchard_34_1", -446, 1372));
	}
}
