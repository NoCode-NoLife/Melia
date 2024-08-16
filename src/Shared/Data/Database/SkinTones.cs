using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkinToneData
	{
		public int ClassId { get; set; }
		public string ClassName { get; set; }
		public uint Color { get; set; }
		public bool Creation { get; set; }
	}

	/// <summary>
	/// Skin tone database.
	/// </summary>
	public class SkinToneDb : DatabaseJson<SkinToneData>
	{
		/// <summary>
		/// Searches for a skin tone by its color and returns the entry
		/// via out. Returns false if no matching color was found.
		/// </summary>
		/// <param name="color"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public bool TryGetByColor(uint color, out SkinToneData data)
		{
			color &= 0xFFFFFF;

			data = this.Find(x => x.Color == color);
			return data != null;
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "className", "color", "creation");

			var data = new SkinToneData();

			data.ClassId = entry.ReadInt("classId");
			data.ClassName = entry.ReadString("className");
			data.Color = entry.ReadUInt("color");
			data.Creation = entry.ReadBool("creation");

			this.Add(data);
		}
	}
}
