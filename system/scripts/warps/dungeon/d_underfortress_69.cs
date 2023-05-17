//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Fortress Battlegrounds
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_69WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Fortress Battlegrounds to Storage Quarter
		AddWarp("UNDERFORTRESS69_UNDERFORTRESS68", 104, From("d_underfortress_69", 2245.019, 24.88506), To("d_underfortress_68", 1785, 1726));
	}
}
