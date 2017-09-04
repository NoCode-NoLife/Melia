// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Newtonsoft.Json.Linq;

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
	/// Custom command database, indexed by id.
	/// </summary>
	public class CustomCommandDb : DatabaseJsonIndexed<int, CustomCommandData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "name", "script", "useTx");

			var info = new CustomCommandData();

			info.Id = entry.ReadInt("id");
			info.Name = entry.ReadString("name");
			info.Script = entry.ReadString("script");
			info.UseTx = entry.ReadBool("useTx");

			this.Entries[info.Id] = info;
		}
	}
}
