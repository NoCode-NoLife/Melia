//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Maven Abbey
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_abbey_41_6WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Maven Abbey to Rasvoy Lake
		AddWarp("ABBEY41_6_PILGRIM41_3", 270, From("d_abbey_41_6", -891.887, -1429.553), To("f_pilgrimroad_41_3", 181, -1014));
	}
}
