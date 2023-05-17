//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tiltas Valley
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_rokas_28WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tiltas Valley to Akmens Ridge
		AddWarp("ROKAS28_ROKAS27", -85, From("f_rokas_28", -717, -1692), To("f_rokas_27", -126, -1263));

		// Tiltas Valley to Rukas Plateau
		AddWarp("ROKAS28_ROKAS29", 259, From("f_rokas_28", -1892, -545), To("f_rokas_29", 2503, 762));

		// Tiltas Valley to Royal Mausoleum Workers Lodge
		AddWarp("ROKAS28_TO_UNDERF591", 252, From("f_rokas_28", 1191.129, 2320.436), To("d_underfortress_59_1", -113, -387));
	}
}
