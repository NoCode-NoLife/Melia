using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Shared.Network;
using Melia.Shared.Util;
using System.Threading;

namespace Melia.Channel.World
{
	public class Group
	{
		public long Id;
		public int Type { get; private set; }
		public string Name { get; private set; }
		public List<Character> members { get; private set; }
		public int maxMembers;

		private Timer _futureTask;
		public int INSTANT_INFO_INTERVAL = 1000; // Millis

		public void InstantInfoTask(Object obj)
		{
			if (_futureTask == null)
				return;

			Send.ZC_PARTY_INST_INFO(this);
		}

		public Group(Character leader, int type, string name)
		{
			this.Id = GenerateUniqueId();
			this.Type = type;

			
			if (this.Type == 0)
			{
				this.maxMembers = 5;
			}
			else
			{
				this.maxMembers = 1; // Default value
			}

			if (name.Equals("Party#"))
				this.Name = name + "ASDF"; // Random from UniqueId?
			else 
				this.Name = name;

			this.members = new List<Character>();

			this.AddMember(leader, true);

			this.BroadcastNewParty(leader);

			_futureTask = TasksPoolManager.Instance.AddGeneralTaskAtFixedRate(InstantInfoTask, null, 5, INSTANT_INFO_INTERVAL);
		}

		public Character GetLeader()
		{
			Character leader = null;

			lock (this.members)
			{
				leader = this.members.First();
			}

			return leader;
		}

		public bool IsLeader(Character character)
		{
			lock (this.members)
			{
				if (this.members.Count > 0)
				{
					if (character == this.members.First())
						return true;
				}
			}
			return false;
		}

		public bool IsFull()
		{
			return (this.members.Count < this.maxMembers) ? false : true;
		}

		public bool AddMember(Character newMember, bool isLeader)
		{
			if (this.IsFull())
				return false;

			lock (members)
			{
				// Check if this character is already in this group
				if (this.members.Contains(newMember))
					return false;

				this.members.Add(newMember);
				newMember.Party = this;
			}

			if (!isLeader)
				this.BroadcastMemberEnter(newMember);

			//this.BroadcastMemberLogin(newMember, true);

			return true;
		}

		public bool RemoveMember(Character member)
		{
			bool isLeader = this.IsLeader(member);

			lock (members)
			{
				// Check if this character is already in this group
				if (!this.members.Contains(member))
					return false;

				// Broadcast the "leave" before actually removing the Character from the group, so the packet is received by him aswell. A better way?
				this.BroadcastMemberLeave(member);

				this.members.Remove(member);
				member.Party = null;

				// Check if this is the last member
				if (this.members.Count == 0)
				{
					this.DisolveParty();
					return true;
				}				
			}

			if (isLeader)
			{
				// Change leader
				this.BroadcastNewLeader(null, this.GetLeader());
			}

			return true;
		}

		public void AcceptInvitation(Character character)
		{
			/// TODO
			/// Check invitation

			if (character.Party != null)
				return;

			this.AddMember(character, false);
		}

		public void RejectInvitation(Character character)
		{
			/// TODO
			/// Check if there is something to reject.  Otherwise, it can be sending spamming messages to party leader

			Send.ZC_ADDON_MSG(this.GetLeader(), "PARTY_INVITE_CANCEL", character.TeamName);
		}

		public List<Character> GetMembers()
		{
			lock (this.members)
			{
				return this.members.ToList();
			}
		}

		public void DisolveParty()
		{
			Log.Debug("DisolveParty");
			if (this.members.Count > 0)
				return;
		}

		private long GenerateUniqueId()
		{
			var rnd = new Random();
			return rnd.Next();
		}

		public void ChangeName(string newName)
		{
			// String sanatize
			/// TODO
			/// 

			// Change Name
			this.Name = newName;

			Send.ZC_NORMAL_PartyNameChange(this, this.Name);

			// Update UnderName for all members
			var membersList = this.GetMembers();

			foreach (var member in membersList)
			{
				Send.ZC_NORMAL_PartyName_underCharacterName(member, this.Name, this.IsLeader(member));
			}
			
		}

