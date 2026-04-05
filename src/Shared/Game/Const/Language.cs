namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Defines the language selected on the client.
	/// </summary>
	/// <remarks>
	/// The client appears to send its selected language only if that
	/// language is defined internally. If a custom language is selected,
	/// or Chinese, no language data is sent.
	/// </remarks>
	public enum Language : short
	{
		English = 0,
		German = 1,
		Portuguese = 2,
		// ? = 3,
		Indonesian = 4,
		Russian = 5,
		Thai = 6,
	}
}
