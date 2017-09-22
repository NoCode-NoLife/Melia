// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Text.RegularExpressions;
using Melia.Channel.World;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;

namespace Melia.Channel.Util
{
	// This is all a little temporary. I don't know if we might want to
	// use Lua for this, or maybe something else entirely.
	public static class AbilityPriceTime
	{
		private static readonly Regex CallRegex = new Regex(@"^\s*(?<funcName>[a-z0-9_]+)\s*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

		/// <summary>
		/// Returns price and time to level up ability for character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="abilityData"></param>
		/// <param name="abilityTreeData"></param>
		/// <param name="level"></param>
		/// <param name="price"></param>
		/// <param name="time"></param>
		public static void Get(Character character, AbilityData abilityData, AbilityTreeData abilityTreeData, int abilityLevel, out int price, out int time)
		{
			price = 999999;
			time = 999999;

			// This is all a little temporary. I don't know if we might want
			// to use Lua for this, or maybe something else entirely.
			// If we leave it as C#, we might not want to use reflection,
			// or at least cache the methods, but for now it will work fine.

			var call = abilityTreeData.PriceTime;
			var match = CallRegex.Match(call);
			if (!match.Success)
			{
				Log.Warning("AbilityPriceTime.Get: Invalid unlock call '{0}'.", call);
				return;
			}

			var funcName = match.Groups["funcName"].Value;
			var abilityClassName = abilityData.ClassName;
			var maxLevel = abilityTreeData.MaxLevel;

			var method = typeof(AbilityPriceTime).GetMethod(funcName);
			if (method == null)
			{
				Log.Warning("AbilityPriceTime.Get: Unknown function '{0}'.", funcName);
				return;
			}

			var parameters = method.GetParameters();
			if (
				method.ReturnType != typeof(void) ||
				parameters.Length != 6 ||
				parameters[0].ParameterType != typeof(Character) ||
				parameters[1].ParameterType != typeof(string) ||
				parameters[2].ParameterType != typeof(int) ||
				parameters[3].ParameterType != typeof(int) ||
				parameters[4].ParameterType.GetElementType() != typeof(int) || !parameters[4].IsOut ||
				parameters[5].ParameterType.GetElementType() != typeof(int) || !parameters[5].IsOut
			)
			{
				Log.Warning("AbilityPriceTime.Get: Function '{0}' has an invalid signature.", funcName);
				return;
			}

			var funcParameters = new object[] { character, abilityClassName, abilityLevel, maxLevel, null, null };
			method.Invoke(null, funcParameters);

			price = (int)funcParameters[4];
			time = (int)funcParameters[5];
		}

		public static void ABIL_1RANK_NORMAL_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1;
			time = 4 + (4 - maxLevel + abilityLevel) * 4;
		}

		public static void ABIL_2RANK_NORMAL_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1;
			time = 8 + (4 - maxLevel + abilityLevel) * 4;
		}

