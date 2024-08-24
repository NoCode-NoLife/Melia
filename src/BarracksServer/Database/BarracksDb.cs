using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Melia.Barracks.Network;
using Melia.Shared.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.Network;
using Melia.Shared.World;
using MySqlConnector;
using Yggdrasil.Logging;
using Yggdrasil.Security.Hashing;
using Yggdrasil.Util;

namespace Melia.Barracks.Database
{
	public class BarracksDb : MeliaDb
	{
		/// <summary>
		/// Normalizes/Updates the file names in the update db.
		/// </summary>
		/// <remarks>
		/// Temporary fix, since we had some issues with the update names.
		/// </remarks>
		/// <returns></returns>
		public void NormalizeUpdateNames()
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("UPDATE `updates` SET `path` = REPLACE(LOWER(`path`), \"update-\", \"update_\")", conn))
			{
				mc.ExecuteNonQuery();
			}
		}

		/// <summary>
		/// Returns true if the update with the given name was already applied.
		/// </summary>
		/// <param name="updateName"></param>
		/// <returns></returns>
		public bool CheckUpdate(string updateName)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `updates` WHERE `path` = @path", conn))
			{
				mc.Parameters.AddWithValue("@path", updateName);

				using (var reader = mc.ExecuteReader())
					return reader.Read();
			}
		}

		/// <summary>
		/// Executes SQL update.
		/// </summary>
		/// <param name="updateName"></param>
		/// <param name="query"></param>
		public void RunUpdate(string updateName, string query)
		{
			try
			{
				using (var conn = this.GetConnection())
				{
					// Run update
					using (var cmd = new MySqlCommand(query, conn))
						cmd.ExecuteNonQuery();

					// Log update
					using (var cmd = new InsertCommand("INSERT INTO `updates` {0}", conn))
					{
						cmd.Set("path", updateName);
						cmd.Execute();
					}

					Log.Info("Successfully applied '{0}'.", updateName);
				}
			}
			catch (Exception ex)
			{
				Log.Error("RunUpdate: Failed to run '{0}': {1}", updateName, ex.Message);
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
				throw new ArgumentNullException(nameof(account));

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
					account.Authority = reader.GetInt32("authority");
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
					cmd.Set("skinColor", character.SkinColor);

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
					character.DbId = cmd.LastId;
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
						cmd.Set("characterId", character.DbId);
						cmd.Set("itemId", newId);
						cmd.Set("sort", 0);
						cmd.Set("equipSlot", (byte)item.Slot);

						cmd.Execute();
					}
				}

				// Job
				using (var cmd = new InsertCommand("INSERT INTO `jobs` {0}", conn, trans))
				{
					cmd.Set("characterId", character.DbId);
					cmd.Set("jobId", character.JobId);
					cmd.Set("selectionDate", DateTime.Now);

					cmd.Execute();
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Deletes character.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public bool DeleteCharacter(Character character)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("DELETE FROM `characters` WHERE `characterId` = @characterId", conn))
			{
				mc.Parameters.AddWithValue("@characterId", character.DbId);

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
				cmd.AddParameter("@characterId", character.DbId);
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
							character.DbId = reader.GetInt64("characterId");
							character.AccountId = accountId;
							character.Name = reader.GetStringSafe("name");
							character.JobId = (JobId)reader.GetInt16("job");
							character.Gender = (Gender)reader.GetByte("gender");
							character.Hair = reader.GetInt32("hair");
							character.SkinColor = reader.GetUInt32("skinColor");
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
						mc.Parameters.AddWithValue("@characterId", character.DbId);

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
						mc.Parameters.AddWithValue("@characterId", character.DbId);

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
			var salt = BCrypt.GenerateSalt();
			var hashedPassword = MD5.Encode(password);
			hashedPassword = BCrypt.HashPassword(hashedPassword, salt);

			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("UPDATE `accounts` SET `password` = @password WHERE `name` = @accountName", conn))
			{
				mc.Parameters.AddWithValue("@accountName", accountName);
				mc.Parameters.AddWithValue("@password", hashedPassword);

				mc.ExecuteNonQuery();
			}
		}

		/// <summary>
		/// Loads mail for the account.
		/// </summary>
		/// <param name="account"></param>
		public void LoadMailbox(Account account)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `mail` WHERE `accountId` = @accountId", conn))
			{
				mc.Parameters.AddWithValue("@accountId", account.Id);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var state = (MailboxMessageState)reader.GetByte("status");
						if (state == MailboxMessageState.Delete)
							continue;

						var expiration = reader.GetDateTimeSafe("expirationDate");
						if (DateTime.Now >= expiration)
							continue;

						var mail = new MailMessage
						{
							Id = reader.GetInt64("mailId"),
							State = state,
							Sender = reader.GetStringSafe("sender"),
							Subject = reader.GetStringSafe("subject"),
							Message = reader.GetStringSafe("message"),
							StartDate = reader.GetDateTimeSafe("startDate"),
							ExpirationDate = expiration,
							CreatedDate = reader.GetDateTimeSafe("createdDate"),
						};

						account.Mailbox.AddMail(mail);
					}
				}
			}

			// XXX: Optimize to get get all items at once?
			foreach (var mail in account.Mailbox.GetMessages())
			{
				foreach (var item in this.LoadMailItems(mail.Id))
					mail.AddItem(item);
			}
		}

		/// <summary>
		/// Loads mail items for a specific mail.
		/// </summary>
		/// <param name="mailId"></param>
		/// <returns></returns>
		public List<MailItem> LoadMailItems(long mailId)
		{
			var items = new List<MailItem>();
			using (var conn = this.GetConnection())
			{
				using (var mc = new MySqlCommand("SELECT * FROM `mail_items` WHERE `mailId` = @mailId", conn))
				{
					mc.Parameters.AddWithValue("@mailId", mailId);

					using (var reader = mc.ExecuteReader())
					{
						while (reader.Read())
						{
							var mailItem = new MailItem
							{
								DbId = (int)reader.GetInt64("mailItemId"),
								ItemDbId = reader.GetInt64("itemId"),
								Id = reader.GetInt32("id"),
								Amount = reader.GetInt32("amount"),
								WasReceived = reader.GetByte("status") == 1,
							};

							items.Add(mailItem);
						}
					}
				}
			}

			return items;
		}

		/// <summary>
		/// Persists the account's mail to the database.
		/// </summary>
		/// <param name="account"></param>
		public void SaveMail(Account account)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				foreach (var mail in account.Mailbox.GetMessages())
				{
					using (var cmd = new UpdateCommand("UPDATE `mail` SET {0} WHERE `mailId` = @mailId", conn, trans))
					{
						cmd.AddParameter("@mailId", mail.Id);
						cmd.Set("accountId", account.Id);
						cmd.Set("sender", mail.Sender);
						cmd.Set("subject", mail.Subject);
						cmd.Set("message", mail.Message);
						cmd.Set("status", (byte)mail.State);
						cmd.Set("startDate", mail.StartDate);
						cmd.Set("expirationDate", mail.ExpirationDate);
						cmd.Set("createdDate", mail.CreatedDate);

						cmd.Execute();
					}

					foreach (var item in mail.GetItems())
					{
						using (var cmd = new UpdateCommand("UPDATE `mail_items` SET {0} WHERE `mailItemId` = @mailItemId", conn, trans))
						{
							cmd.AddParameter("@mailItemId", item.DbId);
							cmd.Set("mailId", mail.Id);
							cmd.Set("itemId", item.ItemDbId);
							cmd.Set("id", item.Id);
							cmd.Set("amount", item.Amount);
							cmd.Set("status", item.WasReceived);
							cmd.Execute();
						}
					}
				}

				trans.Commit();
			}
		}


		/// <summary>
		/// Adds an item to the character's inventory.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="itemId"></param>
		public void SaveItem(Character character, long itemId)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new InsertCommand("INSERT INTO `inventory` {0}", conn))
				{
					cmd.Set("characterId", character.DbId);
					cmd.Set("itemId", itemId);
					cmd.Set("sort", 0);
					cmd.Set("equipSlot", 0x7F);

					cmd.Execute();
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Returns all companions on given account.
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns></returns>
		public List<Companion> GetCompanions(long accountId)
		{
			var result = new List<Companion>();

			using (var conn = this.GetConnection())
			{
				using (var mc = new MySqlCommand("SELECT * FROM `companions` WHERE `accountId` = @accountId ORDER BY `slot`", conn))
				{
					mc.Parameters.AddWithValue("@accountId", accountId);

					using (var reader = mc.ExecuteReader())
					{
						while (reader.Read())
						{
							var characterId = reader.IsDBNull(2) ? 0 : reader.GetInt64("characterId");
							var companion = new Companion(reader.GetInt64("companionId"), reader.GetInt64("accountId"), characterId);
							companion.MonsterId = reader.GetInt32("monsterId");
							companion.Name = reader.GetStringSafe("name");
							companion.Index = (byte)reader.GetInt32("slot");
							companion.BarracksLayer = reader.GetInt32("barrackLayer");

							var bx = reader.GetFloat("bx");
							var by = reader.GetFloat("by");
							var bz = reader.GetFloat("bz");
							companion.BarracksPosition = new Position(bx, by, bz);

							result.Add(companion);
						}
					}
				}
			}

			return result;
		}

		/// <summary>
		/// Set the current character associated with a companion
		/// </summary>
		/// <param name="companionId"></param>
		/// <param name="characterId"></param>
		public void SetCompanionCharacter(long companionId, long characterId)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new UpdateCommand("UPDATE `companions` SET {0} WHERE `companionId` = @companionId", conn, trans))
				{
					cmd.AddParameter("@companionId", companionId);
					if (characterId > 0)
						cmd.Set("characterId", characterId);
					else
						cmd.Set("characterId", null);

					cmd.Execute();
				}
				trans.Commit();
			}
		}

		/// <summary>
		/// Deletes a companion.
		/// </summary>
		/// <param name="companionId"></param>
		/// <returns></returns>
		public bool DeleteCompanion(long companionId)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("DELETE FROM `companions` WHERE `companionId` = @companionId", conn))
			{
				mc.Parameters.AddWithValue("@companionId", companionId);

				return mc.ExecuteNonQuery() > 0;
			}
		}
	}
}
