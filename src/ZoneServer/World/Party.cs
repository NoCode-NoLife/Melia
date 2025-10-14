using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Network;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Game.Const;
using Melia.Shared.Game.Properties;
using Melia.Shared.Util;
using Melia.Zone.Events.Arguments;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Groups;
using Yggdrasil.Extensions;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World
{
	public class Party : Group
	{
		/// <summary>
		/// The party's globally unique id.
		/// </summary>
		public override long ObjectId => this.DbId | ObjectIdRanges.Party;

		/// <summary>
		/// The party's leader unique id.
		/// </summary>
		public override long LeaderObjectId => this.LeaderDbId | ObjectIdRanges.Characters;

		/// <summary>
		/// The party's maximum size.
		/// </summary>
		public override int MaxMemberCount => GetDefaultMaxMemberCount();

		/// <summary>
		/// Party Item Distribution Setting
		/// </summary>
		public PartyItemDistribution ItemDistribution { get; set; }

		/// <summary>
		/// Party Exp Distribution Setting
		/// </summary>
		public PartyExpDistribution ExpDistribution { get; set; }

		/// <summary>
		/// Party Quest Sharing Setting
		/// </summary>
		public PartyQuestSharing QuestSharing { get; set; }

		/// <summary>
		/// Returns the party's property collection.
		/// </summary>
		public override Properties Properties { get; } = new Properties("Party");

		/// <summary>
		/// Returns the type of party
		/// </summary>
		public override GroupType Type => GroupType.Party;

		/// <summary>
		/// Index of the player who last received the item.
		/// Used in round robin item distribution.
		/// </summary>
		public int LastItemRecipientIndex { get; set; } = 0;

		/// <summary>
		/// Returns the party's member count.
		/// </summary>
		public int OnlineMemberCount
			=> ZoneServer.Instance.World.GetCharacters(c => c.PartyId == this.DbId).Length;

		/// <summary>
		/// Creates a new instance of Party.
		/// </summary>
		/// <param name="character"></param>
		public Party()
		{
			this.Name = "Party#" + Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 6).ToUpper();
			this.ItemDistribution = PartyItemDistribution.RoundRobin;
			this.ExpDistribution = PartyExpDistribution.IndividualExp;
			this.QuestSharing = PartyQuestSharing.Enabled;
			this.Note = "Let's Party!";

			this.Load();
		}

		/// <summary>
		/// Create's a new instance of a Party.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="note"></param>
		/// <param name="item"></param>
		/// <param name="exp"></param>
		/// <param name="quest"></param>
		public Party(long id, long leaderId, string name, DateTime dateCreated, string note, PartyItemDistribution item, PartyExpDistribution exp, PartyQuestSharing quest)
		{
			this.DbId = id;
			this.LeaderDbId = leaderId;
			this.Name = name;
			this.DateCreated = dateCreated;
			this.ItemDistribution = item;
			this.ExpDistribution = exp;
			this.QuestSharing = quest;
			this.Note = note;

			this.Load();
		}

		/// <summary>
		/// Initialize Properties
		/// </summary>
		private void Load()
		{
			// These properties aren't used anywhere yet, but might be?
			this.Properties.Create(new RFloatProperty(PropertyName.ItemRouting, () => (int)this.ItemDistribution));
			this.Properties.Create(new RStringProperty(PropertyName.Note, () => this.Note));
			this.Properties.Create(new RFloatProperty(PropertyName.ExpGainType, () => (int)this.ExpDistribution));
			this.Properties.Create(new RFloatProperty(PropertyName.IsQuestShare, () => (int)this.QuestSharing));
			this.Properties.Create(new RStringProperty(PropertyName.CreateTime, () => this.DateCreated.ToPropertyDateTimeString()));
		}

		/// <summary>
		/// How many party members we allow in parties by default
		/// </summary>
		/// <returns></returns>
		public static int GetDefaultMaxMemberCount()
		{
			return 5;
		}

		/// <summary>
		/// Add Member and Send to Party Packets Client
		/// ZC_PARTY_INFO, ZC_PARTY_LIST, ZC_PARTY_ENTER,
		/// ZC_ADDON_MSG, ZC_UPDATE_ALL_STATUS
		/// </summary>
		/// <param name="character"></param>
		/// <param name="silently"></param>
		public virtual void AddMember(Character character, bool silently = false)
		{
			var member = GroupMember.ToPartyMember(character);
			if (!this.AddMember(member))
				return;
			character.Connection.Party = this;
			character.PartyId = this.DbId;
			if (!silently)
			{
				Send.ZC_PARTY_INFO(character, this);
				Send.ZC_PARTY_LIST(this);
				Send.ZC_PARTY_ENTER(character, this);
				Send.ZC_ADDON_MSG(character, AddonMessage.PARTY_JOIN, 0, "None");
				Send.ZC_UPDATE_ALL_STATUS(character, 0);
				var members = character.Map.GetPartyMembers(character);
				foreach (var otherMember in members)
				{
					Send.ZC_CHANGE_RELATION(character.Connection, otherMember.Handle, RelationType.Friendly);
					Send.ZC_CHANGE_RELATION(otherMember.Connection, character.Handle, RelationType.Friendly);
				}
			}
		}

		/// <summary>
		/// Remove a party member and send ZC_PARTY_OUT to party members
		/// </summary>
		/// <param name="character"></param>
		public void RemoveMember(Character character)
		{
			if (this.TryGetMember(character.ObjectId, out var member))
			{
				if (this.IsLeader(character.ObjectId) && this.MemberCount >= 2)
				{
					var nextLeader = this.GetMembers().Find(m => m.ObjectId != character.ObjectId);
					if (nextLeader != null)
						this.ChangeLeader(nextLeader);
				}
				Send.ZC_PARTY_OUT(this, member);
				character.AddonMessage(AddonMessage.SUCCESS_UPDATE_PARTY_INFO, "None", 0);
				character.Connection.Party = null;
				character.PartyId = 0;
				this.RemovePartyMember(member);
			}
		}

		/// <summary>
		/// Remove a party member and send ZC_PARTY_OUT to party members
		/// </summary>
		/// <param name="member"></param>
		private void RemovePartyMember(IMember member)
		{
			this.RemoveMember(member);
			Send.ZC_PARTY_OUT(this, member);
			foreach (var otherMemberId in _members.Keys)
			{
				var character = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == otherMemberId);
				if (character == null)
					continue;
				if (character.MapId == member.MapId)
					Send.ZC_CHANGE_RELATION(character.Connection, member.Handle, RelationType.Neutral);
			}

			var leavingCharacter = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == member.ObjectId);
			ZoneServer.Instance.ServerEvents.PlayerLeftParty.Raise(new PlayerEventArgs(leavingCharacter));
			if (leavingCharacter != null)
			{
				leavingCharacter.PartyId = 0;
				leavingCharacter.Connection.Party = null;
				foreach (var otherMemberId in _members.Keys)
				{
					var character = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == otherMemberId);
					if (character == null)
						continue;
					if (character.MapId == member.MapId)
						Send.ZC_CHANGE_RELATION(leavingCharacter.Connection, character.Handle, RelationType.Neutral);
				}
				Send.ZC_PARTY_OUT(leavingCharacter, this);
				leavingCharacter.AddonMessage(AddonMessage.SUCCESS_UPDATE_PARTY_INFO, "None");
			}
			else
			{
				ZoneServer.Instance.Database.UpdatePartyId(member.DbId);
			}
		}

		/// <summary>
		/// Update Party Settings
		/// </summary>
		/// <param name="id"></param>
		/// <param name="value"></param>
		public void UpdateSetting(int id, string value)
		{
			if (PropertyTable.TryGetName("Party", id, out var propertyId))
			{
				switch (propertyId)
				{
					case PropertyName.ItemRouting:
						this.ItemDistribution = (PartyItemDistribution)int.Parse(value);
						break;
					case PropertyName.Note:
						this.Note = value;
						break;
					case PropertyName.ExpGainType:
						this.ExpDistribution = (PartyExpDistribution)int.Parse(value);
						break;
					case PropertyName.IsQuestShare:
						this.QuestSharing = (PartyQuestSharing)int.Parse(value);
						break;
				}
				Send.ZC_NORMAL.PartyPropertyUpdate(this, id, value);
			}
		}

		public void ChangeName(string name)
		{
			this.Name = name;
			Send.ZC_NORMAL.PartyNameChange(this);
		}

		public void ChangeLeader(Character character)
		{
			var nextLeader = this.GetMembers().Find(m => m.ObjectId == character.ObjectId);
			if (nextLeader != null)
				this.ChangeLeader(nextLeader);
		}

		private void ChangeLeader(IMember nextLeader)
		{
			this.LeaderDbId = nextLeader.DbId;
			Send.ZC_NORMAL.PartyLeaderChange(this, nextLeader.AccountObjectId);
		}

		/// <summary>
		/// Gets all party members in this party as list of characters.
		/// </summary>
		/// <returns></returns>
		public List<Character> GetPartyMembers()
		{
			var list = new List<Character>();
			foreach (var member in _members.Keys)
			{
				// TODO: Improve this
				list.Add(ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == member));
			}

			return list;
		}

		public override void Update(TimeSpan elapsed)
		{
			lock (_members)
			{
				if (_members.Count == 1)
					return;

				foreach (var member in _members.Values)
				{
					Send.ZC_NORMAL.PartyMemberData(member, this);
				}
				Send.ZC_PARTY_INST_INFO(this);
			}
		}

		/// <summary>
		/// Give Exp with Party Settings
		/// </summary>
		/// <param name="killer"></param>
		/// <param name="monster"></param>
		/// <param name="exp"></param>
		/// <param name="classExp"></param>
		public void GiveExp(Character killer, long exp, long classExp, Mob monster)
		{
			// If individual exp distribution, no party bonuses or penalties apply
			if (this.ExpDistribution == PartyExpDistribution.IndividualExp)
			{
				killer.GiveExp(exp, classExp, monster);
				return;
			}

			// Get all valid party members in the map
			var partyCharacters = killer.Map.GetCharacters(a =>
				a.Connection.Party != null &&
				a.Connection.Party.ObjectId == this.ObjectId &&
				!a.IsDead
			);

			// If no valid party members found
			if (partyCharacters.Length == 0)
				return;

			// Calculate party bonus exp
			(exp, classExp) = this.GetPartyBonusExp(exp, classExp);

			// Find highest level in party for penalty calculations
			var highestLevel = partyCharacters.Max(c => c.Level);

			switch (this.ExpDistribution)
			{
				case PartyExpDistribution.EqualExp:
				{
					if (exp > 0)
						exp = Math.Max(0, exp / partyCharacters.Length);
					if (classExp > 0)
						classExp = Math.Max(0, classExp / partyCharacters.Length);

					foreach (var partyCharacter in partyCharacters)
					{
						var (penalizedExp, penalizedClassExp) = this.ApplyLevelPenalty(
							exp,
							classExp,
							partyCharacter.Level,
							highestLevel
						);

						partyCharacter?.GiveExp(
							penalizedExp,
							penalizedClassExp,
							(partyCharacter.ObjectId == killer.ObjectId) ? monster : null
						);
					}
					break;
				}
				case PartyExpDistribution.ByLevel:
				{
					var averageLevel = partyCharacters.Average(a => a.Level);

					foreach (var partyCharacter in partyCharacters)
					{
						var levelModifiedExp = exp;
						var levelModifiedClassExp = classExp;

						if (exp > 0)
							levelModifiedExp = (long)Math.Max(0, exp * (averageLevel / partyCharacter.Level));
						if (classExp > 0)
							levelModifiedClassExp = (long)Math.Max(0, classExp * (averageLevel / partyCharacter.Level));

						var (penalizedExp, penalizedClassExp) = this.ApplyLevelPenalty(
							levelModifiedExp,
							levelModifiedClassExp,
							partyCharacter.Level,
							highestLevel
						);

						partyCharacter?.GiveExp(
							penalizedExp,
							penalizedClassExp,
							(partyCharacter.ObjectId == killer.ObjectId) ? monster : null
						);
					}
					break;
				}
			}
		}

		/// <summary>
		/// Applies level-based experience penalties based on the difference
		/// between a character's level and the highest level in the party.
		/// </summary>
		/// <param name="baseExp"></param>
		/// <param name="baseClassExp"></param>
		/// <param name="characterLevel"></param>
		/// <param name="highestLevel"></param>
		/// <returns></returns>
		private (long exp, long classExp) ApplyLevelPenalty(long baseExp, long baseClassExp, int characterLevel, int highestLevel)
		{
			var levelDifference = highestLevel - characterLevel;
			var penaltyMultiplier = 1.0f;

			if (levelDifference >= 20)
			{
				penaltyMultiplier = 0.0f; // -100% exp
			}
			else if (levelDifference >= 15)
			{
				penaltyMultiplier = 0.4f; // -60% exp
			}
			else if (levelDifference >= 10)
			{
				penaltyMultiplier = 0.7f; // -30% exp
			}

			return (
				(long)(baseExp * penaltyMultiplier),
				(long)(baseClassExp * penaltyMultiplier)
			);
		}


		/// <summary>
		/// Receives the default monster exp and returns the
		/// modified exp based on party configuration.
		/// </summary>
		/// <param name="baseExp"></param>
		/// <returns></returns>
		private (long, long) GetPartyBonusExp(long baseExp, long baseJobExp)
		{
			var bonusExpRatio = this.GetPartyExpModifier();
			baseExp = (long)Math.Floor(baseExp * bonusExpRatio);
			baseJobExp = (long)Math.Floor(baseJobExp * bonusExpRatio);

			return (baseExp, baseJobExp);
		}

		/// <summary>
		/// Returns the exp multiplier based on party member count.
		/// <remarks>
		/// Does not take into consideration party configuration.
		/// </remarks>
		/// </summary>
		/// <returns></returns>
		private float GetPartyExpModifier()
		{
			var onlineMemberCount = this.OnlineMemberCount;
			if (onlineMemberCount <= 1)
			{
				return 1f;
			}

			switch (onlineMemberCount)
			{
				case 2:
					return 1.2f;
				case 3:
					return 1.5f;
				case 4:
					return 1.8f;
				case 5:
					return 2.2f;
				case 6:
					return 2.5f;
				case 7:
					return 2.8f;
				case 8:
					return 3.0f;
				case 9:
					return 3.5f;
				default:
					return (onlineMemberCount - 9) * .5f + 3.5f;
			}
		}

		/// <summary>
		/// Set's a property and updates the client.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="propertyValue"></param>
		public void SetProperty(string propertyName, float propertyValue)
		{
			this.Properties.SetFloat(propertyName, propertyValue);
			Send.ZC_NORMAL.PartyPropertyUpdate(this, this.Properties.GetSelect(propertyName));
		}

		/// <summary>
		/// Set's a property and updates the client.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="propertyValue"></param>
		public void SetProperty(string propertyName, string propertyValue)
		{
			this.Properties.SetString(propertyName, propertyValue);
			Send.ZC_NORMAL.PartyPropertyUpdate(this, this.Properties.GetSelect(propertyName));
		}

		public void Expel(Character sender, string kickedPlayerTeamName)
		{
			if (sender.TeamName != kickedPlayerTeamName)
			{
				if (!this.IsLeader(sender))
					return;
			}
			lock (_members)
			{
				var member = _members.Values.FirstOrDefault(m => m.TeamName == kickedPlayerTeamName);
				if (member != null)
				{
					this.RemovePartyMember(member);
				}
			}
		}

		/// <summary>
		/// Returns the character in the party who should get an item given
		/// party item distribution settings.
		/// </summary>
		/// <param name="killer"></param>
		/// <returns>The character who should receive the item</returns>
		public bool TryGetItemRecipient(Character killer, out Character recipient)
		{
			recipient = killer;

			if (killer == null)
				return false;

			switch (this.ItemDistribution)
			{
				case PartyItemDistribution.Individual:
				{
					return true;
				}
				case PartyItemDistribution.RoundRobin:
				{
					var partyCharacters = killer.Map.GetCharacters(a =>
						a.Connection.Party != null &&
						a.Connection.Party.ObjectId == this.ObjectId &&
						!a.IsDead);

					if (partyCharacters != null && partyCharacters.Length > 0)
					{
						this.LastItemRecipientIndex %= partyCharacters.Length;
						recipient = partyCharacters[this.LastItemRecipientIndex];
						this.LastItemRecipientIndex++;
						return true;
					}
					else
					{
						return false;
					}
				}
				case PartyItemDistribution.Random:
				{
					// Get party members eligible to receive items.
					var partyCharacters = killer.Map.GetCharacters(a =>
						a.Connection.Party != null &&
						a.Connection.Party.ObjectId == this.ObjectId &&
						!a.IsDead);

					if (partyCharacters != null && partyCharacters.Length > 0)
					{
						recipient = partyCharacters.Random();
						return true;
					}
					else
					{
						return false;
					}
				}
				default:
					return false;
			}
		}
	}

	/// <summary>
	/// Party Exp Distribution Values
	/// </summary>
	public enum PartySetting
	{
		ItemDistribution = 2,
		Note = 3,
		ExpDistribution = 4,
		QuestSharing = 7,
	}

	/// <summary>
	/// Party Item Distribution Values
	/// </summary>
	public enum PartyItemDistribution
	{
		Individual = 0,
		RoundRobin = 1,
		Random = 2,
	}

	/// <summary>
	/// Party Exp Distribution Values
	/// </summary>
	public enum PartyExpDistribution
	{
		IndividualExp = 0,
		EqualExp = 1,
		ByLevel = 2,
	}

	/// <summary>
	/// Party Quest Sharing Values
	/// </summary>
	public enum PartyQuestSharing
	{
		Disabled = 0,
		Enabled = 1,
	}
}
