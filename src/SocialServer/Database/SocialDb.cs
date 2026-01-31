using System;
using System.Collections.Generic;
using Melia.Shared.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Social.World;
using MySqlConnector;

namespace Melia.Social.Database
{
	public class SocialDb : MeliaDb
	{
		/// <summary>
		/// Returns account with given name, or null if it doesn't exist.
		/// </summary>
		/// <param name="accountName"></param>
		/// <param name="account"></param>
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
		/// Gets the user for the account from the database. If it doesn't
		/// exist yet, it's created based on the account information.
		/// </summary>
		/// <param name="account"></param>
		/// <returns></returns>
		public SocialUser GetOrCreateUser(Account account)
		{
			using (var conn = this.GetConnection())
			{
				using (var cmd = new MySqlCommand("SELECT * FROM `social_users` WHERE `userId` = @userId", conn))
				{
					cmd.Parameters.AddWithValue("@userId", account.Id);

					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							var user = new SocialUser();

							user.Id = reader.GetInt64("userId");
							user.AccountId = reader.GetInt64("accountId");
							user.Name = reader.GetStringSafe("accountName");
							user.TeamName = reader.GetStringSafe("teamName");

							return user;
						}
					}
				}

				var newUser = new SocialUser();
				newUser.Id = account.Id;
				newUser.AccountId = account.Id;
				newUser.Name = account.Name;
				newUser.TeamName = account.TeamName;

				using (var cmd = new InsertCommand("INSERT IGNORE INTO `social_users` {0}", conn))
				{
					cmd.Set("userId", newUser.Id);
					cmd.Set("accountId", newUser.AccountId);
					cmd.Set("accountName", newUser.Name);
					cmd.Set("teamName", newUser.TeamName);

					cmd.Execute();
				}

