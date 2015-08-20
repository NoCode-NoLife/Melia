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

			_equip = new Dictionary<EquipSlot, Item>(20);
			foreach (EquipSlot slot in Enum.GetValues(typeof(EquipSlot)))
				_equip.Add(slot, new Item(DefaultItems[(int)slot]));

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
		/// Adds item to inventory.
		/// </summary>
		/// <param name="item"></param>
		public void Add(Item item)
		{
			var cat = item.Data.Category;

			lock (_syncLock)
			{
				if (!_items.ContainsKey(cat))
					throw new ArgumentException("Unknown item category.");

				_items[cat].Add(item);
				_itemsWorldIndex[item.WorldId] = item;
			}
		}

		/// <summary>
		/// Puts item into given slot.
		/// </summary>
		/// <param name="slot"></param>
		/// <param name="item"></param>
		public EquipResult Equip(EquipSlot slot, long worldId)
		{
			if (!Enum.IsDefined(typeof(EquipSlot), slot))
				return EquipResult.InvalidSlot;

			var item = this.GetItem(worldId);
			if (item == null)
				return EquipResult.ItemNotFound;

			lock (_syncLock)
			{
				_equip[slot] = item;
				_items[item.Data.Category].Remove(item);
			}

			var equip = this.GetEquip();

			var packet = new Packet(Op.ZC_ITEM_REMOVE);
			packet.PutLong(item.WorldId);
			packet.PutInt(1);
			packet.PutByte(5);
			packet.PutByte(0);
			_character.Connection.Send(packet);

			packet = new Packet(Op.ZC_ITEM_EQUIP_LIST);
			foreach (var equipItem in equip)
			{
				packet.PutInt(equipItem.Value.Id);
				packet.PutShort(0); // Object size
				packet.PutEmptyBin(2);
				packet.PutLong(equipItem.Value.WorldId);
				packet.PutInt((int)equipItem.Key);
				packet.PutInt(0);
				//packet.PutEmptyBin(0); // Object
			}
			_character.Connection.Send(packet);

			packet = new Packet(Op.ZC_UPDATED_PCAPPEARANCE);
			packet.PutShort(_character.WorldId);
			packet.PutEmptyBin(2);
			packet.PutString(_character.Name, 65);
			packet.PutString(_character.TeamName, 64);
			packet.PutEmptyBin(7);
			packet.PutLong(0);
			packet.PutShort(_character.Stance);
			packet.PutShort(0);
			packet.PutShort((short)_character.Job);
			packet.PutByte((byte)_character.Gender);
			packet.PutByte(0);
			packet.PutInt(_character.Level);
			foreach (var equipItem in equip)
				packet.PutInt(equipItem.Value.Id);
			packet.PutByte(_character.Hair);
			_character.Connection.Send(packet);

			return EquipResult.Success;
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
				Log.Debug("    {0} : {1}", item.Key, item.Value.Data.ClassName);

			Log.Debug("</Debug> ----------------------------");
		}
	}

	public enum EquipResult
	{
		Success,
		ItemNotFound,
		InvalidSlot,
	}
}
