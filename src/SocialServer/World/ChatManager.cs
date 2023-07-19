using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Social.Database;
using Melia.Social.Network;

namespace Melia.Social.World
{
	public class ChatManager
	{
		private readonly Dictionary<long, ChatRoom> _chatrooms = new Dictionary<long, ChatRoom>();

		/// <summary>
		/// Chat room id initial seed
		/// </summary>
		private static long ChatId = 0x1FB0F00000000;

		/// <summary>
		/// Generate a unique id for chat rooms.
		/// </summary>
		public long GetNewChatId()
			=> Interlocked.Increment(ref ChatId);

		/// <summary>
		/// Add a chat room
		/// </summary>
		/// <param name="chatRoom"></param>
		public void AddChatRoom(ChatRoom chatRoom)
		{
			lock (_chatrooms)
				_chatrooms.Add(chatRoom.Id, chatRoom);
		}

		/// <summary>
		/// Remove a chat room with a given chat room id.
		/// </summary>
		/// <param name="id"></param>
		public void RemoveChatRoom(long id)
		{
			lock (_chatrooms)
				_chatrooms.Remove(id);
		}

		/// <summary>
		/// Returns a 1:1 chat room between two accounts if one exists.
		/// </summary>
		/// <param name="accountId1"></param>
		/// <param name="accountId2"></param>
		/// <returns></returns>
		public ChatRoom GetChatRoom(long accountId1, long accountId2)
		{
			lock (_chatrooms)
				return _chatrooms.Values.FirstOrDefault(a => a.Type == ChatRoomType.OneToOne && (a.Owner.Id == accountId1 || a.Owner.Id == accountId2));
		}

		/// <summary>
		/// Return true or false if a chat room with a given id is found.
		/// </summary>
		/// <param name="chatId"></param>
		/// <param name="chatRoom"></param>
		/// <returns></returns>
		public bool TryGetChatRoom(long chatId, out ChatRoom chatRoom)
		{
			lock (_chatrooms)
				return _chatrooms.TryGetValue(chatId, out chatRoom);
		}

		/// <summary>
		/// Create a chat room with a given owner.
		/// </summary>
		/// <param name="owner"></param>
		/// <returns></returns>
		public ChatRoom CreateChatRoom(Account owner)
		{
			var chatRoom = new ChatRoom(owner);
			chatRoom.AddMember(owner);
			this.AddChatRoom(chatRoom);

			var chatMessage = new ChatMessage(owner, "!@#$NewRoomHasBeenCreated#@!");
			chatRoom.AddMessage(chatMessage);

			//Send.SC_NORMAL.ChatRoomMessage(owner.Connection, chatRoom, chatMessage);
			Send.SC_NORMAL.ChatLog(owner.Connection, chatRoom, chatMessage);
			Send.SC_NORMAL.Chat(owner.Connection, chatRoom, chatMessage);

			return chatRoom;
		}
	}
}
