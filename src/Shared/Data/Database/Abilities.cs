using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AbilityData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string EngName { get; set; }
		public int Level { get; set; }
		public bool Passive { get; set; }
	}

	/// <summary>
	/// Ability database, indexed by ability id.
	/// </summary>
	public class AbilityDb : DatabaseJsonIndexed<int, AbilityData>
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

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "name", "level", "passive");

			var data = new AbilityData();

			data.Id = entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");
			data.EngName = entry.ReadString("name");
			data.Level = entry.ReadInt("level");
			data.Passive = entry.ReadBool("passive");

			this.Entries[data.Id] = data;
		}
	}
}
