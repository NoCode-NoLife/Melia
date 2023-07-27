using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Social.Database;
using Melia.Social.Network;
using Yggdrasil.Geometry.Shapes;
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
		/// Adds friend to user's friends list.
		/// </summary>
		/// <param name="friend"></param>
		public void Add(Friend friend)
		{
			lock (_friends)
				_friends.Add(friend);

			SocialServer.Instance.Database.CreateFriend(this.User.Id, friend);
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
		/// <param name="userId"></param>
		/// <returns></returns>
		public bool Has(long userId)
		{
			lock (_friends)
				return _friends.Any(f => f.User.Id == userId);
		}

		/// <summary>
		/// Gets a friend or null with a given account id.
		/// </summary>
		/// <param name="userId"></param>
		public Friend Get(long userId)
		{
			lock (_friends)
				return _friends.FirstOrDefault(f => f.User.Id == userId);
		}

		/// <summary>
		/// Returns the friend with the given account id via out.
		/// Returns false if the friend wasn't found.
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="friend"></param>
		/// <returns></returns>
		public bool TryGet(long userId, out Friend friend)
		{
			lock (_friends)
			{
				friend = _friends.FirstOrDefault(f => f.User.Id == userId);
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
		/// Updates the friend's state.
		/// </summary>
		/// <param name="friend"></param>
		/// <param name="state"></param>
		public void UpdateFriend(Friend friend, FriendState state)
		{
			friend.State = state;
			SocialServer.Instance.Database.SaveFriend(friend);
		}

		/// <summary>
		/// Blocks the given user.
		/// </summary>
		/// <param name="userToBlock"></param>
		/// <param name="friend"></param>
		public void BlockUser(SocialUser userToBlock, out Friend friend)
		{
			if (!this.TryGet(userToBlock.Id, out friend))
			{
				this.Add(friend = new Friend(userToBlock, FriendState.Blocked));
				SocialServer.Instance.Database.CreateFriend(this.User.Id, friend);
			}
			else
			{
				this.UpdateFriend(friend, FriendState.Blocked);
				SocialServer.Instance.Database.SaveFriend(friend);
			}
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
