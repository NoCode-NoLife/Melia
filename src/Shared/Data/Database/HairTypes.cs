using System;
using Melia.Shared.Tos.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class HairTypeData
	{
		public int Index { get; set; }
		public Gender Gender { get; set; }
		public string Name { get; set; }
		public string ClassName { get; set; }
		public string Color { get; set; }
	}

	/// <summary>
	/// Hair type database.
	/// </summary>
	public class HairTypeDb : DatabaseJson<HairTypeData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("index", "gender", "name", "className", "color");

			var data = new HairTypeData();

			data.Index = entry.ReadInt("index");
			data.Gender = entry.ReadEnum<Gender>("gender");
			data.Name = entry.ReadString("name");
			data.ClassName = entry.ReadString("className");
			data.Color = entry.ReadString("color");

			this.Add(data);
		}
	}
}
