//--- Melia Script ----------------------------------------------------------
// DOT Buff Items
//--- Description -----------------------------------------------------------
// Item scripts that heal or damage over time.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

public class DotBuffItemScript : GeneralScript
{
	[ScriptableFunction]
	public ItemUseResult SCR_USE_ITEM_DotBuff(Character character, Item item, string buffName, float numArg1, float numArg2)
	{
		character.Buffs.Start(buffName, numArg1, numArg2, TimeSpan.FromSeconds(15));
		return ItemUseResult.Okay;
	}
}
