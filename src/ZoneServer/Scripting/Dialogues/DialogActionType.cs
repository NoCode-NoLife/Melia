namespace Melia.Zone.Scripting.Dialogues
{
	/// <summary>
	/// Specifies an action that was taken during a dialog.
	/// </summary>
	public enum DialogActionType
	{
		/// <summary>
		/// No action was taken.
		/// </summary>
		None,

		/// <summary>
		/// A message was sent to the client.
		/// </summary>
		Message,

		/// <summary>
		/// The client was asked for input and the script was suspended.
		/// </summary>
		Input,

		/// <summary>
		/// The dialog was closed.
		/// </summary>
		Close,
	}
}
