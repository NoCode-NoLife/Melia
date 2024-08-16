using System;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// A request for the total player count.
	/// </summary>
	[Serializable]
	public class ReqPlayerCountMessage : ICommMessage
	{
	}

	/// <summary>
	/// A response to a player count request.
	/// </summary>
	[Serializable]
	public class ResPlayerCountMessage : ICommMessage
	{
		/// <summary>
		/// Returns the total player count.
		/// </summary>
		public int PlayerCount { get; }

		/// <summary>
		/// Creates new player count response.
		/// </summary>
		/// <param name="playerCount"></param>
		public ResPlayerCountMessage(int playerCount)
		{
			this.PlayerCount = playerCount;
		}
	}
}
