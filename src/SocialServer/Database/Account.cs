using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Social.Network;

namespace Melia.Social.Database
{
	public class Account
	{
		private readonly List<Friend> _friends = new List<Friend>();
		private readonly Dictionary<long, ChatRoom> _chatRooms = new Dictionary<long, ChatRoom>();

		/// <summary>
		/// Connection this account uses.
		/// </summary>
		public ISocialConnection Connection { get; set; }

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
		public string TeamName
		{
			get { return _teamName; }
			set { _teamName = value; }
		}
		private string _teamName;

		/// <summary>
		/// Loads account with given name from database
		/// and returns it.
		/// </summary>
		/// <param name="accountName"></param>
		/// <returns></returns>
		public static Account LoadFromDb(string accountName)
		{
			var account = SocialServer.Instance.Database.GetAccount(accountName);
			if (account == null)
				return null;

			foreach (var friend in SocialServer.Instance.Database.GetFriends(account.Id))
				account.AddFriend(friend);

			return account;
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
			{
				return _friends.FirstOrDefault(f => f.AccountId == accountId);
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
		/// Adds friend to the account and the database.
		/// </summary>
		/// <param name="character"></param>
		public void CreateFriend(Friend friend)
		{
			SocialServer.Instance.Database.CreateFriend(this.Id, friend);
			this.AddFriend(friend);
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
		/// Saves friends in database.
		/// </summary>
		public void Save()
		{
			lock (_friends)
			{
				foreach (var friend in _friends)
					SocialServer.Instance.Database.SaveFriend(friend);
			}
		}
	}
}
