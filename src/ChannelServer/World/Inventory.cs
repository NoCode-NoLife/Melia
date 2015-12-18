// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Util;
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
		private Dictionary<InventoryCategory, List<Item>> _items;
		private Dictionary<long, Item> _itemsWorldIndex;
		private Dictionary<EquipSlot, Item> _equip;

		/// <summary>
		/// Creates new inventory for character.
		/// </summary>
		public Inventory(Character character)
		{
			_items = new Dictionary<InventoryCategory, List<Item>>();
			foreach (InventoryCategory category in Enum.GetValues(typeof(InventoryCategory)))
				_items.Add(category, new List<Item>());

			_equip = new Dictionary<EquipSlot, Item>(Items.EquipSlotCount);
			for (EquipSlot slot = 0; slot < (EquipSlot)Items.EquipSlotCount; ++slot)
				_equip.Add(slot, new DummyEquipItem(slot));

			_itemsWorldIndex = new Dictionary<long, Item>();

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
				return _equip.Where(a => (int)a.Key <= Items.EquipSlotCount).OrderBy(a => a.Key).Select(a => a.Value.Id).ToArray();
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
			var result = new Dictionary<int, Item>();

			lock (_syncLock)
			{
				foreach (var category in _items)
				{
					for (int i = 0; i < category.Value.Count; ++i)
						result.Add((int)category.Key * 5000 + 1 + i, category.Value[i]);
				}
			}

			return result;
		}

		/// <summary>
		/// Returns a dictionary with all indices, Key being the item's index.
		/// </summary>
		/// <returns></returns>
		public IDictionary<int, long> GetIndices()
		{
			var result = new Dictionary<int, long>();

			lock (_syncLock)
			{
				foreach (var category in _items)
				{
					for (int i = 0; i < category.Value.Count; ++i)
						result.Add((int)category.Key * 5000 + 1 + i, category.Value[i].WorldId);
				}
			}

			return result;
		}

		/// <summary>
		/// Returns a dictionary with all indices for inventory category,
		/// Key being the item's index.
		/// </summary>
		/// <returns></returns>
		public IDictionary<int, long> GetIndices(InventoryCategory category)
		{
			var result = new Dictionary<int, long>();

			lock (_syncLock)
			{
				if (!_items.ContainsKey(category))
					throw new ArgumentException("Unknown item category.");

				var items = _items[category];
				for (int i = 0; i < items.Count; ++i)
					result.Add((int)category * 5000 + 1 + i, items[i].WorldId);
			}

			return result;
		}

		/// <summary>
		/// Returns true if item exists in inventory.
		/// </summary>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public bool HasItem(int itemId)
		{
			lock (_syncLock)
				return _items.SelectMany(a => a.Value).Any(a => a.Id == itemId);
		}

		/// <summary>
		/// Returns item by world id, or null if it doesn't exist.
		/// </summary>
		/// <param name="worldId"></param>
		/// <returns></returns>
		public Item GetItem(long worldId)
		{
			Item item;
			lock (_syncLock)
				_itemsWorldIndex.TryGetValue(worldId, out item);

			return item;
		}

		/// <summary>
		/// Returns item by world id, or null if it doesn't exist.
		/// </summary>
		/// <param name="worldId"></param>
		/// <returns></returns>
		public Item GetItemByIndex(int index)
		{
			if (index < 5001 || index > 75000)
				throw new ArgumentOutOfRangeException("index");

			var category = (InventoryCategory)(index / 5000);
			var subIndex = index - (int)category * 5000 - 1;

			Item item;
			lock (_syncLock)
			{
				var list = _items[category];
				if (list.Count < subIndex)
					return null;

				item = list[subIndex];
			}

			return item;
		}

		/// <summary>
		/// Returns item by world id, or null if it doesn't exist.
		/// </summary>
		/// <param name="worldId"></param>
		/// <returns></returns>
		public Item GetItem(EquipSlot slot)
		{
			Item item;
			lock (_syncLock)
				_equip.TryGetValue(slot, out item);

			return item;
		}

		/// <summary>
		/// Adds item to inventory without updating the character's client.
		/// </summary>
		/// <param name="item"></param>
		/// <return>Index of the item.</return>
		public int AddSilent(Item item)
		{
			var cat = item.Data.Category;

			lock (_syncLock)
			{
				if (!_items.ContainsKey(cat))
					throw new ArgumentException("Unknown item category.");

				_items[cat].Add(item);
				_itemsWorldIndex[item.WorldId] = item;

				return (int)cat * 5000 + _items[cat].Count;
			}
		}

		/// <summary>
		/// Adds item to inventory and updates client.
		/// </summary>
		/// <param name="item"></param>
		/// <return>Index of the item.</return>
		public int Add(Item item, InventoryAddType addType)
		{
			var index = this.AddSilent(item);

			Send.ZC_ITEM_ADD(_character, item, index, addType);
			Send.ZC_OBJECT_PROPERTY(_character, ObjectProperty.PC.NowWeight);

			return index;
		}

		/// <summary>
		/// Puts item into equip slot without updating the client.
		/// </summary>
		/// <param name="item"></param>
		public void SetEquipSilent(EquipSlot slot, Item item)
		{
			lock (_syncLock)
				_equip[slot] = item;
		}

		/// <summary>
		/// Moves item with the given id into the given slot.
		/// </summary>
		/// <param name="slot"></param>
		/// <param name="item"></param>
		public InventoryResult Equip(EquipSlot slot, long worldId)
		{
			if (!Enum.IsDefined(typeof(EquipSlot), slot))
				return InventoryResult.InvalidSlot;

			var item = this.GetItem(worldId);
			if (item == null)
				return InventoryResult.ItemNotFound;

			// Unequip existing item first.
			var collision = false;
			lock (_syncLock)
				collision = !(_equip[slot] is DummyEquipItem);

			if (collision)
				this.Unquip(slot);

			// Equip new item
			lock (_syncLock)
			{
				_equip[slot] = item;
				_items[item.Data.Category].Remove(item);
				_itemsWorldIndex.Remove(item.WorldId);
			}

			// Update client
			Send.ZC_ITEM_REMOVE(_character, item.WorldId, 1, InventoryItemRemoveMsg.Equipped, InventoryType.Inventory);
			Send.ZC_ITEM_EQUIP_LIST(_character);
			Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character, item.Data.Category);
			Send.ZC_UPDATED_PCAPPEARANCE(_character);

			return InventoryResult.Success;
		}

		/// <summary>
		/// Moves item from given slot into inventory.
		/// </summary>
		/// <param name="slot"></param>
		public InventoryResult Unquip(EquipSlot slot)
		{
			if (!Enum.IsDefined(typeof(EquipSlot), slot))
				return InventoryResult.InvalidSlot;

			var item = this.GetItem(slot);
			if (item == null || item is DummyEquipItem)
				return InventoryResult.ItemNotFound;

			lock (_syncLock)
				_equip[slot] = new DummyEquipItem(slot);

			Send.ZC_ITEM_EQUIP_LIST(_character);
			Send.ZC_UPDATED_PCAPPEARANCE(_character);

			this.Add(item, InventoryAddType.NotNew);

			return InventoryResult.Success;
		}

		/// <summary>
		/// Moves item from given slot into inventory.
		/// </summary>
		/// <param name="slot"></param>
		public InventoryResult Delete(long worldId)
		{
			var item = this.GetItem(worldId);
			if (item == null || item is DummyEquipItem)
				return InventoryResult.ItemNotFound;

			lock (_syncLock)
			{
				if (!_items[item.Data.Category].Remove(item))
					return InventoryResult.ItemNotFound;

				_itemsWorldIndex.Remove(item.WorldId);
			}

			Send.ZC_ITEM_REMOVE(_character, item.WorldId, 1, InventoryItemRemoveMsg.Destroyed, InventoryType.Inventory);
			Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character, item.Data.Category);
			Send.ZC_OBJECT_PROPERTY(_character, ObjectProperty.PC.NowWeight);

			return InventoryResult.Success;
		}

		/// <summary>
		/// Swaps the two items with each other.
		/// </summary>
		/// <param name="worldId1"></param>
		/// <param name="worldId2"></param>
		/// <returns></returns>
		public InventoryResult Swap(long worldId1, long worldId2)
		{
			var item1 = this.GetItem(worldId1);
			var item2 = this.GetItem(worldId2);

			if (item1 == null || item2 == null)
				return InventoryResult.ItemNotFound;

			if (item1.Data.Category != item2.Data.Category)
				return InventoryResult.InvalidOperation;

			var category = item1.Data.Category;

			lock (_syncLock)
			{
				var list = _items[category];
				var index1 = list.IndexOf(item1);
				var index2 = list.IndexOf(item2);

				list[index1] = item2;
				list[index2] = item1;
			}

			//Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character, category);

			return InventoryResult.Success;
		}

		/// <summary>
		/// Sorts inventory by item id.
		/// </summary>
		public void Sort()
		{
			lock (_syncLock)
			{
				var items = new Dictionary<InventoryCategory, List<Item>>();

				foreach (var category in _items.Keys)
					items[category] = _items[category].OrderBy(a => a.Id).ToList();

				_items = items;
			}

			Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character);
		}

		/// <summary>
		/// Returns combined weight of all items in the inventory.
		/// </summary>
		/// <returns></returns>
		public float GetNowWeight()
		{
			var result = 0f;

			// TODO: Cache.
			lock (_syncLock)
			{
				result += _items.SelectMany(a => a.Value).Sum(a => a.Data.Weight);
				result += _equip.Values.Where(a => !(a is DummyEquipItem)).Sum(a => a.Data.Weight);
			}

			return result;
		}

		/// <summary>
		/// Logs the entire inventory and the equipment.
		/// </summary>
		public void Debug()
		{
			Log.Debug("<Debug> -----------------------------");

			Log.Debug("Inventory");
			foreach (var category in _items)
			{
				Log.Debug("  {0}", category.Key);
				for (int i = 0; i < category.Value.Count; ++i)
					Log.Debug("    {0} : {1}", (int)category.Key * 5000 + 1 + i, category.Value[i].Data.ClassName);
			}

			Log.Debug("Equip");
			foreach (var item in _equip.ToDictionary(a => a.Key, a => a.Value))
				Log.Debug("  {0} : {1}", item.Key, item.Value.Data.ClassName);

			Log.Debug("</Debug> ----------------------------");
		}
	}

	public enum InventoryResult
	{
		Success,
		ItemNotFound,
		InvalidSlot,
		InvalidOperation,
	}

	public class DummyEquipItem : Item
	{
		public DummyEquipItem(EquipSlot slot)
			: base(Items.DefaultItems[(int)slot], 1)
		{
		}
	}
}
