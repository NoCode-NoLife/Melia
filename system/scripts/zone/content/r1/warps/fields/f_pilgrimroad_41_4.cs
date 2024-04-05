//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Sekta Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_41_4WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Sekta Forest to Grynas Trails
		AddWarp("PILGRIM41_4_KATYN45_1", -8, From("f_pilgrimroad_41_4", 1821.881, -1410.627), To("f_katyn_45_1", 966, 906));

		// Sekta Forest to Salvia Forest
		AddWarp("PILGRIM41_4_PILGRIM41_2", 183, From("f_pilgrimroad_41_4", -102.1826, 1347.569), To("f_pilgrimroad_41_2", 0, -1407));
	}
}
