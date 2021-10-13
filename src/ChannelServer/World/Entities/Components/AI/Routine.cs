using System;

namespace Melia.Channel.World.Entities.Components.AI
{
	/// <summary>
	/// Describes an AI routine.
	/// </summary>
	public interface IRoutine
	{
		/// <summary>
		/// Executes routine.
		/// </summary>
		/// <param name="elapsed"></param>
		/// <returns></returns>
		RoutineResult Execute(TimeSpan elapsed);
	}
}
