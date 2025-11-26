using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Trades;
using Yggdrasil.Logging;

namespace Melia.Zone.World
{
	/// <summary>
	/// Manages active player-to-player trades.
	/// </summary>
	public class TradeManager
	{
		/// <summary>
		/// Trades indexed by character ObjectId.
		/// </summary>
		private readonly Dictionary<long, Trade> _trades = new Dictionary<long, Trade>();

		/// <summary>
		/// Returns true if the character is currently in a trade.
		/// </summary>
		/// <param name="characterObjectId"></param>
		/// <returns></returns>
		public bool IsTrading(long characterObjectId) => _trades.ContainsKey(characterObjectId);

		/// <summary>
		/// Sends a trade request between two characters, the sender and recipient.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="recipient"></param>
		public void RequestTrade(Character sender, Character recipient)
		{
			if (sender.IsTrading || recipient.IsTrading)
				return;
			var trade = new Trade(sender, recipient);

			lock (_trades)
			{
				if (!_trades.TryAdd(sender.ObjectId, trade))
					return;
				if (!_trades.TryAdd(recipient.ObjectId, trade))
				{
					_trades.Remove(sender.ObjectId);
					return;
				}
			}

			Send.ZC_EXCHANGE_REQUEST_ACK(sender);
			Send.ZC_EXCHANGE_REQUEST_RECEIVED(recipient, sender.Name);
		}

		/// <summary>
		/// Starts the trade session, opening the trade window for both traders.
		/// </summary>
		/// <param name="character"></param>
		public void StartTrade(Character character)
		{
			if (!_trades.TryGetValue(character.ObjectId, out var trade))
			{
				Log.Warning("TradeManager: User {0} tried to start a non-existent trade.", character.Connection.Account.Name);
				return;
			}

			trade.Start();
		}

		/// <summary>
		/// Cancels the trade and removes it from active trades.
		/// </summary>
		/// <param name="character"></param>
		public void CancelTrade(Character character)
		{
			if (!character.IsTrading)
				return;
			if (!_trades.TryGetValue(character.ObjectId, out var trade))
			{
				Log.Warning("TradeManager: User {0} tried to cancel a non-existent trade.", character.Connection.Account.Name);
				return;
			}

			trade.Cancel();

			lock (_trades)
			{
				_trades.Remove(trade.Trader1ObjectId);
				_trades.Remove(trade.Trader2ObjectId);
			}
		}

		/// <summary>
		/// Offers an item to the trade partner.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="worldId"></param>
		/// <param name="amount"></param>
		public void OfferTradeItem(Character character, long worldId, int amount)
		{
			if (!_trades.TryGetValue(character.ObjectId, out var trade))
			{
				Log.Warning("TradeManager: User {0} tried to offer a non-existent trade.", character.Connection.Account.Name);
				return;
			}

			trade.Offer(character, worldId, amount);
		}

		/// <summary>
		/// Confirms the current trade offer (first confirmation).
		/// </summary>
		/// <param name="character"></param>
		public void ConfirmTrade(Character character)
		{
			if (!_trades.TryGetValue(character.ObjectId, out var trade))
			{
				Log.Warning("TradeManager: User {0} tried to confirm a non-existent trade.", character.Connection.Account.Name);
				return;
			}

			trade.Confirm(character);
		}

		/// <summary>
		/// Final confirmation to complete the trade.
		/// </summary>
		/// <param name="character"></param>
		public void FinalConfirmTrade(Character character)
		{
			if (!_trades.TryGetValue(character.ObjectId, out var trade))
			{
				Log.Warning("TradeManager: User {0} tried to final confirm a non-existent trade.", character.Connection.Account.Name);
				return;
			}

			if (trade.FinalConfirm(character))
				this.FinishTrade(character);
		}

		/// <summary>
		/// Removes the completed trade from active trades.
		/// </summary>
		/// <param name="character"></param>
		public void FinishTrade(Character character)
		{
			if (!_trades.TryGetValue(character.ObjectId, out var trade))
			{
				Log.Warning("TradeManager: User {0} tried to finish trade a non-existent trade.", character.Connection.Account.Name);
				return;
			}

			if (trade.IsFinished)
			{
				lock (_trades)
				{
					_trades.Remove(trade.Trader1ObjectId);
					_trades.Remove(trade.Trader2ObjectId);
				}
			}
		}
	}
}
