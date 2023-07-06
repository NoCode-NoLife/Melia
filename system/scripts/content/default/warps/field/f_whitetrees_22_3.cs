//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Izoliacjia Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_whitetrees_22_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Izoliacjia Plateau to Tekel Shelter
		AddWarp("WHITETREES22_3_WHITETREES22_2", 225, From("f_whitetrees_22_3", -171.7528, 1423.126), To("f_whitetrees_22_2", -3, -1698));

		// Izoliacjia Plateau to Narvas Temple
		AddWarp("WHITETREES22_3_ABBEY22_4", -89, From("f_whitetrees_22_3", -1685.871, 304.4066), To("d_abbey_22_4", 1775, 1304));

		// Izoliacjia Plateau to Mishekan Forest
		AddWarp("WHITETREES22_3_WHITETREES56_1", 6, From("f_whitetrees_22_3", 1641.327, -2043.737), To("f_whitetrees_56_1", 123, 1659));
	}
}
