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
		public QuestData QuestData { get; internal set; }
	}

	[Serializable]
	public class QuestData
	{
		public string Name { get; set; }
		public IList<string> InfoName { get; internal set; }
		public IList<string> InfoViewType { get; internal set; }
		public IList<int> InfoMaxCount { get; internal set; }
		public IList<string> MapPointGroup { get; internal set; }
		public IList<int> MapPointView { get; internal set; }
		public IList<string> MonsterNameGroup { get; internal set; }
		public IList<int> MonsterView { get; internal set; }
		public IList<string> MonsterViewTerms { get; internal set; }
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
				JObject questDataObj = entry.ReadObject("quest");
				QuestData questData = new QuestData();
				questData.Name = questDataObj.ReadString("name");
				if (questDataObj.ContainsKey("infoName"))
					questData.InfoName = questDataObj.ReadArray("infoName").ToObject<IList<string>>();
				if (questDataObj.ContainsKey("infoViewType"))
					questData.InfoViewType = questDataObj.ReadArray("infoViewType").ToObject<IList<string>>();
				if (questDataObj.ContainsKey("infoMaxCount"))
					questData.InfoMaxCount = questDataObj.ReadArray("infoMaxCount").ToObject<IList<int>>();
				if (questDataObj.ContainsKey("mapPointGroup"))
					questData.MapPointGroup = questDataObj.ReadArray("mapPointGroup").ToObject<IList<string>>();
				if (questDataObj.ContainsKey("mapPointView"))
					questData.MapPointView = questDataObj.ReadArray("mapPointView").ToObject<IList<int>>();
				if (questDataObj.ContainsKey("monsterNameGroup"))
					questData.MonsterNameGroup = questDataObj.ReadArray("monsterNameGroup").ToObject<IList<string>>();
				if (questDataObj.ContainsKey("monsterView"))
					questData.MonsterView = questDataObj.ReadArray("monsterView").ToObject<IList<int>>();
				if (questDataObj.ContainsKey("monsterViewTerms"))
					questData.MonsterViewTerms = questDataObj.ReadArray("monsterViewTerms").ToObject<IList<string>>();
				info.QuestData = questData;
			}

			this.Entries[info.Id] = info;
		}
	}
}
