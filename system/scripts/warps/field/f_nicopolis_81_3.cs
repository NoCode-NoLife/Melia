//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Spell Tome Town
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_nicopolis_81_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Spell Tome Town to Feline Post Town
		AddWarp("NICO813_NICO812", 90, From("f_nicopolis_81_3", 2914.409, 1168.289), To("f_nicopolis_81_2", -2405, -993));
	}
}
