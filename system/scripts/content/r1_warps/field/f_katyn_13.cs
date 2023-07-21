//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Poslinkis Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_katyn_13WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Poslinkis Forest to Owl Burial Ground
		AddWarp("KATYN13_KATYN7_2", 94, From("f_katyn_13", 71, -2123), To("f_katyn_7_2", 363, 1703));

		// Poslinkis Forest to Saknis Plains
		AddWarp("KATYN13_KATYN14", 270, From("f_katyn_13", -2725, 1296), To("f_katyn_14", 3391, -911));

		// Poslinkis Forest to Septyni Glen
		AddWarp("KATYN13_HUEVILLAGE58_4", 270, From("f_katyn_13", -1079.035, -2373.376), To("f_huevillage_58_4", 1357, 353));
	}
}
