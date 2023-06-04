using System;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Events
{
	/// <summary>
	/// Arguments for events related to a player character.
	/// </summary>
	public class PlayerEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="character"></param>
		public PlayerEventArgs(Character character)
		{
			this.Character = character;
		}
	}

	/// <summary>
	/// Arguments for events related to a player character.
	/// </summary>
	public class PlayerChatEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns what the player said.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		public PlayerChatEventArgs(Character character, string message)
		{
			this.Character = character;
			this.Message = message;
		}
	}
}
