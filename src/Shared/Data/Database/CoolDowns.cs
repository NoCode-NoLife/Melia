// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class CoolDownData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public bool IsOverheat { get; set; }
		public int OverheatResetTime { get; set; }
	}

	public class CoolDownDb : DatabaseJsonIndexed<int, CoolDownData>
	{
		/// <summary>
		/// Returns data for the first ability with the given class name,
		/// or null if none were found.
		/// </summary>
		/// <param name="className"></param>
		/// <returns></returns>
		public CoolDownData Find(string className)
		{
			return this.Entries.Values.FirstOrDefault(a => a.ClassName == className);
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "isOverheat", "overheatResetTime");

			var info = new CoolDownData();

			info.Id = entry.ReadInt("id");
			info.ClassName = entry.ReadString("className");
			info.IsOverheat = entry.ReadBool("isOverheat");
			info.OverheatResetTime = entry.ReadInt("overheatResetTime");

			this.Entries[info.Id] = info;
		}
	}
}
