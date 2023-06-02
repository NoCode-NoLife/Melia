using System;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class NormalTxData
	{
		public int ClassId { get; set; }
		public string Script { get; set; }
	}

	/// <summary>
	/// Normal transaction database, indexed by their class id.
	/// </summary>
	public class NormalTxDb : DatabaseJsonIndexed<int, NormalTxData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "script");

			var data = new NormalTxData();

			data.ClassId = entry.ReadInt("classId");
			data.Script = entry.ReadString("script");

			this.AddOrReplace(data.ClassId, data);
		}
	}
}
