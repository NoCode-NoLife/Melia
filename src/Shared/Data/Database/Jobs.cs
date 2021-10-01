using System;
using System.Collections.Generic;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class JobData
	{
		public JobId Id { get; set; }
		public string ClassName { get; set; }
		public string Initial { get; set; }
		public string Name { get; set; }
		public int Rank { get; set; }
		public int Str { get; set; }
		public int Con { get; set; }
		public int Int { get; set; }
		public int Spr { get; set; }
		public int Dex { get; set; }
		public float HpRate { get; set; }
		public float SpRate { get; set; }
		public int Stamina { get; set; }
		public float DefRate { get; set; }
		public float MDefRate { get; set; }
		public float HrRate { get; set; }
		public float DrRate { get; set; }
		public float BlkRate { get; set; }
		public float BlkBreakRate { get; set; }
		public float CrtHrRate { get; set; }
		public float CrtDrRate { get; set; }
		public float RHpRate { get; set; }
		public float RSpRate { get; set; }
		public float AtkSpeedRate { get; set; }
		public float MoveSpeedRate { get; set; }
		public int BarrackStance { get; set; }

		public ISet<string> DefaultSkills { get; set; }
		public ISet<string> DefaultAbilities { get; set; }
		public ISet<string> DefaultItems { get; set; }
		public IDictionary<EquipSlot, string> DefaultEquip { get; set; }

		/// <summary>
		/// Returns initial HP for this job on level 1.
		/// </summary>
		/// <returns></returns>
		public int GetInitialHp()
		{
			var rate = this.HpRate;
			var stat = this.Con;

			var byJob = Math.Floor(400 * rate);
			var byStats = Math.Floor(((stat * 0.005f) + (Math.Floor(stat / 10.0f) * 0.015f)) * byJob);

			return (int)(byJob + byStats);
		}

		/// <summary>
		/// Returns initial HP for this job on level 1.
		/// </summary>
		/// <returns></returns>
		public int GetInitialSp()
		{
			var rate = this.SpRate;
			var stat = this.Spr;

			var byJob = Math.Floor(200 * rate);
			var byStats = Math.Floor(((stat * 0.005f) + (Math.Floor(stat / 10.0f) * 0.015f)) * byJob);

			return (int)(byJob + byStats);
		}
	}

	/// <summary>
	/// Job database, indexed by job id.
	/// </summary>
	public class JobDb : DatabaseJsonIndexed<JobId, JobData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("jobId", "className", "initial", "name", "rank", "str", "con", "int", "spr", "dex", "hpRate", "spRate", "stamina", "barrackStance");

			var info = new JobData();

			info.Id = (JobId)entry.ReadInt("jobId");
			info.ClassName = entry.ReadString("className");
			info.Initial = entry.ReadString("initial");
			info.Name = entry.ReadString("name");
			info.Rank = entry.ReadInt("rank");
			info.Str = entry.ReadInt("str", 0);
			info.Con = entry.ReadInt("con", 0);
			info.Int = entry.ReadInt("int", 0);
			info.Spr = entry.ReadInt("spr", 0);
			info.Dex = entry.ReadInt("dex", 0);
			info.HpRate = entry.ReadFloat("hpRate", 1);
			info.SpRate = entry.ReadFloat("spRate", 1);
			info.Stamina = entry.ReadInt("stamina", 25000);
			info.DefRate = entry.ReadFloat("defRate", 1);
			info.MDefRate = entry.ReadFloat("mdefRate", 1);
			info.HrRate = entry.ReadFloat("hrRate", 1);
			info.DrRate = entry.ReadFloat("drRate", 1);
			info.BlkRate = entry.ReadFloat("blkRate", 1);
			info.BlkBreakRate = entry.ReadFloat("blkBreakRate", 1);
			info.CrtHrRate = entry.ReadFloat("crthrRate", 1);
			info.CrtDrRate = entry.ReadFloat("crtdrRate", 1);
			info.RHpRate = entry.ReadFloat("rhpRate", 1);
			info.RSpRate = entry.ReadFloat("rspRate", 1);
			info.AtkSpeedRate = entry.ReadFloat("atkSpeedRate", 1);
			info.MoveSpeedRate = entry.ReadFloat("moveSpeedRate", 1);
			info.BarrackStance = entry.ReadInt("barrackStance");

			// TODO: It would be good if we could check right here whether
			//   these skills and items and such actually exist.

			// Skills
			info.DefaultSkills = new HashSet<string>();
			if (entry.ContainsKey("defaultSkills"))
			{
				foreach (var name in entry["defaultSkills"])
					info.DefaultSkills.Add((string)name);
			}

			// Abilities
			info.DefaultAbilities = new HashSet<string>();
			if (entry.ContainsKey("defaultAbilities"))
			{
				foreach (var name in entry["defaultAbilities"])
					info.DefaultAbilities.Add((string)name);
			}

			// Items
			info.DefaultItems = new HashSet<string>();
			if (entry.ContainsKey("defaultItems"))
			{
				foreach (var name in entry["defaultItems"])
					info.DefaultItems.Add((string)name);
			}

			// Equip
			info.DefaultEquip = new Dictionary<EquipSlot, string>();
			if (entry.ContainsKey("defaultEquip"))
			{
				var equipEntry = (JObject)entry["defaultEquip"];
				foreach (var pair in equipEntry)
				{
					var slot = StringToEquipSlot(pair.Key);
					var name = pair.Value;

					info.DefaultEquip[slot] = (string)name;
				}
			}

			this.Entries[info.Id] = info;
		}

		/// <summary>
		/// Returns equip slot for given default equip key.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private static EquipSlot StringToEquipSlot(string str)
		{
			switch (str)
			{
				case "rightHand": return EquipSlot.RightHand;
				case "body": return EquipSlot.Outer2;
				case "shirt": return EquipSlot.Top;
				case "outer": return EquipSlot.Outer2;
				case "pants": return EquipSlot.Pants;
				case "gloves": return EquipSlot.Gloves;
				case "boots": return EquipSlot.Shoes;
			}

			throw new DatabaseErrorException("Unknown equip slot '" + str + "'.");
		}
	}
}
