//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Manahas
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_48WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Manahas to Fasika Plateau
		AddWarp("PILGRIM_48_TO_PILGRIM_36_2", 206, From("f_pilgrimroad_48", -560.6875, 1498.365), To("f_pilgrimroad_36_2", -21, -875));

		// Manahas to Genar Field
		AddWarp("PILGRIM_48_TO_PILGRIM_49", -6, From("f_pilgrimroad_48", -1470.036, -2171.64), To("f_pilgrimroad_49", 2313, 115));
	}
}
