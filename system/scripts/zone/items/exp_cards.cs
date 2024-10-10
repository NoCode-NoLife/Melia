//--- Melia Script ----------------------------------------------------------
// EXP Card Items
//--- Description -----------------------------------------------------------
// Item-related scripts that grant the user experience points.
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Items;

public class ExpCardScripts : GeneralScript
{
	[ScriptableFunction]
	public ItemUseResult SCR_USE_ITEM_EXPCARD(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var baseExp = (long)numArg1;
		var jobExp = (long)(baseExp * 0.77f);

		character.GiveExp(baseExp, jobExp, null);
		character.PlayEffect("F_sys_expcard_normal");

		return ItemUseResult.Okay;
	}

	[ScriptableFunction]
	public DialogTxResult MULTIPLE_USE_XPCARD(Character character, DialogTxArgs args)
	{
		foreach (var txItem in args.TxItems)
		{
			var item = txItem.Item;
			var amount = txItem.Amount;

			if (item.Data.Script.StrArg != "XpCard")
				throw new ArgumentException($"Item '{item.Id}' is not an EXP card.");

			var numArg1 = item.Data.Script.NumArg1;
			var baseExp = (long)numArg1;
			var jobExp = (long)(baseExp * 0.77f);

			baseExp *= amount;
			jobExp *= amount;

			character.GiveExp(baseExp, jobExp, null);
			character.SystemMessage("GetExp{CHAR}{JOB}", new MsgParameter("CHAR", baseExp), new MsgParameter("JOB", jobExp));

			character.Inventory.Remove(item, amount, InventoryItemRemoveMsg.Used);
		}

		character.PlayEffect("F_sys_expcard_normal");

		return DialogTxResult.Okay;
	}

	[ScriptableFunction]
	public static DialogTxResult SCR_ITEM_EXP_UP(Character character, DialogTxArgs args)
	{
		if (args.TxItems.Length < 2)
		{
			Send.ZC_ADDON_MSG(character, AddonMessage.ITEM_EXP_STOP);
			return DialogTxResult.Fail;
		}

		if (!character.IsSitting)
		{
			character.SystemMessage("AvailableOnlyWhileResting");
			return DialogTxResult.Fail;
		}

		var targetItem = args.TxItems[0].Item;
		var tgtGroup = targetItem.Data.Group;
		var tgtEquipXpGroup = targetItem.Data.EquipExpGroup;

		if (tgtEquipXpGroup == EquipExpGroup.None)
		{
			Send.ZC_ADDON_MSG(character, AddonMessage.ITEM_EXP_STOP);
			return DialogTxResult.Fail;
		}

		foreach (var txItem in args.TxItems)
		{
			if (txItem.Item.IsExpired)
			{
				character.SystemMessage("CannotUseLifeTimeOverItem");
				return DialogTxResult.Fail;
			}
		}

		var synthesisTime = 5;
		Send.ZC_ADDON_MSG(character, AddonMessage.ITEM_EXP_START, synthesisTime, "");
		Send.ZC_CANCEL_MOUSE_MOVE(character);

		if (!character.Components.TryGet<TimeActionComponent>(out var timeAction))
			return DialogTxResult.Fail;

		var timeActionResult = timeAction.StartAsync("ItemCraftProcess", "None", "UPGRADEGEM", TimeSpan.FromSeconds(synthesisTime)).Result;

		if (timeActionResult != TimeActionResult.Completed || args.TxItems == null || args.TxItems.Length < 2 || targetItem.IsLocked)
		{
			Send.ZC_ADDON_MSG(character, AddonMessage.ITEM_EXP_STOP);
			return DialogTxResult.Fail;
		}

		var beforeItemExp = (int)targetItem.Properties.GetFloat(PropertyName.ItemExp);
		var totalPoint = 0;

		foreach (var txItem in args.TxItems.Skip(1))
		{
			var materialItem = txItem.Item;
			var materialItemCount = txItem.Amount;

			if (targetItem.ObjectId == materialItem.ObjectId || materialItem.IsLocked)
				return DialogTxResult.Fail;
			if (targetItem.IsExpired || materialItem.IsExpired)
				return DialogTxResult.Fail;

			var exp = ZoneServer.Instance.Data.ItemExpDb.GetGainExp(materialItem.Data.EquipExpGroup);
			totalPoint += materialItemCount * exp;

			character.Inventory.Remove(materialItem, materialItemCount, InventoryItemRemoveMsg.Given);
		}

		var multiplier = 1;
		var totalExp = totalPoint * multiplier;
		var totalLevel = ZoneServer.Instance.Data.ItemExpDb.GetLevel(targetItem.Data.EquipExpGroup, beforeItemExp + totalExp);

		if (tgtGroup == ItemGroup.Card)
			targetItem.Properties.SetFloat(PropertyName.CardLevel, totalLevel);
		else if (tgtGroup == ItemGroup.Gem)
			targetItem.Properties.SetFloat(PropertyName.Level, totalLevel);


		targetItem.Properties.SetFloat(PropertyName.ItemExp, totalExp);

		Send.ZC_ADDON_MSG(character, AddonMessage.ITEM_EXPUP_END, totalPoint, multiplier.ToString());
		Send.ZC_OBJECT_PROPERTY(character.Connection, targetItem);
		character.Properties.InvalidateAll();

		return DialogTxResult.Okay;
	}
}
