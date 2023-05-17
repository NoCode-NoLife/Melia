//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Shaton Farm
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_farm_49_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Shaton Farm to Greene Manor
		AddWarp("FARM492_TO_FARM491", -22, From("f_farm_49_2", 666.3536, -2160.593), To("f_farm_49_1", -1042, 1083));

		// Shaton Farm to Shaton Reservoir
		AddWarp("FARM492_TO_FARM493", 175, From("f_farm_49_2", -2287.959, 1096.116), To("f_farm_49_3", 829, -882));
	}
}
