//--- Melia Script ----------------------------------------------------------
// Instant Heal Items
//--- Description -----------------------------------------------------------
// Item scripts for instant healing potions (HP, SP, Stamina).
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;
using Yggdrasil.Extensions;
using Yggdrasil.Util;

public class InstantHealItemScript : GeneralScript
{
	/// <summary>
	/// Instantly restores HP. Supports HP potion bonus modifiers
	/// (HPPotion_BM).
	/// </summary>
	/// <param name="character">The character that used the item.</param>
	/// <param name="item">The item that was used.</param>
	/// <param name="strArg">Unused.</param>
	/// <param name="numArg1">Base HP heal amount (or min if numArg2 is set).</param>
	/// <param name="numArg2">Max HP heal amount for random range (0 = no range).</param>
	/// <returns></returns>
	[ScriptableFunction]
	public ItemUseResult SCR_USE_ITEM_AddHP1(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var minAmount = numArg1;
		var maxAmount = Math.Max(minAmount, numArg2);

		var healAmount = minAmount;

		if (maxAmount > minAmount)
		{
			var rnd = RandomProvider.Get();
			healAmount = rnd.Between(minAmount, maxAmount);
		}

		if (character.Properties.TryGetFloat(PropertyName.HPPotion_BM, out var byBuff) && byBuff > 0)
			healAmount *= 1 + (byBuff / 100f);

		character.Heal(healAmount, 0);

		return ItemUseResult.Okay;
	}

	/// <summary>
	/// Instantly restores SP. Supports SP potion bonus modifiers
	/// (SPPotion_BM).
	/// </summary>
	/// <param name="character">The character that used the item.</param>
	/// <param name="item">The item that was used.</param>
	/// <param name="strArg">Unused.</param>
	/// <param name="numArg1">Base SP heal amount (or min if numArg2 is set).</param>
	/// <param name="numArg2">Max SP heal amount for random range (0 = no range).</param>
	/// <returns></returns>
	[ScriptableFunction]
	public ItemUseResult SCR_USE_ITEM_AddSP1(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var minAmount = numArg1;
		var maxAmount = Math.Max(minAmount, numArg2);

		var healAmount = minAmount;

		if (maxAmount > minAmount)
		{
			var rnd = RandomProvider.Get();
			healAmount = rnd.Between(minAmount, maxAmount);
		}

		if (character.Properties.TryGetFloat(PropertyName.SPPotion_BM, out var byBuff) && byBuff > 0)
			healAmount *= 1 + (byBuff / 100f);

		character.Heal(0, healAmount);

		return ItemUseResult.Okay;
	}

	/// <summary>
	/// Instantly restores stamina. Supports stamina potion bonus
	/// modifiers (STAPotion_BM).
	/// </summary>
	/// <param name="character">The character that used the item.</param>
	/// <param name="item">The item that was used.</param>
	/// <param name="strArg">Unused.</param>
	/// <param name="numArg1">Base stamina amount in whole numbers (multiplied by 1000 internally).</param>
	/// <param name="numArg2">Max stamina amount for random range (0 = no range).</param>
	/// <returns></returns>
	[ScriptableFunction]
	public ItemUseResult SCR_USE_ITEM_AddSTA1(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var minAmount = numArg1;
		var maxAmount = Math.Max(minAmount, numArg2);

		var healAmount = minAmount;

		if (maxAmount > minAmount)
		{
			var rnd = RandomProvider.Get();
			healAmount = rnd.Between(minAmount, maxAmount);
		}

		if (character.Properties.TryGetFloat(PropertyName.STAPotion_BM, out var staminaPotionBM) && staminaPotionBM > 0)
			healAmount *= 1 + (staminaPotionBM / 100f);

		character.ModifyStamina((int)(healAmount * 1000));

		return ItemUseResult.Okay;
	}

	/// <summary>
	/// Instantly restores both HP and SP, with SP receiving half the
	/// amount of healing. Supports both HP and SP potion bonus modifiers
	/// (HPPotion_BM, SPPotion_BM).
	/// </summary>
	/// <param name="character">The character that used the item.</param>
	/// <param name="item">The item that was used.</param>
	/// <param name="strArg">Unused.</param>
	/// <param name="numArg1">Min amount for random range.</param>
	/// <param name="numArg2">Max amount for random range.</param>
	/// <returns></returns>
	[ScriptableFunction]
	public ItemUseResult SCR_USE_ITEM_AddHPSP1(Character character, Item item, string strArg, float numArg1, float numArg2)
	{
		var minAmount = numArg1;
		var maxAmount = Math.Max(minAmount, numArg2);

		var hpHealAmount = minAmount;
		var spHealAmount = minAmount;

		if (maxAmount > minAmount)
		{
			var rnd = RandomProvider.Get();

			hpHealAmount = rnd.Between(minAmount, maxAmount);
			spHealAmount = rnd.Between(minAmount, maxAmount);
		}

		spHealAmount /= 2;

		if (character.Properties.TryGetFloat(PropertyName.HPPotion_BM, out var hpPotionBM) && hpPotionBM > 0)
			hpHealAmount *= 1 + (hpPotionBM / 100f);

		if (character.Properties.TryGetFloat(PropertyName.SPPotion_BM, out var spPotionBM) && spPotionBM > 0)
			spHealAmount *= 1 + (spPotionBM / 100f);

		character.Heal(hpHealAmount, spHealAmount);

		return ItemUseResult.Okay;
	}
}
