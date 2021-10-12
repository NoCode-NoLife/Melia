using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ItemData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public string LocalKey { get; set; }
		public ItemType Type { get; set; }
		public ItemGroup Group { get; set; }
		public InventoryCategory Category { get; set; }
		public float Weight { get; set; }
		public int MaxStack { get; set; }
		public int Price { get; set; }
		public int SellPrice { get; set; }
		public EquipType EquipType1 { get; set; }
		public EquipType EquipType2 { get; set; }
		public int MinLevel { get; set; }
		public float MinAtk { get; set; }
		public float MaxAtk { get; set; }
		public float PAtk { get; set; }
		public float MAtk { get; set; }
		public float AddMinAtk { get; set; }
		public float AddMaxAtk { get; set; }
		public float AddMAtk { get; set; }
		public float Def { get; set; }
		public float MDef { get; set; }
		public float AddDef { get; set; }
		public float AddMDef { get; set; }
		public ItemScriptData Script { get; set; }

		public bool HasScript => this.Script != null;
	}

	[Serializable]
	public class ItemScriptData
	{
		public string Function { get; set; }
		public string StrArg { get; set; }
		public float NumArg1 { get; set; }
		public float NumArg2 { get; set; }
	}

	/// <summary>
	/// Item database, indexed by item id.
	/// </summary>
	public class ItemDb : DatabaseJsonIndexed<int, ItemData>
	{
		public ItemData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		public ItemData FindByClass(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.ClassName.ToLower() == name).Value;
		}

		public List<ItemData> FindAll(string name)
		{
			name = name.ToLower();
			return this.Entries.FindAll(a => a.Value.Name.ToLower().Contains(name));
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("itemId", "className", "name", "localKey", "type", "group", "weight", "maxStack", "price", "sellPrice");

			var info = new ItemData();

			info.Id = entry.ReadInt("itemId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.LocalKey = entry.ReadString("localKey");
			info.Type = entry.ReadEnum<ItemType>("type");
			info.Group = entry.ReadEnum<ItemGroup>("group");
			info.Category = GetCategory(info);
			info.Weight = entry.ReadFloat("weight", 0);
			info.MaxStack = entry.ReadInt("maxStack", 1);
			info.Price = entry.ReadInt("price", 0);
			info.SellPrice = entry.ReadInt("sellPrice", 0);
			info.EquipType1 = entry.ReadEnum<EquipType>("equipType1", EquipType.None);
			info.EquipType2 = entry.ReadEnum<EquipType>("equipType2", EquipType.None);
			info.MinLevel = entry.ReadInt("minLevel", 1);
			info.MinAtk = entry.ReadFloat("minAtk", 0);
			info.MaxAtk = entry.ReadFloat("maxAtk", 0);
			info.PAtk = entry.ReadFloat("pAtk", 0);
			info.MAtk = entry.ReadFloat("mAtk", 0);
			info.AddMinAtk = entry.ReadFloat("addMinAtk", 0);
			info.AddMaxAtk = entry.ReadFloat("addMaxAtk", 0);
			info.AddMAtk = entry.ReadFloat("addMAtk", 0);
			info.Def = entry.ReadFloat("def", 0);
			info.MDef = entry.ReadFloat("mDef", 0);
			info.AddDef = entry.ReadFloat("addDef", 0);
			info.AddMDef = entry.ReadFloat("addMDef", 0);

			if (entry.ContainsKey("script"))
			{
				var scriptEntry = (JObject)entry["script"];

				scriptEntry.AssertNotMissing("function", "strArg", "numArg1", "numArg2");

				var scriptData = new ItemScriptData();

				scriptData.Function = scriptEntry.ReadString("function");
				scriptData.StrArg = scriptEntry.ReadString("strArg");
				scriptData.NumArg1 = scriptEntry.ReadFloat("numArg1");
				scriptData.NumArg2 = scriptEntry.ReadFloat("numArg2");

				info.Script = scriptData;
			}

			this.Entries[info.Id] = info;
		}

		private static InventoryCategory GetCategory(ItemData data)
		{
			// As far as I can tell there is nothing in the client to
			// simplify this. We just have to manually categorize the
			// items.

			if (data.Group == ItemGroup.Premium)
			{
				return InventoryCategory.Premium_Consume;
			}

			if (data.Type == ItemType.Equip)
			{
				if (data.Group == ItemGroup.Weapon)
					return InventoryCategory.Weapon_Bow;

				if (data.Group == ItemGroup.SubWeapon)
					return InventoryCategory.Weapon_Dagger;

				if (data.EquipType1 == EquipType.Boots)
					return InventoryCategory.Armor_Boots;

				if (data.EquipType1 == EquipType.Gloves)
					return InventoryCategory.Armor_Gloves;

				if (data.EquipType1 == EquipType.Pants)
					return InventoryCategory.Armor_Pants;

				if (data.EquipType1 == EquipType.Shield)
					return InventoryCategory.Armor_Shield;

				if (data.EquipType1 == EquipType.Shirt)
					return InventoryCategory.Armor_Shirt;

				if (data.EquipType1 == EquipType.Outer)
					return InventoryCategory.Outer;

				if (data.Group == ItemGroup.Helmet)
					return InventoryCategory.Premium_Helmet;

				if (data.Group == ItemGroup.Armband)
					return InventoryCategory.Accessory_Band;

				return InventoryCategory.Armor_Boots;
			}

			if (data.Type == ItemType.Quest)
				return InventoryCategory.Quest;

			if (data.Group == ItemGroup.Book)
				return InventoryCategory.Consume_Book;

			if (data.Group == ItemGroup.Card)
				return InventoryCategory.Card;

			if (data.Group == ItemGroup.Collection)
				return InventoryCategory.Misc_Collect;

			if (data.Type == ItemType.Consume)
			{
				if (data.Group == ItemGroup.Cube)
					return InventoryCategory.Consume_Cube;

				return InventoryCategory.Consume_Potion;
			}

			if (data.Type == ItemType.Recipe)
				return InventoryCategory.Recipe;

			if (data.Group == ItemGroup.Material)
				return InventoryCategory.Misc_Etc;

			// Use Non for unused, so items like money get hidden.
			if (data.Group == ItemGroup.Unused)
				return InventoryCategory.None;

			// Return unused by default, which is labeled as "N/A".
			//return InventoryCategory.Unused;

			// Actually, for unknown reasons not all items appear when put
			// into Unused. Let's use a random category for now.
			return InventoryCategory.Misc_Usual;
		}
	}
}
