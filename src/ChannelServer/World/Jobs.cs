// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;

namespace Melia.Channel.World
{
	/// <summary>
	/// Job collection.
	/// </summary>
	public class Jobs
	{
		private Dictionary<JobId, Job> _jobs = new Dictionary<JobId, Job>();

		/// <summary>
		/// Returns the amount of jobs in the collection.
		/// </summary>
		public int Count { get { lock (_jobs) return _jobs.Count; } }

		/// <summary>
		/// Adds given job to collection.
		/// </summary>
		/// <param name="job"></param>
		public void Add(Job job)
		{
			lock (_jobs)
				_jobs[job.Id] = job;
		}

		/// <summary>
		/// Removes session object with given id, returns false if it
		/// didn't exist.
		/// </summary>
		/// <param name="jobId"></param>
		/// <returns></returns>
		public bool Remove(JobId jobId)
		{
			lock (_jobs)
				return _jobs.Remove(jobId);
		}

		/// <summary>
		/// Returns session object with given id, or null if it didn't
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
		/// Returns a list with all session objects.
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
	}
}
