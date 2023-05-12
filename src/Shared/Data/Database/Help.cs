using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class HelpData
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool DbSave { get; set; }
		public bool BasicHelp { get; set; }
	}

	/// <summary>
	/// Help database indexed by the help id.
	/// </summary>
	public class HelpDb : DatabaseJsonIndexed<int, HelpData>
	{
		private readonly Dictionary<string, HelpData> _nameIndex = new Dictionary<string, HelpData>();

		public HelpData Find(string name)
		{
			HelpData result;
			_nameIndex.TryGetValue(name, out result);
			return result;
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "name", "dbSave", "basicHelp");

			var data = new HelpData();

			data.Id = entry.ReadInt("id");
			data.Name = entry.ReadString("name");
			data.DbSave = entry.ReadBool("dbSave");
			data.BasicHelp = entry.ReadBool("basicHelp");

			_nameIndex[data.Name] = data;

			this.AddOrReplace(data.Id, data);
		}
	}
}
