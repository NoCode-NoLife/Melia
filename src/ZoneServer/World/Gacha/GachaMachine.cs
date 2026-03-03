using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.Util;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Extensions;
using Yggdrasil.Util;

namespace Melia.Zone.World.Gacha
{
	/// <summary>
	/// A gacha machine, full of fun and excitement, with not a single
	/// pay-to-win aspect in sight.
	/// </summary>
	public class GachaMachine
	{
		private readonly List<GachaEntry> _entries = new();

		/// <summary>
		/// Returns the gacha machine's class name, commonly used to
		/// identify the item its based on and the associated animations
		/// and item lists.
		/// </summary>
		public string ClassName { get; }

		/// <summary>
		/// Returns the type of the gacha machine, indicating its look and
		/// feel.
		/// </summary>
		public GachaMachineType Type { get; }

		/// <summary>
		/// Gets or sets the soft pity factor, affecting the odds of
		/// getting items after crossing the soft pity threshold.
		/// </summary>
		/// <remarks>
		/// Uses an exponential curve to increase the probability. As an
		/// example, with a spread of 20 common, 10 rare, and 1 super rare
		/// items, at default proabilities of 800, 150, and 50 respectively,
		/// a factor of 1.5 comes out to the following odd increases.
		/// 
		/// - 60 pity: +0%
		/// - 61 pity: +0.14%
		/// - 65 pity: +1.80%
		/// - 70 pity: +13.86%
		/// - 75 pity: +55.29%
		/// - 80 pity: +90.19%
		/// </remarks>
		public float SoftPityFactor { get; set; } = 1.5f;

		/// <summary>
		/// Gets or sets whether pity is factored into pull results,
		/// increasing chances for rare items over time.
		/// </summary>
		public bool PityEnabled { get; set; } = true;

		/// <summary>
		/// Returns a list with the machine's pity values for each rarity.
		/// </summary>
		public Dictionary<GachaRarity, PityValues> PityValues => new()
		{
			{ GachaRarity.Common, new(-1, -1) },
			{ GachaRarity.Rare, new(-1, 10) },
			{ GachaRarity.SuperRare, new(60, 80) },
		};

		/// <summary>
		/// Creates new machine.
		/// </summary>
		/// <param name="className"></param>
		/// <param name="type"></param>
		public GachaMachine(string className, GachaMachineType type)
		{
			this.ClassName = className;
			this.Type = type;
		}

		/// <summary>
		/// Creates new machine and fills it with the given entries.
		/// </summary>
		/// <param name="className"></param>
		/// <param name="type"></param>
		/// <param name="entries"></param>
		public GachaMachine(string className, GachaMachineType type, IEnumerable<GachaEntry> entries)
			: this(className, type)
		{
			this.AddEntries(entries);
		}

		/// <summary>
		/// Adds the given entry to the machine.
		/// </summary>
		/// <param name="entry"></param>
		public void AddEntry(GachaEntry entry)
		{
			lock (_entries)
				_entries.Add(entry);
		}

		/// <summary>
		/// Adds the given entries to the machine.
		/// </summary>
		/// <param name="entries"></param>
		public void AddEntries(IEnumerable<GachaEntry> entries)
		{
			lock (_entries)
				_entries.AddRange(entries);
		}

		/// <summary>
		/// Removes all entries from the machine.
		/// </summary>
		public void ClearEntries()
		{
			lock (_entries)
				_entries.Clear();
		}

