using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests.Rewards
{
	/// <summary>
	/// A reward that gives items to the player.
	/// </summary>
	public class ItemReward : QuestReward
	{
		/// <summary>
		/// Returns the id of the item this reward gives.
		/// </summary>
		public int ItemClassId { get; }

		/// <summary>
		/// Returns the english name of the item.
		/// </summary>
		public string ItemName { get; }

		/// <summary>
		/// Returns the amount of the item that is given.
		/// </summary>
		public int Amount { get; }

		/// <summary>
		/// Returns the icon to display for this reward.
		/// </summary>
		public override string Icon => "Item:" + this.ItemClassId;

		/// <summary>
		/// Creates a quest reward for an item.
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="amount"></param>
		public ItemReward(int itemId, int amount = 1)
		{
			this.ItemClassId = itemId;
			this.Amount = amount;

			if (!ZoneServer.Instance.Data.ItemDb.TryFind(itemId, out var itemData))
				throw new ArgumentException($"Unknown item '{itemId}'.");

			this.ItemName = itemData.Name;
		}

		/// <summary>
		/// Gives the item to the character.
		/// </summary>
		/// <param name="character"></param>
		public override void Give(Character character)
		{
			character.Inventory.Add(this.ItemClassId, this.Amount, InventoryAddType.PickUp);
		}

		/// <summary>
		/// Returns a string representation of the reward.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var itemName = Localization.Get(this.ItemName);
			var format = Localization.GetPlural("{0}", "{1}x {0}", this.Amount);

			return string.Format(format, itemName, this.Amount);
		}
	}
}
