using Melia.Shared.Database;
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

					// Upgrade MD5 hashes
					if (account.Password.Length == 32)
						account.Password = BCrypt.HashPassword(account.Password, BCrypt.GenerateSalt());

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
	}
}
