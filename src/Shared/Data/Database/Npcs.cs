// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class NPCData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
	}

	/// <summary>
	/// NPC database, indexed by npc id.
	/// </summary>
	public class NPCDb : DatabaseJsonIndexed<int, NPCData>
	{
		public NPCData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		public List<NPCData> FindAll(string name)
		{
			name = name.ToLower();
			return this.Entries.FindAll(a => a.Value.Name.ToLower().Contains(name));
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("npcId", "className", "name");

			var info = new NPCData();

			info.Id = entry.ReadInt("npcId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");

			this.Entries[info.Id] = info;
		}
	}
}
