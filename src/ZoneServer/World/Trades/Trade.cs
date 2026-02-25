using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Items;
using Yggdrasil.Logging;

namespace Melia.Zone.World.Trades
{
	public class Trade
	{
		private readonly Dictionary<long, int> _trader1Items = new();
		private readonly Dictionary<long, int> _trader2Items = new();

		private TradeState _trader1State = TradeState.NotStarted;
		private TradeState _trader2State = TradeState.NotStarted;

		enum TradeState
		{
			NotStarted,
			Started,
			Confirmed,
			FinalConfirmed,
		}

		public long Trader1ObjectId { get; }
		public long Trader2ObjectId { get; }

		public bool IsFinished => _trader1State == TradeState.FinalConfirmed && _trader2State == TradeState.FinalConfirmed;

		public Trade(Character trader1, Character trader2)
		{
			this.Trader1ObjectId = trader1.ObjectId;
			this.Trader2ObjectId = trader2.ObjectId;
		}

		/// <summary>
		/// Offer an item to trade.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="worldId"></param>
		/// <param name="amount"></param>
		public void Offer(Character character, long worldId, int amount)
		{
			if (!this.ValidateTrader(character, worldId, amount, out var item, out var traderItems, out var trader))
				return;

			if (!traderItems.TryAdd(worldId, amount))
				traderItems[worldId] = amount;

			var otherTrader = this.GetOtherTrader(character);
			Send.ZC_EXCHANGE_OFFER_ACK(trader, true, item, amount);
			Send.ZC_EXCHANGE_OFFER_ACK(otherTrader, false, item, amount);
		}

		private Character GetOtherTrader(Character character)
		{
			var otherTraderId = character.ObjectId == this.Trader1ObjectId ? this.Trader2ObjectId : this.Trader1ObjectId;

			return ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == otherTraderId);
		}

		/// <summary>
		/// Validates trader and item offered.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="worldId"></param>
		/// <param name="amount"></param>
		/// <param name="item"></param>
		/// <param name="traderItems"></param>
		/// <param name="trader"></param>
		/// <returns></returns>
		private bool ValidateTrader(Character character, long worldId, int amount, out Item item, out Dictionary<long, int> traderItems, out Character trader)
		{
			item = null;
			traderItems = null;
			trader = null;

			if (character.ObjectId == this.Trader1ObjectId)
			{
				trader = character;
				traderItems = this._trader1Items;
			}
			else if (character.ObjectId == this.Trader2ObjectId)
			{
				trader = character;
				traderItems = this._trader2Items;
			}
			else
			{
				return false;
			}

			item = trader.Inventory.GetItem(worldId);
			if (item == null)
			{
				Log.Warning("Trade Offer: User '{0}' tried to trade a non-existent item.", trader.Connection.Account.Name);
				return false;
			}

			if (item.Amount < amount)
			{
				Log.Warning("Trade Offer: User '{0}' tried to trade more of an item than they own.", trader.Connection.Account.Name);
				return false;
			}

			if (item.IsLocked)
			{
				Log.Warning("Trade Offer: User '{0}' tried to trade a locked item.", trader.Connection.Account.Name);
				return false;
			}

			return true;
		}

