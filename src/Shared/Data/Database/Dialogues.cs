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
	}

	/// <summary>
	/// Dialog database.
	/// </summary>
	public class DialogDb : DatabaseJson<DialogData>
	{
		private readonly HashSet<string> _classNames = new HashSet<string>();

		public bool Exists(string className)
		{
			return _classNames.Contains(className);
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "className");

			var data = new DialogData();

			data.ClassId = entry.ReadInt("DialogId");
			data.ClassName = entry.ReadString("className");

			this.Add(data);
		}

		protected override void AfterLoad()
		{
			foreach (var entry in this.Entries)
				_classNames.Add(entry.ClassName);
		}
	}
}
