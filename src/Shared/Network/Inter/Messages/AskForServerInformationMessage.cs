using System;
using Melia.Shared.Data.Database;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Contains updated information about a server.
	/// </summary>
	[Serializable]
	public class AskForServerInformationMessage : ICommMessage
	{
		/// <summary>
		/// Creates a new message.
		/// </summary>
		public AskForServerInformationMessage()
		{
		}
	}
}
