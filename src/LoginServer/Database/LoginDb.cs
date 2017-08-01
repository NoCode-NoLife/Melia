﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Database;
using Melia.Shared.Util;
using Melia.Shared.Util.Security;
using Melia.Shared.World;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.Database
{
	public class LoginDb : MeliaDb
	{
		/// <summary>
		/// Checks whether the SQL update file has already been applied.
		/// </summary>
		/// <param name="updateFile"></param>
		/// <returns></returns>
		public bool CheckUpdate(string updateFile)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `updates` WHERE `path` = @path", conn))
			{
				mc.Parameters.AddWithValue("@path", updateFile);

				using (var reader = mc.ExecuteReader())
					return reader.Read();
			}
		}

		/// <summary>
		/// Executes SQL update file.
		/// </summary>
		/// <param name="updateFile"></param>
		public void RunUpdate(string updateFile)
		{
			try
			{
				using (var conn = this.GetConnection())
				{
					// Run update
					using (var cmd = new MySqlCommand(File.ReadAllText(Path.Combine("sql", updateFile)), conn))
						cmd.ExecuteNonQuery();

					// Log update
					using (var cmd = new InsertCommand("INSERT INTO `updates` {0}", conn))
					{
						cmd.Set("path", updateFile);
						cmd.Execute();
					}

					Log.Info("Successfully applied '{0}'.", updateFile);
				}
			}
			catch (Exception ex)
			{
				Log.Error("RunUpdate: Failed to run '{0}': {1}", updateFile, ex.Message);
				CliUtil.Exit(1);
			}
		}

		/// <summary>
		/// Saves account data.
		/// </summary>
		/// <param name="account"></param>
		/// <returns></returns>
		public bool SaveAccount(Account account)
		{
			if (account == null)
				throw new ArgumentNullException("account");

			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `accounts` SET {0} WHERE `accountId` = @accountId", conn))
			{
				cmd.AddParameter("@accountId", account.Id);
				cmd.Set("teamName", account.TeamName);
				cmd.Set("password", account.Password);

				return cmd.Execute() > 0;
			}
		}

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

					// Upgrade MD5 hashes
					if (account.Password.Length == 32)
						account.Password = BCrypt.HashPassword(account.Password, BCrypt.GenerateSalt());

					return account;
				}
			}
		}

		/// <summary>
		/// Inserts character in database.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="character"></param>
		/// <returns></returns>
		public void CreateCharacter(long accountId, Character character)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new InsertCommand("INSERT INTO `characters` {0}", conn))
				{
					cmd.Set("accountId", accountId);
					cmd.Set("name", character.Name);
					cmd.Set("teamName", character.TeamName);
					cmd.Set("job", character.Job);
					cmd.Set("gender", character.Gender);
					cmd.Set("hair", character.Hair);

					cmd.Set("zone", character.MapId);
					cmd.Set("x", character.Position.X);
					cmd.Set("y", character.Position.Y);
					cmd.Set("z", character.Position.Z);
					cmd.Set("bx", character.BarrackPosition.X);
					cmd.Set("by", character.BarrackPosition.Y);
					cmd.Set("bz", character.BarrackPosition.Z);

					cmd.Set("hp", character.Hp);
					cmd.Set("maxHp", character.MaxHp);
					cmd.Set("sp", character.Sp);
					cmd.Set("maxSp", character.MaxSp);
					cmd.Set("stamina", character.Stamina);
					cmd.Set("maxStamina", character.MaxStamina);
					cmd.Set("str", character.Str);
					cmd.Set("con", character.Con);
					cmd.Set("int", character.Int);
					cmd.Set("spr", character.Spr);
					cmd.Set("dex", character.Dex);

					cmd.Execute();
					character.Id = cmd.LastId;
				}

				var i = 0;
				foreach (var item in character.Equipment)
				{
					using (var cmd = new InsertCommand("INSERT INTO `items` {0}", conn))
					{
						cmd.Set("characterId", character.Id);
						cmd.Set("itemId", item);
						cmd.Set("amount", 1);
						cmd.Set("sort", 0);
						cmd.Set("equipSlot", i++);

						cmd.Execute();
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Deletes character.
		/// </summary>
		/// <param name="characterId"></param>
		/// <returns></returns>
		public bool DeleteCharacter(long characterId)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("DELETE FROM `characters` WHERE `characterId` = @characterId", conn))
			{
				mc.Parameters.AddWithValue("@characterId", characterId);

				return mc.ExecuteNonQuery() > 0;
			}
		}

		/// <summary>
		/// Saves character information.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public void SaveCharacter(Character character)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `characters` SET {0} WHERE `characterId` = @characterId", conn))
			{
				cmd.AddParameter("@characterId", character.Id);
				cmd.Set("teamName", character.TeamName);
				cmd.Set("zone", character.MapId);
				cmd.Set("bx", character.BarrackPosition.X);
				cmd.Set("by", character.BarrackPosition.Y);
				cmd.Set("bz", character.BarrackPosition.Z);

				cmd.Execute();
			}
		}

		/// <summary>
		/// Returns all characters on given account.
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns></returns>
		public List<Character> GetCharacters(long accountId)
		{
			var result = new List<Character>();

			using (var conn = this.GetConnection())
			{
				using (var mc = new MySqlCommand("SELECT * FROM `characters` WHERE `accountId` = @accountId", conn))
				{
					mc.Parameters.AddWithValue("@accountId", accountId);

					using (var reader = mc.ExecuteReader())
					{
						while (reader.Read())
						{
							var character = new Character();
							character.Id = reader.GetInt64("characterId");
							character.AccountId = accountId;
							character.Name = reader.GetStringSafe("name");
							character.Job = (Job)reader.GetInt16("job");
							character.Gender = (Gender)reader.GetByte("gender");
							character.Hair = reader.GetByte("hair");
							character.Level = reader.GetInt32("level");
							character.MapId = reader.GetInt32("zone");

							var bx = reader.GetFloat("bx");
							var by = reader.GetFloat("by");
							var bz = reader.GetFloat("bz");
							character.BarrackPosition = new Position(bx, by, bz);

							result.Add(character);
						}
					}
				}

				foreach (var character in result)
				{
					using (var mc = new MySqlCommand("SELECT * FROM `items` WHERE `characterId` = @characterId AND `equipSlot` != 127", conn))
					{
						mc.Parameters.AddWithValue("@characterId", character.Id);

						using (var reader = mc.ExecuteReader())
						{
							while (reader.Read())
							{
								var itemId = reader.GetInt32("itemId");
								var equipSlot = reader.GetByte("equipSlot");

								character.Equipment[equipSlot] = itemId;
							}
						}
					}
				}
			}

			return result;
		}

		/// <summary>
		/// Changes the given account's auth level.
		/// </summary>
		/// <param name="accountName"></param>
		/// <param name="level"></param>
		/// <returns></returns>
		public bool ChangeAuth(string accountName, int level)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `accounts` SET {0} WHERE `name` = @accountName", conn))
			{
				cmd.AddParameter("@accountName", accountName);
				cmd.Set("authority", level);

				return (cmd.Execute() > 0);
			}
		}

		/// <summary>
		/// Changes the given account's password.
		/// </summary>
		/// <param name="accountName"></param>
		/// <param name="password"></param>
		public void SetAccountPassword(string accountName, string password)
		{
			var md5 = MD5.Create();
			var hashedPassword = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(password))).Replace("-", "");

			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("UPDATE `accounts` SET `password` = @password WHERE `name` = @accountName", conn))
			{
				mc.Parameters.AddWithValue("@accountName", accountName);
				mc.Parameters.AddWithValue("@password", hashedPassword);

				mc.ExecuteNonQuery();
			}
		}
	}
}
