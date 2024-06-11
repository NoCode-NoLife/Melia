//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Nuoridin Falls
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_remains_37_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Nuoridin Falls to Valius' Eternal Resting Place
		AddWarp("REMAINS37_1_CATACOMB_02", 151, From("f_remains_37_1", -65.84995, -1794.304), To("id_catacomb_02", 2800, 1688));

		// Nuoridin Falls to Stele Road
		AddWarp("REMAINS37_1_REMAINS37", 48, From("f_remains_37_1", 2123.194, -745.3977), To("f_remains_37", -84, 2684));

		// Nuoridin Falls to Namu Temple Ruins
		AddWarp("REMAINS37_1_REMAINS37_2", 14, From("f_remains_37_1", -2785.502, 1350.796), To("f_remains_37_2", 1834, -391));
	}
}
