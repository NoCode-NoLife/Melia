//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Gate Route
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_thorn_19WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Gate Route to Spring Light Woods
		AddWarp("THORN19_SIAULIAI46_1", 225, From("d_thorn_19", 215, 3115), To("f_siauliai_46_1", -689, -1872));

		// Gate Route to Septyni Glen
		AddWarp("THORN19_HUEVILLAGE58_4", 259, From("d_thorn_19", -286, -3924), To("f_huevillage_58_4", 991, 1194));

		// Gate Route to Sirdgela Forest
		AddWarp("THORN19_THORN20", -79, From("d_thorn_19", 1980.25, -1018.94), To("d_thorn_20", -1441, -1879));
	}
}
