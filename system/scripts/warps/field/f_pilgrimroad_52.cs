//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Apsimesti Crossroads
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_52WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Apsimesti Crossroads to Forest of Prayer
		AddWarp("PILGRIM52_PILGRIM51", 350, From("f_pilgrimroad_52", -1184.457, -3331.97), To("f_pilgrimroad_51", -1453, 1281));

		// Apsimesti Crossroads to Verkti Square
		AddWarp("PILGRIM52_FLASH59", 180, From("f_pilgrimroad_52", -471, 2056), To("f_flash_59", -378, 804));

		// Apsimesti Crossroads to Main Building
		AddWarp("PILGRIM52_CATHEDRAL53", 115, From("f_pilgrimroad_52", 1033, -691), To("d_cathedral_53", -1, -930));

		// Apsimesti Crossroads to Roxona Reconstruction Agency West Building
		AddWarp("PILGRIMROAD52_TO_FIRETOWER611", 270, From("f_pilgrimroad_52", -1865.088, -78.65852), To("d_firetower_61_1", -283, -2149));
	}
}
