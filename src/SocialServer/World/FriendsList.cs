using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Social.Database;
using Yggdrasil.Logging;

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
		public void Add(Friend friend)
		{
			lock (_friends)
				_friends.Add(friend);
		}

		/// <summary>
		/// Removes friend from the list. 
		/// </summary>
		/// <param name="friend"></param>
		public void Remove(Friend friend)
		{
			lock (_friends)
				_friends.Remove(friend);
		}

		/// <summary>
		/// Returns true if the user has a friend with the given account id.
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns></returns>
		public bool Has(long accountId)
		{
			lock (_friends)
				return _friends.Any(f => f.User.Id == accountId);
		}

		/// <summary>
		/// Gets a friend or null with a given account id.
		/// </summary>
		/// <param name="accountId"></param>
		public Friend Get(long accountId)
		{
			lock (_friends)
				return _friends.FirstOrDefault(f => f.User.Id == accountId);
		}

		/// <summary>
		/// Returns the friend with the given account id via out.
		/// Returns false if the friend wasn't found.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="friend"></param>
		/// <returns></returns>
		public bool TryGet(long accountId, out Friend friend)
		{
			lock (_friends)
			{
				friend = _friends.FirstOrDefault(f => f.User.Id == accountId);
				return friend != null;
			}
		}

		/// <summary>
		/// Returns list of all friends on account.
		/// </summary>
		/// <returns></returns>
		public Friend[] GetAll()
		{
			lock (_friends)
				return _friends.ToArray();
		}

		/// <summary>
		/// Returns a list of all friends with the given state.
		/// </summary>
		/// <returns></returns>
		public Friend[] GetAll(FriendState state)
		{
			lock (_friends)
				return _friends.Where(a => a.State == state).ToArray();
		}

		/// <summary>
		/// Loads the user's friends from the database.
		/// </summary>
		public void LoadFromDb()
		{
			var friends = SocialServer.Instance.Database.GetFriends(this.User.Id);

			foreach (var friend in friends)
			{
				if (!SocialServer.Instance.UserManager.TryGet(friend.UserId, out var friendUser))
				{
					Log.Error("FriendsList.LoadFromDb: User '{0}' not found for friend '{1}' of user '{2}'.", friend.UserId, friend.Id, this.User.Name);
					continue;
				}

				friend.User = friendUser;

				this.Add(friend);
			}
		}
	}
}
