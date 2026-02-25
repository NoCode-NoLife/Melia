using System;
using System.Linq;
using Melia.Shared.Game.Const;
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
		public bool AvailableOnCreation { get; set; }
	}

	/// <summary>
	/// Hair type database.
	/// </summary>
	public class HairTypeDb : DatabaseJson<HairTypeData>
	{
		/// <summary>
		/// Returns the first entry with the given class name via out.
		/// Returns false if no match was found.
		/// </summary>
		/// <param name="className"></param>
		/// <param name="result"></param>
		/// <returns></returns>
		public bool TryFindByClassName(string className, out HairTypeData result)
		{
			result = this.Entries.FirstOrDefault(a => string.CompareOrdinal(a.ClassName, className) == 0);
			return result != null;
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("index", "gender", "name", "className", "color", "availableOnCreation");

			var data = new HairTypeData();

			data.Index = entry.ReadInt("index");
			data.Gender = entry.ReadEnum<Gender>("gender");
			data.Name = entry.ReadString("name");
			data.ClassName = entry.ReadString("className");
			data.Color = entry.ReadString("color");
			data.AvailableOnCreation = entry.ReadBool("availableOnCreation");

			this.Add(data);
		}
	}
}
