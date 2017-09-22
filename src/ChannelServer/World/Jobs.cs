// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Melia.Channel.Network;
using Melia.Shared.Const;

namespace Melia.Channel.World
{
	/// <summary>
	/// Job collection.
	/// </summary>
	public class Jobs
	{
		private static readonly Regex JobClassName = new Regex(@"^Char(?<class>[1-4])_(?<index>[0-9]{1,2})$", RegexOptions.Compiled);

		private Dictionary<JobId, Job> _jobs = new Dictionary<JobId, Job>();

		/// <summary>
		/// The owner of this object.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public Jobs(Character character)
		{
			this.Character = character ?? throw new ArgumentNullException(nameof(character));
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
			Send.ZC_NORMAL_UpdateSkillUI(this.Character);
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
			Send.ZC_NORMAL_UpdateSkillUI(this.Character);

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
		public bool Has(JobId jobId, Circle circle = Circle.First)
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
		public bool ChangeCircle(JobId jobId, Circle circle)
		{
			var job = this.Get(jobId);
			if (job == null)
				return false;

			job.Circle = circle;
			Send.ZC_NORMAL_UpdateSkillUI(this.Character);

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

			job.SkillPoints += modifier;
			Send.ZC_JOB_PTS(this.Character, job);

			return true;
		}

		/// <summary>
		/// Returns the circle the character is on on the given job.
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public Circle GetCircle(JobId jobId)
		{
			var job = this.Get(jobId);
			if (job == null)
				return Circle.None;

			return job.Circle;
		}

		/// <summary>
		/// Returns the circle the character is on on the given job.
		/// </summary>
		/// <param name="jobClassName"></param>
		/// <returns></returns>
		public Circle GetCircle(string jobClassName)
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
			lock (_jobs)
				return _jobs.Values.Sum(a => (int)a.Circle);
		}
	}
}
