//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Laukyme Swamp
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_thorn_39_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Laukyme Swamp to Glade Hillroad
		AddWarp("THORN393_TO_THORN392", 171, From("d_thorn_39_3", 3191.466, 169.0617), To("d_thorn_39_2", -2310, 1304));

		// Laukyme Swamp to Tyla Monastery
		AddWarp("THORN393_TO_ABBEY394", 242, From("d_thorn_39_3", -1937.176, 1262.35), To("d_abbey_39_4", 1439, -1575));

		// Laukyme Swamp to Uskis Arable Land
		AddWarp("THORN393_TO_SIAULIAI462", 2, From("d_thorn_39_3", 1285.156, -2261.436), To("f_siauliai_46_2", 1251.383, 7496.382));

		// Laukyme Swamp to Mokusul Chamber
		AddWarp("THORN393_TO_CATACOMB382", 254, From("d_thorn_39_3", 74.70003, -1006.845), To("id_catacomb_38_2", 1233, -1263));
	}
}
