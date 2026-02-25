using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Melia.Shared.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.Game.Properties;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.Buffs;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Items;
using Melia.Zone.World.Maps;
using Melia.Zone.World.Quests;
using Melia.Zone.World.Storage;
using MySqlConnector;
using Yggdrasil.Logging;
using Yggdrasil.Util;

namespace Melia.Zone.Database
{
	public class ZoneDb : MeliaDb
	{
		/// <summary>
		/// Saves account.
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
				cmd.Set("settings", account.Settings.ToString());
				cmd.Set("premiumTokenExpiration", account.Premium.Token.Expiration);
				cmd.Set("medals", account.Medals);
				cmd.Set("giftMedals", account.GiftMedals);
				cmd.Set("premiumMedals", account.PremiumMedals);

				if (cmd.Execute() == 0)
					return false;
			}

			this.SaveVariables(account.Variables.Perm, "vars_accounts", "accountId", account.Id);
			this.SaveProperties("account_properties", "accountId", account.Id, account.Properties);
			this.SaveChatMacros(account);
			this.SaveRevealedMaps(account);

			return true;
		}

		/// <summary>
		/// Returns account with given name, or null if it doesn't exist.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Account GetAccount(string name)
		{
			var account = new Account();

			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `accounts` WHERE `name` = @name", conn))
			{
				mc.Parameters.AddWithValue("@name", name);

				using (var reader = mc.ExecuteReader())
				{
					if (!reader.Read())
						return null;

					account.Id = reader.GetInt64("accountId");
					account.Name = reader.GetStringSafe("name");
					account.TeamName = reader.GetStringSafe("teamName");
					account.Authority = reader.GetInt32("authority");
					account.Settings.Parse(reader.GetStringSafe("settings"));
					account.Medals = reader.GetInt32("medals");
					account.GiftMedals = reader.GetInt32("giftMedals");
					account.PremiumMedals = reader.GetInt32("premiumMedals");
					account.Premium.Token.Expiration = reader.GetDateTimeSafe("premiumTokenExpiration");
				}
			}

			this.LoadVars(account.Variables.Perm, "vars_accounts", "accountId", account.Id);
			this.LoadProperties("account_properties", "accountId", account.Id, account.Properties);
			this.LoadChatMacros(account);
			this.LoadRevealedMaps(account);

			return account;
		}

		/// <summary>
		/// Returns given character, or null if it doesn't exist.
		/// </summary>
		/// <param name="characterId"></param>
		/// <returns></returns>
		public Character GetCharacter(long accountId, long characterId)
		{
			var character = new Character();
			//var stamina = 25000;

			// When switching maps, the client sends the character object
			// id to select the character, as it's the only information
			// it has. We'll need to adjust that id here to the get the
			// correct character. DatabaseId is ObjectId - Range.
			if (characterId > ObjectIdRanges.Characters)
				characterId -= ObjectIdRanges.Characters;

			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `characters` WHERE `accountId` = @accountId AND `characterId` = @characterId", conn))
			{
				mc.Parameters.AddWithValue("@accountId", accountId);
				mc.Parameters.AddWithValue("@characterId", characterId);

				using (var reader = mc.ExecuteReader())
				{
					if (!reader.Read())
						return null;

					character.DbId = reader.GetInt64("characterId");
					character.AccountId = accountId;
					character.Name = reader.GetStringSafe("name");
					character.TeamName = reader.GetStringSafe("teamName");
					character.JobId = (JobId)reader.GetInt16("job");
					character.Gender = (Gender)reader.GetByte("gender");
					character.Hair = reader.GetInt32("hair");
					character.SkinColor = reader.GetUInt32("skinColor");
					character.MapId = reader.GetInt32("zone");
					character.Exp = reader.GetInt64("exp");
					character.MaxExp = reader.GetInt64("maxExp");
					character.TotalExp = reader.GetInt64("totalExp");

					// Something isn't quite right with the visibility
					// after login right now, because the client always
					// shows everything as visible, even when it's not.
					// So we'll default to everything being visible
					// for now, so the player can at least properly
					// disable the visibility while in-game.
					//character.VisibleEquip = (VisibleEquip)reader.GetInt32("equipVisibility");

					// We get the character's stamina from its data here
					// because this is not a PC property. Actually setting
					// it has to wait until we loaded the properties, however,
					// to get the accurate MaxStamina.
					//stamina = reader.GetInt32("stamina");

					var x = reader.GetFloat("x");
					var y = reader.GetFloat("y");
					var z = reader.GetFloat("z");
					character.Position = new Position(x, y, z);
					character.Direction = new Direction(0);
				}
			}

			this.LoadCharacterItems(character);
			this.LoadVars(character.Variables.Perm, "vars_characters", "characterId", character.DbId);
			this.LoadSessionObjects(character);
			this.LoadJobs(character);
			this.LoadSkills(character);
			this.LoadAbilities(character);
			this.LoadBuffs(character);
			this.LoadCooldowns(character);
			this.LoadQuests(character);
			this.LoadProperties("character_properties", "characterId", character.DbId, character.Properties);
			this.LoadProperties("character_etc_properties", "characterId", character.DbId, character.Etc.Properties);
			this.LoadCollections(character);

			// Initialize the properties to trigger calculated properties
			// and to set some properties in case the character is new and
			// hasn't received its initial properties based on their job's
			// data yet.
			character.InitProperties();

			// We'll simply set stamina to the max on load for now until
			// we do some more research on how stamina works, whether it's
			// saved at all, and what we want the default behavior to be.
			//character.Properties.Stamina = stamina;
			character.Properties.Stamina = (int)character.Properties.GetFloat(PropertyName.MaxSta);

			// Update stance, in case no equip was added, which would've
			// triggered this call.
			character.UpdateStance();

			// Load storage items after we got everything else, so we can set
			// the size and then load in the items. Storages that might require
			// non-character information, like account properties, have to be
			// loaded from a different location.
			character.PersonalStorage.InitSize();
			character.TeamStorage.InitSize();
			this.LoadStorage(character.PersonalStorage, "storage_personal", "characterId", character.DbId);
			this.LoadStorage(character.TeamStorage, "storage_team", "accountId", character.AccountId);

			return character;
		}

		/// <summary>
		/// Loads character's skills.
		/// </summary>
		/// <param name="character"></param>
		private void LoadSkills(Character character)
		{
			using (var conn = this.GetConnection())
			{
				using (var mc = new MySqlCommand("SELECT * FROM `skills` WHERE `characterId` = @characterId", conn))
				{
					mc.Parameters.AddWithValue("@characterId", character.DbId);

					using (var reader = mc.ExecuteReader())
					{
						while (reader.Read())
						{
							var skillId = (SkillId)reader.GetInt32("id");
							var level = reader.GetInt32("level");

							var skill = new Skill(character, skillId, level);

							character.Skills.AddSilent(skill);
						}
					}
				}

				// Properties?
			}
		}

		/// <summary>
		/// Loads character's abilities.
		/// </summary>
		/// <param name="character"></param>
		private void LoadAbilities(Character character)
		{
			using (var conn = this.GetConnection())
			{
				using (var mc = new MySqlCommand("SELECT * FROM `abilities` WHERE `characterId` = @characterId", conn))
				{
					mc.Parameters.AddWithValue("@characterId", character.DbId);

					using (var reader = mc.ExecuteReader())
					{
						while (reader.Read())
						{
							var abilityId = (AbilityId)reader.GetInt32("id");
							var level = reader.GetInt32("level");
							var active = reader.GetBoolean("active");

							var ability = new Ability(abilityId, level);
							ability.Active = active;

							character.Abilities.AddSilent(ability);
						}
					}
				}

				// Properties?
			}
		}

		/// <summary>
		/// Loads character's jobs from the database.
		/// </summary>
		/// <param name="character"></param>
		private void LoadJobs(Character character)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `jobs` WHERE `characterId` = @characterId", conn))
			{
				mc.Parameters.AddWithValue("@characterId", character.DbId);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var jobId = (JobId)reader.GetInt32("jobId");
						var circle = (JobCircle)reader.GetInt32("circle");
						var skillPoints = reader.GetInt32("skillPoints");
						var totalExp = reader.GetInt64("totalExp");
						var selectionDate = reader.GetDateTimeSafe("selectionDate");

						var job = new Job(character, jobId, totalExp, circle, skillPoints);
						job.SelectionDate = selectionDate;

						character.Jobs.AddSilent(job);
					}
				}
			}

			// Fallback if the character doesn't have a job for some reason
			if (character.Jobs.Count == 0)
				character.Jobs.AddSilent(new Job(character, character.JobId));
		}

		/// <summary>
		/// Loads character's session objects.
		/// </summary>
		/// <param name="character"></param>
		private void LoadSessionObjects(Character character)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `session_objects_properties` WHERE `characterId` = @characterId", conn))
			{
				mc.Parameters.AddWithValue("@characterId", character.DbId);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var sessionObjectId = reader.GetInt32("sessionObjectId"); // session object's class id
						var propertyName = reader.GetString("name");
						var typeStr = reader.GetString("type");
						var valueStr = reader.GetString("value");

						// Hotfix for converting old character property
						// ids to names.
						if (Regex.IsMatch(propertyName, @"^[0-9]+$"))
							propertyName = PropertyTable.GetName("SessionObject", int.Parse(propertyName));

						var sessionObject = character.SessionObjects.GetOrCreate(sessionObjectId);
						var properties = sessionObject.Properties;

						if (typeStr == "f")
						{
							if (!properties.TryGet<FloatProperty>(propertyName, out var property))
								property = properties.Create(new FloatProperty(propertyName));

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
		/// Saves character's session objects.
		/// </summary>
		/// <param name="character"></param>
		private void SaveSessionObjects(Character character)
		{
			var sessionObjects = character.SessionObjects.GetList();

			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				foreach (var sessionObject in sessionObjects)
				{
					using (var cmd = new MySqlCommand("DELETE FROM `session_objects_properties` WHERE `characterId` = @characterId AND `sessionObjectId` = @sessionObjectId", conn, trans))
					{
						cmd.Parameters.AddWithValue("@characterId", character.DbId);
						cmd.Parameters.AddWithValue("@sessionObjectId", sessionObject.Id);
						cmd.ExecuteNonQuery();
					}

					var properties = sessionObject.Properties.GetAll();
					foreach (var property in properties)
					{
						var typeStr = property is FloatProperty ? "f" : "s";
						var valueStr = property.Serialize();

						using (var cmd = new InsertCommand("INSERT INTO `session_objects_properties` {0}", conn, trans))
						{
							cmd.Set("characterId", character.DbId);
							cmd.Set("sessionObjectId", sessionObject.Id);
							cmd.Set("name", property.Ident);
							cmd.Set("type", typeStr);
							cmd.Set("value", property.Serialize());

							cmd.Execute();
						}
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Saves character information.
		/// </summary>
		/// <param name="character"></param>
		public void SaveCharacter(Character character)
		{
			var noSave = character.Variables.Temp.GetBool("Melia.NoSave", false);
			if (noSave)
				return;

			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `characters` SET {0} WHERE `characterId` = @characterId", conn))
			{
				cmd.AddParameter("@characterId", character.DbId);
				cmd.Set("name", character.Name);
				cmd.Set("job", (short)character.JobId);
				cmd.Set("gender", (byte)character.Gender);
				cmd.Set("hair", character.Hair);
				cmd.Set("skinColor", character.SkinColor);
				cmd.Set("level", character.Level);
				cmd.Set("zone", character.MapId);
				cmd.Set("x", character.Position.X);
				cmd.Set("y", character.Position.Y);
				cmd.Set("z", character.Position.Z);
				cmd.Set("exp", character.Exp);
				cmd.Set("maxExp", character.MaxExp);
				cmd.Set("totalExp", character.TotalExp);
				cmd.Set("equipVisibility", character.VisibleEquip);
				cmd.Set("stamina", character.Properties.Stamina);
				cmd.Set("silver", character.Inventory.CountItem(ItemId.Silver));

				cmd.Execute();
			}

			this.SaveCharacterItems(character);
			this.SaveStorage(character.PersonalStorage, "storage_personal", "characterId", character.DbId);
			this.SaveStorage(character.TeamStorage, "storage_team", "accountId", character.Connection.Account.Id);
			this.SaveVariables(character.Variables.Perm, "vars_characters", "characterId", character.DbId);
			this.SaveSessionObjects(character);
			this.SaveCollections(character);
			this.SaveProperties("character_properties", "characterId", character.DbId, character.Properties);
			this.SaveProperties("character_etc_properties", "characterId", character.DbId, character.Etc.Properties);
			this.SaveJobs(character);
			this.SaveSkills(character);
			this.SaveAbilities(character);
			this.SaveBuffs(character);
			this.SaveCooldowns(character);
			this.SaveQuests(character);
		}

		/// <summary>
		/// Saves character's skills.
		/// </summary>
		/// <param name="character"></param>
		private void SaveSkills(Character character)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new MySqlCommand("DELETE FROM `skills` WHERE `characterId` = @characterId", conn, trans))
				{
					cmd.Parameters.AddWithValue("@characterId", character.DbId);
					cmd.ExecuteNonQuery();
				}

				var skills = character.Skills.GetList();
				foreach (var skill in skills)
				{
					using (var cmd = new InsertCommand("INSERT INTO `skills` {0}", conn, trans))
					{
						cmd.Set("characterId", character.DbId);
						cmd.Set("id", skill.Id);
						cmd.Set("level", skill.Level);
						cmd.Execute();
					}

					// Properties?
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Saves character's abilities.
		/// </summary>
		/// <param name="character"></param>
		private void SaveAbilities(Character character)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new MySqlCommand("DELETE FROM `abilities` WHERE `characterId` = @characterId", conn, trans))
				{
					cmd.Parameters.AddWithValue("@characterId", character.DbId);
					cmd.ExecuteNonQuery();
				}

				var abilities = character.Abilities.GetList();
				foreach (var ability in abilities)
				{
					using (var cmd = new InsertCommand("INSERT INTO `abilities` {0}", conn, trans))
					{
						cmd.Set("characterId", character.DbId);
						cmd.Set("id", ability.Id);
						cmd.Set("level", ability.Level);
						cmd.Set("active", ability.Active);

						cmd.Execute();
					}

					// Properties?
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Saves character's jobs to the database.
		/// </summary>
		/// <param name="character"></param>
		private void SaveJobs(Character character)
		{
			var jobs = character.Jobs.GetList();

			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new MySqlCommand("DELETE FROM `jobs` WHERE `characterId` = @characterId", conn, trans))
				{
					cmd.Parameters.AddWithValue("@characterId", character.DbId);
					cmd.ExecuteNonQuery();
				}

				foreach (var job in jobs)
				{
					using (var cmd = new InsertCommand("INSERT INTO `jobs` {0}", conn, trans))
					{
						cmd.Set("characterId", character.DbId);
						cmd.Set("jobId", job.Id);
						cmd.Set("circle", job.Circle);
						cmd.Set("skillPoints", job.SkillPoints);
						cmd.Set("totalExp", job.TotalExp);
						cmd.Set("selectionDate", job.SelectionDate);

						cmd.Execute();
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Load character's items.
		/// </summary>
		/// <param name="characterId"></param>
		/// <returns></returns>
		private void LoadCharacterItems(Character character)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT `i`.*, `inv`.`sort`, `inv`.`equipSlot` FROM `inventory` AS `inv` INNER JOIN `items` AS `i` ON `inv`.`itemId` = `i`.`itemUniqueId` WHERE `characterId` = @characterId ORDER BY `sort` ASC", conn))
			{
				mc.Parameters.AddWithValue("@characterId", character.DbId);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var itemId = reader.GetInt32("itemId");
						var amount = reader.GetInt32("amount");
						var equipSlot = (EquipSlot)reader.GetByte("equipSlot");

						// Check item, in case its data was removed
						if (!ZoneServer.Instance.Data.ItemDb.Contains(itemId))
						{
							Log.Warning("ZoneDb.LoadCharacterItems: Item '{0}' not found, removing it from inventory.", itemId);
							continue;
						}

						var item = new Item(itemId, amount);

						if (!Enum.IsDefined(typeof(EquipSlot), equipSlot))
							character.Inventory.AddSilent(item);
						else
							character.Inventory.SetEquipSilent(equipSlot, item);
					}
				}
			}
		}

		/// <summary>
		/// Returns items for given character.
		/// </summary>
		/// <param name="characterId"></param>
		/// <returns></returns>
		public void SaveCharacterItems(Character character)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var mc = new MySqlCommand("DELETE FROM `inventory` WHERE `characterId` = @characterId", conn, trans))
				{
					mc.Parameters.AddWithValue("@characterId", character.DbId);
					mc.ExecuteNonQuery();
				}

				var i = 0;
				foreach (var item in character.Inventory.GetItems().OrderBy(a => a.Key))
				{
					var newId = 0L;

					// Save the actual items into the items table and the
					// inventory-exclusive values into the inventory table,
					// while linking to the items.
					// TODO: Add generic item load and save methods, for
					//   other item collections to use, such as warehouse.

					using (var cmd = new InsertCommand("INSERT INTO `items` {0}", conn, trans))
					{
						cmd.Set("itemId", item.Value.Id);
						cmd.Set("amount", item.Value.Amount);

						cmd.Execute();

						newId = cmd.LastId;
					}

					using (var cmd = new InsertCommand("INSERT INTO `inventory` {0}", conn, trans))
					{
						cmd.Set("characterId", character.DbId);
						cmd.Set("itemId", newId);
						cmd.Set("sort", i++);
						cmd.Set("equipSlot", 0x7F);

						cmd.Execute();
					}
				}

				// Save only non-dummy equip to the database, and make sure
				// that dummy equip that was loaded into the character as a
				// normal item wrongfully isn't saved again.
				foreach (var item in character.Inventory.GetEquip().Where(a => a.Value is not DummyEquipItem && !InventoryDefaults.EquipItems.Contains(a.Value.Id)))
				{
					var newId = 0L;

					using (var cmd = new InsertCommand("INSERT INTO `items` {0}", conn, trans))
					{
						cmd.Set("itemId", item.Value.Id);
						cmd.Set("amount", item.Value.Amount);

						cmd.Execute();

						newId = cmd.LastId;
					}

					using (var cmd = new InsertCommand("INSERT INTO `inventory` {0}", conn, trans))
					{
						cmd.Set("characterId", character.DbId);
						cmd.Set("itemId", newId);
						cmd.Set("sort", 0);
						cmd.Set("equipSlot", (byte)item.Key);

						cmd.Execute();
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Load storage items into given storage.
		/// </summary>
		/// <param name="storage"></param>
		/// <param name="tableName"></param>
		/// <param name="idFieldName"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		internal void LoadStorage(Storage storage, string tableName, string idFieldName, long id)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand(
				"SELECT `i`.*, `stg`.`itemId`, `stg`.`position` FROM `" + tableName + "` AS `stg` " +
				"INNER JOIN `items` AS `i` ON `stg`.`itemId` = `i`.`itemUniqueId` " +
				"WHERE `" + idFieldName + "` = @id"
			, conn))
			{
				mc.Parameters.AddWithValue("@id", id);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var itemId = reader.GetInt32("itemId");
						var amount = reader.GetInt32("amount");
						var position = reader.GetInt32("position");

						// Check item, in case its data was removed
						if (!ZoneServer.Instance.Data.ItemDb.Contains(itemId))
						{
							Log.Warning("ZoneDb.LoadStorage: Item '{0}' not found, removing it from storage.", itemId);
							continue;
						}

						var item = new Item(itemId, amount);

						storage.AddAtPosition(item, position, out var addedAmount);
					}
				}
			}
		}

		/// <summary>
		/// Saves storage to the given table.
		/// </summary>
		/// <param name="storage"></param>
		/// <param name="tableName"></param>
		/// <param name="idFieldName"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		public void SaveStorage(Storage storage, string tableName, string idFieldName, long id)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var mc = new MySqlCommand("DELETE FROM `" + tableName + "` WHERE `" + idFieldName + "` = @id", conn, trans))
				{
					mc.Parameters.AddWithValue("@id", id);
					mc.ExecuteNonQuery();
				}

				foreach (var item in storage.GetItems())
				{
					var newId = 0L;

					using (var cmd = new InsertCommand("INSERT INTO `items` {0}", conn, trans))
					{
						cmd.Set("itemId", item.Value.Id);
						cmd.Set("amount", item.Value.Amount);

						cmd.Execute();

						newId = cmd.LastId;
					}

					using (var cmd = new InsertCommand("INSERT INTO `" + tableName + "` {0}", conn, trans))
					{
						cmd.Set(idFieldName, id);
						cmd.Set("itemId", newId);
						cmd.Set("position", item.Key);

						cmd.Execute();
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Loads chat macros from the database.
		/// </summary>
		/// <param name="account"></param>
		private void LoadChatMacros(Account account)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `chatmacros` WHERE `accountId` = @accountId ORDER BY `index` DESC", conn))
			{
				mc.Parameters.AddWithValue("@accountId", account.Id);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var index = reader.GetInt32("index");
						var message = reader.GetString("message");
						var pose = reader.GetInt32("pose");

						var macro = new ChatMacro(index, message, pose);
						account.AddChatMacro(macro);
					}
				}
			}
		}

		/// <summary>
		/// Persists the account's chat macros to the database.
		/// </summary>
		/// <param name="account"></param>
		private void SaveChatMacros(Account account)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var mc = new MySqlCommand("DELETE FROM `chatmacros` WHERE `accountId` = @accountId", conn, trans))
				{
					mc.Parameters.AddWithValue("@accountId", account.Id);
					mc.ExecuteNonQuery();
				}

				foreach (var macro in account.GetChatMacros().OrderBy(x => x.Index))
				{
					using (var cmd = new InsertCommand("INSERT INTO `chatmacros` {0}", conn, trans))
					{
						cmd.Set("accountId", account.Id);
						cmd.Set("index", macro.Index);
						cmd.Set("message", macro.Message);
						cmd.Set("pose", macro.Pose);

						cmd.Execute();
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Loads revealed maps for the account.
		/// </summary>
		/// <param name="account"></param>
		private void LoadRevealedMaps(Account account)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `revealedmaps` WHERE `accountId` = @accountId", conn))
			{
				mc.Parameters.AddWithValue("@accountId", account.Id);

				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var map = reader.GetInt32("map");
						var explored = (byte[])reader["explored"];
						var percentage = reader.GetFloat("percentage");

						var revealedMap = new RevealedMap(map, explored, percentage);
						account.AddRevealedMap(revealedMap);
					}
				}
			}
		}

		/// <summary>
		/// Persists the account's revealed maps to the database.
		/// </summary>
		/// <param name="account"></param>
		private void SaveRevealedMaps(Account account)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var mc = new MySqlCommand("DELETE FROM `revealedmaps` WHERE `accountId` = @accountId", conn, trans))
				{
					mc.Parameters.AddWithValue("@accountId", account.Id);
					mc.ExecuteNonQuery();
				}

				foreach (var revealedMap in account.GetRevealedMaps())
				{
					using (var cmd = new InsertCommand("INSERT INTO `revealedmaps` {0}", conn, trans))
					{
						cmd.Set("accountId", account.Id);
						cmd.Set("map", revealedMap.MapId);
						cmd.Set("explored", revealedMap.Explored);
						cmd.Set("percentage", revealedMap.Percentage);

						cmd.Execute();
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Saves character's buffs.
		/// </summary>
		/// <param name="character"></param>
		private void SaveBuffs(Character character)
		{
			var buffs = new Dictionary<long, Buff>();

			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new MySqlCommand("DELETE FROM `buffs` WHERE `characterId` = @characterId", conn, trans))
				{
					cmd.Parameters.AddWithValue("@characterId", character.DbId);
					cmd.ExecuteNonQuery();
				}

				foreach (var buff in character.Buffs.GetList())
				{
					if (!buff.Data.Save)
						continue;

					var lastId = 0L;

					using (var cmd = new InsertCommand("INSERT INTO `buffs` {0}", conn, trans))
					{
						cmd.Set("characterId", character.DbId);
						cmd.Set("classId", buff.Id);
						cmd.Set("numArg1", buff.NumArg1);
						cmd.Set("numArg2", buff.NumArg2);
						cmd.Set("duration", buff.Duration);
						cmd.Set("runTime", buff.RunTime);
						cmd.Set("skillId", (int)buff.SkillId);
						cmd.Set("overbuffCount", buff.OverbuffCounter);

						cmd.Execute();
						lastId = cmd.LastId;
					}

					this.SaveVariables(conn, trans, buff.Vars, "vars_buffs", "buffId", lastId);
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Loads buffs for the character.
		/// </summary>
		/// <param name="character"></param>
		private void LoadBuffs(Character character)
		{
			var buffs = new Dictionary<long, Buff>();

			using (var conn = this.GetConnection())
			{
				using (var cmd = new MySqlCommand("SELECT * FROM `buffs` WHERE `characterId` = @characterId", conn))
				{
					cmd.Parameters.AddWithValue("@characterId", character.DbId);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var dbId = reader.GetInt64("buffId");
							var classId = (BuffId)reader.GetInt32("classId");
							var numArg1 = reader.GetInt32("numArg1");
							var numArg2 = reader.GetInt32("numArg2");
							var duration = reader.GetTimeSpan("duration");
							var runTime = reader.GetTimeSpan("runTime");
							var skillId = (SkillId)reader.GetInt32("skillId");
							var overbuffCount = reader.GetInt32("overbuffCount");

							var buff = new Buff(classId, numArg1, numArg2, duration, runTime, character, character, skillId);
							buff.OverbuffCounter = overbuffCount;

							buffs.Add(dbId, buff);
						}
					}
				}

				foreach (var buff in buffs)
				{
					this.LoadVars(conn, buff.Value.Vars, "vars_buffs", "buffId", buff.Key);
					character.Buffs.Restore(buff.Value);
				}
			}
		}

		/// <summary>
		/// Saves character's cooldowns.
		/// </summary>
		/// <param name="character"></param>
		private void SaveCooldowns(Character character)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new MySqlCommand("DELETE FROM `cooldowns` WHERE `characterId` = @characterId", conn, trans))
				{
					cmd.Parameters.AddWithValue("@characterId", character.DbId);
					cmd.ExecuteNonQuery();
				}

				foreach (var cooldown in character.Components.Get<CooldownComponent>().GetAll())
				{
					using (var cmd = new InsertCommand("INSERT INTO `cooldowns` {0}", conn, trans))
					{
						cmd.Set("characterId", character.DbId);
						cmd.Set("classId", cooldown.Id);
						cmd.Set("remaining", cooldown.Remaining);
						cmd.Set("duration", cooldown.Duration);
						cmd.Set("startTime", cooldown.StartTime);

						cmd.Execute();
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Loads cooldowns for the character.
		/// </summary>
		/// <param name="character"></param>
		private void LoadCooldowns(Character character)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new MySqlCommand("SELECT * FROM `cooldowns` WHERE `characterId` = @characterId", conn))
			{
				cmd.Parameters.AddWithValue("@characterId", character.DbId);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						// We load and save the remaining duration because
						// the game has the capability to freeze cooldowns
						// while logged out. That's not currently used by
						// any cooldowns, but this way we're prepared.

						var classId = (CooldownId)reader.GetInt32("classId");
						var remaining = reader.GetTimeSpan("remaining");
						var duration = reader.GetTimeSpan("duration");
						var startTime = reader.GetDateTimeSafe("startTime");

						var endTime = startTime + duration;
						var updatedRemaining = Math2.Max(TimeSpan.Zero, endTime - DateTime.Now);

						if (updatedRemaining == TimeSpan.Zero)
							continue;

						var cooldown = new Cooldown(classId, updatedRemaining, duration, startTime);
						character.Components.Get<CooldownComponent>().Restore(cooldown);
					}
				}
			}
		}

		/// <summary>
		/// Saves the character's quests to the database.
		/// </summary>
		/// <param name="character"></param>
		private void SaveQuests(Character character)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				// Delete only the quests that we successfully loaded
				// and skip the ones that weren't currently available.
				var retainIds = character.Quests.GetDisabledQuests();
				var retainIdStr = string.Join(",", retainIds);

				using (var cmd = new MySqlCommand("DELETE FROM `quests` WHERE `characterId` = @characterId AND `questId` NOT IN (@retain)", conn, trans))
				{
					cmd.AddParameter("@characterId", character.DbId);
					cmd.AddParameter("@retain", retainIdStr);

					cmd.ExecuteNonQuery();
				}

				foreach (var quest in character.Quests.GetList())
				{
					var questDbId = 0L;

					using (var cmd = new InsertCommand("INSERT INTO `quests` {0}", conn, trans))
					{
						cmd.Set("characterId", character.DbId);
						cmd.Set("classId", quest.Data.Id.Value);
						cmd.Set("status", (int)quest.Status);
						cmd.Set("startTime", quest.StartTime);
						cmd.Set("completeTime", quest.CompleteTime);
						cmd.Set("tracked", quest.Tracked);

						cmd.Execute();

						questDbId = cmd.LastId;
					}

					foreach (var progress in quest.Progresses)
					{
						using (var cmd = new InsertCommand("INSERT INTO `quests_progress` {0}", conn, trans))
						{
							cmd.Set("questId", questDbId);
							cmd.Set("characterId", character.DbId);
							cmd.Set("ident", progress.Objective.Ident);
							cmd.Set("count", progress.Count);
							cmd.Set("done", progress.Done);
							cmd.Set("unlocked", progress.Unlocked);

							cmd.Execute();
						}
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Loads the character's quests from the database.
		/// </summary>
		/// <param name="character"></param>
		private void LoadQuests(Character character)
		{
			using (var conn = this.GetConnection())
			{
				var loadedQuests = new Dictionary<long, Quest>();

				using (var cmd = new MySqlCommand("SELECT * FROM `quests` WHERE `characterId` = @characterId", conn))
				{
					cmd.AddParameter("@characterId", character.DbId);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var questDbId = reader.GetInt64("questId");
							var questClassId = reader.GetInt64("classId");
							var status = (QuestStatus)reader.GetInt32("status");
							var startTime = reader.GetDateTimeSafe("startTime");
							var completeTime = reader.GetDateTimeSafe("completeTime");
							var tracked = reader.GetBoolean("tracked");

							// Temporary upgrade for our test quest ids. Remove at
							// some point, when we're also removing support for raw
							// quest ids.
							var questId = questClassId switch
							{
								1000001 => new QuestId("Melia.Test", 1),
								1000002 => new QuestId("Melia.Test", 2),
								_ => new QuestId(questClassId)
							};

							// If the quest does not (currently) exist, make
							// a note of it, so we can skip its deletion on
							// saving later on.
							if (!QuestScript.Exists(questId))
							{
								character.Quests.AddDisabledQuest(questDbId);
								continue;
							}

							var quest = Quest.Create(questId);
							quest.Status = status;
							quest.StartTime = startTime;
							quest.CompleteTime = completeTime;
							quest.Tracked = tracked;

							character.Quests.AddSilent(quest);
							loadedQuests.Add(questDbId, quest);
						}
					}
				}

				using (var cmd = new MySqlCommand("SELECT * FROM `quests_progress` WHERE `characterId` = @characterId", conn))
				{
					cmd.AddParameter("@characterId", character.DbId);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var questDbId = reader.GetInt64("questId");
							var ident = reader.GetStringSafe("ident");
							var count = reader.GetInt32("count");
							var done = reader.GetBoolean("done");
							var unlocked = reader.GetBoolean("unlocked");

							if (character.Quests.IsDisabled(questDbId))
								continue;

							if (!loadedQuests.TryGetValue(questDbId, out var quest))
							{
								Log.Warning("ZoneDb.LoadQuests: Progress '{0}' loaded for a quest that doesn't exist.", ident);
								continue;
							}

							if (!quest.TryGetProgress(ident, out var progress))
							{
								Log.Warning("ZoneDb.LoadQuests: Progress '{0}' loaded for quest '{1}', but the objective doesn't exist.", ident, quest.Data.Id);
								continue;
							}

							progress.Count = count;
							progress.Done = done;
							progress.Unlocked = unlocked;
						}
					}
				}
			}
		}

		/// <summary>
		/// Saves the characters's collections to the database.
		/// </summary>
		/// <param name="character"></param>
		private void SaveCollections(Character character)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new MySqlCommand("DELETE FROM `collections` WHERE `accountId` = @accountId", conn, trans))
				{
					cmd.AddParameter("@accountId", character.AccountId);
					cmd.ExecuteNonQuery();
				}

				using (var cmd = new MySqlCommand("DELETE FROM `collection_items` WHERE `accountId` = @accountId", conn, trans))
				{
					cmd.AddParameter("@accountId", character.AccountId);
					cmd.ExecuteNonQuery();
				}

				foreach (var collection in character.Collections.GetList())
				{
					using (var cmd = new InsertCommand("INSERT INTO `collections` {0}", conn, trans))
					{
						cmd.Set("accountId", character.AccountId);
						cmd.Set("collectionId", collection.Id);
						cmd.Set("isComplete", collection.IsComplete);
						cmd.Set("timesRedeemed", collection.RedeemCount);

						cmd.Execute();
					}

					foreach (var itemId in collection.GetRegisteredItems())
					{
						using (var cmd = new InsertCommand("INSERT INTO `collection_items` {0}", conn, trans))
						{
							cmd.Set("accountId", character.AccountId);
							cmd.Set("collectionId", collection.Id);
							cmd.Set("itemId", itemId);

							cmd.Execute();
						}
					}
				}

				trans.Commit();
			}
		}

		/// <summary>
		/// Loads the character's collections from the database.
		/// This must run after properties because it modifies them.
		/// </summary>
		/// <param name="character"></param>
		private void LoadCollections(Character character)
		{
			using (var conn = this.GetConnection())
			{
				using (var cmd = new MySqlCommand("SELECT `collectionid`, `timesRedeemed` FROM `collections` WHERE `accountid` = @accountId ", conn))
				{
					cmd.AddParameter("@accountId", character.AccountId);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var collectionId = reader.GetInt32("collectionId");
							var redeemCount = reader.GetInt32("timesRedeemed");

							character.Collections.InitAdd(collectionId, redeemCount);
						}
					}
				}

				using (var cmd = new MySqlCommand("SELECT `collectionid`, `itemid` FROM `collection_items` WHERE `accountid` = @accountId ", conn))
				{
					cmd.AddParameter("@accountId", character.AccountId);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var collectionId = reader.GetInt32("collectionId");
							var itemId = reader.GetInt32("itemId");

							character.Collections.InitRegisterItem(collectionId, itemId);
						}
					}
				}

				character.Properties.InvalidateAll();
			}
		}
	}
}
