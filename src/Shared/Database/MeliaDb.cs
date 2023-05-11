using System;
using System.Globalization;
using Melia.Shared.Util;
using Melia.Shared.World.ObjectProperties;
using MySql.Data.MySqlClient;
using Yggdrasil.Security.Hashing;

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
			_connectionString = string.Format("server={0}; database={1}; uid={2}; password={3}; charset=utf8; pooling=true; min pool size=0; max pool size=100;", host, db, user, pass);
			this.TestConnection();
		}

		/// <summary>
		/// Returns a valid connection.
		/// </summary>
		protected MySqlConnection GetConnection()
		{
			if (_connectionString == null)
				throw new Exception("MeliaDb has not been initialized.");

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
				conn?.Close();
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

			// Wrap password in BCrypt
			password = BCrypt.HashPassword(password, BCrypt.GenerateSalt());

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
				catch (Exception ex)
				{
					Log.Exception(ex, "Failed to create account '{0}'.", name);
				}
			}

			return false;
		}

		/// <summary>
		/// Returns true if a character with the given name exists on account.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool CharacterExists(long accountId, string name)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT `characterId` FROM `characters` WHERE `accountId` = @accountId AND `name` = @name", conn))
			{
				mc.Parameters.AddWithValue("@accountId", accountId);
				mc.Parameters.AddWithValue("@name", name);

				using (var reader = mc.ExecuteReader())
					return reader.HasRows;
			}
		}

		/// <summary>
		/// Returns true if team name exists.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool TeamNameExists(string teamName)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT `accountId` FROM `accounts` WHERE `teamName` = @teamName", conn))
			{
				mc.Parameters.AddWithValue("@teamName", teamName);

				using (var reader = mc.ExecuteReader())
					return reader.HasRows;
			}
		}

		/// <summary>
		/// Changes team name for account.
		/// </summary>
		/// <param name="account"></param>
		/// <returns></returns>
		public bool UpdateTeamName(long accountId, string teamName)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `accounts` SET {0} WHERE `accountId` = @accountId", conn))
			{
				cmd.AddParameter("@accountId", accountId);
				cmd.Set("teamName", teamName);

				return cmd.Execute() > 0;
			}
		}

		/// <summary>
		/// Loads properties from database and adds them to the given
		/// properties collection.
		/// </summary>
		/// <param name="databaseName"></param>
		/// <param name="idName"></param>
		/// <param name="id"></param>
		/// <param name="properties"></param>
		protected void LoadProperties(string databaseName, string idName, long id, Properties properties)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand($"SELECT * FROM `{databaseName}` WHERE `{idName}` = @id", conn))
			{
				cmd.Parameters.AddWithValue("@id", id);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var propertyId = reader.GetInt32("id");
						var typeStr = reader.GetString("type");
						var valueStr = reader.GetString("value");

						if (typeStr == "f")
						{
							if (!float.TryParse(valueStr, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
							{
								Log.Warning("MeliaDb.LoadProperties: Invalid float value '{0}' on '{1}/{2}/{3}/{4}'.", valueStr, databaseName, idName, id, propertyId);
								continue;
							}

							properties.Set(propertyId, value);
						}
						else
						{
							properties.Set(propertyId, valueStr);
						}
					}
				}
			}
		}

		/// <summary>
		/// Saves properties to the given database, with the id.
		/// </summary>
		/// <param name="databaseName"></param>
		/// <param name="idName"></param>
		/// <param name="id"></param>
		/// <param name="properties"></param>
		protected void SaveProperties(string databaseName, string idName, long id, Properties properties)
		{
			using (var conn = this.GetConnection())
			{
				using (var cmd = new MySqlCommand($"DELETE FROM `{databaseName}` WHERE `{idName}` = @id", conn))
				{
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}

				foreach (var property in properties.GetAll())
				{
					var typeStr = property.Type == PropertyType.Float ? "f" : "s";
					var valueStr = property.GetString();

					using (var cmd = new InsertCommand($"INSERT INTO `{databaseName}` {{0}}", conn))
					{
						cmd.Set(idName, id);
						cmd.Set("id", property.Id);
						cmd.Set("type", typeStr);
						cmd.Set("value", valueStr);

						cmd.Execute();
					}
				}
			}
		}
	}
}
