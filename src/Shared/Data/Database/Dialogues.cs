using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class DialogData
	{
		public int ClassId { get; set; }
		public string ClassName { get; set; }
		public string Image { get; set; }
	}

	/// <summary>
	/// Dialog database.
	/// </summary>
	public class DialogDb : DatabaseJson<DialogData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "className");

			var data = new DialogData();

			data.ClassId = entry.ReadInt("classId");
			data.ClassName = entry.ReadString("className");
			data.Image = entry.ReadString("image", null);

			this.Add(data);
		}
	}
}
