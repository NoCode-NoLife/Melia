//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Shaton Reservoir
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_farm_49_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Shaton Reservoir to Shaton Farm
		AddWarp("FARM493_TO_FARM492", 4, From("f_farm_49_3", 829.432, -948.9832), To("f_farm_49_2", -2287, 1037));
	}
}
