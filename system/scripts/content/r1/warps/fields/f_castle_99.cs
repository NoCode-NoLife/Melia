//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Tvirtumas Fortress
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_99WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Tvirtumas Fortress to Vienibe Shelter
		AddWarp("F_CASTLE_99_TO_F_CASTLE_97", 38, From("f_castle_99", 2077.656, -1187.94), To("f_castle_97", 2049, 778));

		// Tvirtumas Fortress to Skalda Outskirts
		AddWarp("F_CASTLE_99_TO_F_CASTLE_102", 90, From("f_castle_99", 2386.272, 1130.106), To("f_castle_102", -1468, -1639));
	}
}
