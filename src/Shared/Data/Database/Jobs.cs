using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
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
		public JobClass JobClassId { get; set; }
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
	}

	/// <summary>
	/// Job database, indexed by job id.
	/// </summary>
	public class JobDb : DatabaseJsonIndexed<JobId, JobData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("jobId", "className", "initial", "jobClass", "name", "rank", "str", "con", "int", "spr", "dex", "strRatio", "conRatio", "intRatio", "sprRatio", "dexRatio", "hpRate", "spRate", "stamina", "barrackStance");

			var data = new JobData();

			data.Id = (JobId)entry.ReadInt("jobId");
			data.ClassName = entry.ReadString("className");
			data.Initial = entry.ReadString("initial");
			data.JobClassId = entry.ReadEnum<JobClass>("jobClass");
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

			this.AddOrReplace(data.Id, data);
		}
	}
}
