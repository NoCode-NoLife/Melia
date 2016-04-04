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

			this.Debug();
		}

		/// <summary>
		/// Returns list of ids of equipped items, in the order of EquipSlot.
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
		/// Returns true if and items with the given id exist in the inventory.
		/// </summary>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public bool HasItem(int itemId)
		{
			lock (_syncLock)
				return _items.SelectMany(a => a.Value).Any(a => a.Id == itemId);
		}

		/// <summary>
		/// Returns available item index for stacking.
		/// </summary>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public long GetStackableItemIndex(InventoryCategory cat, int itemId, int amount)
		{
			return _items[cat].FindIndex(a => a.Id == itemId && a.Amount < a.Data.MaxStack);
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
		/// Returns item by index, or null if it doesn't exist.
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
		/// Returns item in given equip slot, or null if there is none.
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
		public List<int> AddSilent(Item item)
		{
			var cat = item.Data.Category;
			lock (_syncLock)
			{
				List<int> items_updated = new List<int>();

				if (!_items.ContainsKey(cat))
					throw new ArgumentException("Unknown item category.");

				var subIndex = -1;
				var expected_amount = item.Amount;

				if (item.Data.MaxStack > 1 && this.HasItem(item.Id))
				{
					int item_index = subIndex;
					while (expected_amount > 0)
					{
						long world_index = this.GetStackableItemIndex(cat, item.Id, item.Amount);
						subIndex = (int)world_index;
						if (subIndex != -1 && _items[cat].Count > subIndex)
						{
							var possible_add_to_current_stack = _items[cat][subIndex].Data.MaxStack - _items[cat][subIndex].Amount;
							Log.Debug("possible add {0}  - expected {1}", possible_add_to_current_stack, expected_amount);

							if(expected_amount > possible_add_to_current_stack)
							{
								_items[cat][subIndex].Amount += possible_add_to_current_stack;
								_itemsWorldIndex[_items[cat][subIndex].WorldId] = _items[cat][subIndex];

								Log.Debug("added PART to stack {0} - {1}pcs", subIndex, possible_add_to_current_stack);

								expected_amount -= possible_add_to_current_stack;
								item.Amount -= possible_add_to_current_stack;
							}
							else
							{
								_items[cat][subIndex].Amount += expected_amount;
								_itemsWorldIndex[_items[cat][subIndex].WorldId] = _items[cat][subIndex];

								Log.Debug("added ALL to stack {0} - {1}pcs", subIndex, expected_amount);

								expected_amount -= expected_amount;
								item.Amount -= expected_amount;
							}

							item_index = subIndex;
							items_updated.Add(item_index);
						}
						else
						{
							// Hope that we cant get at once more than MaxStack of item, so here we skip checking amount if added item
							_items[cat].Add(item);
							_itemsWorldIndex[item.WorldId] = item;
							Log.Debug("add new");

							expected_amount -= expected_amount;
							item_index = _items[cat].Count - 1;
							items_updated.Add(item_index);
						}
						subIndex = -1;
					}
				}
				else
				{
					_items[cat].Add(item);
					_itemsWorldIndex[item.WorldId] = item;
					Log.Debug("add new");
					items_updated.Add(_items[cat].Count - 1);
					//items.Add(items[cat].Count - 1);
				}

				return items_updated;
			}
		}

		/// <summary>
		/// Adds item to inventory and updates client.
		/// </summary>
		/// <param name="item"></param>
		/// <return>Index of the item.</return>
		public int Add(Item item, InventoryAddType addType)
		{
			//this.Debug();
			for (int i = 0; i < _items[item.Data.Category].Count; ++i)
				Log.Debug("BEFORE    {0} ({1}) : {2} {3}pcs", (int)item.Data.Category * 5000 + 1 + i, i, _items[item.Data.Category][i].Data.ClassName, _items[item.Data.Category][i].Amount);

			List<int> indexes = this.AddSilent(item);

			int last_index = indexes.Last();

			//this.Debug();
			for (int i = 0; i < _items[item.Data.Category].Count; ++i)
				Log.Debug("AFTER    {0} ({1}) : {2} {3}pcs", (int)item.Data.Category * 5000 + 1 + i, i, _items[item.Data.Category][i].Data.ClassName, _items[item.Data.Category][i].Amount);

			foreach (int index in indexes)
			{
				Log.Debug("index: {0}", index);
				// For some reason sending directly item in ZC_ITEM_ADD crashing client(but it worked before my code)
				// So i added tmp var for sending with changed amount(not all stack amount)
				Item tmp_item;

				tmp_item = _items[item.Data.Category][index];
				addType = InventoryAddType.NotNew;

				if (index == last_index)
				{
					tmp_item.Amount = item.Amount;
					addType = InventoryAddType.PickUp;
				}

				Send.ZC_ITEM_ADD(_character, tmp_item, (int)item.Data.Category * 5000 + 1 + index, addType);
			}
			Send.ZC_OBJECT_PROPERTY(_character, ObjectProperty.PC.NowWeight);

			return last_index;
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
		/// <returns></returns>
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
		/// <returns></returns>
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
		/// Deletes item with given id from inventory.
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

			Send.ZC_ITEM_REMOVE(_character, item.WorldId, item.Amount, InventoryItemRemoveMsg.Destroyed, InventoryType.Inventory);
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
		/// Sorts inventory by given order.
		/// </summary>
		/// <param name="order"></param>
		public void Sort(InventoryOrder order)
		{
			lock (_syncLock)
			{
				var items = new Dictionary<InventoryCategory, List<Item>>();

				foreach (var category in _items.Keys)
				{
					switch (order)
					{
						case InventoryOrder.Name:
							items[category] = _items[category].OrderBy(a => a.Data.Name).ToList();
							break;

						default:
							items[category] = _items[category].OrderBy(a => a.Id).ToList();
							break;
					}
				}

				_items = items;
			}

			// Sending ZC_ITEM_INVENTORY_INDEX_LIST stopped working at some
			// point after the iCBT2, officials send a full list now.
			//Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character);
			Send.ZC_ITEM_INVENTORY_LIST(_character);
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
					Log.Debug("    {0} ({1}) : {2} {3}pcs", (int)category.Key * 5000 + 1 + i, i, category.Value[i].Data.ClassName, category.Value[i].Amount);
			}

			Log.Debug("Equip");
			foreach (var item in _equip.ToDictionary(a => a.Key, a => a.Value))
				Log.Debug("  {0} : {1}", item.Key, item.Value.Data.ClassName);

			Log.Debug("</Debug> ----------------------------");
		}

		/// <summary>
		/// Removes all items from inventory.
		/// </summary>
		public InventoryResult Clear()
		{
			var modifiedCategories = new HashSet<InventoryCategory>();
			var items = this.GetItems();

			// Remove items
			foreach (var item in items.Values)
			{
				lock (_syncLock)
				{
					_items[item.Data.Category].Remove(item);
					_itemsWorldIndex.Remove(item.WorldId);
				}

				modifiedCategories.Add(item.Data.Category);
				Send.ZC_ITEM_REMOVE(_character, item.WorldId, 1, InventoryItemRemoveMsg.Destroyed, InventoryType.Inventory);
			}

			// Update categories
			foreach (var category in modifiedCategories)
				Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character, category);

			// Update weight
			Send.ZC_OBJECT_PROPERTY(_character, ObjectProperty.PC.NowWeight);

			return InventoryResult.Success;
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
