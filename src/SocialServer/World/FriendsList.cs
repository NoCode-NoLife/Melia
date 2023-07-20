using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Social.Database;

namespace Melia.Social.World
{
	/// <summary>
	/// Represents a list of friends on a user.
	/// </summary>
	public class FriendsList
	{
		private readonly List<Friend> _friends = new List<Friend>();

		/// <summary>
		/// Returns the user this friends list belongs to.
		/// </summary>
		public SocialUser User { get; }

		/// <summary>
		/// Creates new friends list instance for user.
		/// </summary>
		/// <param name="user"></param>
		public FriendsList(SocialUser user)
		{
			this.User = user;
		}

		/// <summary>
		/// Adds friend to account object.
		/// </summary>
		/// <param name="friend"></param>
		public void AddFriend(Friend friend)
		{
			lock (_friends)
				_friends.Add(friend);
		}

		/// <summary>
		/// Adds friend to account object.
		/// </summary>
		/// <param name="friend"></param>
		public void RemoveFriend(Friend friend)
		{
			lock (_friends)
				_friends.Remove(friend);
		}

		/// <summary>
		/// Gets a friend or null with a given account id.
		/// </summary>
		/// <param name="accountId"></param>
		public Friend GetFriend(long accountId)
		{
			lock (_friends)
				return _friends.FirstOrDefault(f => f.AccountId == accountId);
		}

		/// <summary>
		/// Returns the friend with the given account id via out.
		/// Returns false if the friend wasn't found.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="friend"></param>
		/// <returns></returns>
		public bool TryGetFriend(long accountId, out Friend friend)
		{
			lock (_friends)
			{
				friend = _friends.FirstOrDefault(f => f.AccountId == accountId);
				return friend != null;
			}
		}

		/// <summary>
		/// Returns list of all friends on account.
		/// </summary>
		/// <returns></returns>
		public Friend[] GetFriends()
		{
			lock (_friends)
				return _friends.ToArray();
		}

		/// <summary>
		/// Returns a list of all friends with the given state.
		/// </summary>
		/// <returns></returns>
		public Friend[] GetFriends(FriendState state)
		{
			lock (_friends)
				return _friends.Where(a => a.State == state).ToArray();
		}

		/// <summary>
		/// Removes friend from the account and the database.
		/// </summary>
		/// <param name="friend"></param>
		/// <returns></returns>
		public bool DeleteFriend(Friend friend)
		{
			lock (_friends)
			{
				if (!_friends.Contains(friend))
					return false;
			}

			// If the deletion on the db fails, the character shouldn't
			// have been shown to begin with and should be removed.
			// If it doesn't fail, the removal is valid as well,
			// do this regardless of the query result.
			this.RemoveFriend(friend);

			return SocialServer.Instance.Database.DeleteFriend(friend.Id);
		}

		/// <summary>
		/// Loads the user's friends from the database.
		/// </summary>
		public void LoadFromDb()
		{
			var friends = SocialServer.Instance.Database.GetFriends(this.User.Account.Id);

			foreach (var friend in friends)
				this.AddFriend(friend);
		}
	}
}
