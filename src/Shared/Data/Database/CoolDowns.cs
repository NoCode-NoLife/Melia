using System;
using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class CooldownData
	{
		public CooldownId Id { get; set; }
		public string ClassName { get; set; }
		public bool IsOverheat { get; set; }
		public TimeSpan OverheatResetTime { get; set; }
	}

	/// <summary>
	/// Cooldown database, indexed by their their ids.
	/// </summary>
	public class CooldownDb : DatabaseJsonIndexed<CooldownId, CooldownData>
	{
		/// <summary>
		/// Returns data for the first ability with the given class name,
		/// or null if none were found.
		/// </summary>
		/// <param name="className"></param>
		/// <returns></returns>
		public CooldownData Find(string className)
		{
			return this.Entries.Values.FirstOrDefault(a => a.ClassName == className);
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "isOverheat", "overheatResetTime");

			var data = new CooldownData();

			data.Id = entry.ReadEnum<CooldownId>("id");
			data.ClassName = entry.ReadString("className");
			data.IsOverheat = entry.ReadBool("isOverheat");
			data.OverheatResetTime = entry.ReadTimeSpan("overheatResetTime");

			this.AddOrReplace(data.Id, data);
		}
	}
}
