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
	[ScriptableFunction]
	public ItemUseResult SCR_USE_ITEM_EXPCARD(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var baseExp = (long)numArg1;
		var classExp = (long)(baseExp * 0.77f);

		character.GiveExp(baseExp, classExp, null);
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
			var classExp = (long)(baseExp * 0.77f);

			baseExp *= amount;
			classExp *= amount;

			character.GiveExp(baseExp, classExp, null);
			character.SystemMessage("GetExp{CHAR}{JOB}", new MsgParameter("CHAR", baseExp), new MsgParameter("JOB", classExp));

			character.Inventory.Remove(item, amount, InventoryItemRemoveMsg.Used);
		}

		character.PlayEffect("F_sys_expcard_normal");

		return DialogTxResult.Okay;
	}
}
