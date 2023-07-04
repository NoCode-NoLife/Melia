using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Parties;
using Melia.Zone.World.Quests;
using Yggdrasil.Geometry.Shapes;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// A character's party manager.
	/// </summary>
	/// <remarks>
	/// Our current party system is custom-made.
	/// TODO: Add more details to this remarks
	/// </remarks>
	public class PartyComponent : CharacterComponent
	{
		private readonly static TimeSpan AutoReceiveDelay = TimeSpan.FromMinutes(1);
		private const int maxMembers = 5;
		private readonly object _syncLock = new object();
		private readonly static List<Party> _parties = new List<Party>();

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public PartyComponent(Character character)
			: base(character)
		{
		}

		/// <summary>
		/// Adds party without informing the client.
		/// </summary>
		/// <remarks>
		/// This is primarily used while the character and it's party
		/// </remarks>
		/// <param name="party"></param>
		public void AddSilent(Party party)
		{
			lock (_syncLock)
			{
				if ((Character.Party != null && Character.Party.Members.Count <= maxMembers) || Character.Party == null)
				{
					Character.Party = party;

					Character.Party.Members.Add(Character);

					if (!_parties.Contains(party))
					{
						_parties.Add(party);
					}
				}		
			}
		}


		/// <summary>
		/// Returns a list with all of the character's parties.
		/// </summary>
		/// <returns></returns>
		public Party[] GetList()
		{
			lock (_syncLock)
			{
				return _parties.ToArray();
			}				
		}

		/// <summary>
		/// Returns a list with all of the character's parties.
		/// </summary>
		/// <returns></returns>
		public bool PartyNameExists(string newPartyName)
		{
			lock (_syncLock)
			{
				return _parties.Count <= 0 ? false : _parties.FirstOrDefault(a => a.Name == newPartyName) != null;
			}
		}

		/// <summary>
		/// Creates a new party within the given name
		/// </summary>
		/// <returns></returns>
		public void CreateParty(string partyName)
		{
			// Party's Name should be unique
			if (_parties.FirstOrDefault(a => a.Name == partyName) != null || Character.Party != null)
			{
				return;
			}

			var party = ZoneServer.Instance.Database.CreateParty(partyName, "Let's Party", Character);

			if (party != null)
			{
				AddSilent(party);
				Send.ZC_PARTY_INFO(Character);
				Send.ZC_PARTY_LIST(Character);
				
				Send.ZC_ADDON_MSG(Character, "GAME_START", "None");
				Send.ZC_ADDON_MSG(Character, "PARTY_JOIN", "None");
				Send.ZC_ADDON_MSG(Character, "PARTY_UPDATE", "None");

				Send.ZC_NORMAL.PartyCreatedNotify(Character);
				Send.ZC_NORMAL.PartyCreatedNotify2(Character);
			}
		}

		/// <summary>
		/// Returns a list with all of the character's party.
		/// </summary>
		/// <returns></returns>
		public Party GetParty()
		{
			lock (_syncLock)
			{
				return Character.Party;
			}
		}

		/// <summary>
		/// Make the character leave the party.
		/// </summary>
		/// <returns></returns>
		public void LeaveParty()
		{
			if (Character.Party == null)
			{
				return;
			}

			ZoneServer.Instance.Database.LeaveParty(Character);

			foreach (var member in Character.Party.Members)
			{
				Send.ZC_PARTY_OUT(member, Character);
				Send.ZC_ADDON_MSG(member, "PARTY_UPDATE", "None");
			}

			Send.ZC_ADDON_MSG(Character, "PARTY_OUT", "None");

			if (Character.AccountId == Character.Party.LeaderId)
			{
				if (Character.Party.Members.Count >= 2)
				{
					Character.Party.Members.Remove(Character);
					var rnd = RandomProvider.Get();
					var newLeader = rnd.Next(0, Character.Party.Members.Count);

					if (Character.Party.Members[newLeader] != null)
					{
						Character.Party.SetNewLeader(Character.Party.Members[newLeader].DbId, Character.Party.Members[newLeader].TeamName);
					}
					
					//TODO: Notify other Clients about the new leader

					Character.Party = null;
				}
				else
				{
					var party = Character.Party;
					DisbandParty();
					party.Dispose();
				}
			}

			Character.Party = null;
		}

		/// <summary>
		/// Disband the party
		/// </summary>
		/// <returns></returns>
		private void DisbandParty()
		{
			if (Character.Party == null)
			{
				return;
			}

			var party = Character.Party;

			if (_parties.Contains(party))
			{
				_parties.Remove(party);
			}
						
			if (ZoneServer.Instance.Database.DeleteParty(Character))
			{
				//TODO: Notify Client about the party that has been disposed

				party.Dispose();
				Character.Party = null;
			}
		}

		/// <summary>
		/// Add a member to the party.
		/// </summary>
		/// <returns></returns>
		public void RejoinParty(Character member, Party party)
		{
			if (Character.Party == null || member == null)
			{
				return;
			}

			if (!Character.Party.Members.Contains(member))
			{
				if (Character.Party.Members.Count <= maxMembers)
				{
					Character.Party.Members.Add(member);
					member.Party = party;
				}
			}

			// TODO: Notify Client about the member that has joined the party
		}

		/// <summary>
		/// Add a member to the party that was not in it.
		/// </summary>
		/// <returns></returns>
		public bool JoinParty(Character joiningCharacter)
		{
			if (!Character.Party.Members.Contains(joiningCharacter))
			{
				if (Character.Party.Members.Count <= maxMembers)
				{
					Character.Party.Members.Add(joiningCharacter);
					return ZoneServer.Instance.Database.JoinParty(Character, joiningCharacter);
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

			// TODO: Notify Client about the member that has joined the party
		}

		/// <summary>
		/// Update the client about the party situation.
		/// </summary>
		public void UpdateClient()
		{
			Send.ZC_PARTY_INFO(Character);
			Send.ZC_PARTY_LIST(Character);

			Send.ZC_ADDON_MSG(Character, "GAME_START", "None");
			Send.ZC_ADDON_MSG(Character, "PARTY_JOIN", "None");
			Send.ZC_ADDON_MSG(Character, "PARTY_UPDATE", "None");

			Send.ZC_NORMAL.PartyCreatedNotify(Character);
			Send.ZC_NORMAL.PartyCreatedNotify2(Character);
		}
	}
}
