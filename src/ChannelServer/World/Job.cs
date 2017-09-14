// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using Melia.Shared.Const;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	/// <summary>
	/// Represents one of a character's jobs.
	/// </summary>
	public class Job
	{
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
		/// Creates new instance
		/// </summary>
		/// <param name="id"></param>
		public Job(JobId id)
		{
			this.Id = id;
			this.Circle = Circle.First;
			this.SkillPoints = 0;
		}
	}
}
