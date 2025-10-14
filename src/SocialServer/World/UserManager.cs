using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Network;
using Melia.Social.Database;

namespace Melia.Social.World
{
	/// <summary>
	/// Collection of users connected to the social server.
	/// </summary>
	/// <remarks>
	/// The user manager is the authority on managing, loading, and creating
	/// users, and unless there's a really good reason for it, no other class
	/// should directly call into the database to get or create users.
	/// </remarks>
	public class UserManager
	{
		private readonly Dictionary<long, SocialUser> _users = new();

		/// <summary>
		/// Loads existing users from the database.
		/// </summary>
		public void LoadUsers()
		{
			var users = SocialServer.Instance.Database.GetAllUsers();

			lock (_users)
			{
				foreach (var user in users)
					_users[user.Id] = user;
			}

			foreach (var user in users)
			{
				user.Friends.LoadFromDb();
				user.LoadLikesFromDb();
			}
		}

		/// <summary>
		/// Adds a user.
		/// </summary>
		/// <param name="conn"></param>
		//public void Add(SocialUser user)
		//{
		//	lock (_users)
		//		_users[user.Id] = user;
		//}

		/// <summary>
		/// Remove a social connection
		/// </summary>
		/// <param name="conn"></param>
		//public void Remove(long accountId)
		//{
		//	lock (_users)
		//		_users.Remove(accountId);
		//}

		/// <summary>
		/// Returns the user for the account with the given team name,
		/// creating it if it doesn't exist yet.
		/// </summary>
		/// <param name="account"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if no account with the given team name exists.
		/// </exception>
		public SocialUser GetOrCreateUser(string teamName)
		{
			var account = SocialServer.Instance.Database.GetAccountByTeamName(teamName);
			if (account == null)
				throw new ArgumentException($"Account with team name '{teamName}' not found.");

			return this.GetOrCreateUser(account);
		}

		/// <summary>
		/// Returns the user for the given account, creating it if it doesn't
		/// exist yet.
		/// </summary>
		/// <param name="account"></param>
		/// <returns></returns>
		public SocialUser GetOrCreateUser(Account account)
		{
			lock (_users)
			{
				if (!_users.TryGetValue(account.Id, out var user))
				{
					user = SocialServer.Instance.Database.GetOrCreateUser(account);
					user.Friends.LoadFromDb();

					_users[user.Id] = user;
				}

				return user;
			}
		}

		/// <summary>
		/// Returns the user with the given id via out. Returns false if
		/// the user doesn't exist yet.
		/// </summary>
		/// <remarks>
		/// Since users are created when an account first logs in, this
		/// method should only ever return false if the user has never
		/// logged in with a character before. If that's the case, they
		/// should be considered non-existant.
		/// </remarks>
		/// <param name="accountId"></param>
		/// <param name="user"></param>
		/// <returns></returns>
		public bool TryGet(long accountId, out SocialUser user)
		{
			// We could technically get the account and create the user
			// if they don't exist yet, seemingly removing the need for
			// the *Try*Get, but there's still the possibility that the
			// account doesn't exist (anymore), in which case we'd still
			// want to return false.

			lock (_users)
				return _users.TryGetValue(accountId, out user);
		}

		/// <summary>
		/// Returns the user with the given team name via out.
		/// Returns false if no matching user was found.
		/// </summary>
		/// <param name="teamName"></param>
		/// <param name="user"></param>
		/// <returns></returns>
		public bool TryGet(string teamName, out SocialUser user)
		{
			lock (_users)
			{
				user = _users.Values.FirstOrDefault(a => a.TeamName == teamName);
				return user != null;
			}
		}

		/// <summary>
		/// Returns the friend with the given ids via out, either by getting
		/// it from a logged in user or the database. Returns false if the
		/// friend doesn't exist.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="friendAccountId"></param>
		/// <param name="friend"></param>
		/// <returns></returns>
		public bool TryGetFriend(long accountId, long friendAccountId, out Friend friend)
		{
			if (this.TryGet(accountId, out var user))
			{
				if (user.Friends.TryGet(friendAccountId, out friend))
					return true;
			}

			friend = SocialServer.Instance.Database.GetFriend(accountId, friendAccountId);
			return friend != null;
		}

		/// <summary>
		/// Returns true if the user with the given account id is currently online.
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns></returns>
		public bool IsOnline(long accountId)
		{
			if (!this.TryGet(accountId, out var user))
				return false;

			return user.TryGetConnection(out _);
		}

		/// <summary>
		/// Returns all online users with the given party id.
		/// </summary>
		/// <param name="partyId"></param>
		/// <returns></returns>
		public List<SocialUser> GetOnlineUsersByPartyId(long partyId)
		{
			var result = new List<SocialUser>();

			if (partyId == 0)
				return result;

			lock (_users)
			{
				foreach (var user in _users.Values)
				{
					if (user.Character != null && user.Character.PartyId == partyId && user.TryGetConnection(out _))
						result.Add(user);
				}
			}

			return result;
		}

		/// <summary>
		/// Broadcasts packet to all active users.
		/// </summary>
		/// <param name="packet"></param>
		public void Broadcast(Packet packet)
		{
			lock (_users)
			{
				foreach (var user in _users.Values)
					user.Connection?.Send(packet);
			}
		}
	}
}
