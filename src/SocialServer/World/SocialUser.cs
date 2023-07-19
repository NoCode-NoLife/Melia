using System;
using Melia.Social.Database;
using Melia.Social.Network;

namespace Melia.Social.World
{
	/// <summary>
	/// Represents a user connected to a social server.
	/// </summary>
	public class SocialUser
	{
		/// <summary>
		/// Returns the user's connection.
		/// </summary>
		public ISocialConnection Connection { get; }

		/// <summary>
		/// Returns the user's account.
		/// </summary>
		public Account Account { get; }

		/// <summary>
		/// Returns the id of the user's account.
		/// </summary>
		public long Id => this.Account?.Id ?? 0;

		/// <summary>
		/// Returns the name of the user's account.
		/// </summary>
		public string Name => this.Account?.Name ?? "";

		/// <summary>
		/// Returns the id of the character the user is currently logged
		/// in as.
		/// </summary>
		public long CharacterId => this.Account?.CharacterId ?? 0;

		/// <summary>
		/// Returns the user's friends list.
		/// </summary>
		public FriendsList Friends { get; }

		/// <summary>
		/// Creates new social user instance for the given connection
		/// and account.
		/// </summary>
		/// <param name="connection"></param>
		/// <param name="account"></param>
		public SocialUser(ISocialConnection connection, Account account)
		{
			this.Connection = connection;
			this.Account = account;

			this.Friends = new FriendsList(this);
		}
	}
}
