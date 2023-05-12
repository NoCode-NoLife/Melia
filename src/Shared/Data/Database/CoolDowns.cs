using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class CooldownData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public bool IsOverheat { get; set; }
		public int OverheatResetTime { get; set; }
	}

	public class CooldownDb : DatabaseJsonIndexed<int, CooldownData>
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

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "isOverheat", "overheatResetTime");

			var info = new CooldownData();

			info.Id = entry.ReadInt("id");
			info.ClassName = entry.ReadString("className");
			info.IsOverheat = entry.ReadBool("isOverheat");
			info.OverheatResetTime = entry.ReadInt("overheatResetTime");

			this.Entries[info.Id] = info;
		}
	}
}