		public static void ABIL_3RANK_NORMAL_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1;
			time = 12 + (4 - maxLevel + abilityLevel) * 4;
		}

		public static void ABIL_4RANK_NORMAL_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1;
			time = 16 + (4 - maxLevel + abilityLevel) * 4;
		}

		public static void ABIL_5RANK_NORMAL_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 22 + (4 - maxLevel + abilityLevel) * 2;
			time = 20 + (4 - maxLevel + abilityLevel) * 4;
		}

		public static void ABIL_6RANK_NORMAL_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 41 + (4 - maxLevel + abilityLevel) * 3;
			time = 24 + (4 - maxLevel + abilityLevel) * 4;
		}

		public static void ABIL_7RANK_NORMAL_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 70 + (4 - maxLevel + abilityLevel) * 7;
			time = 28 + (4 - maxLevel + abilityLevel) * 4;
		}

		public static void ABIL_8RANK_NORMAL_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 480 + (4 - maxLevel + abilityLevel) * 45;
			time = 240 + (4 - maxLevel + abilityLevel) * 100;
		}

		public static void ABIL_1RANK_BUFF_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1;
			time = 4 + (abilityLevel - 1);
		}

		public static void ABIL_2RANK_BUFF_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1;
			time = 8 + (abilityLevel - 1);
		}

		public static void ABIL_3RANK_BUFF_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1;
			time = 12 + (abilityLevel - 1);
		}

		public static void ABIL_4RANK_BUFF_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1;
			time = 16 + (abilityLevel - 1);
		}

		public static void ABIL_5RANK_BUFF_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 22 + (abilityLevel - 1) * 2;
			time = 20 + (abilityLevel - 1);
		}

		public static void ABIL_6RANK_BUFF_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 41 + (abilityLevel - 1) * 3;
			time = 24 + (abilityLevel - 1);
		}

		public static void ABIL_7RANK_BUFF_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 70 + (abilityLevel - 1) * 7;
			time = 28 + (abilityLevel - 1);
		}

		public static void ABIL_8RANK_BUFF_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 500 + (abilityLevel - 1) * 55;
			time = 240 + (abilityLevel - 1) * 20;
		}

		public static void ABIL_1RANK_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 1);
			time = 0;
		}

		public static void ABIL_2RANK_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 2);
			time = 0;
		}

		public static void ABIL_3RANK_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 3);
			time = 0;
		}

		public static void ABIL_4RANK_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 4);
			time = 0;
		}

		public static void ABIL_5RANK_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 5);
			time = 0;
		}

		public static void ABIL_6RANK_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 6);
			time = 0;
		}

		public static void ABIL_7RANK_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 7);
			time = 0;
		}

		public static void ABIL_8RANK_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.0822, (abilityLevel - 1)) * 8);
			time = 0;
		}

		public static void ABIL_3RANK_MASTER_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 3;
			time = 0;
		}

		public static void ABIL_SWAPWEAPON_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 3;
			time = 10;
		}

		public static void ABIL_MASTERY_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 3 + 1 * (abilityLevel - 1);
			time = 30;
		}

		public static void ABIL_UNIQUEMASTERY_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 6 + 1 * (abilityLevel - 1);
			time = 60;
		}

		public static void ABIL_BOKOR21_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 60 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 7);
			time = (int)Math.Floor(1 + (abilityLevel * 0.1));
		}

		public static void ABIL_BOKOR22_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 60 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 7);
			time = (int)Math.Floor(1 + (abilityLevel * 0.1));
		}

		public static void ABIL_SAVEPOISON_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.07, (abilityLevel - 1)) * 6);
			time = 0;
		}

		public static void ABIL_SORCERER2_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 35);
			time = 0;
		}

		public static void ABIL_SQUIRE_TOUCHUP_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.04, (abilityLevel - 1)) * 15);
			time = 0;
		}

		public static void ABIL_SQUIRE_FOODTABLE_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 10 + 10 * (abilityLevel - 1);
			time = 10;
		}

		public static void ABIL_BOKOR17_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.04, (abilityLevel - 1)) * 10);
			time = 0;
		}

		public static void ABIL_PARDONER5_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = abilityLevel * 1 + RandomProvider.Get().Next(0, 99); // could be max 100
			time = 0;
		}

		public static void ABIL_TINCTURINGPOTION_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = abilityLevel * 10;
			time = 60 + abilityLevel * 4;
		}

		public static void ABIL_HIGHLANDER28_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 15;
			time = 0;
		}

		public static void ABIL_CATAPHRACT28_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 70;
			time = 0;
		}

		public static void ABIL_CATAPHRACT30_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 100;
			time = 0;
		}

		public static void ABIL_NECROMANCER8_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 80 + (int)Math.Floor(Math.Pow(1.05, (abilityLevel - 1)) * 9);
			time = (int)Math.Floor(1 + (abilityLevel * 0.1));
		}

		public static void ABIL_PROVOKE_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1 + (abilityLevel - 1) * 1;
			time = 0;
		}

		public static void ABIL_UNLOCKCHEST_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 32 * abilityLevel;
			time = 1;
		}

		public static void ABIL_TAXPAYMENT_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.09, (abilityLevel - 1)) * 1);
			time = 1;
		}

		public static void ABIL_FEATHERFOOTBLOOD_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.055, (abilityLevel - 1)) * 20);
			time = 1;
		}

		public static void ABIL_FEATHERFOOTREGENERATE_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 500;
			time = 40 + (abilityLevel - 1) * 5;
		}

		public static void ABIL_QUARRELSHOOTER9_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1 + (abilityLevel - 1) * 1;
			time = 60 + (abilityLevel - 1) * 10;
		}

		public static void ABIL_RODELERO29_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 41 + (abilityLevel - 1) * 3;
			time = 24 + (abilityLevel - 1) * 4;
		}

		public static void ABIL_CLERIC18_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 2 + (abilityLevel - 1) * 1;
			time = 1;
		}

		public static void ABIL_ADDBUFFCOUNT_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 10;
			time = 0;
		}

		public static void ABIL_DOPPELSOELDNER20_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 713;
			time = 1440;
		}

		public static void ABIL_ALCHEMIST10_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 3000;
			time = 3000;
		}

		public static void ABIL_TOTALDEADPARTS_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1670 + (abilityLevel - 1) * 200;
			time = 300 * abilityLevel;
		}

		public static void ABIL_HIGHERROTTEN_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 2000;
			time = 1500;
		}

		public static void ABIL_WARLOCK14_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 450 + (int)Math.Floor(Math.Pow(1.1, (abilityLevel - 1)) * 65);
			time = 600 + (abilityLevel - 1) * 100;
		}

		public static void ABIL_SAGE8_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1600;
			time = 2000;
		}

		public static void ABIL_SAGE9_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1500 + (abilityLevel - 1) * 56;
			time = 2000 + (abilityLevel - 1) * 200;
		}

		public static void ABIL_FALCONER11_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1000 + (abilityLevel - 1) * 100;
			time = 1000 + (abilityLevel - 1) * 100;
		}

		public static void ABIL_SHINOBIARUKI_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1800;
			time = 1440;
		}

		public static void ABIL_SCHWARZEREITER17_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 1658;
			time = 1440;
		}

		public static void ABIL_DRUID12_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 954 + (abilityLevel - 1) * 99;
			time = 700 + (abilityLevel - 1) * 100;
		}

		public static void ABIL_INQUISITOR9_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = (int)Math.Floor(Math.Pow(1.09, (abilityLevel - 1)) * 1000);
			time = 100;
		}

		public static void ABIL_CLERIC9_PRICE(Character character, string abilityClassName, int abilityLevel, int maxLevel, out int price, out int time)
		{
			price = 3 + (abilityLevel - 1) * 1;
			time = 12 + (9 - maxLevel + abilityLevel) * 4;
		}
	}
}
