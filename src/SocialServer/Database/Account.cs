using System.Collections.Generic;

namespace Melia.Social.Database
{
	public class Account
	{
		private readonly Dictionary<long, ChatRoom> _chatRooms = new();

		// Temporary solution for testing liking
		private readonly Dictionary<long, int> _likes = new();

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
