// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Util;

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
					for (var i = 0; i < category.Value.Count; ++i)
					{
						var index = category.Value[i].GetInventoryIndex(i);
						var item = category.Value[i];

						result.Add(index, item);
					}
				}
			}

			return result;
		}

		/// <summary>
		/// Returns a dictionary with all items that match the predicate,
		/// Key being their index.
		/// </summary>
		/// <returns></returns>
		public IDictionary<int, Item> GetItems(Func<Item, bool> predicate)
		{
			var result = new Dictionary<int, Item>();

			lock (_syncLock)
			{
				foreach (var category in _items)
				{
					for (var i = 0; i < category.Value.Count; ++i)
					{
						var index = category.Value[i].GetInventoryIndex(i);
						var item = category.Value[i];

						if (predicate(item))
							result.Add(index, item);
					}
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
					for (var i = 0; i < category.Value.Count; ++i)
					{
						var index = category.Value[i].GetInventoryIndex(i);
						var itemObjectId = category.Value[i].ObjectId;

						result.Add(index, itemObjectId);
					}
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
				for (var i = 0; i < items.Count; ++i)
				{
					var index = items[i].GetInventoryIndex(i);
					var itemObjectId = items[i].ObjectId;

					result.Add(index, itemObjectId);
				}
			}

			return result;
		}

		/// <summary>
		/// Returns true if an item with the given id exist in the inventory.
		/// </summary>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public bool HasItem(int itemId)
		{
			lock (_syncLock)
				return _items.SelectMany(a => a.Value).Any(a => a.Id == itemId);
		}

		/// <summary>
		/// Returns amount of items with the given id in the inventory.
		/// </summary>
		/// <remarks>
		/// Stacks count as the amount of items in the stack.
		/// E.g.: One stack with 10 HP potions results in a count of 10.
		/// </remarks>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public int CountItem(int itemId)
		{
			lock (_syncLock)
				return _items.SelectMany(a => a.Value).Where(a => a.Id == itemId).Sum(a => a.Amount);
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
			if (index < 5001 || index > 1750000)
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
		public void AddSilent(Item item)
		{
			var left = this.FillStacks(item, InventoryAddType.NotNew, true);
			if (left > 0)
			{
				item.Amount = left;
				this.AddStack(item, InventoryAddType.NotNew, true);
			}
		}

		/// <summary>
		/// Adds item to inventory and updates client.
		/// </summary>
		/// <param name="item"></param>
		/// <param name="addType"></param>
		public void Add(Item item, InventoryAddType addType)
		{
			var left = this.FillStacks(item, addType, false);
			if (left > 0)
			{
				item.Amount = left;
				this.AddStack(item, addType, false);
			}

			Send.ZC_OBJECT_PROPERTY(_character, PropertyId.PC.NowWeight);
		}

		/// <summary>
		/// Adds new items with given item id to inventory.
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="amount"></param>
		/// <param name="addType"></param>
		public void Add(int itemId, int amount, InventoryAddType addType)
		{
			while (amount > 0)
			{
				// Item caps Amount automatically. By using amount directly
				// either the entire amount is used for the new item,
				// or the max amount for it. This way we add new stacks until
				// amount is 0.

				var item = new Item(itemId, amount);
				this.Add(item, addType);

				amount -= item.Amount;
			}
		}

		/// <summary>
		/// Filles stacks with item, returns the amount of items left.
		/// The item is not modified.
		/// </summary>
		/// <remarks>
		/// If no stacks are found, nothing happens, and the amount returned
		/// will be equal to item.Amount.
		/// </remarks>
		/// <param name="item">Item to fill existing stacks with.</param>
		/// <param name="silent">If true, client isn't updated.</param>
		private int FillStacks(Item item, InventoryAddType addType, bool silent)
		{
			// If item isn't stackable, we've got nothing to do here.
			if (!item.IsStackable)
				return item.Amount;

			var itemId = item.Id;
			var amount = item.Amount;
			var cat = item.Data.Category;
			var stacks = this.GetStacks(cat, itemId);

			// Fill stacks
			foreach (var index in stacks)
			{
				lock (_syncLock)
				{
					var categoryItem = _items[cat][index];
					var space = (categoryItem.Data.MaxStack - categoryItem.Amount);
					var add = Math.Min(amount, space);

					categoryItem.Amount += add;
					amount -= add;

					if (!silent)
					{
						var categoryIndex = categoryItem.GetInventoryIndex(index);

						// Use given add type if this was the last of it,
						// or NotNew if only some was just added to a stack.
						var adjustedAddType = (amount == 0 ? addType : InventoryAddType.NotNew);

						Send.ZC_ITEM_ADD(_character, categoryItem, categoryIndex, add, adjustedAddType);
					}
				}

				if (amount == 0)
					break;
			}

			return amount;
		}

		/// <summary>
		/// Adds given stack to inventory.
		/// </summary>
		/// <param name="item">Item to add to inventory.</param>
		/// <param name="silent">If true, client isn't updated.</param>
		private void AddStack(Item item, InventoryAddType addType, bool silent)
		{
			var cat = item.Data.Category;

			lock (_syncLock)
			{
				_items[cat].Add(item);
				_itemsWorldIndex[item.ObjectId] = item;

				if (!silent)
				{
					var categoryIndex = item.GetInventoryIndex(_items[cat].Count - 1);
					Send.ZC_ITEM_ADD(_character, item, categoryIndex, item.Amount, addType);
				}
			}
		}

		/// <summary>
		/// Returns indices of stacks in cat with the given item id that
		/// aren't full yet.
		/// </summary>
		/// <param name="cat"></param>
		/// <param name="itemId"></param>
		/// <returns></returns>
		private List<int> GetStacks(InventoryCategory cat, int itemId)
		{
			var result = new List<int>();

			lock (_syncLock)
			{
				var categoryItems = _items[cat];
				for (var i = 0; i < categoryItems.Count; ++i)
				{
					var item = categoryItems[i];
					if (item.Id == itemId && item.Amount < item.Data.MaxStack)
						result.Add(i);
				}
			}

			return result;
		}

		/// <summary>
		/// Puts item into equip slot without updating the client.
		/// </summary>
		/// <param name="item"></param>
		public void SetEquipSilent(EquipSlot slot, Item item)
		{
			lock (_syncLock)
				_equip[slot] = item;

			_character.UpdateStance();
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
				this.Unequip(slot);

			// Equip new item
			lock (_syncLock)
			{
				_equip[slot] = item;
				_items[item.Data.Category].Remove(item);
				_itemsWorldIndex.Remove(item.ObjectId);
			}

			// Update character
			_character.UpdateStance();

			// Update client
			Send.ZC_ITEM_REMOVE(_character, item.ObjectId, 1, InventoryItemRemoveMsg.Equipped, InventoryType.Inventory);
			Send.ZC_ITEM_EQUIP_LIST(_character);
			//Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character, item.Data.Category);
			Send.ZC_UPDATED_PCAPPEARANCE(_character);

			return InventoryResult.Success;
		}

		/// <summary>
		/// Moves item from given slot into inventory.
		/// </summary>
		/// <param name="slot"></param>
		/// <returns></returns>
		public InventoryResult Unequip(EquipSlot slot)
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
		/// Removes item with given id from inventory.
		/// </summary>
		/// <param name="slot"></param>
		public InventoryResult Remove(long worldId, int amount = 1)
		{
			var item = this.GetItem(worldId);
			if (item == null || item is DummyEquipItem)
				return InventoryResult.ItemNotFound;

			return this.Remove(item, amount, InventoryItemRemoveMsg.Destroyed);
		}

		/// <summary>
		/// Removes item from inventory.
		/// </summary>
		/// <param name="slot"></param>
		private InventoryResult Remove(Item item)
		{
			lock (_syncLock)
			{
				if (!_items[item.Data.Category].Remove(item))
					return InventoryResult.ItemNotFound;

				_itemsWorldIndex.Remove(item.ObjectId);
			}

			//var msgParameters = new[] { new MsgParameter("ITEM", "@dicID_^*$ITEM_20150317_002105$*^"), new MsgParameter("COUNT", item.Amount.ToString()) };
			//Send.ZC_SYSTEM_MSG(_character, 2225, msgParameters);

			Send.ZC_ITEM_REMOVE(_character, item.ObjectId, item.Amount, InventoryItemRemoveMsg.Destroyed, InventoryType.Inventory);
			//Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character, item.Data.Category);
			Send.ZC_OBJECT_PROPERTY(_character, PropertyId.PC.NowWeight);
			Send.ZC_OBJECT_PROPERTY(_character, PropertyId.PC.MSPD);

			return InventoryResult.Success;
		}

		/// <summary>
		/// Reduces amount of item with the given id. Item is removed
		/// if amount becomes 0.
		/// </summary>
		/// <param name="slot"></param>
		public InventoryResult Remove(Item item, int amount, InventoryItemRemoveMsg msg, InventoryType type = InventoryType.Inventory)
		{
			// Check if item exists in inventory
			lock (_syncLock)
			{
				if (!_items[item.Data.Category].Contains(item))
					return InventoryResult.ItemNotFound;
			}

			// Remove or reduce
			if (item.Amount <= amount)
			{
				this.Remove(item);
			}
			else
			{
				item.Amount -= amount;

				Send.ZC_ITEM_REMOVE(_character, item.ObjectId, amount, msg, type);
				Send.ZC_OBJECT_PROPERTY(_character, PropertyId.PC.NowWeight);
			}

			return InventoryResult.Success;
		}

		/// Removes items with given id from inventory.
		/// </summary>
		/// <param name="itemId">Id of the item to remove.</param>
		/// <param name="amount">Amount of pieces to remove.</param>
		/// <returns>Amount of pieces removed.</returns>
		public int Remove(int itemId, int amount, InventoryItemRemoveMsg msg)
		{
			if (amount == 0)
				return 0;

			var result = 0;

			// Potential optimization: don't search every category. However,
			// technically any item can be in any category.
			foreach (var itemkv in this.GetItems(a => a.Id == itemId))
			{
				var index = itemkv.Key;
				var item = itemkv.Value;
				var itemAmount = item.Amount;
				var category = item.Data.Category;
				var reduce = Math.Min(amount, item.Amount);

				item.Amount -= reduce;
				amount -= reduce;
				result += reduce;

				if (reduce == itemAmount)
				{
					lock (_syncLock)
					{
						_items[category].Remove(item);
						_itemsWorldIndex.Remove(item.ObjectId);

					}
				}

				if (item.Id != 900011 && item.Id != 900012)
					Send.ZC_ITEM_REMOVE(_character, item.ObjectId, reduce, msg, InventoryType.Inventory);
				else
					Send.ZC_ITEM_REMOVE(_character, 0, reduce, msg, InventoryType.Inventory);
				//Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character, item.Data.Category);
			}

			if (result != 0)
				Send.ZC_OBJECT_PROPERTY(_character, PropertyId.PC.NowWeight);

			return result;
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
						case InventoryOrder.Price:
							items[category] = _items[category].OrderBy(a => a.Data.Price).ToList();
							break;

						case InventoryOrder.Weight:
							items[category] = _items[category].OrderBy(a => a.Data.Weight).ToList();
							break;

						//case InventoryOrder.Grade:
						//	items[category] = _items[category].OrderBy(a => a.[...]).ToList();
						//	break;

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
				for (var i = 0; i < category.Value.Count; ++i)
				{
					var index = category.Value[i].GetInventoryIndex(i);
					var item = category.Value[i];

					Log.Debug("    {0} : {1}", index, item.Data.ClassName);
				}
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
					_itemsWorldIndex.Remove(item.ObjectId);
				}

				modifiedCategories.Add(item.Data.Category);
				Send.ZC_ITEM_REMOVE(_character, item.ObjectId, item.Amount, InventoryItemRemoveMsg.Destroyed, InventoryType.Inventory);
			}

			// Update categories
			foreach (var category in modifiedCategories)
				Send.ZC_ITEM_INVENTORY_INDEX_LIST(_character, category);

			// Update weight
			Send.ZC_OBJECT_PROPERTY(_character, PropertyId.PC.NowWeight);

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
