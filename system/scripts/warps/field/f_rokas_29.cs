//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Rukas Plateau
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_rokas_29WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Rukas Plateau to Tiltas Valley
		AddWarp("ROKAS29_ROKAS28", 120, From("f_rokas_29", 2612, 819), To("f_rokas_28", -1785, -587));

		// Rukas Plateau to King's Plateau
		AddWarp("ROKAS29_ROKAS30", -62, From("f_rokas_29", -1413, -2079), To("f_rokas_30", 979, -1036));

		// Rukas Plateau to Mullers Passage
		AddWarp("ROKAS29_PCATACOMB1", 180, From("f_rokas_29", -2114, 1614), To("p_catacomb_1", 21, -1037));
	}
}
