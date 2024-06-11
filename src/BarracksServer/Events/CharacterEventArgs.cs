using System;
using Melia.Barracks.Database;
using Melia.Barracks.Network;

namespace Melia.Barracks.Events
{
	/// <summary>
	/// Event arguments related to a character and their connection.
	/// </summary>
	public class CharacterEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the connection to the client owning the client.
		/// </summary>
		public IBarracksConnection Connection { get; }

		/// <summary>
		/// Returns the character related to the event.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="connection"></param>
		/// <param name="character"></param>
		public CharacterEventArgs(IBarracksConnection connection, Character character)
		{
			this.Connection = connection;
			this.Character = character;
		}
	}
}
