using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class CustomCommandData
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Script { get; set; }
		public bool UseTx { get; set; }
	}

	/// <summary>
	/// Custom command database, indexed by their ids.
	/// </summary>
	public class CustomCommandDb : DatabaseJsonIndexed<int, CustomCommandData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "name", "script", "useTx");

			var data = new CustomCommandData();

			data.Id = entry.ReadInt("id");
			data.Name = entry.ReadString("name");
			data.Script = entry.ReadString("script");
			data.UseTx = entry.ReadBool("useTx");

			this.AddOrReplace(data.Id, data);
		}
	}
}
