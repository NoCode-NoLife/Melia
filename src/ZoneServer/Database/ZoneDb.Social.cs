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
						else
						{
							// Party no longer exists in database - clear stale reference
							character.PartyId = 0;
						}
					}
				}
			}
			else
			{
				if (party.TryGetMember(character.ObjectId, out var member))
					member.IsOnline = true;
			}
		}

		private void LoadPartyMembers(Character loadCharacter, Party party)
		{
			using (var conn = this.GetConnection())
			{
				var offlineMembers = new System.Collections.Generic.List<PartyMember>();

				using (var mc = new MySqlCommand("SELECT * FROM `characters` WHERE `partyId` = @partyId", conn))
				{
					mc.Parameters.AddWithValue("@partyId", party.DbId);
					using (var reader = mc.ExecuteReader())
					{
						while (reader.Read())
						{
							var character = ZoneServer.Instance.World.GetCharacter(c => c.DbId == reader.GetInt64("characterId"));
							if (character == null)
							{
								var member = new PartyMember
								{
									DbId = reader.GetInt64("characterId"),
									AccountId = reader.GetInt64("accountId"),
									Name = reader.GetString("name"),
									TeamName = reader.GetString("teamName"),
									VisualJobId = (JobId)reader.GetInt16("job"),
									Gender = (Gender)reader.GetByte("gender"),
									Hair = reader.GetInt32("hair"),
									MapId = reader.GetInt32("zone"),
									Level = reader.GetInt32("level"),
								};
								var x = reader.GetFloat("x");
								var y = reader.GetFloat("y");
								var z = reader.GetFloat("z");
								member.Position = new Position(x, y, z);
								member.IsOnline = loadCharacter.DbId == member.DbId;
								offlineMembers.Add(member);
							}
							else
								party.AddMember(character, true);
						}
					}
				}

				// Load jobs for offline members
				foreach (var member in offlineMembers)
				{
					using (var mc = new MySqlCommand("SELECT `jobId` FROM `jobs` WHERE `characterId` = @characterId ORDER BY `selectionDate` ASC", conn))
					{
						mc.Parameters.AddWithValue("@characterId", member.DbId);
						using (var reader = mc.ExecuteReader())
						{
							var i = 0;
							while (reader.Read())
							{
								var jobId = (JobId)reader.GetInt32("jobId");
								member.VisualJobId = jobId;
								switch (i)
								{
									case 0:
										member.FirstJobId = jobId;
										break;
									case 1:
										member.SecondJobId = jobId;
										break;
									case 2:
										member.ThirdJobId = jobId;
										break;
									case 3:
										member.FourthJobId = jobId;
										break;
								}
								i++;
							}
						}
					}
					party.AddMember(member);
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
