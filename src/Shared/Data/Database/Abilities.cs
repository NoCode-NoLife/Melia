using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AbilityData
	{
		public AbilityId Id { get; set; }
		public string ClassName { get; set; }
		public string EngName { get; set; }
		public int Level { get; set; }
		public bool Passive { get; set; }
		public HashSet<string> Categories { get; set; } = new();
		public Dictionary<AbilityModifierType, int> Modifiers { get; set; } = new();
	}

	public enum AbilityModifierType
	{
		/// <summary>
		/// A percentage based modifier that affects the SP cost of a
		/// skill. For example, a modifier of -20 would reduce the SP cost
		/// of the skill by 20%.
		/// </summary>
		SP,

		/// <summary>
		/// A modifier that affects a skill's cooldown, in milliseconds.
		/// For example, a modifier of 500 would increase the cooldown of
		/// a skill by 0.5 seconds.
		/// </summary>
		CoolDown,
	}

	/// <summary>
	/// Ability database, indexed by ability id.
	/// </summary>
	public class AbilityDb : DatabaseJsonIndexed<AbilityId, AbilityData>
	{
		/// <summary>
		/// Returns data for the first ability with the given class name,
		/// or null if none were found.
		/// </summary>
		/// <param name="className"></param>
		/// <returns></returns>
		public AbilityData Find(string className)
		{
			return this.Entries.Values.FirstOrDefault(a => a.ClassName == className);
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "name", "level", "passive");

			var data = new AbilityData();

			data.Id = (AbilityId)entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");
			data.EngName = entry.ReadString("name");
			data.Level = entry.ReadInt("level");
			data.Passive = entry.ReadBool("passive");

			if (entry.ContainsKey("categories"))
			{
				var categories = entry["categories"] as JArray;

				foreach (var category in categories)
					data.Categories.Add((string)category);
			}

			if (entry.ContainsKey("modifiers"))
			{
				var modifiers = entry["modifiers"] as JObject;

				foreach (var modifier in modifiers)
				{
					var type = Enum.Parse<AbilityModifierType>(modifier.Key);
					var value = (int)modifier.Value;

					data.Modifiers[type] = value;
				}
			}

			this.AddOrReplace(data.Id, data);
		}
	}
}
