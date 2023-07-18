using System;
using Melia.Shared.Data.Database;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Contains updated information about a server.
	/// </summary>
	[Serializable]
	public class ServerUpdateMessage : ICommMessage
	{
		/// <summary>
		/// Returns the type of the server.
		/// </summary>
		public ServerType ServerType { get; set; }

		/// <summary>
		/// Returns the server's id.
		/// </summary>
		public int ServerId { get; set; }

		/// <summary>
		/// Returns the number of players on the server.
		/// </summary>
		/// <remarks>
		/// Currenty only applies to zone servers.
		/// </remarks>
		public int PlayerCount { get; set; }

		/// <summary>
		/// Returns the server's status.
		/// </summary>
		public ServerStatus ServerStatus { get; set; }

		/// <summary>
		/// Creates a new message.
		/// </summary>
		/// <param name="serverType"></param>
		/// <param name="serverId"></param>
		/// <param name="playerCount"></param>
		/// <param name="serverStatus"></param>
		public ServerUpdateMessage(ServerType serverType, int serverId, int playerCount, ServerStatus serverStatus)
		{
			this.ServerType = serverType;
			this.ServerId = serverId;
			this.PlayerCount = playerCount;
			this.ServerStatus = serverStatus;
		}
	}
}
