using System;

namespace Melia.Zone.World.Actors.Components.AI
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
