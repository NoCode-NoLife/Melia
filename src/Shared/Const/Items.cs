// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;

namespace Melia.Shared.Const
{
	/// <summary>
	/// Inventory category indexes.
	/// </summary>
	/// <remarks>
	/// Used as category in our item database, which is kind of unofficial,
	/// as the client has separate tables for different kinds of items.
	/// As a result, the category in our data dictates where an item appears
	/// in the inventory.
	/// </remarks>
	public enum InventoryCategory
	{
		Premium = 1,
		Weapon = 15,
		Armor = 26,
		SubWeapon = 4,
		Costume = 5,
		Accessory = 30,
		Consumable = 53,
		Gem = 8,
		RecipeWeapon = 9,
		Card = 10,
		Collection = 11,
		Book = 12,
		Quest = 85,
		PetWeapon = 14,
		PetArmor = 15,
		Money = 94, // invisible
		Material = 82,
		Cube = 55,
		RecipeArmor = 19,
		RecipeAccessory = 20,
		RecipePremium = 21,
		RecipeOther = 22, // and above
		Bracelet = 30,
		Necklace = 30,
	}

	public enum ItemType
	{
		Unknown = -1,
		Consume = 1,
		Equip = 2,
		Quest = 3,
		Etc = 4,
		Unused = 5,
	}

	public enum ItemGroup
	{
		Unknown = -1,
		Premium = 1,
		Quest = 2,
		Arcane = 3,
		Drug = 4,
		Material = 5,
		Event = 6,
		Misc = 7,
		Ark = 8,
		LegendMaterial = 9,
		MagicAmulet = 10,
		SpecialMaterial = 11,
		Icor = 12,
		ExpOrb = 13,
		SubExpOrb = 14,
		FishingRod = 15,
		PasteBait = 16,
		Unused = 17,
		HiddenAbility = 18,
		Entrance_Ticket = 19,
		Consume = 20,
		Armor = 21,
		Helmet = 22,
		Weapon = 23,
		Armband = 24,
		SubWeapon = 25,
		Seal = 26,
		Relic = 27,
		Gem = 28,
	}

	public static class InventoryCategoryExtension
	{
		/// <summary>
		/// Returns inventory index for category and category index.
		/// </summary>
		/// <remarks>
		/// Categories are offset by 5000 times their id. We start each
		/// category on index 1 in that range. For example, the first
		/// weapon has index 5001, the second one 5002, the fifth armor
		/// has 10005, and so on.
		/// </remarks>
		/// <param name="cat">Category the index is in.</param>
		/// <param name="index">The index of the item in the category.</param>
		/// <returns></returns>
		public static int GetIndex(this InventoryCategory cat, int index)
		{
			return (int)cat * 5000 + index + 1;
		}
	}

	/// <remarks>
	/// We're using this enum to save which slot an item is equipped on,
	/// should the values change, the values in the database would be
	/// incorrect. Should this enum change again, we should think about
	/// saving the slots as string or creating an intermediary enum.
	/// </remarks>
	public enum EquipSlot : byte
	{
		HairAccessory, // HAT
		SubsidiaryAccessory, // HAT_L
		Hair, // HAIR
		Top, // SHIRT
		Gloves, // GLOVES
		Shoes, // BOOTS
		Helmet, // HELMET
		Armband, // ARMBAND
		RightHand, // RH
		LeftHand, // LH
		Outer1, // OUTER
		Ring1, // OUTERADD1
		Ring2, // OUTERADD2
		Outer2, // BODY
		Pants, // PANTS
		Ring3, // PANTSADD1
		Ring4, // PANTSADD2
		Bracelet1, // RING1
		Bracelet2, // RING2
		Necklace, // NECK
		Hat, // HAT_T
		Lens, // LENS
		Wing, // WING
		SpecialCostume, // ?
		EffectCostume, // ?
	}

	public enum InventoryItemRemoveMsg : byte
	{
		Given = 0, // 0,6,10
		Sold = 1,
		PaidWith = 2,
		Destroyed = 3,
		Equipped = 5,
		Used = 7, // 7,8
	}

	public enum InventoryType : byte
	{
		Inventory = 0,
		Warehouse = 1,
	}

	public enum InventoryAddType : byte
	{
		Buy = 1,
		Sell = 2,
		PickUp = 3, // ?
		NotNew = 4,
	}

	public static class Items
	{
		/// <summary>
		/// Ammount of equip slots.
		/// </summary>
		/// <remarks>
		/// [i11025]  20->21, hair
		/// [i170175] 21->22, lens
		/// [i171032] 22->23, wings
		/// [i184075] 23->24, special costume
		/// [i186893] 24->25, effect costume
		/// [i337645] 25->30
		/// [i339415] 30->32
		/// </remarks>
		public const int EquipSlotCount = 32;

		/// <summary>
		/// Ids of the items equipped by default.
		/// (Literally empty items, NoHat, NoWeapon, etc.)
		/// </summary>
		public static readonly int[] DefaultItems = new int[EquipSlotCount] { 2, 2, 12101, 8, 6, 7, 10000, 11000, 9999996, 9999996, 4, 9, 9, 4, 5, 9, 9, 9, 9, 10, 2, 4, 4, 4, 4, 4, 4, 4, 4, 4, 9999996, 9999996 };
	}

	public enum InventoryOrder : byte
	{
		Price = 2,
		Grade = 0,
		Weight = 1,
		Name = 3,

		Id = 0xFF,
	}

	/// <summary>
	/// Ids of commonly used items.
	/// </summary>
	public static class ItemId
	{
		public const int Silver = 900011;
	}

	/// <summary>
	/// Specifies which hats are visible for a character.
	/// </summary>
	[Flags]
	public enum HatVisibleStates : byte
	{
		Hat1 = 0x01,
		Hat2 = 0x02,
		Hat3 = 0x04,
	}
}
