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
		Weapon = 2,
		Armor = 3,
		SubWeapon = 4,
		Costume = 5,
		Accessory = 6,
		Consumable = 7,
		Gem = 8,
		RecipeWeapon = 9,
		Card = 10,
		Collection = 11,
		Book = 12,
		Quest = 13,
		PetWeapon = 14,
		PetArmor = 15,
		Money = 16, // invisible
		Material = 17,
		Cube = 18,
		RecipeArmor = 19,
		RecipeAccessory = 20,
		RecipePremium = 21,
		RecipeOther = 22, // and above
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
		/// </remarks>
		public const int EquipSlotCount = 30;

		/// <summary>
		/// Ids of the items equipped by default.
		/// (Literally empty items, NoHat, NoWeapon, etc.)
		/// </summary>
		public static readonly int[] DefaultItems = new int[EquipSlotCount] { 2, 2, 12101, 8, 6, 7, 10000, 11000, 9999996, 9999996, 4, 9, 9, 4, 521101, 9, 9, 9, 9, 10, 2, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
		public static readonly int[] DefaultItems2 = new int[EquipSlotCount] { 2, 2, 12101, 8, 6, 7, 10000, 11000, 9999996, 9999996, 4, 9, 9, 4, 5, 9, 9, 9, 9, 10, 2, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
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
