// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Melia.Shared.Const;

namespace Melia.Shared.Data.Database
{
    [Serializable]
    public class SkillsData
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// Skill database, indexed by skill id.
    /// </summary>
    public class SkillDb : DatabaseJsonIndexed<int, SkillsData>
    {
        public SkillsData Find(string name)
        {
            name = name.ToLower();
            return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
        }

        public List<SkillsData> FindAll(string name)
        {
            name = name.ToLower();
            return this.Entries.FindAll(a => a.Value.Name.ToLower().Contains(name));
        }

        protected override void ReadEntry(JObject entry)
        {
            entry.AssertNotMissing("skillId", "className", "name");

            var info = new SkillsData();

            info.Id = entry.ReadInt("skillId");
            info.ClassName = entry.ReadString("className");
            info.Name = entry.ReadString("name");

            this.Entries[info.Id] = info;
        }
    }
}
