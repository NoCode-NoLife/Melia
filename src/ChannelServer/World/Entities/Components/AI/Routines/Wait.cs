using System;

namespace Melia.Channel.World.Entities.Components.AI.Routines
{
	/// <summary>
	/// A routine that simply waits for a certain amount of time.
	/// </summary>
	public class WaitRoutine : IRoutine
	{
		private TimeSpan _remaining;

		/// <summary>
		/// Creates routine.
		/// </summary>
		/// <param name="waitTime"></param>
		public WaitRoutine(TimeSpan waitTime)
		{
			this.Init(waitTime);
		}

		/// <summary>
		/// Initializes the routine.
		/// </summary>
		/// <param name="waitTime"></param>
		public void Init(TimeSpan waitTime)
		{
			_remaining = waitTime;
		}

		/// <summary>
		/// Executes routine, returns Success once the wait time is over.
		/// </summary>
		/// <param name="elapsed"></param>
		/// <returns></returns>
		public RoutineResult Execute(TimeSpan elapsed)
		{
			_remaining -= elapsed;

			if (_remaining > TimeSpan.Zero)
				return RoutineResult.Running;

			return RoutineResult.Success;
		}
	}
}
