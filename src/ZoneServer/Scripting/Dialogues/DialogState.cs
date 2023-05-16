namespace Melia.Zone.Scripting.Dialogues
{
	/// <summary>
	/// Defines the current state of a dialog.
	/// </summary>
	public enum DialogState
	{
		/// <summary>
		/// The dialog wasn't started yet.
		/// </summary>
		NotStarted,

		/// <summary>
		/// The dialog is active.
		/// </summary>
		Active,

		/// <summary>
		/// The dialog is waiting for input from a client.
		/// </summary>
		Waiting,

		/// <summary>
		/// The dialog has ended.
		/// </summary>
		Ended,
	}
}
