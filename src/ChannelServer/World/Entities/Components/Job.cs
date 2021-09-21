using System;
using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;

namespace Melia.Channel.World.Entities.Components
{
	/// <summary>
	/// Represents one of a character's jobs.
	/// </summary>
	public class Job
	{
		/// <summary>
		/// The owner of the job.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns this job's id.
		/// </summary>
		public JobId Id { get; }

		/// <summary>
		/// Gets or sets the circle this job is on.
		/// </summary>
		public Circle Circle { get; set; }

		/// <summary>
		/// Gets or sets skill points available for this job.
		/// </summary>
		public int SkillPoints
		{
			get { return _skillPoints; }
			set { _skillPoints = Math2.Clamp(0, short.MaxValue, value); }
		}
		private int _skillPoints;

		/// <summary>
		/// Reference to the job's data from the job database.
		/// </summary>
		public JobData Data { get; }

		/// <summary>
		/// Total EXP collected for this job.
		/// </summary>
		/// <remarks>
		/// Every job has its own total EXP count, which the client uses
		/// in combination with the character's current job and rank to
		/// determine the class level. There doesn't seem to be a way
		/// to change the max class EXP from the server, as it is with
		/// the base EXP.
		/// </remarks>
		public int TotalExp { get; set; }

		/// <summary>
		/// Returns the class level reached on this job.
		/// </summary>
		public int Level
		{
			get
			{
				// TODO: This should be improved, but I'll be lazy
				//   for the moment, in case all this doesn't work out the
				//   way I expect it to.

				var jobId = this.Id;
				var rank = this.Character.Jobs.GetCurrentRank();
				var totalExp = this.TotalExp;
				var max = (rank == 1 ? 15 : 45); // TODO: Const? Conf? Determine based on exp db?

				// Search for the first level which's requirement we can't
				// fulfill, as that will be the level we're on.
				for (var i = 1; i < max; ++i)
				{
					var needed = ChannelServer.Instance.Data.ExpDb.GetNextTotalClassExp(rank, i);
					if (totalExp < needed)
						return i;
				}

				// Found none? It's the max then.
				return max;
			}
		}

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="jobId"></param>
		/// <param name="circle"></param>
		/// <param name="skillPoints"></param>
		public Job(Character character, JobId jobId, Circle circle = Circle.First, int skillPoints = 0)
			: this(character, jobId, 0, circle, skillPoints)
		{
		}

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="jobId"></param>
		/// <param name="totalExp"></param>
		/// <param name="circle"></param>
		/// <param name="skillPoints"></param>
		public Job(Character character, JobId jobId, int totalExp, Circle circle = Circle.First, int skillPoints = 0)
		{
			this.Character = character;
			this.Id = jobId;
			this.Circle = circle;
			this.SkillPoints = skillPoints;
			this.TotalExp = totalExp;
			this.Data = ChannelServer.Instance.Data.JobDb.Find(jobId) ?? throw new ArgumentException($"Unknown job '{jobId}'.");
		}

		/// <summary>
		/// Modifies job's skill points updates the client.
		/// </summary>
		/// <param name="modifier"></param>
		/// <returns></returns>
		public void ModifySkillPoints(int modifier)
		{
			this.SkillPoints += modifier;
			Send.ZC_JOB_PTS(this.Character, this);
		}
	}
}
