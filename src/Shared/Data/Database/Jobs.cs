﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Melia.Shared.Const;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class JobData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Initial { get; set; }
		public string Name { get; set; }
		public int Rank { get; set; }
		public int Str { get; set; }
		public int Con { get; set; }
		public int Int { get; set; }
		public int Spr { get; set; }
		public int Dex { get; set; }
		public int BarrackStance { get; set; }
	}

	/// <summary>
	/// Job database, indexed by job id.
	/// </summary>
	public class JobDb : DatabaseJsonIndexed<int, JobData>
	{
		public JobData Find(Job job)
		{
			return this.Find((int)job);
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("jobId", "className", "initial", "name", "rank", "str", "con", "int", "spr", "dex", "barrackStance");

			var info = new JobData();

			info.Id = entry.ReadInt("jobId");
			info.ClassName = entry.ReadString("className");
			info.Initial = entry.ReadString("initial");
			info.Name = entry.ReadString("name");
			info.Rank = entry.ReadInt("rank");
			info.Str = entry.ReadInt("str");
			info.Con = entry.ReadInt("con");
			info.Int = entry.ReadInt("int");
			info.Spr = entry.ReadInt("spr");
			info.Dex = entry.ReadInt("dex");
			info.BarrackStance = entry.ReadInt("barrackStance");

			this.Entries[info.Id] = info;
		}
	}
}
