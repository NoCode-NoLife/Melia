// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

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
		public InventoryCategory Category { get; set; }
		public ItemType Type { get; set; }
		public float Weight { get; set; }
		public int MaxStack { get; set; }
		public int Price { get; set; }
		public int SellPrice { get; set; }

		public EquipType EquipType1 { get; set; }
		public EquipType EquipType2 { get; set; }
		public int MinLevel { get; set; }

		public string Script { get; set; }
		public string Properties { get; set; }

		public bool hasScript => !string.IsNullOrWhiteSpace(this.Script);

		public ItemGroup Group { get; internal set; }
	}

	[Serializable]
	public class ItemProperty
	{

	}

	/// <summary>
	/// Item database, indexed by item id.
	/// </summary>
	public class ItemDb : DatabaseJsonIndexed<int, ItemData>
	{
		/// <summary>
		/// Helper Function for Item Group as String to ItemGroup
		/// </summary>
		/// <param name="group"></param>
		/// <returns></returns>
		public ItemGroup GetItemGroup(string group)
		{
			switch (group)
			{
				case "Premium": return ItemGroup.Premium;
				case "Quest": return ItemGroup.Quest;
				case "Arcane": return ItemGroup.Arcane;
				case "Drug": return ItemGroup.Drug;
				case "Material": return ItemGroup.Material;
				case "Event": return ItemGroup.Event;
				case "Misc": return ItemGroup.Misc;
				case "Ark": return ItemGroup.Ark;
				case "LegendMaterial": return ItemGroup.LegendMaterial;
				case "MagicAmulet": return ItemGroup.MagicAmulet;
				case "SpecialMaterial": return ItemGroup.SpecialMaterial;
				case "Icor": return ItemGroup.Icor;
				case "ExpOrb": return ItemGroup.ExpOrb;
				case "SubExpOrb": return ItemGroup.SubExpOrb;
				case "FishingRod": return ItemGroup.FishingRod;
				case "PasteBait": return ItemGroup.PasteBait;
				case "Unused": return ItemGroup.Unused;
				case "HiddenAbility": return ItemGroup.HiddenAbility;
				case "Entrance_Ticket": return ItemGroup.Entrance_Ticket;
				case "Consume": return ItemGroup.Consume;
				case "Armor": return ItemGroup.Armor;
				case "Helmet": return ItemGroup.Helmet;
				case "Weapon": return ItemGroup.Weapon;
				case "Armband": return ItemGroup.Armband;
				case "SubWeapon": return ItemGroup.SubWeapon;
				case "Seal": return ItemGroup.Seal;
				case "Relic": return ItemGroup.Relic;
				case "Gem": return ItemGroup.Gem;
				default: return ItemGroup.Unknown;
			}
		}

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

		static Dictionary<string, int> ItemTypes = new Dictionary<string, int>();
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("itemId", "className", "name", "type");

			var info = new ItemData();

			info.Id = entry.ReadInt("itemId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			//info.Type = GetItemType(entry.ReadString("type"));
			info.Group = GetItemGroup(entry.ReadString("group"));
			info.Category = GetItemCategory(info.Group);
			info.Weight = entry.ReadFloat("weight", 0f);
			info.MaxStack = entry.ReadInt("maxStack", 1);
			info.Price = entry.ReadInt("price", 0);
			info.SellPrice = entry.ReadInt("sellPrice", 0);

			var equipType1 = entry.ReadString("equipType1", null);
			if (equipType1 != null)
			{
				if (!Enum.TryParse<EquipType>(equipType1, out var type))
					throw new DatabaseErrorException($"Invalid equip type 1 '{equipType1}'.");
				info.EquipType1 = type;
			}

			var equipType2 = entry.ReadString("equipType2", null);
			if (equipType2 != null)
			{
				if (!Enum.TryParse<EquipType>(equipType2, out var type))
					throw new DatabaseErrorException($"Invalid equip type 2 '{equipType2}'.");
				info.EquipType2 = type;
			}

			info.MinLevel = entry.ReadInt("minLevel", 1);

			this.Entries[info.Id] = info;
		}

		private InventoryCategory GetItemCategory(ItemGroup group)
		{
			switch(group)
			{
				case ItemGroup.Premium: return InventoryCategory.Premium;
				case ItemGroup.Weapon: return InventoryCategory.Weapon;
				case ItemGroup.Armor: return InventoryCategory.Armor;
				//case ItemGroup.SubWeapon: return InventoryCategory.SubWeapon;
				//case ItemGroup.Costume: return InventoryCategory.Costume;
				case ItemGroup.Event: return InventoryCategory.Accessory;
				case ItemGroup.Consume: return InventoryCategory.Consumable;
				//case ItemGroup.Gem: return InventoryCategory.Gem;
				//case ItemGroup.RecipeWeapon: return InventoryCategory.RecipeWeapon;
				//case ItemGroup.Card: return InventoryCategory.Card;
				//case ItemGroup.Collection: return InventoryCategory.Collection;
				//case ItemGroup.Book: return InventoryCategory.Book;
				case ItemGroup.Quest: return InventoryCategory.Quest;
				//case ItemGroup.PetWeapon: return InventoryCategory.PetWeapon;
				//case "FishingRod": return InventoryCategory.PetArmor;
				case ItemGroup.Unused: return InventoryCategory.Money;
				case ItemGroup.Material: return InventoryCategory.Material;
				//case ItemGroup.Cube: return InventoryCategory.Cube;
				//case ItemGroup.RecipeArmor: return InventoryCategory.RecipeArmor;
				//case "Consume": return InventoryCategory.RecipeAccessory;
				//case "Armor": return InventoryCategory.RecipePremium;
				//case "Helmet": return InventoryCategory.RecipeOther;
				case ItemGroup.MagicAmulet: return InventoryCategory.Accessory;
				//case ItemGroup.Armband: return InventoryCategory.Necklace;
				default: return InventoryCategory.Premium;

			}
		}
	}

	public enum EquipType
	{
		None,
		Sword,
		THSword,
		Dagger,
		Staff,
		THStaff,
		Bow,
		THBow,
		Mace,
		THMace,
		Spear,
		THSpear,
		Rapier,
		Musket,
		Gun,
		Pistol,
		Cannon,
		Shield,
		Charm,
		Outer,
		Pants,
		Gloves,
		Boots,
		Shirt,
		Armband,
		Helmet,
		Hat,
		Premium,
		Neck,
		Ring,
		Hair,
		Lens,
		Wing,
		Artefact,
		SpecialCostume,
		EffectCostume,
		Seal,
		Trinket,
		Relic,
		Skin,
	}
}
