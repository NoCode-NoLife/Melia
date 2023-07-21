//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Mullers Passage
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class p_catacomb_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Mullers Passage to Pilgrim Path
		AddWarp("PCATACOMB1_PILGRIM47", 180, From("p_catacomb_1", 19, 1161), To("f_pilgrimroad_47", 2075, -629));

		// Mullers Passage to Rukas Plateau
		AddWarp("PCATACOMB1_ROKAS29", 360, From("p_catacomb_1", 21, -1146), To("f_rokas_29", -2004, 1489));
	}
}
