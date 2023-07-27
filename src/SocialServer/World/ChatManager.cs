using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Social.Database;
using Melia.Social.Network;

namespace Melia.Social.World
{
	public class ChatManager
	{
		private readonly Dictionary<long, ChatRoom> _rooms = new Dictionary<long, ChatRoom>();

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
			lock (_rooms)
				_rooms.Add(chatRoom.Id, chatRoom);
		}

		/// <summary>
		/// Remove a chat room with a given chat room id.
		/// </summary>
		/// <param name="id"></param>
		public void RemoveChatRoom(long id)
		{
			lock (_rooms)
				_rooms.Remove(id);
		}

		/// <summary>
		/// Returns a 1:1 chat room between two accounts if one exists.
		/// </summary>
		/// <param name="accountId1"></param>
		/// <param name="accountId2"></param>
		/// <returns></returns>
		public ChatRoom GetChatRoom(long accountId1, long accountId2)
		{
			lock (_rooms)
			{
				foreach (var chatRoom in _rooms.Values)
				{
					if (chatRoom.Type != ChatRoomType.OneToOne)
						continue;

					var members = chatRoom.GetMembers();
					if (members.Length != 2)
						continue;

					if (members.Any(a => a.AccountId == accountId1) && members.Any(a => a.AccountId == accountId2))
						return chatRoom;
				}
			}

			return null;
		}

		/// <summary>
		/// Return true or false if a chat room with a given id is found.
		/// </summary>
		/// <param name="chatId"></param>
		/// <param name="chatRoom"></param>
		/// <returns></returns>
		public bool TryGetChatRoom(long chatId, out ChatRoom chatRoom)
		{
			lock (_rooms)
				return _rooms.TryGetValue(chatId, out chatRoom);
		}

		/// <summary>
		/// Creates a new chat room for the given user.
		/// </summary>
		/// <param name="creator"></param>
		/// <returns></returns>
		public ChatRoom CreateChatRoom(SocialUser creator)
		{
			var chatRoom = new ChatRoom("", ChatRoomType.Group);
			chatRoom.AddMember(creator);
			this.AddChatRoom(chatRoom);

			Send.SC_NORMAL.CreateRoom(creator.Connection, chatRoom);

			// Not sending this will not display the message. Sending it
			// will display the message twice. No idea why, but the same
			// behavior can be observed in the game.
			var chatMessage = new ChatMessage(creator, "!@#$NewRoomHasBeenCreated#@!");
			chatRoom.AddMessage(chatMessage);

			Send.SC_NORMAL.AddMessage(creator.Connection, chatRoom, chatMessage);

			return chatRoom;
		}
	}
}
