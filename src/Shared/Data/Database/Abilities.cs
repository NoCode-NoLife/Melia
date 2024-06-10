using System;
using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
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

			this.AddOrReplace(data.Id, data);
		}
	}
}
