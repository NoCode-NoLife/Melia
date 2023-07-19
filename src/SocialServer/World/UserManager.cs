using System.Collections.Generic;
using System.Linq;
using Melia.Social.Network;

namespace Melia.Social.World
{
	public class UserManager
	{
		private readonly Dictionary<long, ISocialConnection> _connectedUsers = new Dictionary<long, ISocialConnection>();

		/// <summary>
		/// Add a social connection
		/// </summary>
		/// <param name="conn"></param>
		public void Add(ISocialConnection conn)
		{
			lock (_connectedUsers)
			{
				conn.Account.Connection = conn;
				if (_connectedUsers.ContainsKey(conn.Account.Id))
					_connectedUsers.Remove(conn.Account.Id);
				_connectedUsers.Add(conn.Account.Id, conn);
			}
		}

		/// <summary>
		/// Remove a social connection
		/// </summary>
		/// <param name="conn"></param>
		public void Remove(ISocialConnection conn)
		{
			lock (_connectedUsers)
			{
				conn.Account.Connection = null;
				_connectedUsers.Remove(conn.Account.Id);
			}
		}

		/// <summary>
		/// Returns the connection with the given account id via out.
		/// returns false if no matching connection was found.
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns></returns>
		public bool TryGetSocialConnection(long accountId, out ISocialConnection conn)
		{
			lock (_connectedUsers)
				return _connectedUsers.TryGetValue(accountId, out conn);
		}

		/// <summary>
		/// Get a social connection with a given team name.
		/// </summary>
		/// <param name="teamName"></param>
		/// <returns></returns>
		public ISocialConnection GetSocialConnection(string teamName)
		{
			lock (_connectedUsers)
				return _connectedUsers.Values.FirstOrDefault(a => a.Account?.TeamName == teamName);
		}
	}
}
