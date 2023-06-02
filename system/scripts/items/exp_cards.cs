//--- Melia Script ----------------------------------------------------------
// EXP Card Items
//--- Description -----------------------------------------------------------
// Item-related scripts that grant the user experience points.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

public class ExpCardScripts : GeneralScript
{
	[ItemScript("SCR_USE_ITEM_EXPCARD")]
	public ItemUseResult SCR_USE_ITEM_EXPCARD(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var baseExp = (long)numArg1;
		var classExp = (long)(baseExp * 0.77f);

		character.GiveExp(baseExp, classExp, null);
		character.PlayEffect("F_sys_expcard_normal");

		return ItemUseResult.Okay;
	}

	[DialogTxScript("MULTIPLE_USE_XPCARD")]
	public DialogTxResult TxItemScriptFunc(Character character, DialogTxArgs args)
	{
		foreach (var txItem in args.TxItems)
		{
			var item = txItem.Item;
			var amount = txItem.Amount;

			if (item.Data.Script.StrArg != "XpCard")
				throw new ArgumentException($"Item '{item.Id}' is not an EXP card.");

			var numArg1 = item.Data.Script.NumArg1;
			var baseExp = (long)numArg1;
			var classExp = (long)(baseExp * 0.77f);

			baseExp *= amount;
			classExp *= amount;

			character.GiveExp(baseExp, classExp, null);
			Send.ZC_SYSTEM_MSG(character, 2230, new MsgParameter("CHAR", baseExp.ToString()), new MsgParameter("JOB", classExp.ToString()));

			character.Inventory.Remove(item, amount, InventoryItemRemoveMsg.Used);
		}

		character.PlayEffect("F_sys_expcard_normal");

		return DialogTxResult.Okay;
	}
}
