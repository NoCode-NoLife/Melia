using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class DialogTxData
	{
		public int ClassId { get; set; }
		public string ClassName { get; set; }
		public DialogTxType Type { get; set; }
		public string Script { get; set; }
	}

	public enum DialogTxType
	{
		Item,
		ItemArg,
		ItemList,
		Item_String
	}

	/// <summary>
	/// Dialog transaction database, indexed by their class id.
	/// </summary>
	public class DialogTxDb : DatabaseJsonIndexed<int, DialogTxData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "className", "type", "script");

			var data = new DialogTxData();

			data.ClassId = entry.ReadInt("classId");
			data.ClassName = entry.ReadString("className");
			data.Type = entry.ReadEnum<DialogTxType>("type");
			data.Script = entry.ReadString("script");

			this.AddOrReplace(data.ClassId, data);
		}
	}
}
