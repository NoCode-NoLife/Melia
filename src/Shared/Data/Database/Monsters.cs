// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Util;

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

		// Collision Radious?
		public int CollisionRadious { get; set; }

		// GuardImpactTime == Time it is shocked after impact? (in a flashing state) -- I think this value is in hit list info
		// HitRng ==
		// Search Range == When following or aggro mob?
		// NumOfAttacks == 3 ?? Kepa hits 3 times per attack? 
		// HitTime1 / HitTime2 / HitTime3
		// BornTime (Inmunity time when born? or what?)
		// DeadTime (Time the corpse is in floor?)
		// DyingTime (time it takes animation for dying?)
		// MinR = Min Range of attack?
		// MaxR = Max Range of attack?

		// SplRange ==
		// SplLimit
		// SplDamage
		// BuffFreq (frquenciy it makes buffs)?
		// Ratio
		// PreDelay
		// LifeTime
		// Range
		// AppTime
		// Mass
		// Hit
		// Hits
		/*
		public MonsterRace Race { get; set; }
		public ArmorType ArmorType { get; set; }
		public MonsterSize Size { get; set; }
		public WeaponTypes WeaponType { get; set; }
		*/



		// Stats
		public int STR { get; set; }
		public int CON { get; set; }
		public int INT { get; set; }
		public int DEX { get; set; }
		public int MNA { get; set; }

		// Movement
		public int WalkSpeed { get; set; }
		public int RunSpeed { get; set; }

		// Attack info
		public int ATK_RANGE { get; set; }


	}

	/// <summary>
	/// Monster database, indexed by monster id.
	/// </summary>
	public class MonsterDb : DatabaseJsonIndexed<int, MonsterData>
	{
		public MonsterData FindByClassName(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.ClassName.ToLower() == name).Value;
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
			if (entry.ContainsKey("hp"))
			{
				
				info.Hp = entry.ReadInt("hp");
				Log.Debug("Read HP {0}", info.Hp);
			}
			if (entry.ContainsKey("walkspeed"))
			{
				info.WalkSpeed = entry.ReadInt("walkSpeed");
			}
			if (entry.ContainsKey("runSpeed"))
			{
				info.RunSpeed = entry.ReadInt("runSpeed");
			}

			info.CollisionRadious = 10;

			this.Entries[info.Id] = info;
		}
	}
}
