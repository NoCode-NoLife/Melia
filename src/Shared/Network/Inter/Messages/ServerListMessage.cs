using System;
using System.Collections.Generic;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// A request for the server list count.
	/// </summary>
	[Serializable]
	public class ReqServerListMessage : ICommMessage
	{
	}

	/// <summary>
	/// A response to a server list request.
	/// </summary>
	[Serializable]
	public class ResServerListMessage : ICommMessage
	{
		/// <summary>
		/// Returns the list of servers.
		/// </summary>
		public ServerInfo[] Servers { get; }

		/// <summary>
		/// Creates response.
		/// </summary>
		/// <param name="servers"></param>
		public ResServerListMessage(ServerInfo[] servers)
		{
			this.Servers = servers;
		}
	}
}
