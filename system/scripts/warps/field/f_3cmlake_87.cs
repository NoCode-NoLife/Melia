//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Barynwell 87 Waters
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_3cmlake_87WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Barynwell 87 Waters to Barynwell 86 Waters
		AddWarp("F_3CMLAKE_87_TO_F_3CMLAKE_86", -46, From("f_3cmlake_87", -400.7808, -1716.368), To("f_3cmlake_86", 1683, 887));

		// Barynwell 87 Waters to Astral Tower 1F
		AddWarp("F_3CMLAKE_87_TO_D_STARTOWER_88", 180, From("f_3cmlake_87", -46.00846, 2327.865), To("d_startower_88", 2359, 1688));

		// Barynwell 87 Waters to Barynwell 27 Waters
		AddWarp("F_3CMLAKE_87_TO_F_3CMLAKE_27_1", 75, From("f_3cmlake_87", 1958.015, -838.8867), To("f_3cmlake_27_1", -169, -1406));

		// Barynwell 87 Waters to Outer Wall District 11
		AddWarp("F_3CMLAKE_87_TO_F_CASTLE_93", -70, From("f_3cmlake_87", -1349.675, 70.23941), To("f_castle_93", 1138, 43));
	}
}
