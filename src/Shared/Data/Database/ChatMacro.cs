// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Newtonsoft.Json.Linq;
using System;

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
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "name", "pose", "text");

			var info = new ChatMacroData();

			info.Id = entry.ReadInt("id");
			info.Name = entry.ReadString("name");
			info.Pose = entry.ReadInt("pose");
			info.Text = entry.ReadString("text");

			this.Entries[info.Id] = info;
		}
	}
}
