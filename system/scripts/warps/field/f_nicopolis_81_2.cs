//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Feline Post Town
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_nicopolis_81_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Feline Post Town to Starry Town
		AddWarp("NICO812_NICO811", -25, From("f_nicopolis_81_2", 1650.421, -1984.765), To("f_nicopolis_81_1", -1630, 714));

		// Feline Post Town to Spell Tome Town
		AddWarp("NICO812_NICO813", 261, From("f_nicopolis_81_2", -2474.083, -993.7436), To("f_nicopolis_81_3", -1061, 616));
	}
}
