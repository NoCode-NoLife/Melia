// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class MonsterData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public int Exp { get; set; }
		public int ClassExp { get; set; }
	}

	/// <summary>
	/// Monster database, indexed by monster id.
	/// </summary>
	public class MonsterDb : DatabaseJsonIndexed<int, MonsterData>
	{
		public MonsterData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		public List<MonsterData> FindAll(string name)
		{
			name = name.ToLower();
			return this.Entries.FindAll(a => a.Value.Name.ToLower().Contains(name));
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("monsterId", "className", "name", "level", "exp", "classExp");

			var info = new MonsterData();

			info.Id = entry.ReadInt("monsterId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Level = entry.ReadInt("level");
			info.Exp = entry.ReadInt("exp");
			info.ClassExp = entry.ReadInt("classExp");

			this.Entries[info.Id] = info;
		}
	}
}
