//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Royal Mausoleum Storage
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_59_3WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Royal Mausoleum Storage to Royal Mausoleum Constructors' Chapel
		AddWarp("UNDERF593_TO_UNDERF592", 270, From("d_underfortress_59_3", -1688.722, -1199.876), To("d_underfortress_59_2", 201, 264));
	}
}
