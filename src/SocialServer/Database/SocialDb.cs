using System;
using System.Collections.Generic;
using Melia.Shared.Database;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using MySql.Data.MySqlClient;

namespace Melia.Social.Database
{
	public class SocialDb : MeliaDb
	{
		/// <summary>
		/// Returns account with given name, or null if it doesn't exist.
		/// </summary>
		/// <param name="accountName"></param>
		/// <returns></returns>
		public bool TryGetAccount(string accountName, out Account account)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `accounts` WHERE `name` = @name", conn))
			{
				mc.Parameters.AddWithValue("@name", accountName);

				using (var reader = mc.ExecuteReader())
				{
					if (!reader.Read())
					{
						account = null;
						return false;
					}

					account = new Account();

					account.Id = reader.GetInt64("accountId");
					account.Name = reader.GetStringSafe("name");
					account.TeamName = reader.GetStringSafe("teamName");
					account.Password = reader.GetStringSafe("password");
					account.CharacterId = reader.GetInt64("loginCharacter") | ObjectIdRanges.Characters;

					return true;
				}
			}
		}

		/// <summary>
		/// Returns account with a given team name, or null if it doesn't
		/// exist.
		/// </summary>
		/// <param name="teamName"></param>
		/// <returns></returns>
		public Account GetAccountByTeamName(string teamName)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `accounts` WHERE `teamName` = @name", conn))
			{
				mc.Parameters.AddWithValue("@name", teamName);

				using (var reader = mc.ExecuteReader())
				{
					if (!reader.Read())
						return null;

					var account = new Account();

					account.Id = reader.GetInt64("accountId");
					account.Name = reader.GetStringSafe("name");
					account.TeamName = reader.GetStringSafe("teamName");

					return account;
				}
			}
		}

		/// <summary>
		/// Returns friends with a given account id.
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns></returns>
		public List<Friend> GetFriends(long accountId)
		{
			var friends = new List<Friend>();

			using (var conn = this.GetConnection())
			{
				var query = @"
					SELECT f.`friendId`, f.`group`, f.`note`, f.`state`, a.`accountId`, a.`lastLogin`, a.`teamName`, a.`loginCharacter` AS `characterId`,
					       IFNULL('', c.`name`) AS `name`, IFNULL(0, c.`job`) AS `job`, IFNULL(0, c.`gender`) AS `gender`, IFNULL(0, c.`hair`) AS `hair`, IFNULL(0, c.`level`) AS `level`
					FROM `friends` AS `f`
					LEFT JOIN `accounts` AS a ON f.`friendAccountId` = a.`accountId`
					LEFT JOIN `characters` AS c ON a.`loginCharacter` = c.`characterId`
					WHERE f.`accountId` = @accountId
				";

				using (var mc = new MySqlCommand(query, conn))
				{
					mc.Parameters.AddWithValue("@accountId", accountId);

					using (var reader = mc.ExecuteReader())
					{
						while (reader.Read())
						{
							var friend = this.ReadFriend(reader);
							friends.Add(friend);
						}
					}
				}
			}

			return friends;
		}

		/// <summary>
		/// Returns friend with a given account ids.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="friendAccountId"></param>
		/// <returns></returns>
		public Friend GetFriend(long accountId, long friendAccountId)
		{
			using (var conn = this.GetConnection())
			{
				var query = @"
					SELECT f.`friendId`, f.`group`, f.`note`, f.`state`, a.`accountId`, a.`lastLogin`, a.`teamName`, a.`loginCharacter` AS `characterId`,
					       IFNULL('', c.`name`) AS `name`, IFNULL(0, c.`job`) AS `job`, IFNULL(0, c.`gender`) AS `gender`, IFNULL(0, c.`hair`) AS `hair`, IFNULL(0, c.`level`) AS `level`
					FROM `friends` AS `f`
					LEFT JOIN `accounts` AS a ON f.`friendAccountId` = a.`accountId`
					LEFT JOIN `characters` AS c ON a.`loginCharacter` = c.`characterId`
					WHERE f.`accountId` = @accountId AND f.`friendAccountId` = @friendAccountId
				";

				using (var mc = new MySqlCommand(query, conn))
				{
					mc.Parameters.AddWithValue("@accountId", accountId);
					mc.Parameters.AddWithValue("@friendAccountId", friendAccountId);

					using (var reader = mc.ExecuteReader())
					{
						if (!reader.Read())
							return null;

						return this.ReadFriend(reader);
					}
				}
			}
		}

		/// <summary>
		/// Reads friend from reader and returns it.
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		private Friend ReadFriend(MySqlDataReader reader)
		{
			var friend = new Friend();

			friend.Id = reader.GetInt64("friendId");
			friend.State = (FriendState)reader.GetByte("state");
			friend.Group = reader.GetStringSafe("group");
			friend.Note = reader.GetStringSafe("note");
			friend.LastLogin = reader.GetDateTimeSafe("lastLogin");

			return friend;
		}

		/// <summary>
		/// Inserts friend in database.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="friend"></param>
		/// <returns></returns>
		public void CreateFriend(long accountId, Friend friend)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new InsertCommand("INSERT INTO `friends` {0}", conn, trans))
				{
					cmd.Set("accountId", accountId);
					cmd.Set("friendAccountId", friend.User.Id);
					cmd.Set("state", (byte)friend.State);
					cmd.Set("registerDate", DateTime.Now);

					cmd.Execute();
					friend.Id = cmd.LastId;
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Deletes friend.
		/// </summary>
		/// <param name="friendId"></param>
		/// <returns></returns>
		public bool DeleteFriend(long friendId)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand("DELETE FROM `friends` WHERE `friendId` = @friendId", conn))
			{
				cmd.Parameters.AddWithValue("@friendId", friendId);

				return cmd.ExecuteNonQuery() > 0;
			}
		}

		/// <summary>
		/// Saves friend information.
		/// </summary>
		/// <param name="friend"></param>
		/// <returns></returns>
		public void SaveFriend(Friend friend)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `friends` SET {0} WHERE `friendId` = @friendId", conn))
			{
				cmd.AddParameter("@friendId", friend.Id);

				cmd.Set("state", (byte)friend.State);
				cmd.Set("group", friend.Group ?? "");
				cmd.Set("note", friend.Note ?? "");

				cmd.Execute();
			}
		}
	}
}
