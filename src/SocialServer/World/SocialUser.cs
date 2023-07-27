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
		/// Returns the information about the character the user is logged
		/// in as, if any.
		/// </summary>
		public Character Character { get; } = new Character();

		/// <summary>
		/// Returns the id of the user's account.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Returns the name of the user's account.
		/// </summary>
		public string Name => this.Account?.Name ?? "";

		/// <summary>
		/// Returns the user's team name.
		/// </summary>
		public string TeamName { get; set; }

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
