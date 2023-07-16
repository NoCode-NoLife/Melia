//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Valius' Eternal Resting Place
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class id_catacomb_02WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Valius' Eternal Resting Place to Videntis Shrine
		AddWarp("CATACOMB_02_CATACOMB_38_1", 45, From("id_catacomb_02", -712.566, -1847.855), To("id_catacomb_38_1", 1716, 1495));

		// Valius' Eternal Resting Place to Nuoridin Falls
		AddWarp("CATACOMB_02_REMAINS37_1", 225, From("id_catacomb_02", 2712.65, 1785.594), To("f_remains_37_1", -114, -1874));
	}
}
