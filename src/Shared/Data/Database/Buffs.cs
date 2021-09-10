using System;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class BuffData
	{
		public BuffId Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public int Duration { get; set; }
		public int BuffUpExp { get; set; }
		public bool Removable { get; set; }
		public bool RemoveOnDeath { get; set; }
		public bool RemoveBySkill { get; set; }
		public string UpdateProperties { get; set; }
	}

	/// <summary>
	/// Buff database, indexed by buff id.
	/// </summary>
	public class BuffDb : DatabaseJsonIndexed<BuffId, BuffData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "name", "level", "duration", "buffExpUp", "removable", "removeOnDeath", "removeBySkill", "updateProperties");

			var info = new BuffData();

			info.Id = (BuffId)entry.ReadInt("id");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Level = entry.ReadInt("level");
			info.Duration = entry.ReadInt("duration");
			info.BuffUpExp = entry.ReadInt("buffExpUp");
			info.Removable = entry.ReadBool("removable");
			info.RemoveOnDeath = entry.ReadBool("removeOnDeath");
			info.RemoveBySkill = entry.ReadBool("removeBySkill");
			info.UpdateProperties = entry.ReadString("updateProperties");

			this.Entries[info.Id] = info;
		}
	}
}
