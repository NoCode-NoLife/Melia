//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Outer Wall District 11
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_castle_93WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Outer Wall District 11 to Barynwell 87 Waters
		AddWarp("F_CASTLE_93_TO_F_3CMLAKE_87", 110, From("f_castle_93", 1211.465, 64.41367), To("f_3cmlake_87", -1284, 90));

		// Outer Wall District 11 to Inner Wall District 10
		AddWarp("F_CASTLE_93_TO_F_CASTLE_94", -90, From("f_castle_93", -2869.648, -219.702), To("f_castle_94", 1415, 1005));

		// Outer Wall District 11 to Outer Wall District 9
		AddWarp("F_CASTLE_93_TO_F_CASTLE_20_1", 208, From("f_castle_93", 507.2914, -920.1061), To("f_castle_20_1", 1113, 422));
	}
}
