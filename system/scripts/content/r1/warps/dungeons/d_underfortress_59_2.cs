//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Royal Mausoleum Constructors' Chapel
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_underfortress_59_2WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Royal Mausoleum Constructors' Chapel to Royal Mausoleum Storage
		AddWarp("UNDERF592_TO_UNDERF593", 270, From("d_underfortress_59_2", -40.84153, 281.1239), To("d_underfortress_59_3", -1289, -1209));

		// Royal Mausoleum Constructors' Chapel to Royal Mausoleum Workers Lodge
		AddWarp("UNDERF592_TO_UNDERF591", 93, From("d_underfortress_59_2", 456.9549, -386.4884), To("d_underfortress_59_1", 581, 236));
	}
}
