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
		/// Returns the id of the user's globally unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Returns the id of the user's account id.
		/// </summary>
		/// <remarks>
		/// This is current the same as the user's id, but this might
		/// change in the future.
		/// </remarks>
		public long AccountId { get; set; }

		/// <summary>
		/// Get or sets the name of the user's account.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Returns the user's team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Returns the last time the user logged in.
		/// </summary>
		public DateTime LastLogin { get; set; }

		/// <summary>
		/// Returns the user's friends list.
		/// </summary>
		public FriendsList Friends { get; }

		/// <summary>
		/// Gets or sets the user's connection if a player is connected.
		/// </summary>
		public ISocialConnection Connection { get; set; }

		/// <summary>
		/// Returns the information about the character the user is logged
		/// in as, if any.
		/// </summary>
		public Character Character { get; } = new Character();

		/// <summary>
		/// Creates new social user instance for the given connection
		/// and account.
		/// </summary>
		public SocialUser()
		{
			this.Friends = new FriendsList(this);
		}

		/// <summary>
		/// Returns the active connection of the user via out. Returns
		/// false if no player is connected.
		/// </summary>
		/// <param name="conn"></param>
		/// <returns></returns>
		public bool TryGetConnection(out ISocialConnection conn)
		{
			conn = this.Connection;
			return conn != null;
		}
	}
}