				return newUser;
			}
		}

		/// <summary>
		/// Returns a list with all users from the database.
		/// </summary>
		/// <returns></returns>
		public List<SocialUser> GetAllUsers()
		{
			var users = new List<SocialUser>();

			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand("SELECT * FROM `social_users`", conn))
			{
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var user = new SocialUser();

						user.Id = reader.GetInt64("userId");
						user.AccountId = reader.GetInt64("accountId");
						user.Name = reader.GetStringSafe("accountName");
						user.TeamName = reader.GetStringSafe("teamName");
						user.LastLogin = reader.GetDateTimeSafe("lastLogin");

						users.Add(user);
					}
				}
			}

			return users;
		}

		/// <summary>
		/// Updates the last login time for the user.
		/// </summary>
		/// <param name="user"></param>
		public void UpdateLastSocialLogin(SocialUser user)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `social_users` SET {0} WHERE `userId` = @userId", conn))
			{
				cmd.AddParameter("@userId", user.Id);
				cmd.Set("lastLogin", user.LastLogin);

				cmd.Execute();
			}
		}

		/// <summary>
		/// Returns friends with a given account id.
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		public List<Friend> GetFriends(long userId)
		{
			var friends = new List<Friend>();

			using (var conn = this.GetConnection())
			{
				var query = @"
					SELECT f.`friendId`, f.`group`, f.`note`, f.`state`, u.`userId`
					FROM `friends` AS `f`
					LEFT JOIN `social_users` AS u ON f.`friendUserId` = u.`userId`
					WHERE f.`userId` = @userId
				";

				using (var mc = new MySqlCommand(query, conn))
				{
					mc.Parameters.AddWithValue("@userId", userId);

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
		/// <param name="userId"></param>
		/// <param name="friendUserId"></param>
		/// <returns></returns>
		public Friend GetFriend(long userId, long friendUserId)
		{
			using (var conn = this.GetConnection())
			{
				var query = @"
					SELECT f.`friendId`, f.`group`, f.`note`, f.`state`, u.`userId`
					FROM `friends` AS `f`
					LEFT JOIN `social_users` AS u ON f.`friendUserId` = u.`userId`
					WHERE f.`userId` = @userId AND f.`friendUserId` = @friendUserId
				";

				using (var mc = new MySqlCommand(query, conn))
				{
					mc.Parameters.AddWithValue("@userId", userId);
					mc.Parameters.AddWithValue("@friendUserId", friendUserId);

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
			friend.UserId = reader.GetInt64("userId");
			friend.State = (FriendState)reader.GetByte("state");
			friend.Group = reader.GetStringSafe("group");
			friend.Note = reader.GetStringSafe("note");

			return friend;
		}

		/// <summary>
		/// Inserts friend in database.
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="friend"></param>
		/// <returns></returns>
		public void CreateFriend(long userId, Friend friend)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new InsertCommand("INSERT INTO `friends` {0}", conn, trans))
				{
					cmd.Set("userId", userId);
					cmd.Set("friendUserId", friend.UserId);
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

		/// <summary>
		/// Loads the character information for the given user if a character
		/// is online.
		/// </summary>
		/// <param name="user"></param>
		public void LoadCharacterInfo(SocialUser user)
		{
			using (var conn = this.GetConnection())
			{
				var query = @"
					SELECT `c`.`characterId`, `c`.`name`, `c`.`teamName`, `c`.`level`, `c`.`job`, `c`.`gender`, `c`.`hair`, `c`.`skinColor`, `c`.`equipVisibility`, `c`.`zone`, `c`.`partyId`
					FROM `accounts` AS `a`
					INNER JOIN `characters` AS `c` ON `a`.`loginCharacter` = `c`.`characterId`
					WHERE `a`.`accountId` = @accountId
				";

				using (var cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@accountId", user.AccountId);

					using (var reader = cmd.ExecuteReader())
					{
						var character = user.Character;

						if (!reader.Read())
						{
							// The character will appear as offline if map id is 0
							character.MapId = 0;
							character.ChannelId = 0;
							return;
						}

						character.Id = reader.GetInt64("characterId") | ObjectIdRanges.Characters;
						character.Name = reader.GetStringSafe("name");
						character.TeamName = reader.GetStringSafe("teamName");
						character.Level = reader.GetInt32("level");
						character.JobId = (JobId)reader.GetInt32("job");
						character.Gender = (Gender)reader.GetInt32("gender");
						character.Hair = reader.GetInt32("hair");
						character.SkinColor = reader.GetUInt32("skinColor");
						character.VisibleHats = (VisibleEquip)reader.GetInt32("equipVisibility");
						character.MapId = reader.GetInt32("zone");

						// Only set PartyId from database if not already set
						// This prevents overwriting values set from PartyUpdateMessage
						if (character.PartyId == ObjectIdRanges.Party)
							character.PartyId = reader.GetInt64("partyId") | ObjectIdRanges.Party;
					}
				}
			}
		}

		/// <summary>
		/// Loads the user's likes from the database and fills its like collections.
		/// </summary>
		/// <param name="user"></param>
		public void LoadLikes(SocialUser user)
		{
			user.ReceivedLikes.Clear();
			user.SentLikes.Clear();

			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand("SELECT * FROM `likes` WHERE `receiverId` = @id OR `senderId` = @id", conn))
			{
				cmd.AddParameter("@id", user.Id);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var receiverId = reader.GetInt64("receiverId");
						var receiverName = reader.GetString("receiverName");
						var senderId = reader.GetInt64("senderId");
						var senderName = reader.GetString("senderName");
						var time = reader.GetDateTime("time");

						var like = new Like(receiverId, receiverName, senderId, senderName, time);

						if (receiverId == user.Id)
							user.ReceivedLikes.Add(like);
						else
							user.SentLikes.Add(like);
					}
				}
			}
		}

		/// <summary>
		/// Saves the given like to the database.
		/// </summary>
		/// <param name="like"></param>
		public void AddLike(Like like)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new InsertCommand("INSERT INTO `likes` {0}", conn))
			{
				cmd.Set("receiverId", like.ReceiverId);
				cmd.Set("receiverName", like.ReceiverName);
				cmd.Set("senderId", like.SenderId);
				cmd.Set("senderName", like.SenderName);
				cmd.Set("time", like.Time);

				cmd.Execute();
			}
		}

		/// <summary>
		/// Removes a like from the database.
		/// </summary>
		/// <param name="receiverId"></param>
		/// <param name="senderId"></param>
		public void RemoveLike(long receiverId, long senderId)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand("DELETE FROM `likes` WHERE `receiverId` = @receiverId AND `senderId` = @senderId", conn))
			{
				cmd.AddParameter("@receiverId", receiverId);
				cmd.AddParameter("@senderId", senderId);

				cmd.ExecuteNonQuery();
			}
		}
	}
}
