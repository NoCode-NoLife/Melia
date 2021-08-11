// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class PetData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public int Exp { get; set; }
		public int ClassExp { get; set; }
		public int Hp { get; set; }

		public int Defense { get; set; }
	}

	/// <summary>
	/// Pet database, indexed by Pet id.
	/// </summary>
	public class PetDb : DatabaseJsonIndexed<int, PetData>
	{
		public PetData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		public List<PetData> FindAll(string name)
		{
			name = name.ToLower();
			return this.Entries.FindAll(a => a.Value.Name.ToLower().Contains(name));
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("petId", "className", "name", "level", "exp", "classExp", "hp", "defense");

			var info = new PetData();

			info.Id = entry.ReadInt("petId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Level = entry.ReadInt("level");
			info.Exp = entry.ReadInt("exp");
			info.ClassExp = entry.ReadInt("classExp");
			info.Hp = entry.ReadInt("hp");
			info.Defense = entry.ReadInt("defense");

			this.Entries[info.Id] = info;
		}
	}
}
