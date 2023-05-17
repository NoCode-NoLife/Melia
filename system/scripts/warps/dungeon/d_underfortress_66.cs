//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Drill Ground of Confliction
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_66WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Drill Ground of Confliction to Sentry Bailey
		AddWarp("UNDERFORTRESS66_UNDERFORTRESS65", 3, From("d_underfortress_66", 1286.9, -310.5479), To("d_underfortress_65", -394, 1927));

		// Drill Ground of Confliction to Resident Quarter
		AddWarp("UNDERFORTRESS66_UNDERFORTRESS67", -86, From("d_underfortress_66", -603.3459, -85.16348), To("d_underfortress_67", 115, -1567));
	}
}
