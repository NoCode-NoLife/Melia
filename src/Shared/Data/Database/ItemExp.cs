using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ItemExpData
	{
		public EquipExpGroup Group { get; set; }
		public int Level { get; set; }
		public int Exp { get; set; }
		public int GainExp { get; set; }
		public float PriceMultiplier { get; set; } = 1.0f;
	}

	/// <summary>
	/// Item Exp database.
	/// </summary>
	public class ItemExpDb : DatabaseJson<ItemExpData>
	{
		private readonly List<ItemExpData> _itemExp = new();

		public int GetGainExp(EquipExpGroup group, int level = 1)
		{
			var exp = this.Entries.Find(a => a.Group == group && a.Level == 1)?.GainExp ?? 0;

			return exp;
		}

		/// <summary>
		/// Returns exp required to reach the next level after the
		/// given one.
		/// </summary>
		/// <remarks>
		/// Returns 0 if there's no data for the given level,
		/// i.e. if it's the last one or goes beyond.
		/// </remarks>
		/// <param name="level"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">Thrown if level is invalid (< 1).</exception>
		public int GetNextExp(EquipExpGroup group, int level)
		{
			if (level < 1)
				throw new ArgumentException("Invalid level (too low).");

			if (level > _itemExp.Count)
				return 0;

			var index = level - 1;
			var exp = this.Entries.Where(a => a.Group == group).OrderBy(a => a.Level).ToList()[index];

			return exp.Exp;
		}

		/// <summary>
		/// Returns the EXP required to reach the given level.
		/// </summary>
		/// <param name="exp"></param>
		/// <returns></returns>
		public int GetLevel(EquipExpGroup group, int exp)
		{
			var result = 1;
			var data = this.Entries.Where(a => a.Group == group && a.Exp <= exp).OrderBy(a => a.Level).LastOrDefault();
			if (data != null)
				result = data.Level;

			return result;
		}

		/// <summary>
		/// Returns the price multiplier at a certain level.
		/// </summary>
		/// <param name="level"></param>
		/// <returns></returns>
		public float GetPriceMultiplier(EquipExpGroup group, int level)
		{
			var result = 1f;
			var data = this.Entries.Find(a => a.Level == level);
			if (data != null)
				result = data.PriceMultiplier;

			return result;
		}

		/// <summary>
		/// Returns the EXP required to reach the given level.
		/// </summary>
		/// <param name="level"></param>
		/// <returns></returns>
		public int GetTotalExp(EquipExpGroup group, int level)
		{
			var result = 0;
			for (var i = 1; i < level; ++i)
				result += this.GetNextExp(group, i);

			return result;
		}

		/// <summary>
		/// Returns the max level.
		/// </summary>
		/// <returns></returns>
		public int GetMaxLevel(EquipExpGroup group)
		{
			return _itemExp.Where(a => a.Group == group && a.Exp > 0).Max(a => a.Level);
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <remarks>
		/// Uses the JSON database to be fed its entries, but doesn't
		/// adhere to the Entries format and uses custom lists instead.
		/// </remarks>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{

			entry.AssertNotMissing("level", "exp");

			var data = new ItemExpData();

			data.Group = entry.ReadEnum("group", EquipExpGroup.None);
			data.Level = entry.ReadInt("level");
			data.Exp = entry.ReadInt("exp");
			data.GainExp = entry.ReadInt("gainExp");

			this.Entries.Add(data);
		}

		protected override void AfterLoad()
		{
			_itemExp.AddRange(this.Entries);
		}
	}
}
