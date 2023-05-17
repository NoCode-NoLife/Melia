//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Evacuation Residential District
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_30_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Evacuation Residential District to Extension
		AddWarp("UNDERFORTRESS30_3_UNDERFORTRESS30_2", 92, From("d_underfortress_30_3", 2002.301, -850.6414), To("d_underfortress_30_2", -1595, -691));
	}
}
