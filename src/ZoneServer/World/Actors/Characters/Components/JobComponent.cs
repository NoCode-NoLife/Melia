using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// Job collection.
	/// </summary>
	public class JobComponent : CharacterComponent
	{
		private static readonly Regex JobClassName = new Regex(@"^Char(?<class>[1-4])_(?<index>[0-9]{1,2})$", RegexOptions.Compiled);

		private readonly Dictionary<JobId, Job> _jobs = new Dictionary<JobId, Job>();

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public JobComponent(Character character) : base(character)
		{
		}

		/// <summary>
		/// Returns the amount of jobs in the collection.
		/// </summary>
		public int Count { get { lock (_jobs) return _jobs.Count; } }

		/// <summary>
		/// Adds given without updating the client. Replaces existing
		/// jobs.
		/// </summary>
		/// <param name="job"></param>
		public void AddSilent(Job job)
		{
			lock (_jobs)
				_jobs[job.Id] = job;
		}

		/// <summary>
		/// Adds given job and updates the client. Replaces existing
		/// jobs.
		/// </summary>
		/// <param name="job"></param>
		public void Add(Job job)
		{
			this.AddSilent(job);
			Send.ZC_NORMAL.UpdateSkillUI(this.Character);
		}

		/// <summary>
		/// Removes job with given id, returns false if it
		/// didn't exist. Doesn't update the client.
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public bool RemoveSilent(JobId jobId)
		{
			lock (_jobs)
				return _jobs.Remove(jobId);
		}

		/// <summary>
		/// Removes job with given id, returns false if it
		/// didn't exist. Updates the client on success.
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public bool Remove(JobId jobId)
		{
			if (!this.RemoveSilent(jobId))
				return false;

			// XXX: Seems like this is not enough to get rid of the jobs at
			//   run-time. Is there a way for us to refresh the UI?
			Send.ZC_NORMAL.UpdateSkillUI(this.Character);

			return true;
		}

		/// <summary>
		/// Returns job with given id, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public Job Get(JobId jobId)
		{
			lock (_jobs)
			{
				_jobs.TryGetValue(jobId, out var job);
				return job;
			}
		}

		/// <summary>
		/// Returns the job with the given class name, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="jobClassName"></param>
		/// <returns></returns>
		public Job Get(string jobClassName)
		{
			lock (_jobs)
				return _jobs.Values.FirstOrDefault(job => job.Data.ClassName == jobClassName);
		}

		/// <summary>
		/// Returns job with the given id via out. Returns false if it
		/// wasn't found.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="job"></param>
		/// <returns></returns>
		public bool TryGet(JobId jobId, out Job job)
		{
			lock (_jobs)
				return _jobs.TryGetValue(jobId, out job);
		}

		/// <summary>
		/// Returns a list with all jobs.
		/// </summary>
		/// <returns></returns>
		public Job[] GetList()
		{
			lock (_jobs)
				return _jobs.Values.ToArray();
		}

		/// <summary>
		/// Returns true if the job exists, and whether it's at least at the
		/// given circle.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="circle"></param>
		/// <returns></returns>
		public bool Has(JobId jobId, JobCircle circle = JobCircle.First)
		{
			lock (_jobs)
			{
				if (!_jobs.TryGetValue(jobId, out var job))
					return false;

				return (job.Circle >= circle);
			}
		}

		/// <summary>
		/// Changes job's circle if it exists, returns false if not.
		/// Updates client on success.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="circle"></param>
		public bool ChangeCircle(JobId jobId, JobCircle circle)
		{
			var job = this.Get(jobId);
			if (job == null)
				return false;

			job.Circle = circle;
			Send.ZC_NORMAL.UpdateSkillUI(this.Character);

			return true;
		}

		/// <summary>
		/// Modifies given job's skill points if it exists and updates
		/// the client. Returns false if job wasn't found.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="modifier"></param>
		/// <returns></returns>
		public bool ModifySkillPoints(JobId jobId, int modifier)
		{
			var job = this.Get(jobId);
			if (job == null)
				return false;

			job.ModifySkillPoints(modifier);

			return true;
		}

		/// <summary>
		/// Returns the circle the character is on on the given job.
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public JobCircle GetCircle(JobId jobId)
		{
			var job = this.Get(jobId);
			if (job == null)
				return JobCircle.None;

			return job.Circle;
		}

		/// <summary>
		/// Returns the circle the character is on on the given job.
		/// </summary>
		/// <param name="jobClassName"></param>
		/// <returns></returns>
		public JobCircle GetCircle(string jobClassName)
		{
			var jobId = GetJobIdFromClassName(jobClassName);
			return this.GetCircle(jobId);
		}

		/// <summary>
		/// Converts job class name to job id and returns it.
		/// </summary>
		/// <param name="jobClassName"></param>
		/// <returns></returns>
		private static JobId GetJobIdFromClassName(string jobClassName)
		{
			var match = JobClassName.Match(jobClassName);
			if (!match.Success)
				throw new ArgumentException($"Invalid job class name format '{jobClassName}'.");

			var jobClass = int.Parse(match.Groups["class"].Value);
			var index = int.Parse(match.Groups["index"].Value);

			return (JobId)((jobClass * 1000) + index);
		}

		/// <summary>
		/// Returns the character's job rank.
		/// </summary>
		/// <remarks>
		/// I currently don't know how *exactly* this is supposed to work.
		/// It's the equivilant of the client's "GetTotalJobCount" function,
		/// which, I assume returns the rank the character is on with its
		/// jobs, which is kind of based on the amount of jobs, or rather
		/// the circle sum.
		/// 
		/// For example:
		/// - Swordman Circle 1 = 1
		/// - Swordman Circle 2 = 2
		/// - Swordman Circle 2 + Highlander Circle 1 = 3
		/// - Swordman Circle 2 + Highlander Circle 2 = 4
		/// - etc.
		/// </remarks>
		/// <returns></returns>
		public int GetCurrentRank()
		{
			var rank = 0;
			lock (_jobs)
				rank = _jobs.Values.Sum(a => (int)a.Circle);

			// Even if _jobs is empty right now for some reason, rank 1
			// is always the minimum.

			return Math.Max(1, rank);
		}
	}

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
		public JobCircle Circle { get; set; }

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
		public long TotalExp { get; set; }

		/// <summary>
		/// Returns the total maximum EXP that can be collected on this job.
		/// </summary>
		public long TotalMaxExp => ZoneServer.Instance.Data.ExpDb.GetNextTotalClassExp(this.Character.Jobs.GetCurrentRank(), this.MaxLevel);

		/// <summary>
		/// Returns the class level reached on this job based on the
		/// current rank and total EXP.
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
				var max = this.MaxLevel;

				// Search for the first level which's requirement we can't
				// fulfill, as that will be the level we're on.
				for (var i = 1; i < max; ++i)
				{
					var needed = ZoneServer.Instance.Data.ExpDb.GetNextTotalClassExp(rank, i);
					if (totalExp < needed)
						return i;
				}

				// Found none? It's the max then.
				return max;
			}
		}

		/// <summary>
		/// Returns the max class level for this job.
		/// </summary>
		public int MaxLevel
		{
			get
			{
				// If the current rank is 1, we're still on the base job
				// and this will return 15. If the rank is above 1, it will
				// return 45, which is the max level for all other ranks.
				// Maybe it would make more sense to determine the job's
				// max level based on the rank it was added on.

				var rank = this.Character.Jobs.GetCurrentRank();
				return ZoneServer.Instance.Data.ExpDb.GetMaxClassLevel(rank);
			}
		}

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="jobId"></param>
		/// <param name="circle"></param>
		/// <param name="skillPoints"></param>
		public Job(Character character, JobId jobId, JobCircle circle = JobCircle.First, int skillPoints = 0)
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
		public Job(Character character, JobId jobId, long totalExp, JobCircle circle = JobCircle.First, int skillPoints = 0)
		{
			this.Character = character;
			this.Id = jobId;
			this.Circle = circle;
			this.SkillPoints = skillPoints;
			this.TotalExp = totalExp;
			this.Data = ZoneServer.Instance.Data.JobDb.Find(jobId) ?? throw new ArgumentException($"Unknown job '{jobId}'.");
		}

		/// <summary>
		/// Modifies job's skill points updates the client.
		/// </summary>
		/// <param name="modifier"></param>
		/// <returns></returns>
		public void ModifySkillPoints(int modifier)
			=> this.SetSkillPoints(this.SkillPoints + modifier);

		/// <summary>
		/// Sets job's skill points updates the client.
		/// </summary>
		/// <param name="skillPoints"></param>
		/// <returns></returns>
		public void SetSkillPoints(int skillPoints)
		{
			this.SkillPoints = skillPoints;
			Send.ZC_JOB_PTS(this.Character, this);
		}
	}
}
