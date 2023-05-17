//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Ouaas Memorial
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_41_5WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Ouaas Memorial to Rasvoy Lake
		AddWarp("PILGRIM41_5_PILGRIM41_3", -89, From("f_pilgrimroad_41_5", -1941.114, 576.4455), To("f_pilgrimroad_41_3", -1064, -1280));
	}
}
