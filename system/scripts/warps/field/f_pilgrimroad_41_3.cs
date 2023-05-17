//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Rasvoy Lake
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_41_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Rasvoy Lake to Salvia Forest
		AddWarp("PILGRIM41_3_PILGRIM41_2", -88, From("f_pilgrimroad_41_3", -1543.187, 687.9524), To("f_pilgrimroad_41_2", 1890, -985));

		// Rasvoy Lake to Ouaas Memorial
		AddWarp("PILGRIM41_3_PILGRIM41_5", -2, From("f_pilgrimroad_41_3", -1064.135, -1412.153), To("f_pilgrimroad_41_5", -1762, 506));

		// Rasvoy Lake to Maven Abbey
		AddWarp("PILGRIM41_3_ABBEY41_6", 79, From("f_pilgrimroad_41_3", 304.7036, -1040.122), To("d_abbey_41_6", -795, -1426));
	}
}
