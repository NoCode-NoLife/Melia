using System;
using System.IO;

namespace Melia.Zone.World.Gacha
{
	/// <summary>
	/// Represents an entry in a gacha machine.
	/// </summary>
	public class GachaEntry
	{
		/// <summary>
		/// Returns the id of the item this entry rewards.
		/// </summary>
		public int ItemClassId { get; }

		/// <summary>
		/// Returns the class name of the item this entry rewards.
		/// </summary>
		public string ItemClassName { get; }

		/// <summary>
		/// Returns the amount for the item rewarded.
		/// </summary>
		public int Amount { get; }

		/// <summary>
		/// Returns the entry's rarity.
		/// </summary>
		public GachaRarity Rarity { get; }

		/// <summary>
		/// Returns the probability of this entry being pulled.
		/// </summary>
		/// <remarks>
		/// Note that this is not a percentage, but rather a value that is
		/// compared against the total probability of all entries to
		/// determine the odds of pulling this one.
		/// </remarks>
		public int Probability { get; internal set; }

		/// <summary>
		/// Returns a numeric value that combines the rarity and amount of
		/// this entry. Used to send both to the client in one value.
		/// </summary>
		public int RarityAmount => (int)this.Rarity * 1000 + this.Amount;

		/// <summary>
		/// Creates new instance with a default probability based on
		/// rarity.
		/// </summary>
		/// <param name="className"></param>
		/// <param name="amount"></param>
		/// <param name="rarity"></param>
		public GachaEntry(string className, int amount, GachaRarity rarity)
			: this(className, amount, rarity, GetProbability(rarity))
		{
		}

		/// <summary>
		/// Creates new instance with the given probability.
		/// </summary>
		/// <param name="className"></param>
		/// <param name="amount"></param>
		/// <param name="rarity"></param>
		/// <param name="probability"></param>
		/// <exception cref="ArgumentException"></exception>
		public GachaEntry(string className, int amount, GachaRarity rarity, int probability)
		{
			if (!ZoneServer.Instance.Data.ItemDb.TryFind(a => a.ClassName == className, out var itemData))
				throw new ArgumentException($"Invalid item class name: {className}");

			this.ItemClassId = itemData.Id;
			this.ItemClassName = className;
			this.Amount = amount;
			this.Rarity = rarity;
			this.Probability = probability;
		}

		/// <summary>
		/// Returns the default probability for the given rarity.
		/// </summary>
		/// <param name="rarity"></param>
		/// <returns></returns>
		/// <exception cref="InvalidDataException"></exception>
		private static int GetProbability(GachaRarity rarity)
		{
			return rarity switch
			{
				GachaRarity.Common => 800,
				GachaRarity.Rare => 150,
				GachaRarity.SuperRare => 50,
				_ => throw new InvalidDataException($"Unknown rarity '{rarity}'.")
			};
		}
	}
}
