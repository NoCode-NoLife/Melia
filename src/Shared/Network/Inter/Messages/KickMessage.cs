using System;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Instruction to kick a player.
	/// </summary>
	[Serializable]
	public class KickMessage : ICommMessage
	{
		/// <summary>
		/// Returns the name of the origin of the kick request.
		/// </summary>
		public string OriginName { get; }

		/// <summary>
		/// Returns the team name of the target of the kick request.
		/// </summary>
		public string TargetName { get; }

		/// <summary>
		/// Creates new kick message.
		/// </summary>
		/// <param name="sourceName"></param>
		/// <param name="targetName"></param>
		public KickMessage(string sourceName, string targetName)
		{
			this.OriginName = sourceName;
			this.TargetName = targetName;
		}
	}
}
