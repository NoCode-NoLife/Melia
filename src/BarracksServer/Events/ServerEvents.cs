using System;
using Melia.Barracks.Network;

namespace Melia.Barracks.Events
{
	/// <summary>
	/// Manager for events occurring on the server, such as players logging
	/// in or killing monsters.
	/// </summary>
	public class ServerEvents
	{
		/// <summary>
		/// Raised when a user successfully logged into the barracks server.
		/// </summary>
		public event EventHandler<ConnectionEventArgs> UserLoggedIn;
		public void OnUserLoggedIn(IBarracksConnection conn) => UserLoggedIn?.Invoke(BarracksServer.Instance, new ConnectionEventArgs(conn));

		/// <summary>
		/// Raised when a user logged out from the barracks server.
		/// </summary>
		public event EventHandler<ConnectionEventArgs> UserLoggedOut;
		public void OnUserLoggedOut(IBarracksConnection conn) => UserLoggedOut?.Invoke(BarracksServer.Instance, new ConnectionEventArgs(conn));

		/// <summary>
		/// Raised after the full login process, once the user reaches
		/// the barracks screen and all information was sent.
		/// </summary>
		public event EventHandler<ConnectionEventArgs> UserEntered;
		public void OnUserEntered(IBarracksConnection conn) => UserEntered?.Invoke(BarracksServer.Instance, new ConnectionEventArgs(conn));

		/// <summary>
		/// Raised during character creation, after the character's data
		/// was set, but before it gets added to the account.
		/// </summary>
		public event EventHandler<CharacterEventArgs> CreatingCharacter;
		public void OnCreatingCharacter(CharacterEventArgs args) => CreatingCharacter?.Invoke(BarracksServer.Instance, args);

		/// <summary>
		/// Raised after a character was created and added to the account.
		/// </summary>
		public event EventHandler<CharacterEventArgs> CharacterCreated;
		public void OnCharacterCreated(CharacterEventArgs args) => CharacterCreated?.Invoke(BarracksServer.Instance, args);

		/// <summary>
		/// Raised after a character was removed.
		/// </summary>
		public event EventHandler<CharacterEventArgs> CharacterRemoved;
		public void OnCharacterRemoved(CharacterEventArgs args) => CharacterRemoved?.Invoke(BarracksServer.Instance, args);
	}
}
