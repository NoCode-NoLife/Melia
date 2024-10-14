using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ItemData
	{
		public int Id { get; set; }

		public string ClassName { get; set; }
		public string Name { get; set; }

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
		public float SmallSizeBonus { get; set; }
		public float MediumSizeBonus { get; set; }
		public float LargeSizeBonus { get; set; }
		public ArmorMaterialType Material { get; set; }
		public SkillId LeftHandSkill { get; set; }
		public SkillAttackType AttackType { get; set; }

		public float Slash { get; set; }
		public float Aries { get; set; }
		public float Strike { get; set; }
		public float SlashDefense { get; set; }
		public float AriesDefense { get; set; }
		public float StrikeDefense { get; set; }
		public float SlashRange { get; set; }
		public float AriesRange { get; set; }
		public float StrikeRange { get; set; }

		public float FireResistence { get; set; }
		public float IceResistence { get; set; }
		public float LightningResistence { get; set; }
		public float EarthResistence { get; set; }
		public float PoisonResistence { get; set; }
		public float HolyResistence { get; set; }
		public float DarkResistence { get; set; }
		public float SoulResistence { get; set; }

		public CooldownId CooldownId { get; set; }
		public TimeSpan CooldownTime { get; set; }

		public ItemScriptData Script { get; set; }

		public bool HasScript => this.Script != null;
		public bool HasCooldown => this.CooldownTime > TimeSpan.Zero;


		public EquipExpGroup EquipExpGroup { get; set; }
		public CardGroup CardGroup { get; set; }
		public int CardLevel { get; set; }
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
		/// <summary>
		/// Returns the item with the given name or null if there was no
		/// matching item.
		/// </summary>
		/// <param name="name">Name of the item (case-insensitive)</param>
		/// <returns></returns>
		public ItemData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		/// <summary>
		/// Returns the item with the given class name or null if there was no
		/// matching item.
		/// </summary>
		/// <param name="name">Name of the item (case-insensitive)</param>
		/// <returns></returns>
		public ItemData FindByClass(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.ClassName.ToLower() == name).Value;
		}


		/// <summary>
		/// Returns a list of all items whose name contains the given string
		/// If there is an exact match, return only those ones
		/// </summary>
		/// <param name="searchString">String to search for (case-insensitive)</param>
		/// <returns></returns>
		public List<ItemData> FindAllPreferExact(string searchString)
		{
			searchString = searchString.ToLower();

			var exactMatches = this.Entries.Values.Where(a => a.Name.ToLower() == searchString);
			if (exactMatches.Any())
				return exactMatches.ToList();

			return this.FindAll(searchString);
		}

		/// <summary>
		/// Returns a list of all items whichs' names contain the given
		/// string.
		/// </summary>
		/// <param name="searchString">String to look for in the item names (case-insensitive)</param>
		/// <returns></returns>
		public List<ItemData> FindAll(string searchString)
		{
			searchString = searchString.ToLower();
			return this.Entries.Where(a => a.Value.Name.ToLower().Contains(searchString)).Select(a => a.Value).ToList();
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("itemId", "className", "name", "type", "group", "weight", "maxStack", "price", "sellPrice");

			var data = new ItemData();

			data.Id = entry.ReadInt("itemId");

			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");
			data.Type = entry.ReadEnum<ItemType>("type");
			data.Group = entry.ReadEnum<ItemGroup>("group");

			data.Weight = entry.ReadFloat("weight", 0);
			data.MaxStack = entry.ReadInt("maxStack", 1);
			data.Price = entry.ReadInt("price", 0);
			data.SellPrice = entry.ReadInt("sellPrice", 0);
			data.EquipType1 = entry.ReadEnum<EquipType>("equipType1", EquipType.None);
			data.EquipType2 = entry.ReadEnum<EquipType>("equipType2", EquipType.None);
			data.MinLevel = entry.ReadInt("minLevel", 1);

			data.Category = GetCategory(data);
			data.CardGroup = entry.ReadEnum("cardGroup", CardGroup.None);
			data.CardLevel = entry.ReadInt("cardLevel", 0);
			data.EquipExpGroup = entry.ReadEnum("equipExpGroup", EquipExpGroup.None);

			data.MinAtk = entry.ReadFloat("minAtk", 0);
			data.MaxAtk = entry.ReadFloat("maxAtk", 0);
			data.PAtk = entry.ReadFloat("pAtk", 0);
			data.MAtk = entry.ReadFloat("mAtk", 0);
			data.AddMinAtk = entry.ReadFloat("addMinAtk", 0);
			data.AddMaxAtk = entry.ReadFloat("addMaxAtk", 0);
			data.AddMAtk = entry.ReadFloat("addMAtk", 0);
			data.Def = entry.ReadFloat("def", 0);
			data.MDef = entry.ReadFloat("mDef", 0);
			data.AddDef = entry.ReadFloat("addDef", 0);
			data.AddMDef = entry.ReadFloat("addMDef", 0);
			data.SmallSizeBonus = entry.ReadFloat("smallSizeBonus", 0);
			data.MediumSizeBonus = entry.ReadFloat("mediumSizeBonus", 0);
			data.LargeSizeBonus = entry.ReadFloat("largeSizeBonus", 0);
			data.Material = entry.ReadEnum<ArmorMaterialType>("material", ArmorMaterialType.None);
			data.LeftHandSkill = entry.ReadEnum<SkillId>("leftHandSkill", SkillId.None);
			data.AttackType = entry.ReadEnum<SkillAttackType>("attackType", SkillAttackType.None);

			data.Aries = entry.ReadFloat("aries", 0);
			data.Slash = entry.ReadFloat("slash", 0);
			data.Strike = entry.ReadFloat("strike", 0);
			data.AriesDefense = entry.ReadFloat("ariesDef", 0);
			data.SlashDefense = entry.ReadFloat("slashDef", 0);
			data.StrikeDefense = entry.ReadFloat("strikeDef", 0);

			data.FireResistence = entry.ReadFloat("fireRes", 0);
			data.IceResistence = entry.ReadFloat("iceRes", 0);
			data.PoisonResistence = entry.ReadFloat("poisonRes", 0);
			data.LightningResistence = entry.ReadFloat("lightningRes", 0);
			data.EarthResistence = entry.ReadFloat("earthRes", 0);
			data.SoulResistence = entry.ReadFloat("soulRes", 0);
			data.HolyResistence = entry.ReadFloat("holyRes", 0);
			data.DarkResistence = entry.ReadFloat("darkRes", 0);

			data.CooldownId = entry.ReadEnum<CooldownId>("cooldownGroup", 0);
			data.CooldownTime = entry.ReadTimeSpan("cooldown", TimeSpan.Zero);

			if (entry.TryGetObject("script", out var scriptEntry))
			{
				// We can't really assert that no fields are missing,
				// because thanks to dialog transactions, some items
				// have no script function but do define arguments.
				//scriptEntry.AssertNotMissing("function", "strArg", "numArg1", "numArg2");

				var scriptData = new ItemScriptData();

				scriptData.Function = scriptEntry.ReadString("function");
				scriptData.StrArg = scriptEntry.ReadString("strArg");
				scriptData.NumArg1 = scriptEntry.ReadFloat("numArg1");
				scriptData.NumArg2 = scriptEntry.ReadFloat("numArg2");

				data.Script = scriptData;
			}

			this.AddOrReplace(data.Id, data);
		}

		/// <summary>
		/// Returns the category for the given item.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		private static InventoryCategory GetCategory(ItemData data)
		{
			// This data is not included in the client and as far as I
			// can tell there is nothing in the client to simplify this.
			// We just have to manually categorize the items.

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
