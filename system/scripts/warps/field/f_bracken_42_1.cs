//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Khonot Forest
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_bracken_42_1WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Khonot Forest to Salvia Forest
		AddWarp("BRACKEN42_1_TO_PILGRIM41_2", -24, From("f_bracken_42_1", -1014.497, -700.0676), To("f_pilgrimroad_41_2", 123, 1540));

		// Khonot Forest to Lemprasa Pond
		AddWarp("BRACKEN42_1_TO_EP13_F_SIAULIAI_1", 181, From("f_bracken_42_1", 83.4843, 1045.963), To("ep13_f_siauliai_1", -462, 1846));

		// Khonot Forest to Khamadon Forest
		AddWarp("BRACKEN42_1_TO_BRACKEN42_2", 79, From("f_bracken_42_1", 2084.651, -198.6541), To("f_bracken_42_2", -1666, 163));

		// Khonot Forest to Tevhrin Stalactite Cave Section 1
		AddWarp("BRACKEN42_1_TO_LIMESTONECAVE52_1", 245, From("f_bracken_42_1", -1597.763, 222.3342), To("d_limestonecave_52_1", 212, -1104));
	}
}
