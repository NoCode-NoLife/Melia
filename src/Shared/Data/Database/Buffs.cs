// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class BuffData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public float Duration { get; set; }
		public float BuffUpExp { get; set; }
		public bool Removable { get; set; }
		public bool RemoveOnDeath { get; set; }
		public bool RemoveBySkill { get; set; }
		public string UpdateProperties { get; set; }
	}

	/// <summary>
	/// Buff database, indexed by buff id.
	/// </summary>
	public class BuffDb : DatabaseJsonIndexed<int, BuffData>
	{
		public BuffData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		public List<BuffData> FindAll(string name)
		{
			name = name.ToLower();
			return this.Entries.FindAll(a => a.Value.Name.ToLower().Contains(name));
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("buffId", "className", "name", "level", "duration", "buffExpUp");

			var info = new BuffData();

			info.Id = entry.ReadInt("buffId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Level = entry.ReadInt("level");
			info.Duration = entry.ReadFloat("duration");
			info.BuffUpExp = entry.ReadFloat("buffExpUp");
			info.Removable = entry.ReadBool("removable");
			info.RemoveOnDeath = entry.ReadBool("removeOnDeath");
			info.RemoveBySkill = entry.ReadBool("removeBySkill");
			info.UpdateProperties = entry.ReadString("updateProperties");

			this.Entries[info.Id] = info;
		}
	}
}
