using System.Collections.Generic;
using System.Linq;

namespace Melia.Social.Database
{
	public class Account
	{
		private readonly Dictionary<long, ChatRoom> _chatRooms = new Dictionary<long, ChatRoom>();

		// Temporary solution for testing liking
		private readonly Dictionary<long, int> _likes = new Dictionary<long, int>();

		/// <summary>
		/// Account id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Account name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Account password.
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Gets or sets account's team name and updates all characters.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Gets or sets the id of the character that is currently logged in.
		/// </summary>
		public long CharacterId { get; set; }

		/// <summary>
		/// Add a reference to the object in Account's chatrooms.
		/// </summary>
		/// <param name="chatRoom"></param>
		public void AddChatRoom(ChatRoom chatRoom)
		{
			lock (_chatRooms)
			{
				if (!_chatRooms.ContainsKey(chatRoom.Id))
					_chatRooms.Add(chatRoom.Id, chatRoom);
			}
		}

		/// <summary>
		/// Removes a object from Account's chatrooms.
		/// </summary>
		/// <param name="id"></param>
		public void RemoveChatRoom(long id)
		{
			lock (_chatRooms)
			{
				if (_chatRooms.ContainsKey(id))
					_chatRooms.Remove(id);
			}
		}

		/// <summary>
		/// Returns list of all friends on account.
		/// </summary>
		/// <returns></returns>
		public ChatRoom[] GetChatRooms()
		{
			lock (_chatRooms)
				return _chatRooms.Values.ToArray();
		}

		/// <summary>
		/// Adds a like to the given character.
		/// </summary>
		/// <param name="characterId"></param>
		public void AddLike(long characterId)
		{
			lock (_likes)
			{
				if (!_likes.TryGetValue(characterId, out var likes))
					_likes[characterId] = 0;

				_likes[characterId]++;
			}
		}

		/// <summary>
		/// Removes a like for the given character.
		/// </summary>
		/// <param name="characterId"></param>
		public void RemoveLike(long characterId)
		{
			lock (_likes)
			{
				if (!_likes.TryGetValue(characterId, out var likes))
					_likes[characterId] = 0;

				_likes[characterId]--;
			}
		}

		/// <summary>
		/// Returns the number of likes the given character received.
		/// </summary>
		/// <param name="characterId"></param>
		/// <returns></returns>
		public int GetLikes(long characterId)
		{
			lock (_likes)
			{
				if (!_likes.TryGetValue(characterId, out var likes))
					return 0;

				return likes;
			}
		}
	}
}
