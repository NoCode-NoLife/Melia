using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

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
		public FactionType Faction { get; set; }

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
			return this.Entries.Where(a => a.Value.Name.ToLower().Contains(name)).Select(a => a.Value).ToList();
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("monsterId", "className", "name", "localKey", "level", "exp", "classExp", "race", "size", "faction", "walkSpeed", "runSpeed", "hp", "sp", "pAttackMin", "pAttackMax", "mAttackMin", "mAttackMax", "pDefense", "mDefense");

			var data = new MonsterData();

			data.Id = entry.ReadInt("monsterId");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");
			data.LocalKey = entry.ReadString("localKey");
			data.Race = entry.ReadEnum<RaceType>("race");
			data.Size = entry.ReadEnum<Size>("size");
			data.Faction = entry.ReadEnum<FactionType>("faction");

			data.WalkSpeed = entry.ReadInt("walkSpeed");
			data.RunSpeed = entry.ReadInt("runSpeed");

			data.Level = entry.ReadInt("level");
			data.Exp = entry.ReadInt("exp");
			data.ClassExp = entry.ReadInt("classExp");
			data.Hp = entry.ReadInt("hp");
			data.Sp = entry.ReadInt("sp");

			data.PhysicalAttackMin = entry.ReadInt("pAttackMin");
			data.PhysicalAttackMax = entry.ReadInt("pAttackMax");
			data.MagicalAttackMin = entry.ReadInt("mAttackMin");
			data.MagicalAttackMax = entry.ReadInt("mAttackMax");
			data.PhysicalDefense = entry.ReadInt("pDefense");
			data.MagicalDefense = entry.ReadInt("mDefense");
			data.HitRatio = entry.ReadInt("mDefense");
			data.BlockBreak = entry.ReadInt("mDefense");
			data.BlockRate = entry.ReadInt("mDefense");
			data.CritAttack = entry.ReadInt("mDefense");
			data.CritDefenseRate = entry.ReadInt("mDefense");
			data.CritHitRate = entry.ReadInt("mDefense");
			data.DodgeRate = entry.ReadInt("mDefense");

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

					data.Drops.Add(dropData);
				}
			}

			this.AddOrReplace(data.Id, data);
		}
	}
}