		/// <summary>
		/// Adjusts the entries' probabilities to arrive at the given
		/// chances to be awarded an item of that rarity.
		/// </summary>
		/// <remarks>
		/// Probabilities are assigned based on rarity by default, but
		/// they can also be set manually when an entry is added. This
		/// method overwrites previously set probabilities to create
		/// specific and reliable chances to get items of a certain
		/// rarity.
		///
		/// For example, if the chance to receive any rare item is
		/// intended to be 5%, and the chance for a super rare item is 1%,
		/// this method, if passed 5 and 1 respectively, will recalculate
		/// all probabilities to match these expectations.
		/// </remarks>
		/// <param name="rareChance">Chance to receive a rare item in percent.</param>
		/// <param name="superRareChance">Chance to receive a super rare item in percent.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="InvalidOperationException"></exception>
		public void AutoWeight(float rareChance, float superRareChance)
		{
			if (rareChance + superRareChance >= 100)
				throw new ArgumentException("Chances must add up to less than 100.");

			var commonChance = 100 - rareChance - superRareChance;

			lock (_entries)
			{
				var totalCount = _entries.Count;
				var commonCount = _entries.Count(e => e.Rarity == GachaRarity.Common);
				var rareCount = _entries.Count(e => e.Rarity == GachaRarity.Rare);
				var superRareCount = _entries.Count(e => e.Rarity == GachaRarity.SuperRare);

				var commonProbability = (int)(commonChance * 1000 / commonCount);
				var rareProbability = (int)(rareChance * 1000 / rareCount);
				var superRare = (int)(superRareChance * 1000 / superRareCount);

				foreach (var entry in _entries)
				{
					entry.Probability = entry.Rarity switch
					{
						GachaRarity.Common => commonProbability,
						GachaRarity.Rare => rareProbability,
						GachaRarity.SuperRare => superRare,
						_ => throw new InvalidOperationException("Invalid rarity."),
					};
				}
			}
		}

		/// <summary>
		/// Returns the weighted probability of the given entry, based on
		/// the entry's base probability and the soft pity.
		/// </summary>
		/// <param name="entry"></param>
		/// <param name="pity">The current pity, aka pulls since the last reset.</param>
		/// <param name="softPity">The soft pity at which the probability increases.</param>
		/// <returns></returns>
		private int GetWeightedProbability(GachaEntry entry, int pity, int softPity)
		{
			if (!this.PityEnabled)
				return entry.Probability;

			if (entry.Rarity == GachaRarity.Common)
				return entry.Probability;

			var inPity = Math.Max(0, pity - softPity);
			var multiplier = Math.Pow(this.SoftPityFactor, inPity);

			return (int)(entry.Probability * multiplier);
		}

		/// <summary>
		/// Returns the total weighted probability of all entries in the
		/// machine, based on the entries' base probabilities and the
		/// respective soft pity values.
		/// </summary>
		/// <param name="counters"></param>
		/// <returns></returns>
		private int GetWeightedTotalProbability(PityCounters counters)
		{
			var total = 0;

			foreach (var entry in _entries)
			{
				var pity = entry.Rarity == GachaRarity.Rare ? counters.Rare.PullsSince : counters.SuperRare.PullsSince;
				var softPity = this.PityValues[entry.Rarity].SoftPity;

				var probability = this.GetWeightedProbability(entry, pity, softPity);
				total += probability;
			}

			return total;
		}

		/// <summary>
		/// Returns a random entry from the machine, affected by soft
		/// pity. Modifies the pity counters as appropriate.
		/// </summary>
		/// <param name="counters"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public GachaEntry GetRandomEntry(PityCounters counters)
		{
			lock (_entries)
			{
				if (_entries.Count == 0)
					throw new InvalidOperationException("No entries found.");

				var totalProbability = this.GetWeightedTotalProbability(counters);
				var randomValue = RandomProvider.Get().Next(0, totalProbability);

				foreach (var entry in _entries)
				{
					var pity = entry.Rarity == GachaRarity.Rare ? counters.Rare.PullsSince : counters.SuperRare.PullsSince;
					var softPity = this.PityValues[entry.Rarity].SoftPity;

					var probability = this.GetWeightedProbability(entry, pity, softPity);

					if (randomValue >= probability)
					{
						randomValue -= probability;
						continue;
					}

					switch (entry.Rarity)
					{
						case GachaRarity.Common:
						{
							counters.Rare.Increase();
							counters.SuperRare.Increase();
							break;
						}
						case GachaRarity.Rare:
						{
							counters.Rare.Reset();
							counters.SuperRare.Increase();
							break;
						}
						case GachaRarity.SuperRare:
						{
							counters.Rare.Increase();
							counters.SuperRare.Reset();
							break;
						}
					}

					return entry;
				}
			}

			throw new InvalidOperationException("No random entry found. What the heck?");
		}

