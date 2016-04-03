using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Skills;

namespace Melia.Channel.World.Creatures
{
    public class CreatureSkills
    {
        private Character _creature;
        private Dictionary<SkillId, Skill> _skills;

        /// <summary>
		/// Currently active skill
		/// </summary>
		public Skill ActiveSkill { get; set; }

        /// <summary>
		/// New skill manager for creature.
		/// </summary>
		/// <param name="creature"></param>
		public CreatureSkills(Character creature)
        {
            _skills = new Dictionary<SkillId, Skill>();
            _creature = creature;
        }

        /// <summary>
		/// Returns skill by id, or null.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Skill Get(SkillId id)
        {
            Skill result;
            lock (_skills)
                _skills.TryGetValue(id, out result);
            return result;
        }

        /// <summary>
		/// Traing a given skillId, an specific amount of levels
		/// </summary>
		/// <param name="skill"></param>
		public bool Learn(int jobId, int skillIndex, int amount)
        {
            // Check if skill is learnable by this creature
            if (this.CanLearnSkill(jobId, skillIndex))
            {
                // Check if creature has enough SkillPoints available to increase "amount" of levels
                // Check if "amount" of levels is a valid amount to increase (or if reaches max level sooner)
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
		/// Check if creature can learn a skill
		/// </summary>
		/// <param name="skill"></param>
		public bool CanLearnSkill(int jobId, int skillIndex)
        {
            return true;
        }
    }
}
