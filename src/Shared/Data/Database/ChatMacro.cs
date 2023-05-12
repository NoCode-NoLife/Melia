using Newtonsoft.Json.Linq;
using System;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ChatMacroData
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Pose { get; set; }
		public string Text { get; set; }
	}

	/// <summary>
	/// Chat macro database, indexed by id.
	/// </summary>
	public class ChatMacroDb : DatabaseJsonIndexed<int, ChatMacroData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "name", "pose", "text");

			var data = new ChatMacroData();

			data.Id = entry.ReadInt("id");
			data.Name = entry.ReadString("name");
			data.Pose = entry.ReadInt("pose");
			data.Text = entry.ReadString("text");

			this.AddOrReplace(data.Id, data);
		}
	}
}
