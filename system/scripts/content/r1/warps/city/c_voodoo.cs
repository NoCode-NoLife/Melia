//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Bokor Master's Home
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class c_voodooWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Bokor Master's Home to Klaipeda
		AddWarp("WS_BOCORS_KLAPEDA", 20, From("c_voodoo", 43, -129), To("c_Klaipe", -939, -527));
	}
}
