//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Greene Manor
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_farm_49_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Greene Manor to Aqueduct Bridge Area
		AddWarp("FARM491_TO_FARM472", 106, From("f_farm_49_1", 2378, 909), To("f_farm_47_2", -1578, 998));

		// Greene Manor to Shaton Farm
		AddWarp("FARM491_TO_FARM492", 126, From("f_farm_49_1", -979.0124, 1136.139), To("f_farm_49_2", 716, -2046));
	}
}
