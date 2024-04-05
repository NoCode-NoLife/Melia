using System;
using Melia.Shared.L10N;
using Melia.Shared.Scripting;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Items;
using Melia.Zone.Network;
using Yggdrasil.Util;

public class CollectionItemScripts : GeneralScript
{
	[ScriptableFunction]
	public ItemUseResult SCR_USE_COLLECTION_GET(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var collectionName = strArg;

		if (ZoneServer.Instance.Data.CollectionDb.Lookup(strArg, out var collectionData))
		{
			if (character.Collections.Add(collectionData.Id))
			{
				character.SystemMessage("GetCollection");
				Send.ZC_NORMAL.UnlockCollection(character, collectionData.Id);
				Send.ZC_ADDON_MSG(character, AddonMessage.UPDATE_READ_COLLECTION_COUNT, 0, null);

				return ItemUseResult.Okay;
			}
		}
		return ItemUseResult.Fail;
	}

	[ScriptableFunction]
	public DialogTxResult SCR_PUT_COLLECTION(Character character, DialogTxArgs args)
	{

		var collectionId = args.NumArgs[0];
		var item = args.TxItems[0].Item;

		if (character.Collections.RegisterItem(collectionId, item))
		{
			character.Inventory.Remove(item, 1, InventoryItemRemoveMsg.Destroyed);
			Send.ZC_NORMAL.UpdateCollection(character, collectionId, item.Id);
			return DialogTxResult.Okay;
		}

		return DialogTxResult.Fail;
	}
}
