using System;
using System.Collections.Generic;
using Melia.Shared.Database;
using Melia.Shared.Tos.Const;
using MySql.Data.MySqlClient;
using Yggdrasil.Security.Hashing;

namespace Melia.Social.Database
{
	public class SocialDb : MeliaDb
	{
		/// <summary>
		/// Returns account with given name, or null if it doesn't exist.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Account GetAccount(string name)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `accounts` WHERE `name` = @name", conn))
			{
				mc.Parameters.AddWithValue("@name", name);

				using (var reader = mc.ExecuteReader())
				{
					if (!reader.Read())
						return null;

					var account = new Account();
					account.Id = reader.GetInt64("accountId");
					account.Name = reader.GetStringSafe("name");
					account.TeamName = reader.GetStringSafe("teamName");
					account.Password = reader.GetStringSafe("password");

					return account;
				}
			}
		}

		/// <summary>
		/// Returns account with a given team name, or null if it doesn't exist.
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
				using (var mc = new MySqlCommand("SELECT f.`friendId`, f.`group`, f.`note`, f.`state`, c.`characterId`, c.`accountId`, c.`name`, c.`teamName`, c.`job`, c.`gender`, c.`hair`, c.`level` FROM `friends` AS `f` INNER JOIN `characters` AS c ON f.`friendAccountId` = c.`accountId` WHERE f.`accountId` = @accountId GROUP BY `f`.`friendAccountId`", conn))
				{
					mc.Parameters.AddWithValue("@accountId", accountId);

					using (var reader = mc.ExecuteReader())
					{
						while (reader.Read())
						{
							var friend = new Friend();
							friend.Id = reader.GetInt64("friendId");
							friend.CharacterId = reader.GetInt64("characterId");
							friend.AccountId = reader.GetInt64("accountId");
							friend.State = (FriendState)reader.GetByte("state");
							friend.TeamName = reader.GetStringSafe("teamName");
							friend.Name = reader.GetStringSafe("name");
							friend.JobId = (JobId)reader.GetInt16("job");
							friend.Gender = (Gender)reader.GetByte("gender");
							friend.Hair = reader.GetInt32("hair");
							friend.Level = reader.GetInt32("level");
							friend.Group = reader.GetStringSafe("group");
							friend.Note = reader.GetStringSafe("note");

							friends.Add(friend);
						}
					}
				}
			}
			return friends;
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
					cmd.Set("friendAccountId", friend.AccountId);
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
			using (var mc = new MySqlCommand("DELETE FROM `friends` WHERE `friendId` = @friendId", conn))
			{
				mc.Parameters.AddWithValue("@friendId", friendId);

				return mc.ExecuteNonQuery() > 0;
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
				cmd.Set("group", friend.Group);
				cmd.Set("note", friend.Note);

				cmd.Execute();
			}
		}
	}
}