		/// <summary>
		/// Check if offered items exist and have enough quantity to be traded
		/// before swapping items from inventory, returns true if trade is completed.
		/// </summary>
		private bool Finalized()
		{
			var trader1 = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == this.Trader1ObjectId);
			var trader2 = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == this.Trader2ObjectId);

			if (trader1 == null || trader2 == null)
			{
				this.Cancel();
				return false;
			}

			// --- Pre-validation step to ensure trade is still valid ---
			foreach (var offer in _trader1Items)
			{
				var item = trader1.Inventory.GetItem(offer.Key);
				if (item == null || item.Amount < offer.Value || item.IsLocked)
				{
					trader1.SystemMessage("An item in your trade offer is no longer valid. The trade has been cancelled.");
					trader2.SystemMessage("An item in the other player's trade offer is no longer valid. The trade has been cancelled.");
					this.Cancel();
					return false;
				}
			}
			foreach (var offer in _trader2Items)
			{
				var item = trader2.Inventory.GetItem(offer.Key);
				if (item == null || item.Amount < offer.Value || item.IsLocked)
				{
					trader2.SystemMessage("An item in your trade offer is no longer valid. The trade has been cancelled.");
					trader1.SystemMessage("An item in the other player's trade offer is no longer valid. The trade has been cancelled.");
					this.Cancel();
					return false;
				}
			}

			// --- Perform Transfers ---

			// Transfer items from Trader 1 to Trader 2
			foreach (var offer in this._trader1Items)
			{
				var tradedItem = trader1.Inventory.GetItem(offer.Key);
				if (tradedItem != null)
				{
					var amountToTransfer = offer.Value;

					trader1.Inventory.Remove(tradedItem, offer.Value, InventoryItemRemoveMsg.Given);

					if (amountToTransfer > 0)
					{
						var newItem = new Item(tradedItem, amountToTransfer);
						trader2.Inventory.Add(newItem, InventoryAddType.New);
					}
				}
			}

			// Transfer items from Trader 2 to Trader 1
			foreach (var offer in this._trader2Items)
			{
				var tradedItem = trader2.Inventory.GetItem(offer.Key);
				if (tradedItem != null)
				{
					var amountToTransfer = offer.Value;

					trader2.Inventory.Remove(tradedItem, offer.Value, InventoryItemRemoveMsg.Given);

					if (amountToTransfer > 0)
					{
						var newItem = new Item(tradedItem, amountToTransfer);
						trader1.Inventory.Add(newItem, InventoryAddType.New);
					}
				}
			}

			Send.ZC_EXCHANGE_SUCCESS(trader1);
			Send.ZC_EXCHANGE_SUCCESS(trader2);

			return true;
		}

		/// <summary>
		/// Start Trade
		/// </summary>
		public void Start()
		{
			this._trader1State = TradeState.Started;
			this._trader2State = TradeState.Started;
			var trader1 = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == this.Trader1ObjectId);
			var trader2 = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == this.Trader2ObjectId);

			Send.ZC_EXCHANGE_START(trader1, trader2.TeamName);
			Send.ZC_EXCHANGE_START(trader2, trader1.TeamName);
		}

		/// <summary>
		/// Cancel Trade
		/// </summary>
		public void Cancel()
		{
			var trader1 = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == this.Trader1ObjectId);
			var trader2 = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == this.Trader2ObjectId);

			if (trader1 != null)
				Send.ZC_EXCHANGE_CANCEL_ACK(trader1);
			if (trader2 != null)
				Send.ZC_EXCHANGE_CANCEL_ACK(trader2);
		}

		/// <summary>
		/// Trade offer confirmation, before final trade confirmation
		/// </summary>
		/// <param name="trader"></param>
		public void Confirm(Character trader)
		{
			var otherTrader = this.GetOtherTrader(trader);

			if (trader.ObjectId == this.Trader1ObjectId)
				this._trader1State = TradeState.Confirmed;
			else if (trader.ObjectId == this.Trader2ObjectId)
				this._trader2State = TradeState.Confirmed;

			Send.ZC_EXCHANGE_AGREE_ACK(trader, true);
			Send.ZC_EXCHANGE_AGREE_ACK(otherTrader, false);
		}

		/// <summary>
		/// Trade Final Agreement, if both players agree finalized is called.
		/// </summary>
		/// <param name="trader"></param>
		public bool FinalConfirm(Character trader)
		{
			var otherTrader = this.GetOtherTrader(trader);

			if (trader.ObjectId == this.Trader1ObjectId)
				this._trader1State = TradeState.FinalConfirmed;
			else if (trader.ObjectId == this.Trader2ObjectId)
				this._trader2State = TradeState.FinalConfirmed;

			Send.ZC_EXCHANGE_FINALAGREE_ACK(trader, true);
			Send.ZC_EXCHANGE_FINALAGREE_ACK(otherTrader, false);

			if (this._trader1State == TradeState.FinalConfirmed && this._trader2State == TradeState.FinalConfirmed)
				return this.Finalized();

			return false;
		}
	}
}
