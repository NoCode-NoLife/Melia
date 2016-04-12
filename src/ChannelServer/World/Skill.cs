using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using System.Threading;

namespace Melia.Channel.World
{
	public class Skill : Actor
	{
		public long _worldId;
		public int Id;
		public int level;

		public SkillData Data;

		public Skill(int skillId, int level)
		{
			this._worldId = Interlocked.Increment(ref _worldId) + 0x30000000000000;
			this.level = level;
			this.Id = skillId;
			this.LoadData();
		}

		public bool SetLevel(int newLevel)
		{
			this.level = newLevel;
			return true;
		}

		/// <summary>
		/// Loads skill data from data files.
		/// </summary>
		public void LoadData()
		{
			if (this.Id == 0)
				throw new InvalidOperationException("Skill id wasn't set before calling LoadData.");

			this.Data = ChannelServer.Instance.Data.SkillDb.Find(this.Id);
			if (this.Data == null)
				throw new NullReferenceException("No skill data found for '" + this.Id + "'.");
		}
	}
}
