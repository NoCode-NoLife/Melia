using System;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Instruction to kick one or multiple players.
	/// </summary>
	[Serializable]
	public class KickMessage : ICommMessage
	{
		/// <summary>
		/// Returns the target type, specifying who to kick.
		/// </summary>
		public KickTargetType TargetType { get; }

		/// <summary>
		/// Returns the name of the target of the kick request, typically
		/// a team or map name.
		/// </summary>
		public string TargetName { get; }

		/// <summary>
		/// Returns the name of the origin of the kick request.
		/// </summary>
		public string OriginName { get; }

		/// <summary>
		/// Creates new kick message.
		/// </summary>
		/// <param name="targetType">Who to target with the kick.</param>
		/// <param name="targetName">The name of the target.</param>
		/// <param name="originName">Who initiated the kick.</param>
		public KickMessage(KickTargetType targetType, string targetName, string originName)
		{
			this.TargetType = targetType;
			this.TargetName = targetName;
			this.OriginName = originName;
		}
	}

	/// <summary>
	/// Specifies who to kick.
	/// </summary>
	public enum KickTargetType
	{
		/// <summary>
		/// Kicks the player with the specified team name.
		/// </summary>
		Player,

		/// <summary>
		/// Kicks all players on the map with the specified class name.
		/// </summary>
		Map,
	}
}
