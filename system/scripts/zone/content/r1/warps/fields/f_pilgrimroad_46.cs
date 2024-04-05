//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Starving Demon's Way
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_46WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Starving Demon's Way to Fedimian
		AddWarp("PILGRIM46_FEDMIAN", -45, From("f_pilgrimroad_46", -2072.84, -2455.15), To("c_fedimian", 807, 1031));

		// Starving Demon's Way to Pilgrim Path
		AddWarp("PILGRIM46_PILGRIM47", 180, From("f_pilgrimroad_46", 601, 1714), To("f_pilgrimroad_47", -2376, -2109));
	}
}
