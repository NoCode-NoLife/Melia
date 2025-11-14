//--- Melia Script ----------------------------------------------------------
// Instant Heal Items
//--- Description -----------------------------------------------------------
// Item scripts for instant healing potions (HP, SP, Stamina).
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Items;
using Yggdrasil.Util;

public class InstantHealItemScript : GeneralScript
{
	/// <summary>
	/// Instantly restores HP. Supports HP potion bonus modifiers (HPPotion_BM).
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
		var hpHeal = (int)numArg1;
		if (numArg2 != 0)
			hpHeal = RandomProvider.Get().Next((int)numArg1, (int)numArg2);

		if (character.Properties.TryGetFloat(PropertyName.HPPotion_BM, out var hpPotionBM) && hpPotionBM > 0)
			hpHeal = (int)MathF.Floor(hpHeal * (1 + hpPotionBM / 100));

		character.Heal(hpHeal, 0);

		return ItemUseResult.Okay;
	}

	/// <summary>
	/// Instantly restores SP. Supports SP potion bonus modifiers (SPPotion_BM).
	/// Curse debuffs prevent SP recovery.
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
		var spHeal = (int)numArg1;
		if (numArg2 != 0)
			spHeal = RandomProvider.Get().Next((int)numArg1, (int)numArg2);

		if (character.Properties.TryGetFloat(PropertyName.SPPotion_BM, out var spPotionBM) && spPotionBM > 0)
			spHeal = (int)MathF.Floor(spHeal * (1 + spPotionBM / 100));

		character.Heal(0, spHeal);

		return ItemUseResult.Okay;
	}

	/// <summary>
	/// Instantly restores stamina. Supports stamina potion bonus modifiers (STAPotion_BM).
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
		var stamina = (int)numArg1 * 1000;
		var staminaMax = (int)numArg2 * 1000;
		if (staminaMax != 0)
			stamina = RandomProvider.Get().Next(stamina, staminaMax);

		if (character.Properties.TryGetFloat(PropertyName.STAPotion_BM, out var staminaPotionBM) && staminaPotionBM > 0)
			stamina = (int)MathF.Floor(stamina * (1 + staminaPotionBM / 100));

		character.ModifyStamina(stamina);

		return ItemUseResult.Okay;
	}

	/// <summary>
	/// Instantly restores both HP and SP. Supports both HP and SP potion bonus modifiers.
	/// Curse debuffs prevent SP recovery.
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
		var hpPoint = RandomProvider.Get().Next((int)numArg1, (int)numArg2);
		var spPoint = RandomProvider.Get().Next((int)numArg1, (int)numArg2) / 2;

		if (character.Properties.TryGetFloat(PropertyName.SPPotion_BM, out var spPotionBM) && spPotionBM > 0)
			spPoint = (int)MathF.Floor(spPoint * (1 + spPotionBM / 100));

		if (character.Properties.TryGetFloat(PropertyName.HPPotion_BM, out var hpPotionBM) && hpPotionBM > 0)
			hpPoint = (int)MathF.Floor(hpPoint * (1 + hpPotionBM / 100));

		character.Heal(hpPoint, spPoint);

		return ItemUseResult.Okay;
	}
}
