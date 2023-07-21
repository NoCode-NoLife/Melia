using System;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Instruction to kick all players.
	/// </summary>
	[Serializable]
	public class ReqKickAllMessage : ICommMessage
	{
	}
}
