namespace Melia.Channel.Scripting
{
	/// <summary>
	/// Contains information about the result of a call to a script
	/// function.
	/// </summary>
	public struct ScriptCallResult
	{
		/// <summary>
		/// How the script call ended.
		/// </summary>
		public readonly ScriptCallResultType Type;

		/// <summary>
		/// The error message, in case an error occurred.
		/// </summary>
		public readonly string ErrorMessage;

		/// <summary>
		/// Creates new result.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="error"></param>
		public ScriptCallResult(ScriptCallResultType type, string error = null)
		{
			this.Type = type;
			this.ErrorMessage = error;
		}
	}

	/// <summary>
	/// Describes how a script function call ended.
	/// </summary>
	public enum ScriptCallResultType
	{
		/// <summary>
		/// The call was successful.
		/// </summary>
		Success,

		/// <summary>
		/// An error occurred during execution.
		/// </summary>
		Error,

		/// <summary>
		/// The script function wasn't found.
		/// </summary>
		NotFound,
	}
}
