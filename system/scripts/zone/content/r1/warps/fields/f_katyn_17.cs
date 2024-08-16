//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Bladelight Basin
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_17WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Bladelight Basin to (Closed) (Ex)Woods of the Linked Bridges
		AddWarp("KATYN17_SIAUL15", 360, From("f_katyn_17", 1988, -4112), To("f_siauliai_15_re", -446, -3316));

		// Bladelight Basin to Zachariel Crossroads
		AddWarp("KATYN17_ROKAS31", 360, From("f_katyn_17", -3653, 441), To("f_rokas_31", 826, -1276));

		// Bladelight Basin to Rukas Plateau
		AddWarp("KATYN17_ROKAS29", 90, From("f_katyn_17", 421, -678), To("f_rokas_29", 1564, -1437));

		// Bladelight Basin to Stele Road
		AddWarp("KATYN17_REMAINS37", 270, From("f_katyn_17", -2400, 410), To("f_remains_37", 1168, -2571));
	}
}
