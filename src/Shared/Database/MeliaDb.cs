using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Melia.Shared.Game.Properties;
using Melia.Shared.ObjectProperties;
using MySqlConnector;
using Yggdrasil.Logging;
using Yggdrasil.Security.Hashing;
using Yggdrasil.Util;

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
		/// Returns true if an account with the given username exists.
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
		/// Returns true if a character with the given name exists on the account.
		/// </summary>
		/// <param name="accountId"></param>
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
		/// Returns true if the given team name exists.
		/// </summary>
		/// <param name="teamName"></param>
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
		/// Changes the account's team name to the given one.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="teamName"></param>
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

		/// <summary>
		/// Saves variables in database.
		/// </summary>
		/// <param name="vars"></param>
		/// <param name="tableName"></param>
		/// <param name="ownerField"></param>
		/// <param name="ownerId"></param>
		public void SaveVariables(Variables vars, string tableName, string ownerField, long ownerId)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				this.SaveVariables(conn, trans, vars, tableName, ownerField, ownerId);
				trans.Commit();
			}
		}

		/// <summary>
		/// Saves owner's variables in database.
		/// </summary>
		/// <param name="vars"></param>
		/// <param name="tableName"></param>
		/// <param name="ownerField"></param>
		/// <param name="ownerId"></param>
		protected void SaveVariables(MySqlConnection conn, MySqlTransaction trans, Variables vars, string tableName, string ownerField, long ownerId)
		{
			var checkOwner = ownerField != null;
			var where = checkOwner ? $"`{ownerField}` = @ownerId" : "1";

			using (var mc = new MySqlCommand($"DELETE FROM `{tableName}` WHERE {where}", conn, trans))
			{
				if (checkOwner)
					mc.Parameters.AddWithValue("@ownerId", ownerId);
				mc.ExecuteNonQuery();
			}

			foreach (var var in vars.GetList())
			{
				if (var.Value == null)
					continue;

				// Get type
				string type;
				if (var.Value is byte) type = "1u";
				else if (var.Value is ushort) type = "2u";
				else if (var.Value is uint) type = "4u";
				else if (var.Value is ulong) type = "8u";
				else if (var.Value is sbyte) type = "1";
				else if (var.Value is short) type = "2";
				else if (var.Value is int) type = "4";
				else if (var.Value is long) type = "8";
				else if (var.Value is float) type = "f";
				else if (var.Value is double) type = "d";
				else if (var.Value is bool) type = "b";
				else if (var.Value is string) type = "s";
				else if (var.Value is DateTime) type = "dt";
				else if (var.Value is TimeSpan) type = "ts";
				else
				{
					Log.Warning("SaveVars: Skipping variable '{0}', unsupported type '{1}'.", var.Key, var.Value.GetType().Name);
					continue;
				}

				// Get value
				var val = "";
				switch (type)
				{
					case "f": val = ((float)var.Value).ToString(CultureInfo.InvariantCulture); break;
					case "d": val = ((double)var.Value).ToString(CultureInfo.InvariantCulture); break;
					case "dt": val = ((DateTime)var.Value).Ticks.ToString(); break;
					case "ts": val = ((TimeSpan)var.Value).Ticks.ToString(); break;
					default: val = var.Value.ToString(); break;
				}

				// Make sure value isn't too big for the mediumtext field
				// (unlikely as it may be). Size: 16,777,215
				if (val.Length > (1 << 24) - 1)
				{
					Log.Warning("SaveVars: Skipping variable '{0}', it's too big.", var.Key);
					continue;
				}

				// Save
				using (var cmd = new InsertCommand($"INSERT INTO `{tableName}` {{0}}", conn, trans))
				{
					if (checkOwner)
						cmd.Set(ownerField, ownerId);

					cmd.Set("name", var.Key);
					cmd.Set("type", type);
					cmd.Set("value", val);

					cmd.Execute();
				}
			}
		}

		/// <summary>
		/// Loads owner's variables into the variable manager.
		/// </summary>
		/// <param name="vars"></param>
		/// <param name="tableName"></param>
		/// <param name="ownerField"></param>
		/// <param name="ownerId"></param>
		/// <returns></returns>
		public void LoadVars(Variables vars, string tableName, string ownerField, long ownerId)
		{
			using (var conn = this.GetConnection())
				this.LoadVars(conn, vars, tableName, ownerField, ownerId);
		}

		/// <summary>
		/// Loads owner's variables into the variable manager.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="vars"></param>
		/// <param name="tableName"></param>
		/// <param name="ownerField"></param>
		/// <param name="ownerId"></param>
		/// <returns></returns>
		protected void LoadVars(MySqlConnection conn, Variables vars, string tableName, string ownerField, long ownerId)
		{
			var checkOwner = ownerField != null;
			var where = checkOwner ? $"`{ownerField}` = @ownerId" : "1";

			using (var mc = new MySqlCommand($"SELECT * FROM `{tableName}` WHERE {where}", conn))
			{
				if (checkOwner)
					mc.Parameters.AddWithValue("@ownerId", ownerId);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var name = reader.GetString("name");
						var type = reader.GetString("type");
						var val = reader.GetStringSafe("value");

						if (val == null)
							continue;

						try
						{
							switch (type)
							{
								case "1u": vars.Set(name, byte.Parse(val)); break;
								case "2u": vars.Set(name, ushort.Parse(val)); break;
								case "4u": vars.Set(name, uint.Parse(val)); break;
								case "8u": vars.Set(name, ulong.Parse(val)); break;
								case "1": vars.Set(name, sbyte.Parse(val)); break;
								case "2": vars.Set(name, short.Parse(val)); break;
								case "4": vars.Set(name, int.Parse(val)); break;
								case "8": vars.Set(name, long.Parse(val)); break;
								case "f": vars.Set(name, float.Parse(val, CultureInfo.InvariantCulture)); break;
								case "d": vars.Set(name, double.Parse(val, CultureInfo.InvariantCulture)); break;
								case "b": vars.Set(name, bool.Parse(val)); break;
								case "s": vars.Set(name, val); break;
								case "dt": vars.Set(name, new DateTime(long.Parse(val))); break;
								case "ts": vars.Set(name, new TimeSpan(long.Parse(val))); break;

								default:
									Log.Warning("LoadVars: Unknown variable type '{0}'.", type);
									continue;
							}
						}
						catch (FormatException)
						{
							Log.Warning("LoadVars: Variable '{0}' could not be parsed as type '{1}'. Value: '{2}', Owner: '{3}:{4}'", name, type, val, ownerField, ownerId);
							continue;
						}
						catch (OverflowException)
						{
							Log.Warning("LoadVars: Value '{2}' of variable '{0}' doesn't fit into type '{1}'. Owner: '{3}:{4}'", name, type, val, ownerField, ownerId);
							continue;
						}
					}
				}
			}
		}
	}
}
