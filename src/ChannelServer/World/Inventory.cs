using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class Inventory
	{
		/// <summary>
		/// Ids of the items equipped by default.
		/// (Literally empty items, NoHat, NoWeapon, etc.)
		/// </summary>
		/// <remarks>
		/// Hair Acc, Subsidiary Acc, Outer?, Top, Gloves, Shoes,
		/// Helmet? (headless), Armband, L Weapon, R Weapon, Costume,
		/// Ring?, Ring?, Outer?, Pants, Ring?, Ring?, Bracelet 1,
		/// Bracelet 2, Necklace
		/// </remarks>
		public static readonly int[] DefaultItems = new int[] { 2, 2, 4, 8, 6, 7, 10000, 11000, 9999996, 9999996, 4, 9, 9, 4, 9, 9, 9, 9, 9, 10 };

		private Character _character;

		private object _syncLock = new object();
		private Dictionary<int, Item> _items;
		private Dictionary<InventoryCategory, int> _nextFreeIndex;
		private Dictionary<EquipSlot, Item> _equip;

		/// <summary>
		/// Creates new inventory for character.
		/// </summary>
		public Inventory(Character character)
		{
			_items = new Dictionary<int, Item>();
			_nextFreeIndex = new Dictionary<InventoryCategory, int>();

			_equip = new Dictionary<EquipSlot, Item>(20);
			foreach (EquipSlot slot in Enum.GetValues(typeof(EquipSlot)))
				_equip.Add(slot, new Item(DefaultItems[(int)slot]));

			_character = character;
		}

		/// <summary>
		/// Returns list of ids of equipped items, in the order of EquipmentSlotType.
		/// </summary>
		/// <returns></returns>
		public int[] GetEquipIds()
		{
			// TODO: Cache.

			lock (_syncLock)
				return _equip.OrderBy(a => a.Key).Select(a => a.Value.Id).ToArray();
		}

		/// <summary>
		/// Returns dictionary of equipped items.
		/// </summary>
		/// <returns></returns>
		public Dictionary<EquipSlot, Item> GetEquip()
		{
			lock (_syncLock)
				return _equip.ToDictionary(a => a.Key, a => a.Value);
		}

		/// <summary>
		/// Returns a dictionary with all items, Key being their index.
		/// </summary>
		/// <returns></returns>
		public IDictionary<int, Item> GetItems()
		{
			lock (_syncLock)
				return _items.ToDictionary(a => a.Key, a => a.Value);
		}

		/// <summary>
		/// Returns a dictionary with all indices, Key being the item's index.
		/// </summary>
		/// <returns></returns>
		public IDictionary<int, long> GetIndices()
		{
			lock (_syncLock)
				return _items.ToDictionary(a => a.Key, a => a.Value.WorldId);
		}

		/// <summary>
		/// Returns item by world id, or null if it doesn't exist.
		/// </summary>
		/// <param name="worldId"></param>
		/// <returns></returns>
		public Item GetItem(long worldId)
		{
			lock (_syncLock)
				return _items.Values.FirstOrDefault(a => a.WorldId == worldId);
		}

		/// <summary>
		/// Adds item to inventory.
		/// </summary>
		/// <param name="item"></param>
		public void Add(Item item)
		{
			lock (_syncLock)
			{
				var nextFreeId = this.GetNextFreeId(item.Data.Category);
				_items.Add(nextFreeId, item);
				this.UpdateNextFreeId(item.Data.Category, nextFreeId + 1);
			}
		}

		/// <summary>
		/// Returns next free index in inventory category.
		/// </summary>
		/// <remarks>
		/// Not thread-safe, use from locked methods only!
		/// Update the free id list if you use the returned one!
		/// </remarks>
		/// <param name="category"></param>
		/// <returns></returns>
		private int GetNextFreeId(InventoryCategory category)
		{
			if (!_nextFreeIndex.ContainsKey(category))
				return (int)category * 5000 + 1;

			return _nextFreeIndex[category];
		}

		/// <summary>
		/// Updates the next free id in inventory category.
		/// </summary>
		/// <remarks>
		/// Not thread-safe, use from locked methods only!
		/// </remarks>
		/// <param name="category"></param>
		/// <param name="id">Leave as -1 to accurately calculate the id.</param>
		private void UpdateNextFreeId(InventoryCategory category, int id = -1)
		{
			if (id == -1)
				id = _items.Where(a => a.Value.Data.Category == category).Max(a => a.Key) + 1;

			_nextFreeIndex[category] = id;
		}

		/// <summary>
		/// Puts item into given slot.
		/// </summary>
		/// <param name="slot"></param>
		/// <param name="item"></param>
		public void Equip(EquipSlot slot, Item item)
		{
			lock (_syncLock)
				_equip[slot] = item;
		}
	}
}
