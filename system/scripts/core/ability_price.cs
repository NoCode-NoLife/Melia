//--- Melia Script ----------------------------------------------------------
// Ability Price/Time Calculation Functions
//--- Description -----------------------------------------------------------
// Scriptable functions that calculate the prices and times in minutes
// required to learn abilities.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Data.Database;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Util;

internal class AbilityPriceTimeFunctionsScript : GeneralScript
{
	[ScriptableFunction]
	public static void ABIL_1RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1 + (4 - maxLevel + abilityLevel) * 1;
			time = 4 + (4 - maxLevel + abilityLevel) * 4;
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_2RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 2 + (4 - maxLevel + abilityLevel) * 1;
			time = 8 + (4 - maxLevel + abilityLevel) * 4;
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_3RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 5 + (4 - maxLevel + abilityLevel) * 1;
			time = 12 + (4 - maxLevel + abilityLevel) * 4;
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_4RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 11 + (4 - maxLevel + abilityLevel) * 1;
			time = 16 + (4 - maxLevel + abilityLevel) * 4;
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_5RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 22 + (4 - maxLevel + abilityLevel) * 2;
			time = 20 + (4 - maxLevel + abilityLevel) * 4;
		}
		else
		{
			price = 22 + (4 - maxLevel + abilityLevel) * 2;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_6RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 41 + (4 - maxLevel + abilityLevel) * 3;
			time = 24 + (4 - maxLevel + abilityLevel) * 4;
		}
		else
		{
			price = 41 + (4 - maxLevel + abilityLevel) * 3;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_7RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 70 + (4 - maxLevel + abilityLevel) * 7;
			time = 28 + (4 - maxLevel + abilityLevel) * 4;
		}
		else
		{
			price = 70 + (4 - maxLevel + abilityLevel) * 7;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_8RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 480 + (4 - maxLevel + abilityLevel) * 45;
			time = 240 + (4 - maxLevel + abilityLevel) * 100;
		}
		else
		{
			price = 480 + (4 - maxLevel + abilityLevel) * 45;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_9RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 720 + (4 - maxLevel + abilityLevel) * 67;
			time = 360 + (4 - maxLevel + abilityLevel) * 120;
		}
		else
		{
			price = 720 + (4 - maxLevel + abilityLevel) * 67;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_10RANK_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1080 + (4 - maxLevel + abilityLevel) * 100;
			time = 400 + (4 - maxLevel + abilityLevel) * 200;
		}
		else
		{
			price = 1080 + (4 - maxLevel + abilityLevel) * 100;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_1RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1 + (abilityLevel - 1) * 1;
			time = 4 + (abilityLevel - 1);
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_2RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 2 + (abilityLevel - 1) * 1;
			time = 8 + (abilityLevel - 1);
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_3RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 5 + (abilityLevel - 1) * 1;
			time = 12 + (abilityLevel - 1);
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_4RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 11 + (abilityLevel - 1) * 1;
			time = 16 + (abilityLevel - 1);
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_5RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 22 + (abilityLevel - 1) * 2;
			time = 20 + (abilityLevel - 1);
		}
		else
		{
			price = 22 + (abilityLevel - 1) * 2;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_6RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 41 + (abilityLevel - 1) * 3;
			time = 24 + (abilityLevel - 1);
		}
		else
		{
			price = 41 + (abilityLevel - 1) * 3;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_7RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 70 + (abilityLevel - 1) * 7;
			time = 28 + (abilityLevel - 1);
		}
		else
		{
			price = 70 + (abilityLevel - 1) * 7;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_8RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 571 + (abilityLevel - 1) * 71;
			time = 240 + (abilityLevel - 1) * 20;
		}
		else
		{
			price = 500 + (abilityLevel - 1) * 55;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_9RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 600 + (abilityLevel - 1) * 65;
			time = 360 + (abilityLevel - 1) * 30;
		}
		else
		{
			price = 600 + (abilityLevel - 1) * 65;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_10RANK_BUFF_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 700 + (abilityLevel - 1) * 75;
			time = 400 + (abilityLevel - 1) * 50;
		}
		else
		{
			price = 700 + (abilityLevel - 1) * 75;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_1RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 1);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_2RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 2);
			time = 0;
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_3RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 3);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_4RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 4);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_5RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 5);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_6RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 6);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_7RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 7);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_8RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = (int)Math.Floor(Math.Pow(1.085, (abilityLevel - 1)) * 8);
			time = 0;
		}
		else
		{
			price = (int)Math.Floor(Math.Pow(1.0822, (abilityLevel - 1)) * 8);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_9RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.0822, (abilityLevel - 1)) * 8.5);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_10RANK_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.0822, (abilityLevel - 1)) * 9);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_10RANK_FOR67_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 250 + (abilityLevel - 1) * 250;
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_3RANK_MASTER_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 3;
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_BASE_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 1;
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_REINFORCE_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		var baseFactor = 1.07;

		var increaseFactorList = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 8.5, 9 };
		var increaseFactor = 0.0;

		var index = (int)Math.Ceiling(abilityLevel / 10.0) - 1;
		if (index >= 0 && index < increaseFactorList.Length)
			increaseFactor = increaseFactorList[index];

		price = (int)Math.Floor(Math.Pow(baseFactor, (abilityLevel - 1)) * increaseFactor);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_ABOVE_NORMAL_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 60 + (abilityLevel - 1) * 5;
		time = 0;
	}

	private static void ABIL_COMMON_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, int minimumFactor, int increseFactor, out int price, out int time)
	{
		price = Math.Max(1, minimumFactor + (4 - maxLevel + abilityLevel) * increseFactor);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_COMMON_PRICE_1LV(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
		=> ABIL_COMMON_PRICE(character, abilityData, abilityLevel, maxLevel, 11, 1, out price, out time);

	[ScriptableFunction]
	public static void ABIL_COMMON_PRICE_100LV(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
		=> ABIL_COMMON_PRICE(character, abilityData, abilityLevel, maxLevel, 22, 2, out price, out time);

	[ScriptableFunction]
	public static void ABIL_COMMON_PRICE_150LV(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
		=> ABIL_COMMON_PRICE(character, abilityData, abilityLevel, maxLevel, 34, 3, out price, out time);

	[ScriptableFunction]
	public static void ABIL_COMMON_PRICE_200LV(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
		=> ABIL_COMMON_PRICE(character, abilityData, abilityLevel, maxLevel, 48, 4, out price, out time);

	[ScriptableFunction]
	public static void ABIL_COMMON_PRICE_250LV(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
		=> ABIL_COMMON_PRICE(character, abilityData, abilityLevel, maxLevel, 63, 5, out price, out time);

	[ScriptableFunction]
	public static void ABIL_COMMON_PRICE_300LV(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
		=> ABIL_COMMON_PRICE(character, abilityData, abilityLevel, maxLevel, 84, 6, out price, out time);

	[ScriptableFunction]
	public static void ABIL_COMMON_PRICE_350LV(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
		=> ABIL_COMMON_PRICE(character, abilityData, abilityLevel, maxLevel, 115, 7, out price, out time);

	[ScriptableFunction]
	public static void ABIL_COMMON_PRICE_400LV(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
		=> ABIL_COMMON_PRICE(character, abilityData, abilityLevel, maxLevel, 240, 45, out price, out time);

	[ScriptableFunction]
	public static void ABIL_SWAPWEAPON_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 3;
			time = 10;
		}
		else
		{
			price = 3;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_MASTERY_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 3 + 1 * (abilityLevel - 1);
			time = 30;
		}
		else
		{
			price = 3 + 1 * (abilityLevel - 1);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_UNIQUEMASTERY_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 6 + 1 * (abilityLevel - 1);
			time = 60;
		}
		else
		{
			price = 6 + 1 * (abilityLevel - 1);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_BOKOR21_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 60 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 7);
			time = (int)Math.Floor(1 + (abilityLevel * 0.1));
		}
		else
		{
			price = 60 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 7);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_BOKOR22_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 60 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 7);
			time = (int)Math.Floor(1 + (abilityLevel * 0.1));
		}
		else
		{
			price = 60 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 7);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_SAVEPOISON_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 6);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_SORCERER2_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 35);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_SQUIRE_TOUCHUP_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.04, (abilityLevel - 1)) * 15);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_SQUIRE_FOODTABLE_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 10 + 10 * (abilityLevel - 1);
			time = 10;
		}
		else
		{
			price = 10 + 10 * (abilityLevel - 1);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_BOKOR17_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = (int)Math.Floor(Math.Pow(1.04, (abilityLevel - 1)) * 10);
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_PARDONER5_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = abilityLevel * 1 + RandomProvider.Get().Next(0, 99); // could be max 100
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_TINCTURINGPOTION_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = abilityLevel * 10;
			time = 60 + abilityLevel * 4;
		}
		else
		{
			price = abilityLevel * 10;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_HIGHLANDER28_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 15;
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_CATAPHRACT28_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 70;
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_CATAPHRACT30_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 100;
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_NECROMANCER8_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 80 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 9);
			time = (int)Math.Floor(1 + (abilityLevel * 0.1));
		}
		else
		{
			price = 80 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 9);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_PROVOKE_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 1 + (abilityLevel - 1) * 1;
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_UNLOCKCHEST_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 32 * abilityLevel;
			time = 1;
		}
		else
		{
			price = 32 * abilityLevel;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_TAXPAYMENT_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = (int)Math.Floor(Math.Pow(1.09, (abilityLevel - 1)) * 1);
			time = 1;
		}
		else
		{
			price = (int)Math.Floor(Math.Pow(1.09, (abilityLevel - 1)) * 1);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_FEATHERFOOTBLOOD_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = (int)Math.Floor(Math.Pow(1.055, (abilityLevel - 1)) * 20);
			time = 1;
		}
		else
		{
			price = (int)Math.Floor(Math.Pow(1.055, (abilityLevel - 1)) * 20);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_FEATHERFOOTREGENERATE_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 500;
			time = 40 + (abilityLevel - 1) * 5;
		}
		else
		{
			price = 500;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_QUARRELSHOOTER9_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1 + (abilityLevel - 1) * 1;
			time = 60 + (abilityLevel - 1) * 10;
		}
		else
		{
			price = 1 + (abilityLevel - 1) * 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_RODELERO29_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 41 + (abilityLevel - 1) * 3;
			time = 24 + (abilityLevel - 1) * 4;
		}
		else
		{
			price = 41 + (abilityLevel - 1) * 3;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_CLERIC18_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 2 + (abilityLevel - 1) * 1;
			time = 1;
		}
		else
		{
			price = 2 + (abilityLevel - 1) * 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_ADDBUFFCOUNT_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 10;
		time = 0;
	}

	[ScriptableFunction]
	public static void ABIL_DOPPELSOELDNER20_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 713;
			time = 1440;
		}
		else
		{
			price = 713;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_ALCHEMIST10_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 3000;
			time = 3000;
		}
		else
		{
			price = 3000;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_TOTALDEADPARTS_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1670 + (abilityLevel - 1) * 200;
			time = 300 * abilityLevel;
		}
		else
		{
			price = 1670 + (abilityLevel - 1) * 200;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_HIGHERROTTEN_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 2000;
			time = 1500;
		}
		else
		{
			price = 2000;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_WARLOCK14_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 571 + (int)Math.Floor(Math.Pow(1.1, (abilityLevel - 1)) * 80);
			time = 600 + (abilityLevel - 1) * 100;
		}
		else
		{
			price = 450 + (int)Math.Floor(Math.Pow(1.1, (abilityLevel - 1)) * 65);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_SAGE8_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 2000;
			time = 2000;
		}
		else
		{
			price = 1600;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_SAGE9_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1600 + (abilityLevel - 1) * 100;
			time = 2000 + (abilityLevel - 1) * 200;
		}
		else
		{
			price = 1500 + (abilityLevel - 1) * 56;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_FALCONER11_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1000 + (abilityLevel - 1) * 100;
			time = 1000 + (abilityLevel - 1) * 100;
		}
		else
		{
			price = 1000 + (abilityLevel - 1) * 100;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_SHINOBIARUKI_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1800;
			time = 1440;
		}
		else
		{
			price = 1800;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_SCHWARZEREITER17_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 1658;
			time = 1440;
		}
		else
		{
			price = 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_DRUID12_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 954 + (abilityLevel - 1) * 99;
			time = 700 + (abilityLevel - 1) * 100;
		}
		else
		{
			price = 954 + (abilityLevel - 1) * 99;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_INQUISITOR9_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = (int)Math.Floor(Math.Pow(1.09, (abilityLevel - 1)) * 1000);
			time = 100;
		}
		else
		{
			price = (int)Math.Floor(Math.Pow(1.09, (abilityLevel - 1)) * 1000);
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void ABIL_CLERIC9_PRICE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		if (!Feature.IsEnabled("AbilityCostRevamp"))
		{
			price = 3 + (abilityLevel - 1) * 1;
			time = 12 + (9 - maxLevel + abilityLevel) * 4;
		}
		else
		{
			price = 3 + (abilityLevel - 1) * 1;
			time = 0;
		}
	}

	[ScriptableFunction]
	public static void HIDDENABIL_PRICE_COND_REINFORCE(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 3057 * (int)Math.Max(1, Math.Pow(3, Math.Ceiling(abilityLevel / 10.0) - 2));
		time = 0;
	}

	[ScriptableFunction]
	public static void HIDDENABIL_PRICE_COND_JOBLEVEL(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time)
	{
		price = 36000 / maxLevel;
		time = 0;
	}
}
