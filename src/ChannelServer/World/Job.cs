// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;

namespace Melia.Channel.World
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
		/// Creates new instance
		/// </summary>
		/// <param name="character"></param>
		/// <param name="jobId"></param>
		/// <param name="circle"></param>
		/// <param name="skillPoints"></param>
		public Job(Character character, JobId jobId, Circle circle = Circle.First, int skillPoints = 0)
		{
			this.Character = character;
			this.Id = jobId;
			this.Circle = circle;
			this.SkillPoints = skillPoints;
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
