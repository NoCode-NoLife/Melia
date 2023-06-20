using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A function that handles a custom command.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="numArg1"></param>
	/// <param name="numArg2"></param>
	/// <param name="numArg3"></param>
	/// <returns></returns>
	public delegate CustomCommandResult CustomCommandScriptFunc(Character character, int numArg1, int numArg2, int numArg3);

	/// <summary>
	/// Specifies the result of a custom command.
	/// </summary>
	public enum CustomCommandResult
	{
		/// <summary>
		/// The custom command was executed successfully.
		/// </summary>
		Okay,

		/// <summary>
		/// The custom command execution failed.
		/// </summary>
		Fail,
	}
}
