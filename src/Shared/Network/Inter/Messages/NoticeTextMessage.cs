using System;
using Melia.Shared.Tos.Const;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Instruction to broadcast a notice text to all players.
	/// </summary>
	[Serializable]
	public class NoticeTextMessage : ICommMessage
	{
		/// <summary>
		/// Returns the display style of the text.
		/// </summary>
		public NoticeTextType Type { get; }

		/// <summary>
		/// Returns the text to broadcast.
		/// </summary>
		public string Text { get; }

		/// <summary>
		/// Creates a new broadcast text message.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="text"></param>
		public NoticeTextMessage(NoticeTextType type, string text)
		{
			this.Type = type;
			this.Text = text;
		}
	}
}
