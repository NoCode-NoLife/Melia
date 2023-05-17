//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Genar Field
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class GuildColony_f_pilgrimroad_49WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Genar Field to Manahas
		AddWarp("PILGRIM_49_TO_PILGRIM_48", 124, From("GuildColony_f_pilgrimroad_49", 2378.388, 184.8524), To("f_pilgrimroad_48", -1455, -2052));

		// Genar Field to Pilgrim Path
		AddWarp("PILGRIM_49_TO_PILGRIM_47", -15, From("GuildColony_f_pilgrimroad_49", -2314.767, -647.9147), To("f_pilgrimroad_47", 1304, -1261));

		// Genar Field to Altar Way
		AddWarp("PILGRIM_49_TO_PILGRIM_50", 179, From("GuildColony_f_pilgrimroad_49", -85.97439, 1318.946), To("f_pilgrimroad_50", -138, -662));
	}
}
