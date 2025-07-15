//--- Melia Script ----------------------------------------------------------
// Miscellanous Item Scripts
//--- Description -----------------------------------------------------------
// Item scripts that don't require dedicated files.
//---------------------------------------------------------------------------

using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

public class MiscItemScripts : GeneralScript
{
	[ScriptableFunction]
	public ItemUseResult SCR_UES_ITEM_BOOK(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var bookName = strArg;
		Send.ZC_NORMAL.OpenBook(character, bookName);

		return ItemUseResult.OkayNotConsumed;
	}
}
