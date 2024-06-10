﻿using System;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class BuffData
	{
		public BuffId Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public BuffType Type { get; set; }
		public int Level { get; set; }
		public TimeSpan Duration { get; set; }
		public TimeSpan UpdateTime { get; set; }
		public int OverBuff { get; set; }
		public int BuffUpExp { get; set; }
		public bool Removable { get; set; }
		public bool RemoveOnDeath { get; set; }
		public bool RemoveBySkill { get; set; }
		public bool Save { get; set; }
		public string[] UpdateProperties { get; set; }
	}

	public enum BuffType
	{
		Buff,
		Debuff,
	}

	/// <summary>
	/// Buff database, indexed by buff id.
	/// </summary>
	public class BuffDb : DatabaseJsonIndexed<BuffId, BuffData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "name", "type", "level", "duration", "overBuff", "updateTime", "buffExpUp", "removable", "removeOnDeath", "removeBySkill", "save");

			var data = new BuffData();

			data.Id = (BuffId)entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");
			data.Type = entry.ReadEnum<BuffType>("type");
			data.Level = entry.ReadInt("level");
			data.Duration = TimeSpan.FromMilliseconds(entry.ReadInt("duration"));
			data.UpdateTime = TimeSpan.FromMilliseconds(entry.ReadInt("updateTime"));
			data.OverBuff = entry.ReadInt("overBuff");
			data.BuffUpExp = entry.ReadInt("buffExpUp");
			data.Removable = entry.ReadBool("removable");
			data.RemoveOnDeath = entry.ReadBool("removeOnDeath");
			data.RemoveBySkill = entry.ReadBool("removeBySkill");
			data.Save = entry.ReadBool("save");
			data.UpdateProperties = entry.ReadArray("updateProperties", new string[0]);

			this.AddOrReplace(data.Id, data);
		}
	}
}
