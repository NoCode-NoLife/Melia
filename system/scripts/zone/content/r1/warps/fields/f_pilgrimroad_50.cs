//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Altar Way
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class f_pilgrimroad_50WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Altar Way to Pilgrim Path
		AddWarp("PILGRIM50_PILGRIM47", 270, From("f_pilgrimroad_50", -1933.78, -1179), To("f_pilgrimroad_47", 1900, 2263));

		// Altar Way to Forest of Prayer
		AddWarp("PILGRIM50_PILGRIM51", 70, From("f_pilgrimroad_50", 2243, -1306), To("f_pilgrimroad_51", -923, -2053));

		// Altar Way to Genar Field
		AddWarp("PILGRIM_50_TO_PILGRIM_49", -10, From("f_pilgrimroad_50", -161.1756, -725.1011), To("f_pilgrimroad_49", -98, 1160));
	}
}
