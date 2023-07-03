using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Melia.Shared.Database;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using MySql.Data.MySqlClient;
using Yggdrasil.Logging;
using Yggdrasil.Security.Hashing;
using Yggdrasil.Util;

namespace Melia.Barracks.Database
{
	public class BarracksDb : MeliaDb
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
				ConsoleUtil.Exit(1);
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
				cmd.Set("medals", account.Medals);
				cmd.Set("giftMedals", account.GiftMedals);
				cmd.Set("premiumMedals", account.PremiumMedals);
				cmd.Set("additionalSlotCount", account.AdditionalSlotCount);
				cmd.Set("teamExp", account.TeamExp);
				cmd.Set("barracksThema", account.SelectedBarrack);
				cmd.Set("themas", string.Join(" ", account.Themas));
				cmd.Set("selectedSlot", account.SelectedCharacterSlot);

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
					account.Medals = reader.GetInt32("medals");
					account.GiftMedals = reader.GetInt32("giftMedals");
					account.PremiumMedals = reader.GetInt32("premiumMedals");
					account.AdditionalSlotCount = reader.GetInt32("additionalSlotCount");
					account.TeamExp = reader.GetInt32("teamExp");
					account.SelectedBarrack = reader.GetInt32("barracksThema");
					account.SelectedCharacterSlot = reader.GetInt32("selectedSlot");

					var themas = reader.GetStringSafe("themas");
					account.Themas.Clear();
					account.Themas.UnionWith(themas.Split(' ').Select(int.Parse));

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
				using (var cmd = new InsertCommand("INSERT INTO `characters` {0}", conn, trans))
				{
					cmd.Set("accountId", accountId);
					cmd.Set("name", character.Name);
					cmd.Set("teamName", character.TeamName);
					cmd.Set("job", character.JobId);
					cmd.Set("gender", character.Gender);
					cmd.Set("hair", character.Hair);

					cmd.Set("zone", character.MapId);
					cmd.Set("x", character.Position.X);
					cmd.Set("y", character.Position.Y);
					cmd.Set("z", character.Position.Z);
					cmd.Set("bx", character.BarracksPosition.X);
					cmd.Set("by", character.BarracksPosition.Y);
					cmd.Set("bz", character.BarracksPosition.Z);
					cmd.Set("bd", character.BarracksDirection.DegreeAngle);

					cmd.Set("hp", character.Hp);
					cmd.Set("hpRate", character.HpRateByJob);
					cmd.Set("sp", character.Sp);
					cmd.Set("spRate", character.SpRateByJob);
					cmd.Set("stamina", character.Stamina);
					cmd.Set("staminaByJob", character.StaminaByJob);
					cmd.Set("strByJob", character.StrByJob);
					cmd.Set("conByJob", character.ConByJob);
					cmd.Set("intByJob", character.IntByJob);
					cmd.Set("sprByJob", character.SprByJob);
					cmd.Set("dexByJob", character.DexByJob);
					cmd.Set("maxExp", character.MaxExp);

					cmd.Set("barrackLayer", character.BarrackLayer);
					cmd.Set("slot", character.Index);

					cmd.Execute();
					character.Id = cmd.LastId;
				}

				// Equip
				// Only save items that aren't default equipment
				foreach (var item in character.Equipment.Where(a => !InventoryDefaults.EquipItems.Contains(a.Id)))
				{
					var newId = 0L;

					using (var cmd = new InsertCommand("INSERT INTO `items` {0}", conn))
					{
						cmd.Set("itemId", item.Id);
						cmd.Set("amount", 1);

						cmd.Execute();

						newId = cmd.LastId;
					}

					using (var cmd = new InsertCommand("INSERT INTO `inventory` {0}", conn))
					{
						cmd.Set("characterId", character.Id);
						cmd.Set("itemId", newId);
						cmd.Set("sort", 0);
						cmd.Set("equipSlot", (byte)item.Slot);

						cmd.Execute();
					}
				}

				// Job
				using (var cmd = new InsertCommand("INSERT INTO `jobs` {0}", conn, trans))
				{
					cmd.Set("characterId", character.Id);
					cmd.Set("jobId", character.JobId);

					cmd.Execute();
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
				cmd.Set("bx", character.BarracksPosition.X);
				cmd.Set("by", character.BarracksPosition.Y);
				cmd.Set("bz", character.BarracksPosition.Z);
				cmd.Set("bd", character.BarracksDirection.DegreeAngle);
				cmd.Set("barrackLayer", character.BarrackLayer);
				cmd.Set("slot", character.Index);

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
				using (var mc = new MySqlCommand("SELECT * FROM `characters` WHERE `accountId` = @accountId ORDER BY `slot`", conn))
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
							character.JobId = (JobId)reader.GetInt16("job");
							character.Gender = (Gender)reader.GetByte("gender");
							character.Hair = reader.GetInt32("hair");
							character.Level = reader.GetInt32("level");
							character.MapId = reader.GetInt32("zone");
							character.Index = (byte)reader.GetInt32("slot");
							character.BarrackLayer = reader.GetInt32("barrackLayer");
							character.Silver = reader.GetInt32("silver");

							// Something isn't quite right with the visibility
							// after login right now, because the client always
							// shows everything as visible, even when it's not.
							// So we'll default to everything being visible
							// for now, so the player can at least properly
							// disable the visibility while in-game.
							//character.VisibleEquip = (VisibleEquip)reader.GetInt32("equipVisibility");

							var bx = reader.GetFloat("bx");
							var by = reader.GetFloat("by");
							var bz = reader.GetFloat("bz");
							character.BarracksPosition = new Position(bx, by, bz);
							character.BarracksDirection = new Direction(reader.GetFloat("bd"));

							result.Add(character);
						}
					}
				}

				foreach (var character in result)
				{
					// Items
					using (var mc = new MySqlCommand("SELECT `i`.*, `inv`.`sort`, `inv`.`equipSlot` FROM `inventory` AS `inv` INNER JOIN `items` AS `i` ON `inv`.`itemId` = `i`.`itemUniqueId` WHERE `characterId` = @characterId AND `equipSlot` != 127", conn))
					{
						mc.Parameters.AddWithValue("@characterId", character.Id);

						using (var reader = mc.ExecuteReader())
						{
							while (reader.Read())
							{
								var itemId = reader.GetInt32("itemId");
								var equipSlot = reader.GetByte("equipSlot");

								character.Equipment[equipSlot] = new EquipItem(itemId, (EquipSlot)equipSlot);
							}
						}
					}

					// Jobs
					using (var mc = new MySqlCommand("SELECT `jobId` FROM `jobs` WHERE `characterId` = @characterId", conn))
					{
						mc.Parameters.AddWithValue("@characterId", character.Id);

						using (var reader = mc.ExecuteReader())
						{
							while (reader.Read())
							{
								var jobId = (JobId)reader.GetInt32("jobId");

								character.Jobs.Add(jobId);
							}
						}
					}

					if (character.Jobs.Count == 0)
						character.Jobs.Add(character.JobId);
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
			var passwordBytes = Encoding.UTF8.GetBytes(password);
			var passwordHashed = MD5.Encode(passwordBytes);
			var hashedPassword = Hex.ToString(passwordHashed, HexStringOptions.None);

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
