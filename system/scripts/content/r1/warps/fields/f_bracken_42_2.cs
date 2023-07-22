//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Khamadon Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_bracken_42_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Khamadon Forest to Khonot Forest
		AddWarp("BRACKEN42_2_TO_BRACKEN42_1", 257, From("f_bracken_42_2", -1735.163, 231.7298), To("f_bracken_42_1", 2024, -214));
	}
}
