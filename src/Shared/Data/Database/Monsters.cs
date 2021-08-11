// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
		public int Hp { get; set; }

		public int PhysicalAttackMinimum { get; set; }
		public int PhysicalAttackMaximum { get; set; }
		public int MagicalAttackMinimum { get; set; }
		public int MagicalAttackMaximum { get; set; }
		public int PhysicalDefense { get; set; }
		public int MagicalDefense { get; set; }
		public List<DropData> Drops { get; internal set; }
	}

	[Serializable]
	public class DropData
	{
		public int ItemId { get; set; }
		public float DropChance { get; set; }
		public int MinimumQuantity { get; set; }
		public int MaximumQuantity { get; set; }
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
			entry.AssertNotMissing("monsterId", "className", "name");

			var info = new MonsterData();

			info.Id = entry.ReadInt("monsterId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Level = entry.ReadInt("level");
			info.Exp = entry.ReadInt("exp");
			info.ClassExp = entry.ReadInt("classExp");
			info.Hp = entry.ReadInt("hp");
			info.PhysicalDefense = entry.ReadInt("physicalDefense");
			var drops = entry.ReadArray("drops");
			if (drops != null)
			{
				if (info.Drops == null)
					info.Drops = new List<DropData>();
				foreach (var drop in drops.ToObject<IList<DropData>>())
				{
					info.Drops.Add(drop);
				}
			}
			this.Entries[info.Id] = info;
		}
	}
}
