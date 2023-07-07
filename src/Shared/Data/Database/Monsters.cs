using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
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

		public ElementType Element { get; set; }
		public RaceType Race { get; set; }
		public ArmorMaterialType ArmorMaterial { get; set; }
		public SizeType Size { get; set; }
		public FactionType Faction { get; set; }

		public MoveType MoveType { get; set; }
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
		public int HitRate { get; set; }
		public int DodgeRate { get; set; }
		public int BlockRate { get; set; }
		public int BlockBreakRate { get; set; }
		public int CritHitRate { get; set; }
		public int CritDodgeRate { get; set; }
		public int CritAttack { get; set; }

		public List<DropData> Drops { get; set; } = new List<DropData>();
		public List<MonsterSkillData> Skills { get; set; } = new List<MonsterSkillData>();
	}

	[Serializable]
	public class DropData
	{
		public int ItemId { get; set; }
		public float DropChance { get; set; }
		public int MinAmount { get; set; }
		public int MaxAmount { get; set; }
	}

	[Serializable]
	public class MonsterSkillData
	{
		public string Name { get; set; }
		public SkillId SkillId { get; set; }
	}

	/// <summary>
	/// Monster database, indexed by monster id.
	/// </summary>
	public class MonsterDb : DatabaseJsonIndexed<int, MonsterData>
	{
		/// <summary>
		/// Returns the monster with the given name. Returns null if
		/// no matching entry was found.
		/// </summary>
		/// <param name="name">Name of the monster (case-insensitive)</param>
		/// <returns></returns>
		public MonsterData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		/// <summary>
		/// Returns a list of all monsters whichs' name contains the given
		/// string.
		/// </summary>
		/// <param name="searchString">String to search for (case-insensitive)</param>
		/// <returns></returns>
		public List<MonsterData> FindAll(string searchString)
		{
			searchString = searchString.ToLower();
			return this.Entries.Where(a => a.Value.Name.ToLower().Contains(searchString)).Select(a => a.Value).ToList();
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("monsterId", "className", "name", "localKey", "level", "exp", "classExp", "element", "race", "armor", "size", "faction", "moveType", "walkSpeed", "runSpeed", "hp", "sp", "pAttackMin", "pAttackMax", "mAttackMin", "mAttackMax", "pDefense", "mDefense", "hitRate", "dodgeRate", "blockRate", "blockBreakRate", "critHitRate", "critDodgeRate", "critAttack");

			var data = new MonsterData();

			data.Id = entry.ReadInt("monsterId");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");
			data.LocalKey = entry.ReadString("localKey");

			data.Element = entry.ReadEnum<ElementType>("element");
			data.Race = entry.ReadEnum<RaceType>("race");
			data.ArmorMaterial = entry.ReadEnum<ArmorMaterialType>("armor");
			data.Size = entry.ReadEnum<SizeType>("size");
			data.Faction = entry.ReadEnum<FactionType>("faction");

			data.MoveType = entry.ReadEnum<MoveType>("moveType");
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
			data.HitRate = entry.ReadInt("hitRate");
			data.DodgeRate = entry.ReadInt("dodgeRate");
			data.BlockRate = entry.ReadInt("blockRate");
			data.BlockBreakRate = entry.ReadInt("blockBreakRate");
			data.CritHitRate = entry.ReadInt("critHitRate");
			data.CritDodgeRate = entry.ReadInt("critDodgeRate");
			data.CritAttack = entry.ReadInt("critAttack");

			if (entry.ContainsKey("skills"))
			{
				foreach (JObject skillEntry in entry["skills"])
				{
					skillEntry.AssertNotMissing("name", "skillId");

					var skillData = new MonsterSkillData();

					skillData.Name = skillEntry.ReadString("name");
					skillData.SkillId = skillEntry.ReadEnum<SkillId>("skillId");

					data.Skills.Add(skillData);
				}
			}

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