		/// <summary>
		/// Returns a number of random entries from the machine, affected
		/// by soft pity and guaranteed pity. Modifies the pity counters
		/// as appropriate.
		/// </summary>
		/// <param name="count"></param>
		/// <param name="pity"></param>
		/// <returns></returns>
		public List<GachaEntry> GetRandomEntries(int count, PityCounters pity)
		{
			var entries = new List<GachaEntry>();

			var rarityCount = new Dictionary<GachaRarity, int>();
			rarityCount[GachaRarity.Common] = 0;
			rarityCount[GachaRarity.Rare] = 0;
			rarityCount[GachaRarity.SuperRare] = 0;

			for (var i = 0; i < count; ++i)
			{
				var entry = this.GetRandomEntry(pity);
				entries.Add(entry);

				rarityCount[entry.Rarity]++;
			}

			if (this.PityEnabled)
			{
				if (this.PityValues[GachaRarity.SuperRare].IsHardPity(pity.SuperRare) && rarityCount[GachaRarity.SuperRare] == 0)
				{
					var superRares = _entries.Where(e => e.Rarity == GachaRarity.SuperRare);
					if (superRares.Any())
					{
						var pityEntry = superRares.Random();
						var lastCommonIndex = entries.FindLastIndex(e => e.Rarity == GachaRarity.Common);
						if (lastCommonIndex != -1)
						{
							entries[lastCommonIndex] = pityEntry;
							pity.SuperRare.Reset();
						}
					}
				}

				if (this.PityValues[GachaRarity.Rare].IsHardPity(pity.Rare) && rarityCount[GachaRarity.Rare] == 0)
				{
					var rares = _entries.Where(e => e.Rarity == GachaRarity.Rare);
					if (rares.Any())
					{
						var pityEntry = rares.Random();
						var lastCommonIndex = entries.FindLastIndex(e => e.Rarity == GachaRarity.Common);
						if (lastCommonIndex != -1)
						{
							entries[lastCommonIndex] = pityEntry;
							pity.Rare.Reset();
						}
					}
				}
			}

			return entries;
		}

		/// <summary>
		/// Awards the given entries to the character, adding them to the
		/// inventory and displaying them in a popup.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="entries"></param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="InvalidOperationException"></exception>
		public void GivePrices(Character character, IEnumerable<GachaEntry> entries)
		{
			var count = entries.Count();

			if (count != 1 && count != 10 && count != 11)
				throw new ArgumentException("Invalid entry count. Must be 1, 10 or 11.");

			foreach (var entry in entries)
				character.Inventory.Add(entry.ItemClassId, entry.Amount, InventoryAddType.NotNew);

			var addonMessage = this.Type switch
			{
				GachaMachineType.Capsule => "HAIR_GACHA_POPUP",
				GachaMachineType.Box => "RBOX_GACHA_POPUP",
				_ => throw new InvalidOperationException("Invalid gacha machine type."),
			};

			if (count == 1)
			{
				var entry = entries.First();
				Send.ZC_ADDON_MSG(character, addonMessage, entry.RarityAmount, entry.ItemClassName);
			}
			else
			{
				var itemsStr = string.Join("&", entries.Select(e => $"{e.ItemClassName}&{e.RarityAmount}"));

				// Attach a dummy item at the end, because it doesn't
				// display the last one for some reason.
				itemsStr += "&DUMMY&0";

				Send.ZC_ADDON_MSG(character, addonMessage + "_10", 0, itemsStr);
			}
		}

		/// <summary>
		/// Makes the character operate the machine, playing a pull
		/// animation and awarding the prizes at the end.
		/// </summary>
		/// <param name="character">Character to make the pull.</param>
		/// <param name="count">Number of pulls to perform. Must be 1, 10, or 11.</param>
		/// <param name="animationSpeed">Speed multiplier for the pull animation. 0 for no animation.</param>
		public void Pull(Character character, int count, float animationSpeed = 1)
		{
			var pityCounters = new PityCounters(this.ClassName);
			pityCounters.Load(character);

			var entries = this.GetRandomEntries(count, pityCounters);
			pityCounters.Save(character);

			var animation = "gacha";
			var animationTime = TimeSpan.FromSeconds(10.5);

			if (this.Type == GachaMachineType.Box)
			{
				animation = "gacha_box";
				animationTime = TimeSpan.FromSeconds(3);
			}

			TaskHelper.CallSafe(Task.Run(async () =>
			{
				if (animationSpeed > 0)
				{
					character.ToggleControl("GACHA_ITEM", false);
					character.PlayAnimation(animation, animationSpeed);

					await Task.Delay(animationTime / animationSpeed);

					character.ToggleControl("GACHA_ITEM", true);
				}

				this.GivePrices(character, entries);
			}));
		}
	}
}