		public void ChangeLeader(Character member)
		{
			Log.Debug("ChangeLeader");

			Character previousLeader = null;

			lock (this.members)
			{
				var memberIndex = this.members.IndexOf(member);

				if (memberIndex == -1)
					return;

				if (memberIndex > 0)
				{
					previousLeader = this.GetLeader();

					this.members[0] = member;
					this.members[memberIndex] = previousLeader;
				}
			}

			Log.Debug("New leader is {0}", member.TeamName);

			this.BroadcastNewLeader(previousLeader, member);


		}

		public void Broadcast(Packet packet)
		{
			Array membersArray;
			lock (this.members)
			{
				membersArray = this.members.ToArray();
			}
			foreach (Character member in membersArray)
			{
				if (member.Connection != null)
				{
					Log.Debug("Broadcasting to {0}", member.TeamName);
					member.Connection.Send(packet);
				}
			}
		}

		public void BroadcastToPartyMembers(Packet packet, Character character)
		{
			Array membersArray;
			lock (this.members)
			{
				membersArray = this.members.ToArray();
			}
			foreach (Character member in membersArray)
			{
				if (member.Connection != null && member != character)
				{
					Log.Debug("Broadcasting to {0}", member.TeamName);
					member.Connection.Send(packet);
				}
			}
		}

		// Broadcast
		public void BroadcastNewParty(Character leader)
		{
			Send.ZC_PARTY_INFO(leader, this);
			Send.ZC_PARTY_LIST(leader, this, 1);
			Send.ZC_PARTY_LIST(leader, this, 2);
			Send.ZC_NORMAL_PartyName_underCharacterName(leader, this.Name, true);
			//Send.ZC_NORMAL_UNK_6e01(
		}

		public void BroadcastMemberEnter(Character member)
		{
			// Member enter
			Send.ZC_PARTY_ENTER(this, member);
			// These only for the one how enters
			/// TODO
			{
				Send.ZC_PARTY_INFO(member, this);
				Send.ZC_PARTY_LIST(member, this, 1);
			}
			// Initial broadcast of Group Name
			Send.ZC_NORMAL_PartyName_underCharacterName(member, this.Name, this.IsLeader(member));

			//
			// ZC_CHANGE_RELATION to 00
			var membersList = this.GetMembers();
			var leader = this.GetLeader();
			foreach (var m in membersList)
			{
				if (m != member)
					Send.ZC_CHANGE_RELATION(member, m, 0);
				
				if (m != leader)
					Send.ZC_CHANGE_RELATION(leader, m, 0);
				
			}
			// Has to do with CHANGE RELATION THING? to enable icon in map?
			Send.ZC_NORMAL_UNK_4201(member);
			Send.ZC_NORMAL_UNK_4201(leader);

		}

		public void BroadcastMemberLeave(Character member)
		{
			// Remove this member from the list
			Send.ZC_PARTY_OUT(this, member);
			// 
			Send.ZC_NORMAL_PartyName_underCharacterName(member, "", false);

			// ZC_CHANGE_RELATION to 02
			var membersList = this.GetMembers();
			var leader = this.GetLeader();
			foreach (var m in membersList)
			{
				if (m != member)
					Send.ZC_CHANGE_RELATION(member, m, 2);

				if (m != leader)
					Send.ZC_CHANGE_RELATION(leader, m, 2);

			}
			// Has to do with CHANGE RELATION THING? to enable icon in map?
			Send.ZC_NORMAL_UNK_4201(member);
			Send.ZC_NORMAL_UNK_4201(leader);
		}

		public void BroadcastMemberLogin(Character member, bool login)
		{
			// This member entered/exit the game
			Send.ZC_NORMAL_Party2(this, member, login);
		}

		public void BroadcastMemberLogout(Character member)
		{
			Send.ZC_NORMAL_Party2(this, member, false);
		}

		public void BroadcastNewLeader(Character previousLeader, Character newLeader)
		{
			Send.ZC_NORMAL_PartyLeaderChange(this);

			// Update their UnderName and icon
			if (previousLeader != null)
				Send.ZC_NORMAL_PartyName_underCharacterName(previousLeader, this.Name, false);
			Send.ZC_NORMAL_PartyName_underCharacterName(newLeader, this.Name, true);
		}
	}
}
