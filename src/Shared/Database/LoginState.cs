namespace Melia.Shared.Database
{
	/// <summary>
	/// Specifies whether a character is logged in and which type of server
	/// they're connected to.
	/// </summary>
	public enum LoginState
	{
		/// <summary>
		/// Account is currently not logged in.
		/// </summary>
		LoggedOut,

		/// <summary>
		/// Account is currently connection to a barracks server.
		/// </summary>
		Barracks,

		/// <summary>
		/// Account is currently connected to a zone server.
		/// </summary>
		Zone,
	}
}
