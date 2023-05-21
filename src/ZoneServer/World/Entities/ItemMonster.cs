using System;
using Melia.Shared.Tos.Const;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Zone.World.Entities
{
	/// <summary>
	/// A representation of an item on a map.
	/// </summary>
	public class ItemMonster : Monster
	{
		/// <summary>
		/// Returns the item's entity type.
		/// </summary>
		public override EntityType Type => EntityType.Item;

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
		private ItemMonster(Item item, int monsterId) : base(monsterId, NpcType.NPC)
		{
			this.Item = item;
			this.Properties = new Properties();
		}

		/// <summary>
		/// Does nothing, as items have no monster data to load.
		/// </summary>
		protected override void LoadData()
		{
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
		/// <param name="entity"></param>
		/// <returns></returns>
		public bool CanBePickedUpBy(IEntity entity)
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
			if (this.Item.OriginalOwnerHandle == entity.Handle)
			{
				if (DateTime.Now < this.Item.RePickUpTime)
					return false;

				if (!this.Position.InRange2D(entity.Position, 20))
					return false;
			}

			// If the loot protection is active, only the owner can pick
			// up the item.
			if (DateTime.Now < this.Item.LootProtectionEnd)
				return this.Item.OwnerHandle == entity.Handle;

			return true;
		}
	}
}
