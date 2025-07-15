using System;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Instruction to broadcast a shout to all users.
	/// </summary>
	[Serializable]
	public class ShoutMessage : ICommMessage
	{
		/// <summary>
		/// Returns the team name of the user.
		/// </summary>
		public string TeamName { get; }

		/// <summary>
		/// Returns the message text.
		/// </summary>
		public string Text { get; }

		/// <summary>
		/// Creates new message.
		/// </summary>
		public ShoutMessage(string teamName, string text)
		{
			this.TeamName = teamName;
			this.Text = text;
		}
	}
}
