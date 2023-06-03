//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Taniel I Commemorative Orb
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_dcapital_103WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Taniel I Commemorative Orb to Inner Wall District 8
		AddWarp("DCAPITAL103_TO_CASTLE20_3", 46, From("f_dcapital_103", 738.5951, -1526.434), To("f_castle_20_3", -668, 1244));

		// Taniel I Commemorative Orb to City Wall District 8
		AddWarp("DCAPITAL103_TO_CASTLE20_4", 91, From("f_dcapital_103", 1754.669, -546.0566), To("f_castle_20_4", -1596, 385));

		// Taniel I Commemorative Orb to Path of Desition
		AddWarp("DCAPITAL103_TO_DCAPITAL104", 119, From("f_dcapital_103", 1215.827, 1377.111), To("f_dcapital_104", 0, 0));

		// Taniel I Commemorative Orb to Baltinel Memorial
		AddWarp("DCAPITAL103_TO_DCAPITAL105", -89, From("f_dcapital_103", -1632.505, 234.6475), To("f_dcapital_105", 0, 0));
	}
}
