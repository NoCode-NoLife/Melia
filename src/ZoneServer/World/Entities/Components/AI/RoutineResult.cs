namespace Melia.Zone.World.Entities.Components.AI
{
	/// <summary>
	/// The current state of a routine.
	/// </summary>
	public enum RoutineResult
	{
		/// <summary>
		/// The routine is still executing.
		/// </summary>
		Running,

		/// <summary>
		/// The routine was completed successfully.
		/// </summary>
		Success,

		/// <summary>
		/// The routine failed to be completed.
		/// </summary>
		Fail,
	}
}
