using System;
using Melia.Zone.World.Items;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// A representation of an item on a map.
	/// </summary>
	public class ItemMonster : MonsterInName
	{
		/// <summary>
		/// Returns the item this monster represents.
		/// </summary>
		public Item Item { get; private set; }

		/// <summary>
		/// Gets or sets whether the item was picked up.
		/// </summary>
		public bool PickedUp { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="monsterId"></param>
		private ItemMonster(Item item, int monsterId) : base(monsterId)
		{
			this.Item = item;
			//this.Properties = item.Properties;
		}

		/// <summary>
		/// Creates item monster from item.
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public static ItemMonster Create(Item item)
		{
			if (!ZoneServer.Instance.Data.ItemMonsterDb.TryFind(item.Id, out var data))
				throw new ArgumentException($"No monster id found for item '{item.Id}'.");

			var monster = new ItemMonster(item, data.MonsterId);
			return monster;
		}

		/// <summary>
		/// Returns true if the entity is allowed to pick up the item.
		/// </summary>
		/// <param name="actor"></param>
		/// <returns></returns>
		public bool CanBePickedUpBy(IActor actor)
		{
			// If the entity is the original owner, we want them to have
			// to make more of an effort to get the item, otherwise it
			// would be easy to accidentally pick it right back up.
			// Items are dropped in a 30 unit range, so let's have them
			// get right on top of it to pick it back up.
			// Alternatives:
			// - A confirmation box could work, though it would constantly
			//   activate and end up being annoying.
			// - We could disable pick ups for a certain amount of time,
			//   but if you drop something and want to pick it right back
			//   up for whatever reason, a delay would be annoying.
			if (this.Item.OriginalOwnerHandle == actor.Handle)
			{
				if (DateTime.Now < this.Item.RePickUpTime)
					return false;

				if (!this.Position.InRange2D(actor.Position, 20))
					return false;
			}

			// If the loot protection is active, only the owner can pick
			// up the item.
			if (DateTime.Now < this.Item.LootProtectionEnd)
				return this.Item.OwnerHandle == actor.Handle;

			return true;
		}
	}

	/// <summary>
	/// Represents an item stack that is to be dropped.
	/// </summary>
	public class DropStack
	{
		/// <summary>
		/// Returns the class id of the item.
		/// </summary>
		public int ItemId { get; set; }

		/// <summary>
		/// Returns the amount of items in the stack.
		/// </summary>
		public int Amount { get; set; }

		/// <summary>
		/// Returns the original, unaltered drop chance.
		/// </summary>
		public float DropChance { get; set; }

		/// <summary>
		/// Returns the drop chance adjusted by the drop rate.
		/// </summary>
		public float AdjustedDropChance { get; set; }

		/// <summary>
		/// Creates a new stack.
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="amount"></param>
		/// <param name="dropChance"></param>
		/// <param name="adjustedDropChance"></param>
		public DropStack(int itemId, int amount, float dropChance, float adjustedDropChance)
		{
			this.ItemId = itemId;
			this.Amount = amount;
			this.DropChance = dropChance;
			this.AdjustedDropChance = adjustedDropChance;
		}
	}
}
