using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class MonsterData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public string LocalKey { get; set; }
		public RaceType Race { get; set; }
		public Size Size { get; set; }

		public int WalkSpeed { get; set; }
		public int RunSpeed { get; set; }

		public int Level { get; set; }
		public int Exp { get; set; }
		public int ClassExp { get; set; }
		public int Hp { get; set; }
		public int Sp { get; set; }

		public int PhysicalAttackMin { get; set; }
		public int PhysicalAttackMax { get; set; }
		public int MagicalAttackMin { get; set; }
		public int MagicalAttackMax { get; set; }
		public int PhysicalDefense { get; set; }
		public int MagicalDefense { get; set; }
		public int HitRatio { get; set; }
		public int BlockBreak { get; set; }
		public int BlockRate { get; set; }
		public int CritAttack { get; set; }
		public int CritDefenseRate { get; set; }
		public int CritHitRate { get; set; }
		public int DodgeRate { get; set; }

		public List<DropData> Drops { get; set; } = new List<DropData>();
	}

	[Serializable]
	public class DropData
	{
		public int ItemId { get; set; }
		public float DropChance { get; set; }
		public int MinAmount { get; set; }
		public int MaxAmount { get; set; }
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
			entry.AssertNotMissing("monsterId", "className", "name", "localKey", "level", "exp", "classExp", "race", "size", "walkSpeed", "runSpeed", "hp", "sp", "pAttackMin", "pAttackMax", "mAttackMin", "mAttackMax", "pDefense", "mDefense");

			var info = new MonsterData();

			info.Id = entry.ReadInt("monsterId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.LocalKey = entry.ReadString("localKey");
			info.Race = entry.ReadEnum<RaceType>("race");
			info.Size = entry.ReadEnum<Size>("size");

			info.WalkSpeed = entry.ReadInt("walkSpeed");
			info.RunSpeed = entry.ReadInt("runSpeed");

			info.Level = entry.ReadInt("level");
			info.Exp = entry.ReadInt("exp");
			info.ClassExp = entry.ReadInt("classExp");
			info.Hp = entry.ReadInt("hp");
			info.Sp = entry.ReadInt("sp");

			info.PhysicalAttackMin = entry.ReadInt("pAttackMin");
			info.PhysicalAttackMax = entry.ReadInt("pAttackMax");
			info.MagicalAttackMin = entry.ReadInt("mAttackMin");
			info.MagicalAttackMax = entry.ReadInt("mAttackMax");
			info.PhysicalDefense = entry.ReadInt("pDefense");
			info.MagicalDefense = entry.ReadInt("mDefense");
			info.HitRatio = entry.ReadInt("mDefense");
			info.BlockBreak = entry.ReadInt("mDefense");
			info.BlockRate = entry.ReadInt("mDefense");
			info.CritAttack = entry.ReadInt("mDefense");
			info.CritDefenseRate = entry.ReadInt("mDefense");
			info.CritHitRate = entry.ReadInt("mDefense");
			info.DodgeRate = entry.ReadInt("mDefense");

			if (entry.ContainsKey("drops"))
			{
				foreach (JObject dropEntry in entry["drops"])
				{
					dropEntry.AssertNotMissing("itemId", "chance");

					var dropData = new DropData();

					dropData.ItemId = dropEntry.ReadInt("itemId");
					dropData.DropChance = dropEntry.ReadFloat("chance");
					dropData.MinAmount = dropEntry.ReadInt("minQuantity", 1);
					dropData.MaxAmount = dropEntry.ReadInt("maxQuantity", 1);

					if (dropData.MaxAmount < dropData.MinAmount)
						dropData.MaxAmount = dropData.MinAmount;

					info.Drops.Add(dropData);
				}
			}

			this.Entries[info.Id] = info;
		}
	}
}
