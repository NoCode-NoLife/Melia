using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.Database
{
	public class LoginDb : MeliaDb
	{
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
				cmd.Set("x", character.X);
				cmd.Set("y", character.Y);
				cmd.Set("z", character.Z);

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
	}
}
