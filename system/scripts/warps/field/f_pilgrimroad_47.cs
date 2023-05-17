//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Pilgrim Path
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_47WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Pilgrim Path to Starving Demon's Way
		AddWarp("PILGRIM47_PILGRIM46", -53, From("f_pilgrimroad_47", -2462, -2202), To("f_pilgrimroad_46", 611, 1571));

		// Pilgrim Path to Altar Way
		AddWarp("PILGRIM47_PILGRIM50", 115, From("f_pilgrimroad_47", 2037, 2357), To("f_pilgrimroad_50", -1743, -1170));

		// Pilgrim Path to Mullers Passage
		AddWarp("PILGRIM47_PCATACOMB1", 90, From("f_pilgrimroad_47", 2209, -586), To("p_catacomb_1", 21, 1028));

		// Pilgrim Path to Saalus Convent
		AddWarp("PILGRIM47_NUNNERY", 180, From("f_pilgrimroad_47", -1135, 1471), To("c_nunnery", 490, 151));

		// Pilgrim Path to Genar Field
		AddWarp("PILGRIM_47_TO_PILGRIM_49", 43, From("f_pilgrimroad_47", 1361.23, -1354.494), To("f_pilgrimroad_49", -2223, -577));
	}
}
