using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Shared.Network;
using Melia.Shared.ObjectProperties;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Groups
{

	public abstract class Group : IGroup
	{
		/// <summary>
		/// List of party members
		/// </summary>
		protected readonly Dictionary<long, IMember> _members = new();

		/// <summary>
		/// The group's type.
		/// </summary>
		public abstract GroupType Type { get; }

		/// <summary>
		/// The group's maximum size.
		/// </summary>
		public abstract int MaxMemberCount { get; }

		/// <summary>
		/// The group's database unique id.
		/// </summary>
		public long DbId { get; set; }

		/// <summary>
		/// The group's unique id.
		/// </summary>
		public abstract long ObjectId { get; }

		/// <summary>
		/// The group's leader database unique id.
		/// </summary>
		public long LeaderDbId { get; set; }

		/// <summary>
		/// The group's leader globally unique id.
		/// </summary>
		public abstract long LeaderObjectId { get; }

		public DateTime DateCreated { get; set; }

		public string Name { get; set; }

		public string Note { get; set; }

		public abstract Properties Properties { get; }

		/// <summary>
		/// Returns the group's variables.
		/// </summary>
		/// <remarks>
		/// Not saved to the database.
		/// </remarks>
		public Variables Vars { get; } = new Variables();

		public IMember Owner => this.GetMember(this.LeaderObjectId);
		public bool IsLeader(long objectId) => this.LeaderObjectId == objectId;

		/// <summary>
		/// Checks if the character is party leader otherwise sends a system message.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public bool IsLeader(Character character)
		{
			var isLeader = this.IsLeader(character.ObjectId);
			if (!isLeader)
				character.SystemMessage("PartyLeaderOnly");
			return isLeader;
		}

		/// <summary>
		/// Returns the group's member count.
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
		/// Get's the group leader.
		/// </summary>
		/// <returns></returns>
		public Character GetLeader()
		{
			return ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == this.LeaderObjectId);
		}

		/// <summary>
		/// Return's true if the group has a leader is on the same Zone Server.
		/// </summary>
		/// <returns></returns>
		public bool TryGetLeader(out Character leader)
		{
			leader = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == this.LeaderObjectId);

			return leader != null;
		}

		/// <summary>
		/// Add a member
		/// </summary>
		/// <param name="member"></param>
		/// <returns></returns>
		public bool AddMember(IMember member)
		{
			lock (_members)
			{
				// Do not add another character from the same team.
				if (_members.Values.Any(m => m.AccountId == member.AccountId))
					return false;
				if (_members.Count < this.MaxMemberCount)
					return _members.TryAdd(member.ObjectId, member);

				return false;
			}
		}

		public void Broadcast(Packet packet, Character memberToExclude = null)
		{
			lock (_members)
			{
				foreach (var member in _members.Values)
				{
					var character = ZoneServer.Instance.World.GetCharacter(c => c.ObjectId == member.ObjectId);
					if (character != null)
						character?.Connection.Send(packet);
				}
			}
		}

		private IMember GetMember(long leaderObjectId)
		{
			IMember member = default;
			lock (_members)
				_members.TryGetValue(leaderObjectId, out member);
			return member;
		}

		public List<IMember> GetMembers()
		{
			lock (_members)
				return _members.Values.ToList();
		}

		/// <summary>
		/// Gets all alive members in the group.
		/// </summary>
		/// <returns>A list of alive members.</returns>
		public List<IMember> GetAliveMembers()
		{
			var aliveMembers = new List<IMember>();
			lock (_members)
			{
				foreach (var member in _members.Values)
				{
					// An alive member is online and has more than 0 HP.
					if (member.IsOnline && member.Hp > 0)
					{
						aliveMembers.Add(member);
					}
				}
			}
			return aliveMembers;
		}

		/// <summary>
		/// Gets the count of alive members in the group.
		/// </summary>
		/// <returns>The number of alive members.</returns>
		public int GetAliveMemberCount()
		{
			return this.GetAliveMembers().Count;
		}

		/// <summary>
		/// Remove a group member
		/// </summary>
		/// <param name="member"></param>
		protected void RemoveMember(IMember member)
		{
			lock (_members)
			{
				_members.Remove(member.ObjectId);
			}
		}

		/// <summary>
		/// Returns true if a member if found, otherwise false.
		/// </summary>
		/// <param name="characterObjectId"></param>
		/// <returns></returns>
		public bool TryGetMember(long characterObjectId, out IMember member)
		{
			lock (_members)
				return _members.TryGetValue(characterObjectId, out member);
		}

		/// <summary>
		/// Broadcast member info update, used for Instant Updates (HP? Position?).
		/// </summary>
		/// <param name="character"></param>
		public void UpdateMemberInfo(Character character, bool isOnline = true)
		{
			if (this.TryGetMember(character.ObjectId, out var member))
			{
				member.Handle = character.Handle;
				member.Hp = character.Hp;
				member.MaxHp = character.MaxHp;
				member.Sp = character.Sp;
				member.MaxSp = character.MaxSp;
				member.Position = character.Position;
				member.MapId = character.MapId;
				member.Level = character.Level;
				member.JobLevel = character.JobLevel;
				member.IsOnline = isOnline;

				// Spams pretty hard, probably should move this to the Update(TimeSpan elapsed)
				// TODO: Optimize this, maybe only send if more than 1 member is online too.
				Send.ZC_PARTY_INST_INFO(this);
			}
		}

		public void UpdateMember(Character character, bool isOnline = true)
		{
			this.UpdateMemberData(character, isOnline);
			this.UpdateMemberInfo(character, isOnline);
			if (isOnline)
				Send.ZC_PARTY_INST_INFO(this);
			this.UpdateMemberMapChannel(character);
		}

		/// <summary>
		/// Broadcast member data update, used for HP/SP/Map/Level Updates.
		/// </summary>
		/// <param name="character"></param>
		public void UpdateMemberData(Character character, bool isOnline = true)
		{
			if (this.TryGetMember(character.ObjectId, out var member))
			{
				member.Handle = character.Handle;
				member.Hp = character.Hp;
				member.MaxHp = character.MaxHp;
				member.Sp = character.Sp;
				member.MaxSp = character.MaxSp;
				member.Position = character.Position;
				member.MapId = character.MapId;
				member.Level = character.Level;
				member.JobLevel = character.JobLevel;
				member.IsOnline = isOnline;

				Send.ZC_NORMAL.PartyMemberData(member, this);
			}
		}

		public void UpdateMemberMapChannel(Character character)
		{
			if (this.TryGetMember(character.ObjectId, out var member))
				Send.ZC_NORMAL.MemberMapStatusUpdate(this, member);
		}

		public virtual void Update(TimeSpan elapsed)
		{
		}

		public IMember ToMember(Character character)
		{
			switch (this.Type)
			{
				case GroupType.Party:
					return GroupMember.ToPartyMember(character);
			}
			return null;
		}
	}

	public interface IGroup : IPropertyObject, IUpdateable
	{
		/// <summary>
		/// The group's type.
		/// </summary>
		public GroupType Type { get; }

		/// <summary>
		/// The group's unique id.
		/// </summary>
		public long DbId { get; set; }

		/// <summary>
		/// The group leader's unique id.
		/// </summary>
		public long LeaderDbId { get; set; }

		/// <summary>
		/// The group leader's globally unique id.
		/// </summary>
		public long LeaderObjectId => this.LeaderDbId | ObjectIdRanges.Characters;

		/// <summary>
		/// The group's owner.
		/// </summary>
		public IMember Owner { get; }

		/// <summary>
		/// The group's creation date.
		/// </summary>
		DateTime DateCreated { get; set; }

		/// <summary>
		/// The group's name.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// The group's note.
		/// </summary>
		string Note { get; }

		/// <summary>
		/// Get a list of members of the group.
		/// </summary>
		/// <returns></returns>
		List<IMember> GetMembers();

		/// <summary>
		/// Gets all alive members in the group.
		/// </summary>
		/// <returns>A list of alive members.</returns>
		List<IMember> GetAliveMembers();

		/// <summary>
		/// Gets the count of alive members in the group.
		/// </summary>
		/// <returns>The number of alive members.</returns>
		int GetAliveMemberCount();

		/// <summary>
		/// Converts character to member.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public IMember ToMember(Character character);

		/// <summary>
		/// Broadcast a packet to the group.
		/// </summary>
		/// <param name="packet"></param>
		public void Broadcast(Packet packet, Character memberToExclude = null);
	}
}
