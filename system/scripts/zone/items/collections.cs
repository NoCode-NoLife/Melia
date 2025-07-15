//--- Melia Script ----------------------------------------------------------
// Collection Item Scripts
//--- Description -----------------------------------------------------------
// Scripts that handle item-collection related actions, such as registering
// a new item to a collection.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events.Arguments;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

public class CollectionItemScripts : GeneralScript
{
	[ScriptableFunction]
	public ItemUseResult SCR_USE_COLLECTION_GET(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var collectionName = strArg;

		if (ZoneServer.Instance.Data.CollectionDb.TryFindByClassName(collectionName, out var collectionData))
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

		if (character.Collections.RegisterItem(collectionId, item.Id))
		{
			character.Inventory.Remove(item, 1, InventoryItemRemoveMsg.Destroyed);

			// This is necessary for the collection to go through on the front end
			Send.ZC_ITEM_INVENTORY_DIVISION_LIST(character);
			Send.ZC_NORMAL.UpdateCollection(character, collectionId, item.Id);

			return DialogTxResult.Okay;
		}

		return DialogTxResult.Fail;
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		// Give rewards for collections to the character, in case there
		// are some they didn't get yet. This needs to be done on login,
		// but after the character, account, and connection were set up,
		// in case we need them.
		e.Character.Collections.GrantEligibleRewards();
	}
}
