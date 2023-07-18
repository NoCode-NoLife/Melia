using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SystemMessageData
	{
		public int ClassId { get; set; }
		public string ClassName { get; set; }
	}

	/// <summary>
	/// System message database, indexed by their class name.
	/// </summary>
	public class SystemMessageDb : DatabaseJsonIndexed<string, SystemMessageData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "className");

			var data = new SystemMessageData();

			data.ClassId = entry.ReadInt("classId");
			data.ClassName = entry.ReadString("className");

			this.AddOrReplace(data.ClassName, data);
		}
	}
}
