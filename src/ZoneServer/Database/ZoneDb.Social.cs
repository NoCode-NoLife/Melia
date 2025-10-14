using System;
using Melia.Shared.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.World;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Groups;
using MySqlConnector;
using Yggdrasil.Logging;

namespace Melia.Zone.Database
{
	/// <summary>
	/// Contains methods related to Social (Party/Guild) persistence.
	/// </summary>
	public partial class ZoneDb
	{
		#region Party Methods
		public void CreateParty(Party party)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				try
				{
					using (var cmd = new InsertCommand("INSERT INTO `party` {0}", conn, trans))
					{
						party.DateCreated = DateTime.Now;
						cmd.Set("name", party.Name);
						cmd.Set("leaderId", party.LeaderDbId);
						cmd.Set("note", party.Note);
						cmd.Set("questSharing", (int)party.QuestSharing);
						cmd.Set("expDistribution", (int)party.ExpDistribution);
						cmd.Set("itemDistribution", (int)party.ItemDistribution);
						cmd.Set("dateCreated", party.DateCreated);
						cmd.Execute();
						party.DbId = cmd.LastId;
					}

					using (var cmdUpdateLeader = new UpdateCommand("UPDATE `characters` SET {0} WHERE `characterId` = @characterId", conn, trans))
					{
						cmdUpdateLeader.AddParameter("@characterId", party.LeaderDbId);
						cmdUpdateLeader.Set("partyId", party.DbId);
						if (cmdUpdateLeader.Execute() == 0)
						{
							Log.Error($"CreateParty: Failed to update partyId for leader character {party.LeaderDbId}.");
							throw new InvalidOperationException($"Failed to update leader character {party.LeaderDbId}");
						}
					}
					trans.Commit();
				}
				catch (Exception ex)
				{
					Log.Error($"CreateParty: Transaction failed (Leader: {party.LeaderDbId}): {ex}");
					try { trans.Rollback(); } catch (Exception rbEx) { Log.Error($"CreateParty: Rollback failed: {rbEx}"); }
					throw;
				}
			}
		}

		public void LoadParty(Character character)
		{
			if (character.PartyId <= 0)
				return;
			var party = ZoneServer.Instance.World.GetParty(character.PartyId);
			if (party == null)
			{
				using (var conn = this.GetConnection())
				using (var mc = new MySqlCommand("SELECT * FROM `party` WHERE `partyId` = @partyId", conn))
				{
					mc.Parameters.AddWithValue("@partyId", character.PartyId);
					using (var reader = mc.ExecuteReader())
					{
						if (reader.Read())
						{
							party = new Party(reader.GetInt64("partyId"), reader.GetInt64("leaderId"), reader.GetString("name"), reader.GetDateTime("dateCreated"), reader.GetString("note"),
								(PartyItemDistribution)reader.GetByte("itemDistribution"), (PartyExpDistribution)reader.GetByte("expDistribution"), (PartyQuestSharing)reader.GetByte("questSharing"));
							this.LoadPartyMembers(character, party);
							ZoneServer.Instance.World.Parties.Add(party);
						}
					}
				}
			}
		}

		private void LoadPartyMembers(Character loadCharacter, Party party)
		{
			using (var conn = this.GetConnection())
			using (var mc = new MySqlCommand("SELECT * FROM `characters` WHERE `partyId` = @partyId", conn))
			{
				mc.Parameters.AddWithValue("@partyId", party.DbId);
				using (var reader = mc.ExecuteReader())
				{
					while (reader.Read())
					{
						var characterDbId = reader.GetInt64("characterId");

						// Check if this is the character that's logging in
						if (characterDbId == loadCharacter.DbId)
						{
							// Use the actual character object that's logging in
							// Can't use AddMember(Character) because Connection is null
							// Create a PartyMember instead
							var member = new PartyMember
							{
								DbId = characterDbId,
								AccountId = reader.GetInt64("accountId"),
								Name = reader.GetString("name"),
								TeamName = reader.GetString("teamName"),
								VisualJobId = (JobId)reader.GetInt16("job"),
								Gender = (Gender)reader.GetByte("gender"),
								Hair = reader.GetInt32("hair"),
								MapId = reader.GetInt32("zone"),
								Level = reader.GetInt32("level"),
								Position = new Position(reader.GetFloat("x"), reader.GetFloat("y"), reader.GetFloat("z")),
								IsOnline = loadCharacter.DbId == characterDbId
							};
							party.AddMember(member);
						}
						else
						{
							// Try to find the character in the world (for other online members)
							var character = ZoneServer.Instance.World.GetCharacter(c => c.DbId == characterDbId);
							if (character == null)
							{
								// Character is offline, create a PartyMember placeholder
								var member = new PartyMember
								{
									DbId = characterDbId,
									AccountId = reader.GetInt64("accountId"),
									Name = reader.GetString("name"),
									TeamName = reader.GetString("teamName"),
									VisualJobId = (JobId)reader.GetInt16("job"),
									Gender = (Gender)reader.GetByte("gender"),
									Hair = reader.GetInt32("hair"),
									MapId = reader.GetInt32("zone"),
									Level = reader.GetInt32("level"),
									Position = new Position(reader.GetFloat("x"), reader.GetFloat("y"), reader.GetFloat("z")),
									IsOnline = loadCharacter.DbId == reader.GetInt64("characterId")
								};
								party.AddMember(member);
							}
							else
							{
								// Character is online, use the actual character object
								party.AddMember(character, true);
							}
						}
					}
				}
			}
		}

		public void SaveParty(Character character)
		{
			var party = character.Connection.Party;
			if (party == null || !party.IsLeader(character.ObjectId))
				return;
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new UpdateCommand("UPDATE `party` SET {0} WHERE `partyId` = @partyId", conn, trans))
				{
					cmd.AddParameter("@partyId", party.DbId);
					cmd.Set("name", party.Name);
					cmd.Set("leaderId", party.LeaderDbId);
					cmd.Set("note", party.Note);
					cmd.Set("questSharing", (int)party.QuestSharing);
					cmd.Set("expDistribution", (int)party.ExpDistribution);
					cmd.Set("itemDistribution", (int)party.ItemDistribution);
					cmd.Execute();
				}
				trans.Commit();
			}
		}

		public void DeleteParty(Party party)
		{
			using (var conn = this.GetConnection())
			using (var trans = conn.BeginTransaction())
			{
				using (var cmd = new MySqlCommand("DELETE FROM `party` WHERE `partyId` = @partyId", conn, trans))
				{
					cmd.Parameters.AddWithValue("@partyId", party.DbId);
					cmd.ExecuteNonQuery();
				}
				foreach (var member in party.GetMembers())
				{
					using (var cmd = new UpdateCommand("UPDATE `characters` SET {0} WHERE `characterId` = @characterId", conn, trans))
					{
						cmd.AddParameter("@characterId", member.DbId);
						cmd.Set("partyId", 0);
						cmd.Execute();
					}
				}
				trans.Commit();
			}
		}

		public void UpdatePartyId(long dbId, long partyId = 0)
		{
			using (var conn = this.GetConnection())
			using (var cmd = new UpdateCommand("UPDATE `characters` SET {0} WHERE `characterId` = @characterId", conn))
			{
				cmd.AddParameter("@characterId", dbId);
				cmd.Set("partyId", partyId);
				cmd.Execute();
			}
		}
		#endregion
	}
}
