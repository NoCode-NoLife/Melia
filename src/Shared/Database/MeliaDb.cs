using System;
using System.Text.RegularExpressions;
using Melia.Shared.Game.Properties;
using Melia.Shared.ObjectProperties;
using MySqlConnector;
using Yggdrasil.Logging;
using Yggdrasil.Security.Hashing;

namespace Melia.Shared.Database
{
	public class MeliaDb
	{
		private readonly static Regex IpAddressRegex = new(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
		private readonly static Regex IpMaskRegex = new(@"^(\d{1,3}|\*)\.(\d{1,3}|\*)\.(\d{1,3}|\*)\.(\d{1,3}|\*)$");

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
				throw new ArgumentNullException(nameof(name));

			if (string.IsNullOrWhiteSpace(password))
				throw new ArgumentNullException(nameof(password));

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

							if (property is not IUnsettableProperty)
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

		/// <summary>
		/// Saves properties to the given database, with the id.
		/// </summary>
		/// <param name="databaseName"></param>
		/// <param name="idName"></param>
		/// <param name="id"></param>
		/// <param name="properties"></param>
		protected void SaveProperties(string databaseName, string idName, long id, Properties properties, MySqlConnection conn, MySqlTransaction trans)
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
		}

		/// <summary>
		/// Updates the login state of the given account.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="characterDbId"></param>
		/// <param name="state"></param>
		public void UpdateLoginState(long accountId, long characterDbId, LoginState state)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `accounts` SET {0} WHERE `accountId` = @accountId", conn))
			{
				cmd.AddParameter("@accountId", accountId);
				cmd.Set("loginState", (int)state);
				cmd.Set("loginCharacter", characterDbId);

				cmd.Execute();
			}
		}

		/// <summary>
		/// Updates the session key of the given account.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="sessionKey"></param>
		public void UpdateSessionKey(long accountId, string sessionKey)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `accounts` SET {0} WHERE `accountId` = @accountId", conn))
			{
				cmd.AddParameter("@accountId", accountId);
				cmd.Set("sessionKey", sessionKey);

				cmd.Execute();
			}
		}

		/// <summary>
		/// Returns true if the given session key matches the one found in the
		/// database for the account.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="sessionKey"></param>
		/// <returns></returns>
		public bool CheckSessionKey(long accountId, string sessionKey)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand("SELECT `sessionKey` FROM `accounts` WHERE `accountId` = @accountId", conn))
			{
				cmd.Parameters.AddWithValue("@accountId", accountId);

				using (var reader = cmd.ExecuteReader())
				{
					if (!reader.Read())
						return false;

					var dbSessionKey = reader.GetStringSafe("sessionKey");
					return dbSessionKey == sessionKey;
				}
			}
		}

		/// <summary>
		/// Returns true if the given account is logged in.
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns></returns>
		public bool IsLoggedIn(long accountId)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand("SELECT `loginState` FROM `accounts` WHERE `accountId` = @accountId", conn))
			{
				cmd.AddParameter("@accountId", accountId);

				using (var reader = cmd.ExecuteReader())
				{
					if (!reader.Read())
						return false;

					var loginState = (LoginState)reader.GetInt32("loginState");
					return loginState != LoginState.LoggedOut;
				}
			}
		}

		/// <summary>
		/// Returns true if the given IP address is banned.
		/// </summary>
		/// <param name="ip"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public bool CheckIpBan(string ip)
		{
			// Remove potential ports
			if (ip.Contains(':'))
				ip = ip.Split(':')[0];

			if (!IpAddressRegex.IsMatch(ip))
				throw new ArgumentException("Invalid IP address.", nameof(ip));

			var ipParts = ip.Split('.');
			var mask1 = $"{ipParts[0]}.*.*.*";
			var mask2 = $"{ipParts[0]}.{ipParts[1]}.*.*";
			var mask3 = $"{ipParts[0]}.{ipParts[1]}.{ipParts[2]}.*";

			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand("SELECT * FROM `ip_bans` WHERE `ip` = @ip OR `ip` = @mask1 OR `ip` = @mask2 OR `ip` = @mask3", conn))
			{
				cmd.AddParameter("@ip", ip);
				cmd.AddParameter("@mask1", mask1);
				cmd.AddParameter("@mask2", mask2);
				cmd.AddParameter("@mask3", mask3);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var from = reader.GetDateTime("fromDate");
						var to = reader.GetDateTime("toDate");
						var isBanned = from <= DateTime.Now && to >= DateTime.Now;

						if (isBanned)
							return true;
					}
				}
			}

			return false;
		}

		/// <summary>
		/// Bans the given IP address or mask.
		/// </summary>
		/// <remarks>
		/// The IP mask can contain wildcards in form of asterisks (*).
		/// For example, "192.168.*.*" would ban all IP addresses in the
		/// 192.168.x.x range.
		/// </remarks>
		/// <param name="ipMask"></param>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="reason"></param>
		/// <exception cref="ArgumentException"></exception>
		public void BanIp(string ipMask, DateTime from, DateTime to, string reason)
		{
			if (!IpMaskRegex.IsMatch(ipMask))
				throw new ArgumentException("Invalid IP address mask.", nameof(ipMask));

			using (var conn = this.GetConnection())
			using (var cmd = new InsertCommand("INSERT INTO `ip_bans` {0}", conn))
			{
				cmd.Set("ip", ipMask);
				cmd.Set("fromDate", from);
				cmd.Set("toDate", to);
				cmd.Set("reason", reason);

				cmd.Execute();
			}
		}
	}
}
