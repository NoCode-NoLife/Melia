using System;
using System.Collections.Generic;
using System.Globalization;
using Melia.Shared.Network;
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
			// Commands sent by the client
			this.Add("requpdateequip", "", "", this.HandleReqUpdateEquip);
			this.Add("buyabilpoint", "<amount>", "", this.HandleBuyAbilPoint);

			// Custom (Client Scripting)
			this.Add("buyshop", "", "", this.HandleBuyShop);
			this.Add("updatemouse", "", "", this.HandleUpdateMouse);
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

		/// <summary>
		/// Opens buy-in shop creation window or creates shop based on
		/// arguments.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleBuyShop(Character character, string message, string command, Arguments args)
		{
			if (args.Count == 0)
			{
				Send.ZC_EXEC_CLIENT_SCP(character.Connection, "OPEN_PERSONAL_SHOP_REGISTER()");
				return CommandResult.Okay;
			}

			if (args.Count < 2)
			{
				Log.Debug("HandleBuyShop: Not enough arguments.");
				return CommandResult.Okay;
			}

			// Read arguments
			var title = args.Get(0);
			var items = new List<Tuple<int, int, int>>();

			for (var i = 2; i < args.Count; ++i)
			{
				var split = args.Get(i).Split(',');

				if (split.Length != 3 || !int.TryParse(split[0], out var id) || !int.TryParse(split[1], out var amount) || !int.TryParse(split[2], out var price))
				{
					Log.Debug("HandleBuyShop: Invalid argument '{0}'.", args.Get(i));
					return CommandResult.Okay;
				}

				items.Add(new Tuple<int, int, int>(id, amount, price));
			}

			// Create auto seller packet from arguments and have the
			// channel handle it as if the client had sent it.
			var packet = new Packet(Op.CZ_REGISTER_AUTOSELLER);
			packet.PutString(title, 64);
			packet.PutInt(items.Count);
			packet.PutInt(270065); // PersonalShop
			packet.PutInt(0);

			foreach (var item in items)
			{
				packet.PutInt(item.Item1);
				packet.PutInt(item.Item2);
				packet.PutInt(item.Item3);
				packet.PutEmptyBin(264);
			}

			ZoneServer.Instance.PacketHandler.Handle(character.Connection, packet);

			return CommandResult.Okay;
		}

		/// <summary>
		/// Updates the character's mouse position variables.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private CommandResult HandleUpdateMouse(Character character, string message, string command, Arguments args)
		{
			character.Variables.Temp.SetFloat("MouseX", float.Parse(args.Get(0), CultureInfo.InvariantCulture));
			character.Variables.Temp.SetFloat("MouseY", float.Parse(args.Get(1), CultureInfo.InvariantCulture));
			character.Variables.Temp.SetFloat("ScreenWidth", float.Parse(args.Get(2), CultureInfo.InvariantCulture));
			character.Variables.Temp.SetFloat("ScreenHeight", float.Parse(args.Get(3), CultureInfo.InvariantCulture));

			return CommandResult.Okay;
		}
	}
}
