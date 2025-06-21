﻿//--- Melia Script ----------------------------------------------------------
// Trade Select Item
//--- Description -----------------------------------------------------------
// Item scripts that handle boxes that let you select items, such as
// growth equip boxes.
//---------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.RegularExpressions;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;

public class TradeSelectItemScript : GeneralScript
{
	[ScriptableFunction]
	public NormalTxResult SCR_TX_TRADE_SELECT_ITEM_RANOPT(Character character, string strArg)
	{
		// The selection information comes in the format "itemId#selectionIndex",
		// where the item id is the object id of the box item and the selection
		// index a value between 1 and the max amount of items.

		var match = StrArgRegex.Match(strArg);
		if (!match.Success)
		{
			Log.Warning("SCR_TX_TRADE_SELECT_ITEM_RANOPT: Invalid string argument '{0}'.", strArg);
			return NormalTxResult.Fail;
		}

		if (!long.TryParse(match.Groups["itemId"].Value, out var itemObjectId))
		{
			Log.Warning("SCR_TX_TRADE_SELECT_ITEM_RANOPT: Invalid item id '{0}'.", match.Groups["itemId"].Value);
			return NormalTxResult.Fail;
		}

		if (!int.TryParse(match.Groups["selectionIndex"].Value, out var selectionIndex))
		{
			Log.Warning("SCR_TX_TRADE_SELECT_ITEM_RANOPT: Invalid selection index '{0}'.", match.Groups["selectionIndex"].Value);
			return NormalTxResult.Fail;
		}

		var item = character.Inventory.GetItem(itemObjectId);
		if (item == null)
		{
			Log.Warning("SCR_TX_TRADE_SELECT_ITEM_RANOPT: User '{0}' tried to use a non-existant item.", character.Username);
			return NormalTxResult.Fail;
		}

		if (!BoxItems.TryGetValue(item.Id, out var itemList))
		{
			Log.Warning("SCR_TX_TRADE_SELECT_ITEM_RANOPT: No item list for item {0}.", item.Id);
			return NormalTxResult.Fail;
		}

		if (selectionIndex < 1 || selectionIndex > itemList.Length)
		{
			Log.Warning("SCR_TX_TRADE_SELECT_ITEM_RANOPT: Invalid item selection for {0}.", item.Id);
			return NormalTxResult.Fail;
		}

		var itemId = itemList[selectionIndex - 1];
		character.Inventory.Add(itemId, 1, InventoryAddType.PickUp);

		character.Inventory.Remove(item, 1, InventoryItemRemoveMsg.Used);

		return NormalTxResult.Okay;
	}

	private readonly static Regex StrArgRegex = new(@"^(?<itemId>[0-9]+)#(?<selectionIndex>[0-9]+)$");

	// This information can be found in the client, where it's a database
	// instead. We might want to do that as well... but then again, a script
	// is way more flexible and I don't feel like adding another database
	// right now =)

	private readonly static Dictionary<int, int[]> BoxItems = new()
	{
		[ItemId.Select_Growth_Sword_Weapon] = [ItemId.GROWTH_REINFORCE_TIER1_SWORD, ItemId.GROWTH_REINFORCE_TIER1_THSWORD, ItemId.GROWTH_REINFORCE_TIER1_SPEAR, ItemId.GROWTH_REINFORCE_TIER1_THSPEAR, ItemId.GROWTH_REINFORCE_TIER1_RAPIER],
		[ItemId.Select_Growth_Sword_SubWeapon] = [ItemId.GROWTH_REINFORCE_TIER1_SHIELD, ItemId.GROWTH_REINFORCE_TIER1_TRINKET],
		[ItemId.Select_Growth_Wizard_Weapon] = [ItemId.GROWTH_REINFORCE_TIER1_STAFF, ItemId.GROWTH_REINFORCE_TIER1_THSTAFF],
		[ItemId.Select_Growth_Wizard_SubWeapon] = [ItemId.GROWTH_REINFORCE_TIER1_SHIELD, ItemId.GROWTH_REINFORCE_TIER1_TRINKET],
		[ItemId.Select_Growth_Archer_Weapon] = [ItemId.GROWTH_REINFORCE_TIER1_THBOW, ItemId.GROWTH_REINFORCE_TIER1_BOW, ItemId.GROWTH_REINFORCE_TIER1_CANNON, ItemId.GROWTH_REINFORCE_TIER1_MUSKET],
		[ItemId.Select_Growth_Archer_SubWeapon] = [ItemId.GROWTH_REINFORCE_TIER1_SHIELD, ItemId.GROWTH_REINFORCE_TIER1_DAGGER, ItemId.GROWTH_REINFORCE_TIER1_TRINKET],
		[ItemId.Select_Growth_Cleric_Weapon] = [ItemId.GROWTH_REINFORCE_TIER1_MACE, ItemId.GROWTH_REINFORCE_TIER1_THMACE],
		[ItemId.Select_Growth_Cleric_SubWeapon] = [ItemId.GROWTH_REINFORCE_TIER1_SHIELD, ItemId.GROWTH_REINFORCE_TIER1_TRINKET],
		[ItemId.Select_Growth_Scout_Weapon] = [ItemId.GROWTH_REINFORCE_TIER1_DAGGER, ItemId.GROWTH_REINFORCE_TIER1_PISTOL],
		[ItemId.Select_Growth_Scout_SubWeapon] = [ItemId.GROWTH_REINFORCE_TIER1_SWORD, ItemId.GROWTH_REINFORCE_TIER1_SHIELD],
	};
}
