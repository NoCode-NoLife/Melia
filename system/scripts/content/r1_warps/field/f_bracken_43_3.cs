//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Ziburynas Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_bracken_43_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Ziburynas Forest to Phamer Forest
		AddWarp("BRACKEN433_BRACKEN432", 156, From("f_bracken_43_3", 344.6537, 1648.768), To("f_bracken_43_2", 1430, -484));

		// Ziburynas Forest to Alembique Cave
		AddWarp("BRACKEN433_LIMESTONECAVE551", 152, From("f_bracken_43_3", 2531.14, -223.4384), To("d_limestonecave_55_1", -2175, 234));

		// Ziburynas Forest to Mollogheo Forest
		AddWarp("BRACKEN433_BRACKEN434", -6, From("f_bracken_43_3", 180.6867, -1344.983), To("f_bracken_43_4", 383, 1135));
	}
}
