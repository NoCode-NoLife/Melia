//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Stele Road
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_remains_37WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Stele Road to Zachariel Crossroads
		AddWarp("REMAINS37_ROKAS31", 45, From("f_remains_37", -1292, -2944), To("f_rokas_31", 553, -1337));

		// Stele Road to Goddess' Ancient Garden
		AddWarp("REMAINS37_REMAINS38", 176, From("f_remains_37", 564, 3367), To("f_remains_38", -1382, -2101));

		// Stele Road to Passage of the Recluse
		AddWarp("REMAINS37_PCATHEDRAL1", 360, From("f_remains_37", 485, -2623), To("p_cathedral_1", 55, 191));

		// Stele Road to Nuoridin Falls
		AddWarp("REMAINS37_REMAINS37_1", 160, From("f_remains_37", -72.25984, 2797.046), To("f_remains_37_1", 2061, -689));

		// Stele Road to Zima Suecourt
		AddWarp("REMAINS37_TO_FIRETOWER691", -1, From("f_remains_37", 1165.491, -2714.446), To("d_firetower_69_1", -2479, -246));
	}
}
