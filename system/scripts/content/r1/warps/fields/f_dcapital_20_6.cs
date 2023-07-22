//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Jonael Commemorative Orb
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_dcapital_20_6WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Jonael Commemorative Orb to Jeromel Park
		AddWarp("DCAPITAL_20_6_TO_DCAPITAL_20_5", 4, From("f_dcapital_20_6", -450.3388, -588.2379), To("f_dcapital_20_5", 1297, -708));
	}
}
