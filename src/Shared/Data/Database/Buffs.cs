using System;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class BuffData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public int Duration { get; set; }
		public int UpdateTime { get; set; }
		public int OverBuff { get; set; }
		public int BuffUpExp { get; set; }
		public bool Removable { get; set; }
		public bool RemoveOnDeath { get; set; }
		public bool RemoveBySkill { get; set; }
		public string UpdateProperties { get; set; }
	}

	/// <summary>
	/// Buff database, indexed by buff id.
	/// </summary>
	public class BuffDb : DatabaseJsonIndexed<int, BuffData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "name", "level", "duration", "overBuff", "updateTime", "buffExpUp", "removable", "removeOnDeath", "removeBySkill", "updateProperties");

			var info = new BuffData();

			info.Id = entry.ReadInt("id");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Level = entry.ReadInt("level");
			info.Duration = entry.ReadInt("duration");
			info.UpdateTime = entry.ReadInt("updateTime");
			info.OverBuff = entry.ReadInt("overBuff");
			info.BuffUpExp = entry.ReadInt("buffExpUp");
			info.Removable = entry.ReadBool("removable");
			info.RemoveOnDeath = entry.ReadBool("removeOnDeath");
			info.RemoveBySkill = entry.ReadBool("removeBySkill");
			info.UpdateProperties = entry.ReadString("updateProperties");

			this.Entries[info.Id] = info;
		}
	}
}
