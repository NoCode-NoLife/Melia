//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Saalus Convent
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class c_nunneryWarpsScript : GeneralScript
{
	public override void Load()
	{
		// Saalus Convent to Pilgrim Path
		AddWarp("NUNNERY_PILGRIM47", 90, From("c_nunnery", 591, 146), To("f_pilgrimroad_47", -1124, 1360));
	}
}
