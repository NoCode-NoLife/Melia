//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Residence of the Fallen Legwyn Family
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_startower_60_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Residence of the Fallen Legwyn Family to Forest of Prayer
		AddWarp("STOWERTOWER_60_1_TO_PILGRIMROAD_51", 270, From("d_startower_60_1", -81.22099, -2128.663), To("f_pilgrimroad_51", 1288, 2095));
	}
}
