//--- Melia Script ----------------------------------------------------------
// Special Class Vouchers
//--- Description -----------------------------------------------------------
// Item scripts that handle unlocking special classes via vouchers.
//---------------------------------------------------------------------------

using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

public class SpecialClassVouchersItemScript : GeneralScript
{
	[ScriptableFunction]
	public ItemUseResult SCR_USE_UnlockQuest_JobUnlock(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var jobClassName = strArg;
		var propertyName = "UnlockQuest_" + jobClassName;

		character.Connection.Account.Properties.SetFloat(propertyName, 1);
		Send.ZC_NORMAL.AccountProperties(character);

		return ItemUseResult.Okay;
	}
}
