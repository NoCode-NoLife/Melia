//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Escanciu Village
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_remains_39WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Escanciu Village to Goddess' Ancient Garden
		AddWarp("REMAINS39_REMAINS38", 45, From("f_remains_39", -479, -656), To("f_remains_38", 1440, 1630));

		// Escanciu Village to Fedimian Suburbs
		AddWarp("REMAINS39_REMAINS40", 190, From("f_remains_39", 873, 1635), To("f_remains_40", 48, -2541));

		// Escanciu Village to King's Plateau
		AddWarp("REMAINS39_ROKAS30", 90, From("f_remains_39", 1261, -325), To("f_rokas_30", -174, 684));
	}
}
