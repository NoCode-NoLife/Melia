using System.Collections.Generic;
using System.Linq;
using Melia.Social.Database;

namespace Melia.Social.World
{
	/// <summary>
	/// Collection of users connected to the social server.
	/// </summary>
	public class UserManager
	{
		private readonly Dictionary<long, SocialUser> _users = new Dictionary<long, SocialUser>();

		/// <summary>
		/// Adds a user.
		/// </summary>
		/// <param name="conn"></param>
		public void Add(SocialUser user)
		{
			lock (_users)
				_users[user.Account.Id] = user;
		}

		/// <summary>
		/// Remove a social connection
		/// </summary>
		/// <param name="conn"></param>
		public void Remove(long accountId)
		{
			lock (_users)
				_users.Remove(accountId);
		}

		/// <summary>
		/// Returns the user with the given team name, or null if no
		/// online user was found.
		/// </summary>
		/// <param name="teamName"></param>
		/// <returns></returns>
		public SocialUser GetOrCreateUser(Account account)
		{
			if (!this.TryGet(account.Id, out var user))
			{
				user = SocialServer.Instance.Database.GetOrCreateUser(account);
				this.Add(user);
			}

			return user;
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
				user = _users.Values.FirstOrDefault(a => a.Account.TeamName == teamName);
				return user != null;
			}
		}

		/// <summary>
		/// Returns the account with the given id via out, either by getting
		/// the accout from a logged in user or the database. Returns false
		/// if the account doesn't exist.
		/// </summary>
		/// <param name="teamName"></param>
		/// <param name="account"></param>
		/// <returns></returns>
		public bool TryGetAccount(string teamName, out Account account)
		{
			if (this.TryGet(teamName, out var user))
			{
				account = user.Account;
				return true;
			}

			if (SocialServer.Instance.Database.TryGetAccount(teamName, out account))
				return true;

			return false;
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
	}
}
