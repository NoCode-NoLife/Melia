using System;
using Melia.Zone.World.Entities;

namespace Melia.Zone.Events
{
	/// <summary>
	/// Manager for events occurring on the server, such as players logging
	/// in or killing monsters.
	/// </summary>
	public class ServerEvents
	{
		/// <summary>
		/// Raised when a player logged in.
		/// </summary>
		/// <remarks>
		/// This event is raised right after the login was confirmed and
		/// before any more packets are sent to the client or they are
		/// added to the world. This makes it a good time to make 
		/// odifications to the character, but packets sent to the
		/// client might be handled as intended yet.
		/// </remarks>
		public event EventHandler<PlayerEventArgs> PlayerLoggedIn;
		public void OnPlayerLoggedIn(Character character) => PlayerLoggedIn?.Invoke(ZoneServer.Instance, new PlayerEventArgs(character));

		/// <summary>
		/// Raised when a player logged in completely.
		/// </summary>
		/// <remarks>
		/// This event is raised right after we start sending the client
		/// updates about the world, such as monsters and players moving
		/// around. At this point, the client is expected to be fully
		/// loaded and ready to receive whatever you throw at it.
		/// </remarks>
		public event EventHandler<PlayerEventArgs> PlayerReady;
		public void OnPlayerReady(Character character) => PlayerReady?.Invoke(ZoneServer.Instance, new PlayerEventArgs(character));
	}
}
