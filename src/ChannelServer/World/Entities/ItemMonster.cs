using System;
using Melia.Shared.Const;

namespace Melia.Channel.World.Entities
{
	/// <summary>
	/// A representation of an item on the map.
	/// </summary>
	public class ItemMonster : Monster
	{
		/// <summary>
		/// Returns the item this monster represents.
		/// </summary>
		public Item Item { get; private set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="monsterId"></param>
		private ItemMonster(Item item, int monsterId) : base(monsterId, NpcType.NPC)
		{
			this.Item = item;
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
			if (!ChannelServer.Instance.Data.ItemMonsterDb.TryFind(item.Id, out var data))
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
			if (DateTime.Now < this.Item.LootProtectionEnd)
				return this.Item.OwnerHandle == entity.Handle;

			return true;
		}
	}
}
