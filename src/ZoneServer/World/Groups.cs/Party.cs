using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Shared.Game.Properties;
using Melia.Shared.Network;
using Melia.Shared.ObjectProperties;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Items;
using Yggdrasil.Extensions;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Groups
{
	public class Party : IPropertyObject
	{
		/// <summary>
		/// List of party members
		/// </summary>
		private readonly Dictionary<long, PartyMember> _members = new Dictionary<long, PartyMember>();

		/// <summary>
		/// The party's unique id.
		/// </summary>
		public long DbId { get; set; }

		/// <summary>
		/// The party's globally unique id.
		/// </summary>
		public virtual long ObjectId => ObjectIdRanges.Party + this.DbId;

		/// <summary>
		/// The party leader's unique id.
		/// </summary>
		public long LeaderDbId { get; set; }

		/// <summary>
		/// The party leader's globally unique id.
		/// </summary>
		public long LeaderObjectId => ObjectIdRanges.Characters + this.LeaderDbId;

		/// <summary>
		/// The party's owner.
		/// </summary>
		public PartyMember Owner => this.GetMember(this.LeaderObjectId);

		/// <summary>
		/// Return a member if found, otherwise null.
		/// </summary>
		/// <param name="characterId"></param>
		/// <returns></returns>
		public PartyMember GetMember(long characterId)
		{
			lock (_members)
			{
				if (_members.TryGetValue(characterId, out var member))
					return member;
			}
			return null;
		}

		/// <summary>
		/// The party's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The party's creation date
		/// </summary>
		public DateTime DateCreated { get; set; }

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
		/// Party Note
		/// </summary>
		public string Note { get; set; }

		/// <summary>
		/// Returns the party's property collection.
		/// </summary>
		public Properties Properties { get; } = new Properties("Party");

		/// <summary>
		/// Returns the type of party
		/// </summary>
		public virtual PartyType Type => PartyType.Party;

		/// <summary>
		/// Index of the player who last received the item.
		/// Used in round robin item distribution.
		/// </summary>
		public int LastItemRecipientIndex { get; set; } = 0;

		/// <summary>
		/// Returns the party's member count.
		/// </summary>
		public int MemberCount
		{
			get
			{
				lock (_members)
					return this._members.Count;
			}
		}

		/// <summary>
		/// Creates a new instance of Party.
		/// </summary>
		/// <param name="character"></param>
		public Party()
		{
			this.Name = "Party#" + Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 6).ToUpper();
			this.ItemDistribution = PartyItemDistribution.RoundRobin;
			this.ExpDistribution = PartyExpDistribution.EqualExp;
			this.QuestSharing = PartyQuestSharing.Enabled;
			this.Note = "Let's Party!";

			this.Load();
		}

		/// <summary>
		/// Creates a new instance of a Party.
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
			this.Properties.Create(new StringProperty(PropertyName.ItemRouting, ((int)this.ItemDistribution).ToString()));
			this.Properties.Create(new StringProperty(PropertyName.Note, this.Note));
			this.Properties.Create(new StringProperty(PropertyName.ExpGainType, ((int)this.ExpDistribution).ToString()));
			this.Properties.Create(new StringProperty(PropertyName.IsQuestShare, ((int)this.QuestSharing).ToString()));
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
			lock (_members)
			{
				var member = PartyMember.ToMember(character);

				if (!this.AddMember(member))
					return;

				character.Connection.Party = this;
				character.PartyId = this.DbId;
				ZoneServer.Instance.Database.JoinParty(character, this);

				if (!silently)
				{
					Send.ZC_PARTY_INFO(character, this);
					Send.ZC_PARTY_LIST(this);
					Send.ZC_PARTY_ENTER(character, this);
					Send.ZC_ADDON_MSG(character, AddonMessage.PARTY_JOIN, 0, "None");
					Send.ZC_UPDATE_ALL_STATUS(character, 0);

					foreach (var keyPairValue in _members)
					{
						if (keyPairValue.Value == null)
							continue;

						if (keyPairValue.Value.Character == null)
							keyPairValue.Value.Character = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == member.CharacterObjectId);

						if (keyPairValue.Value.Character == null)
							continue;

						var partyMemberCharacter = keyPairValue.Value.Character;
						Send.ZC_CHANGE_RELATION(partyMemberCharacter, this, 0);
					}
				}
			}
		}

		/// <summary>
		/// Add a member
		/// </summary>
		/// <param name="member"></param>
		/// <returns></returns>
		public bool AddMember(PartyMember member)
		{
			lock (_members)
			{
				if (_members.ContainsKey(member.CharacterObjectId) || _members.Count >= 5)
					return false;

				_members.Add(member.CharacterObjectId, member);
			}
			return true;
		}

		/// <summary>
		/// Notify the client about its own party status
		/// </summary>
		/// <param name="character"></param>
		public void NotifyJoinedParty(Character character)
		{
			this.UpdateMember(character);
			Send.ZC_PARTY_INFO(character, this);
			Send.ZC_PARTY_LIST(this);
			Send.ZC_ADDON_MSG(character, AddonMessage.PARTY_JOIN, 0, "None");
			Send.ZC_PARTY_INST_INFO(character, character.Connection.Party);
			Send.ZC_CHANGE_RELATION(character, character.Connection.Party, 0);
			Send.ZC_NORMAL.ShowParty(character);
		}

		/// <summary>
		/// Broadcasts packet to all characters in party.
		/// </summary>
		/// <param name="packet"></param>
		public virtual void Broadcast(Packet packet, Character memberToExclude = null)
		{
			lock (_members)
			{
				foreach (var member in _members.Values)
				{
					var character = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == member.CharacterObjectId);
					character?.Connection.Send(packet);
				}
			}
		}

		/// <summary>
		/// Remove a party member and send ZC_PARTY_OUT to party members
		/// </summary>
		/// <param name="character"></param>
		public virtual void RemoveMember(Character character)
		{
			lock (_members)
			{
				var member = this.GetMember(character.ObjectId);
				if (member == null)
					return;
				
				Send.ZC_PARTY_OUT(this, member);

				if (member.Character == null)
					member.Character = ZoneServer.Instance.World.GetCharacter(c => c.DbId == member.CharacterDbId);

				if (member.Character != null)
					Send.ZC_CHANGE_RELATION(member.Character, this, 2);

				foreach(var member2 in _members.Values)
				{
					if (member2.Character == null)
						member2.Character = ZoneServer.Instance.World.GetCharacter(c => c.DbId == member2.CharacterDbId);

					if (member2.Character != null)
						Send.ZC_CHANGE_RELATION(member2.Character, this, 2);
				}

				Send.ZC_PARTY_INST_INFO(character, character.Connection.Party);

				if (_members.ContainsKey(member.CharacterObjectId))					
					_members.Remove(member.CharacterObjectId);
					
				if (member.CharacterDbId == this.LeaderDbId)
				{
					if (_members.Count <= 0)
					{
						ZoneServer.Instance.World.Parties.Delete(this);
					}
					else
					{
						var rnd = RandomProvider.Get();
						var leaderRngIndex = rnd.Next(0, _members.Count);
						var nextLeaderKeyPair = _members.ElementAt(leaderRngIndex);
						if (nextLeaderKeyPair.Value != null)
							ZoneServer.Instance.World.Parties.UpdatePartyLeader(this, nextLeaderKeyPair.Value.Character, nextLeaderKeyPair.Value, member);
					}
				}

				ZoneServer.Instance.World.Parties.LeaveParty(member.Character);				
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
				this.Properties.SetString(propertyId, value);
				Send.ZC_NORMAL.PartyPropertyUpdate(this, this.Properties.GetSelect(propertyId));
			}
		}

		public void ChangeName(string name)
		{
			this.Name = name;
			Send.ZC_NORMAL.PartyNameChange(this);
		}

		/// <summary>
		/// Give Exp with Party Settings
		/// </summary>
		/// <param name="character"></param>
		/// <param name="monster"></param>
		/// <param name="exp"></param>
		/// <param name="classExp"></param>
		public void GiveExp(Character character, long exp, long classExp, Mob monster)
		{
			switch (this.ExpDistribution)
			{
				case PartyExpDistribution.IndividualExp:
				{
					character.GiveExp(exp, classExp, monster);
					return;
				}
				case PartyExpDistribution.EqualExp:
				{
					var partyCharacters = character.Map.GetCharacters(a => a.Connection.Party != null && a.Connection.Party.ObjectId == this.ObjectId);
					if (exp > 0)
						exp = Math.Max(0, exp / partyCharacters.Length);

					if (classExp > 0)
						classExp = Math.Max(0, classExp / partyCharacters.Length);

					foreach (var partyCharacter in partyCharacters)
						partyCharacter?.GiveExp(exp, classExp, (partyCharacter.ObjectId == character.ObjectId) ? monster : null);
					return;
				}
				case PartyExpDistribution.ByLevel:
				{
					var partyCharacters = character.Map.GetCharacters(a => a.Connection.Party != null && a.Connection.Party.ObjectId == this.ObjectId);
					var averageLevel = partyCharacters.Average(a => a.Level);

					foreach (var partyCharacter in partyCharacters)
					{
						if (exp > 0)
							exp = (long)Math.Max(0, exp * (averageLevel / partyCharacter.Level));

						if (classExp > 0)
							classExp = (long)Math.Max(0, classExp * (averageLevel / partyCharacter.Level));
						partyCharacter?.GiveExp(exp, classExp, (partyCharacter.ObjectId == character.ObjectId) ? monster : null);
					}
					return;
				}
			}
		}

		/// <summary>
		/// Returns an array of members.
		/// </summary>
		/// <returns></returns>
		public PartyMember[] GetMembers()
		{
			lock (_members)
				return _members.Values.ToArray();
		}

		/// <summary>
		/// Broadcast member data update
		/// </summary>
		/// <param name="character"></param>
		public void UpdateMember(Character character)
		{
			var member = this.GetMember(character.ObjectId);
			if (member != null)
			{
				member.Handle = character.Handle;
				Send.ZC_NORMAL.PartyMemberData(member, this);
				member.UpdateValues(character);
			}
		}

		/// <summary>
		/// Returns true if the character is member of the party
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public bool IsPartyMember(Character character)
		{
			var member = this.GetMember(character.ObjectId);
			return member != null;
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

		/// <summary>
		/// Expel a character from the party
		/// </summary>
		/// <param name="teamName"></param>
		public void Expel(string teamName)
		{
			lock (_members)
			{
				var member = _members.Values.FirstOrDefault(m => m.TeamName == teamName);
				if (member != null)
				{
					var expeledMemberCharacter = ZoneServer.Instance.World.GetCharacter(c => c.DbId == member.CharacterDbId);
					this.RemoveMember(expeledMemberCharacter);
				}
			}
		}

		/// <summary>
		/// Give Item with Party Settings
		/// </summary>
		/// <param name="killer"></param>
		/// <param name="dropItem"></param>
		/// <param name="addType"></param>
		public void GiveItem(Character killer, Item dropItem, InventoryAddType addType = InventoryAddType.PickUp)
		{
			switch (this.ItemDistribution)
			{
				case PartyItemDistribution.Individual:
				{
					killer.Inventory.Add(dropItem, addType);
					return;
				}
				case PartyItemDistribution.RoundRobin:
				{
					var partyCharacters = killer.Map.GetCharacters(a => a.Connection.Party != null && a.Connection.Party.ObjectId == this.ObjectId);
					partyCharacters[this.LastItemRecipientIndex++ % partyCharacters.Length].Inventory.Add(dropItem, addType);
					return;
				}
				case PartyItemDistribution.Random:
				{
					var partyCharacters = killer.Map.GetCharacters(a => a.Connection.Party != null && a.Connection.Party.ObjectId == this.ObjectId);
					var partyMember = partyCharacters.Random();
					partyMember.Inventory.Add(dropItem, addType);
					return;
				}
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
