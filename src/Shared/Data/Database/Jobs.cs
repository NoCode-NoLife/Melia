using System;
using System.Collections.Generic;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data;
using Yggdrasil.Data.JSON;

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
		public int StrRatio { get; set; }
		public int ConRatio { get; set; }
		public int IntRatio { get; set; }
		public int SprRatio { get; set; }
		public int DexRatio { get; set; }
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
			entry.AssertNotMissing("jobId", "className", "initial", "name", "rank", "str", "con", "int", "spr", "dex", "strRatio", "conRatio", "intRatio", "sprRatio", "dexRatio", "hpRate", "spRate", "stamina", "barrackStance");

			var data = new JobData();

			data.Id = (JobId)entry.ReadInt("jobId");
			data.ClassName = entry.ReadString("className");
			data.Initial = entry.ReadString("initial");
			data.Name = entry.ReadString("name");
			data.Rank = entry.ReadInt("rank");
			data.Str = entry.ReadInt("str");
			data.Con = entry.ReadInt("con");
			data.Int = entry.ReadInt("int");
			data.Spr = entry.ReadInt("spr");
			data.Dex = entry.ReadInt("dex");
			data.StrRatio = entry.ReadInt("strRatio");
			data.ConRatio = entry.ReadInt("conRatio");
			data.IntRatio = entry.ReadInt("intRatio");
			data.SprRatio = entry.ReadInt("sprRatio");
			data.DexRatio = entry.ReadInt("dexRatio");
			data.HpRate = entry.ReadFloat("hpRate");
			data.SpRate = entry.ReadFloat("spRate");
			data.Stamina = entry.ReadInt("stamina");
			data.DefRate = entry.ReadFloat("defRate", 1);
			data.MDefRate = entry.ReadFloat("mdefRate", 1);
			data.HrRate = entry.ReadFloat("hrRate", 1);
			data.DrRate = entry.ReadFloat("drRate", 1);
			data.BlkRate = entry.ReadFloat("blkRate", 1);
			data.BlkBreakRate = entry.ReadFloat("blkBreakRate", 1);
			data.CrtHrRate = entry.ReadFloat("crthrRate", 1);
			data.CrtDrRate = entry.ReadFloat("crtdrRate", 1);
			data.RHpRate = entry.ReadFloat("rhpRate", 1);
			data.RSpRate = entry.ReadFloat("rspRate", 1);
			data.AtkSpeedRate = entry.ReadFloat("atkSpeedRate", 1);
			data.MoveSpeedRate = entry.ReadFloat("moveSpeedRate", 1);
			data.BarrackStance = entry.ReadInt("barrackStance");

			// TODO: It would be good if we could check right here whether
			//   these skills and items and such actually exist.

			// Skills
			data.DefaultSkills = new HashSet<string>();
			if (entry.ContainsKey("defaultSkills"))
			{
				foreach (var name in entry["defaultSkills"])
					data.DefaultSkills.Add((string)name);
			}

			// Abilities
			data.DefaultAbilities = new HashSet<string>();
			if (entry.ContainsKey("defaultAbilities"))
			{
				foreach (var name in entry["defaultAbilities"])
					data.DefaultAbilities.Add((string)name);
			}

			// Items
			data.DefaultItems = new HashSet<string>();
			if (entry.ContainsKey("defaultItems"))
			{
				foreach (var name in entry["defaultItems"])
					data.DefaultItems.Add((string)name);
			}

			// Equip
			data.DefaultEquip = new Dictionary<EquipSlot, string>();
			if (entry.ContainsKey("defaultEquip"))
			{
				var equipEntry = (JObject)entry["defaultEquip"];
				foreach (var pair in equipEntry)
				{
					var slot = StringToEquipSlot(pair.Key);
					var name = pair.Value;

					data.DefaultEquip[slot] = (string)name;
				}
			}

			this.AddOrReplace(data.Id, data);
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
