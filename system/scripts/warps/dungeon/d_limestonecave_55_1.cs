//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Alembique Cave
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_limestonecave_55_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Alembique Cave to Ziburynas Forest
		AddWarp("LSCAVE551_TO_BRACKEN433", 187, From("d_limestonecave_55_1", -2235.26, 355.2), To("f_bracken_43_3", 2523, -291));
	}
}
