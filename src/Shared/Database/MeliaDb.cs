using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Database
{
	public class MeliaDb
	{
		private string _connectionString;

		/// <summary>
		/// Sets connection string and calls TestConnection.
		/// </summary>
		/// <param name="host"></param>
		/// <param name="user"></param>
		/// <param name="pass"></param>
		/// <param name="db"></param>
		/// <exception cref="Exception">Thrown if connection couldn't be established.</exception>
		public void Init(string host, string user, string pass, string db)
		{
			_connectionString = string.Format("server={0}; database={1}; uid={2}; password={3}; pooling=true; min pool size=0; max pool size=100;", host, db, user, pass);
			this.TestConnection();
		}

		/// <summary>
		/// Returns a valid connection.
		/// </summary>
		public MySqlConnection GetConnection()
		{
			if (_connectionString == null)
				throw new Exception("AuraDb has not been initialized.");

			var result = new MySqlConnection(_connectionString);
			result.Open();
			return result;
		}

		/// <summary>
		/// Tests connection.
		/// </summary>
		/// <exception cref="Exception">Thrown if connection couldn't be established.</exception>
		public void TestConnection()
		{
			MySqlConnection conn = null;
			try
			{
				conn = this.GetConnection();
			}
			finally
			{
				if (conn != null)
					conn.Close();
			}
		}

		/// <summary>
		/// Returns true if accounts exists.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool AccountExists(string name)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT `name` FROM `accounts` WHERE `name` = @name", conn))
			{
				mc.Parameters.AddWithValue("@name", name);

				using (var reader = mc.ExecuteReader())
					return reader.HasRows;
			}
		}

		/// <summary>
		/// Returns true if account exists and password is correct.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public bool CheckAccount(string name, string password)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT `name` FROM `accounts` WHERE `name` = @name AND `password` = @password", conn))
			{
				mc.Parameters.AddWithValue("@name", name);
				mc.Parameters.AddWithValue("@password", password);

				using (var reader = mc.ExecuteReader())
					return reader.HasRows;
			}
		}

		/// <summary>
		/// Creates new account with given information.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">Thrown if name or password is empty.</exception>
		public bool CreateAccount(string name, string password)
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentNullException("name");

			if (string.IsNullOrWhiteSpace(password))
				throw new ArgumentNullException("password");

			using (var conn = this.GetConnection())
			using (var cmd = new InsertCommand("INSERT INTO `accounts` {0}", conn))
			{
				cmd.Set("name", name);
				cmd.Set("password", password);

				try
				{
					cmd.Execute();
					return true;
				}
				catch
				{
					Log.Error("Failed to create account '{0}'.", name);
				}
			}

			return false;
		}

		/// <summary>
		/// Saves account and all associated data (like characters).
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

				foreach (var character in account.GetCharacters())
					this.SaveCharacter(character);

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
					account.Password = reader.GetStringSafe("password");
					account.TeamName = reader.GetStringSafe("teamName");

					var characters = this.GetCharacters(account.Id);
					foreach (var character in characters)
						account.AddCharacter(character);

					return account;
				}
			}
		}

		/// <summary>
		/// Returns true if a character with the given name exists.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool CharacterExists(string name)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT `characterId` FROM `characters` WHERE `name` = @name", conn))
			{
				mc.Parameters.AddWithValue("@name", name);

				using (var reader = mc.ExecuteReader())
					return reader.HasRows;
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
			using (var cmd = new InsertCommand("INSERT INTO `characters` {0}", conn))
			{
				cmd.Set("accountId", accountId);
				cmd.Set("name", character.Name);
				cmd.Set("job", character.Job);
				cmd.Set("gender", character.Gender);
				cmd.Set("hair", character.Hair);
				cmd.Set("x", character.X);
				cmd.Set("y", character.Y);
				cmd.Set("z", character.Z);

				cmd.Execute();
				character.Id = cmd.LastId;
			}
		}

		/// <summary>
		/// Saves character information.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public bool SaveCharacter(Character character)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `characters` SET {0} WHERE `characterId` = @characterId", conn))
			{
				cmd.AddParameter("@characterId", character.Id);
				cmd.Set("x", character.X);
				cmd.Set("y", character.Y);
				cmd.Set("z", character.Z);

				cmd.Execute();
			}

			return false;
		}

		/// <summary>
		/// Returns all characters on account.
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns></returns>
		private List<Character> GetCharacters(long accountId)
		{
			var result = new List<Character>();

			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `characters` WHERE `accountId` = @accountId", conn))
			{
				mc.Parameters.AddWithValue("@accountId", accountId);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var character = new Character();
						character.Id = reader.GetInt64("characterId");
						character.Name = reader.GetStringSafe("name");
						character.Job = (Job)reader.GetInt16("job");
						character.Gender = (Gender)reader.GetByte("gender");
						character.Hair = reader.GetByte("hair");
						character.Level = reader.GetInt32("level");
						character.X = reader.GetFloat("x");
						character.Y = reader.GetFloat("y");
						character.Z = reader.GetFloat("z");

						result.Add(character);
					}
				}
			}

			return result;
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
	}
}
