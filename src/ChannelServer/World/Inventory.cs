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
		private Character _character;

		private object _syncLock = new object();
		private Dictionary<int, Item> _items;
		private Dictionary<InventoryCategory, int> _nextFreeIndex;
		private Item[] _equip;

		/// <summary>
		/// Creates new inventory for character.
		/// </summary>
		public Inventory(Character character)
		{
			_items = new Dictionary<int, Item>();
			_nextFreeIndex = new Dictionary<InventoryCategory, int>();
			_equip = new Item[20];

			_character = character;
		}

		/// <summary>
		/// Returns list of ids of equipped items, in the order of EquipmentSlotType.
		/// </summary>
		/// <returns></returns>
		public int[] GetEquipIds()
		{
			// Defaults are literally empty items, NoHat, NoWeapon, etc.
			var result = new List<int>();
			result.Add(2); // Hair Acc
			result.Add(2); // Subsidiary Acc
			result.Add(4); // Outer?
			result.Add(8); // Top
			result.Add(6); // Gloves
			result.Add(7); // Shoes
			result.Add(10000); // Helmet? (headless)
			result.Add(11000); // Armband
			result.Add(9999996); // L Weapon
			result.Add(9999996); // R Weapon
			result.Add(4); // Costume
			result.Add(9); // Ring?
			result.Add(9); // Ring?
			result.Add(4); // Outer?
			result.Add(9); // Pants
			result.Add(9); // Ring?
			result.Add(9); // Ring?
			result.Add(9); // Bracelet 1
			result.Add(9); // Bracelet 2
			result.Add(10); // Necklace

			// Replace defaults with the actual ids.
			lock (_syncLock)
			{
				for (int i = 0; i < _equip.Length; ++i)
				{
					var item = _equip[i];
					if (item != null)
						result[i] = item.Id;
				}
			}

			// TODO: Cache.
			// TODO: Could be optimized on expense of simplicity?

			return result.ToArray();
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
	}
}
