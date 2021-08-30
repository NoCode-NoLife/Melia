// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SessionObjectData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public QuestData QuestData { get; set; }
	}

	[Serializable]
	public class QuestData
	{
		public string Name { get; set; }
		public List<string> InfoName { get; set; }
		public List<string> InfoViewType { get; set; }
		public List<int> InfoMaxCount { get; set; }
		public List<string> MapPointGroup { get; set; }
		public List<int> MapPointView { get; set; }
		public List<string> MonsterNameGroup { get; set; }
		public List<int> MonsterView { get; set; }
		public List<string> MonsterViewTerms { get; set; }
	}

	/// <summary>
	/// SessionObject database, indexed by skill id.
	/// </summary>
	public class SessionObjectDb : DatabaseJsonIndexed<int, SessionObjectData>
	{
		/// <summary>
		/// Returns first skill data entry with given class name, or null
		/// if it wasn't found.
		/// </summary>
		/// <param name="className"></param>
		/// <returns></returns>
		public SessionObjectData Find(string className)
		{
			return this.Entries.Values.FirstOrDefault(a => a.ClassName == className);
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("id", "className", "name");

			var info = new SessionObjectData();

			info.Id = entry.ReadInt("id");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");

			if (entry.ContainsKey("quest"))
			{
				var questEntry = (JObject)entry["quest"];
				questEntry.AssertNotMissing("name");

				var questData = new QuestData();
				questData.Name = questEntry.ReadString("name");

				questData.InfoName = questEntry.ReadList<string>("infoName", null);
				questData.InfoViewType = questEntry.ReadList<string>("infoViewType", null);
				questData.InfoMaxCount = questEntry.ReadList<int>("infoMaxCount", null);
				questData.MapPointGroup = questEntry.ReadList<string>("mapPointGroup", null);
				questData.MapPointView = questEntry.ReadList<int>("mapPointView", null);
				questData.MonsterNameGroup = questEntry.ReadList<string>("monsterNameGroup", null);
				questData.MonsterView = questEntry.ReadList<int>("monsterView", null);
				questData.MonsterViewTerms = questEntry.ReadList<string>("monsterViewTerms", null);

				info.QuestData = questData;
			}

			this.Entries[info.Id] = info;
		}
	}
}
