using Melia.Shared.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Melia.Channel.World
{
    public class Skill
    {
        private static long _worldId = 0x0060000000000000;

        /// <summary>
        /// Returns the skill's id.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Data from data files.
        /// </summary>
        public Skills Data { get; private set; }

        /// <summary>
        /// Returns the Level of the skill.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Returns the jobid of the skill.
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// skill's world id...?
        /// </summary>
        /// <remarks>
        /// Is there an entity id like system?
        /// </remarks>
        public long WorldId { get; private set; }

        /// <summary>
        /// Creates new skill.
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="level"></param>
        public Skill(int jobId, int skillId, int level = 1)
        {
            this.Id = skillId;
            this.JobId = jobId;
            this.Level = Math.Max(1, level);
            this.WorldId = Interlocked.Increment(ref _worldId);
        }
    }
}
