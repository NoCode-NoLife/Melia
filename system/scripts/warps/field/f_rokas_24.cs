//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Gateway of the Great King
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_rokas_24WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Gateway of the Great King to Sunset Flag Forest
		AddWarp("ROKAS24_THORN23", 0, From("f_rokas_24", 930, -3045), To("d_thorn_23", 2398, 2096));

		// Gateway of the Great King to Ramstis Ridge
		AddWarp("ROKAS24_ROKAS25", 176, From("f_rokas_24", 904, 1240), To("f_rokas_25", -2266, -1122));

		// Gateway of the Great King to (Closed) Letas Stream
		AddWarp("ROKAS24_KATYN12", 90, From("f_rokas_24", 1652.514, -1050.812), To("f_katyn_12", -1561, 2205));
	}
}
