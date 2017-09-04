// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class HelpData
	{
		public int HelpId { get; set; }
		public string ClassName { get; set; }
		public string DbSave { get; set; }
		public string BasicHelp { get; set; }
	}

	/// <summary>
	/// Help database indexed by the help ID.
	/// </summary>
	public class HelpDb : DatabaseJsonIndexed<int, HelpData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("HelpId", "ClassName", "DbSave", "BasicHelp");

			var info = new HelpData();

			info.HelpId = entry.ReadInt("HelpId");
			info.ClassName = entry.ReadString("ClassName");
			info.DbSave = entry.ReadString("DbSave");
			info.BasicHelp = entry.ReadString("BasicHelp");

			this.Entries[info.HelpId] = info;
		}
	}
}