// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
    public class Skills
    {
        private Character _character;

        private object _syncLock = new object();
        private Dictionary<long, Skill> _skills;

        /// <summary>
        /// Creates new Skills for character.
        /// </summary>
        public Skills(Character character)
        {
            _skills = new Dictionary<long, Skill>();

            _character = character;
        }

        public IDictionary<int, Skill> GetSkills()
        {
            var result = new Dictionary<int, Skill>();

            lock (_syncLock)
            {
                foreach (var skill in _skills)
                {
                    result.Add(skill.Value.Id, skill.Value);
                }
            }

            return result;
        }

        /// <summary>
        /// Learn skill
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="skillId"></param>
        /// <param name="level"></param>
        /// <return>Index of the skill.</return>
        public int Learn(int jobId, int skillId, int level)
        {
            int index = int.Parse(jobId.ToString() + skillId.ToString());
            Skill skill;
            Skill tmp_skill;

            if (_skills.TryGetValue(index, out tmp_skill))
            {
                skill = tmp_skill;
                skill.Level += level;
                _skills[index] = skill;
            }
            else
            {
                skill = new Skill(jobId, skillId, level);
                _skills.Add(index, skill);
            }

            Send.ZC_ABILITY_LIST(_character);

            return 1;
        }

        /// <summary>
		/// Adds skill to skills list and updates client.
		/// </summary>
		/// <param name="skill"></param>
		/// <return>Index of the skill.</return>
		public int Add(long uniqueID, Skill skill)
        {
            _skills.Add(uniqueID, skill);

            //NUllReferenceError in this string, i have no idea why :D
            //Send.ZC_ABILITY_LIST(_character);

            return 1;
        }

        /// <summary>
		/// Return user skils count for ZC_ABILITY_LIST
		/// </summary>
		/// <param name="skill"></param>
		/// <return>Skils count.</return>
		public int Length()
        {
            return _skills.Count;
        }
    }
}
