using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Melia.Shared.Tos.Properties;
using Melia.Shared.ObjectProperties;
using MySqlConnector;
using Yggdrasil.Logging;
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
					Log.Error("Failed to create account '{0}'. Exception: {1}", name, ex);
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
						var propertyName = reader.GetString("name");
						var typeStr = reader.GetString("type");
						var valueStr = reader.GetString("value");

						// Hotfix for converting old character property
						// ids to names.
						if (databaseName == "character_properties" && Regex.IsMatch(propertyName, @"^[0-9]+$"))
						{
							var propertyId = int.Parse(propertyName);

							// It seems like we added some PCEtc properties
							// to characters at some point. I dearly hope
							// that this was a mistake on our part, as our
							// new system would crumble under the requirement
							// of supporting multiple namespaces per
							// properties instance.
							if (!PropertyTable.TryGetName("PC", propertyId, out propertyName))
							{
								if (!PropertyTable.TryGetName("PCEtc", propertyId, out propertyName))
									throw new Exception($"Property '{propertyName}' exists in neither PC nor PCEtc.");

								Log.Debug($"MeliaDb.LoadProperties: Found PCEtc property '{propertyName}' on a character. Skipping.");
								continue;
							}
						}

						if (typeStr == "f")
						{
							if (!properties.TryGet<FloatProperty>(propertyName, out var property))
								property = properties.Create(new FloatProperty(propertyName));

							if (!(property is IUnsettableProperty))
								property.Deserialize(valueStr);
						}
						else
						{
							if (!properties.TryGet<StringProperty>(propertyName, out var property))
								property = properties.Create(new StringProperty(propertyName));

							property.Deserialize(valueStr);
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
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new MySqlCommand($"DELETE FROM `{databaseName}` WHERE `{idName}` = @id", conn, trans))
				{
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}

				foreach (var property in properties.GetAll())
				{
					var typeStr = property is FloatProperty ? "f" : "s";
					var valueStr = property.Serialize();

					using (var cmd = new InsertCommand($"INSERT INTO `{databaseName}` {{0}}", conn, trans))
					{
						cmd.Set(idName, id);
						cmd.Set("name", property.Ident);
						cmd.Set("type", typeStr);
						cmd.Set("value", valueStr);

						cmd.Execute();
					}
				}

				trans.Commit();
			}
		}
	}
}
