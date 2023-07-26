using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;

namespace Melia.Zone.Commands
{
	/// <summary>
	/// The dedicated chat command manager for chat commands sent by clients
	/// (usually from from behind the scenes).
	/// </summary>
	public partial class ClientChatCommands : CommandManager<ClientChatCommand, ClientChatCommandFunc>
	{
		/// <summary>
		/// Initializes commands.
		/// </summary>
		public ClientChatCommands()
		{
			this.Add("requpdateequip", "", "", this.HandleReqUpdateEquip);
			this.Add("buyabilpoint", "<amount>", "", this.HandleBuyAbilPoint);
		}

		/// <summary>
		/// Official slash command, purpose unknown.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleReqUpdateEquip(Character character, string message, string command, Arguments args)
		{
			// Command is sent when the inventory is opened, purpose unknown,
			// officials don't seem to send anything back.

			// Comment in the client's Lua files:
			//   내구도 회복 유료템 때문에 정확한 값을 지금 알아야 함.
			//   (Durability recovery Due to the paid system, you need to know the correct value now.)

			return CommandResult.Okay;
		}

		/// <summary>
		/// Official slash command, exchanges silver for ability points.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleBuyAbilPoint(Character character, string message, string command, Arguments args)
		{
			if (args.Count < 0)
			{
				Log.Warning("HandleBuyAbilPoint: No amount given by user '{0}'.", character.Connection.Account.Name);
				return CommandResult.Okay;
			}

			if (!int.TryParse(args.Get(0), out var amount))
			{
				Log.Warning("HandleBuyAbilPoint: Invalid amount '{0}' by user '{1}'.", amount, character.Connection.Account.Name);
				return CommandResult.Okay;
			}

			var costPerPoint = ZoneServer.Instance.Conf.World.AbilityPointCost;
			var totalCost = (amount * costPerPoint);
			var silver = character.Inventory.CountItem(ItemId.Silver);
			if (silver < totalCost)
			{
				Log.Warning("HandleBuyAbilPoint: User '{0}' didn't have enough money.", character.Connection.Account.Name);
				return CommandResult.Okay;
			}

			character.Inventory.Remove(ItemId.Silver, totalCost, InventoryItemRemoveMsg.Given);
			character.ModifyAbilityPoints(amount);

			Send.ZC_ADDON_MSG(character, AddonMessage.SUCCESS_BUY_ABILITY_POINT, 0, "BLANK");

			return CommandResult.Okay;
		}
	}
}
