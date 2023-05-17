//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in King's Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_rokas_30WarpsScript : GeneralScript
{
	public override void Load()
	{
		// King's Plateau to Rukas Plateau
		AddWarp("ROKAS30_ROKAS29", 45, From("f_rokas_30", 1019, -1097), To("f_rokas_29", -1306, -1980));

		// King's Plateau to Zachariel Crossroads
		AddWarp("ROKAS30_ROKAS31", 263, From("f_rokas_30", -1773, -116), To("f_rokas_31", 802, -1121));

		// King's Plateau to Escanciu Village
		AddWarp("ROKAS30_REMAINS39", 180, From("f_rokas_30", -209, 893), To("f_remains_39", 1070, -282));
	}
}
