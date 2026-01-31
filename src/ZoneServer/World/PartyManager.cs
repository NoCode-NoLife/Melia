using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Network.Inter.Messages;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Network.Communication;

namespace Melia.Zone.World
{
	public class PartyManager
	{
		/// <summary>
		/// Parties indexed by their id.
		/// </summary>
		private readonly Dictionary<long, Party> _parties = new();

		/// <summary>
		/// Create a party and persist it to the database.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public Party Create(Character character)
		{
			var party = new Party()
			{
				LeaderDbId = character.DbId,
			};
			party.AddMember(character, true);

			ZoneServer.Instance.Database.CreateParty(party);

			// Notify SocialServer to add player to party chat room
			// Must be done after CreateParty() so party.DbId is valid
			var partyUpdateMsg = new PartyUpdateMessage(character.Connection.Account.Id, party.DbId, true);
			ZoneServer.Instance.Communicator.Send("Coordinator", partyUpdateMsg.BroadcastTo("Chat"));

			Send.ZC_PARTY_INFO(character, party);
			Send.ZC_ADDON_MSG(character, AddonMessage.PARTY_JOIN, 0, "None");
			Send.ZC_PARTY_LIST(party);
			Send.ZC_NORMAL.ShowParty(character);
			this.Add(party);
			return party;
		}

		/// <summary>
		/// Removes a party and deletes it from the database.
		/// </summary>
		/// <param name="party"></param>
		public void Delete(Party party)
		{
			if (this.Remove(party.ObjectId))
				ZoneServer.Instance.Database.DeleteParty(party);
		}

		/// <summary>
		/// Adds party to the manager.
		/// </summary>
		/// <param name="party"></param>
		/// <exception cref="ArgumentException">
		/// Thrown if a party with the same id as the given one
		/// already exists.
		/// </exception>
		public void Add(Party party)
		{
			lock (_parties)
			{
				_parties.TryAdd(party.ObjectId, party);
			}
		}

		/// <summary>
		/// Removes the party with given id from the manager.
		/// </summary>
		/// <param name="partyId"></param>
		/// <returns>True if the party was removed, false if it didn't exist.</returns>
		public bool Remove(long partyId)
		{
			if (partyId < ObjectIdRanges.Party)
				partyId += ObjectIdRanges.Party;

			lock (_parties)
			{
				return _parties.Remove(partyId);
			}
		}

		/// <summary>
		/// Checks if a party exists with given id in the manager.
		/// </summary>
		/// <param name="partyId"></param>
		/// <returns>True if the party exists</returns>
		public bool Exists(long partyId)
		{
			if (partyId < ObjectIdRanges.Party)
				partyId += ObjectIdRanges.Party;

			lock (_parties)
			{
				return _parties.ContainsKey(partyId);
			}
		}

		/// <summary>
		/// Find party by id or null if it doesn't exist
		/// </summary>
		/// <param name="partyId"></param>
		/// <returns></returns>
		public Party GetParty(long partyId)
		{
			if (partyId < ObjectIdRanges.Party)
				partyId += ObjectIdRanges.Party;

			lock (_parties)
			{
				if (_parties.TryGetValue(partyId, out var value))
					return value;
			}
			return null;
		}

		/// <summary>
		/// Finds a party that has a member with the given account ID.
		/// Returns the party and the member if found.
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="member"></param>
		/// <returns></returns>
		public Party FindPartyByAccountId(long accountId, out Groups.IMember member)
		{
			member = null;
			lock (_parties)
			{
				foreach (var party in _parties.Values)
				{
					var members = party.GetMembers();
					foreach (var m in members)
					{
						if (m.AccountId == accountId)
						{
							member = m;
							return party;
						}
					}
				}
			}
			return null;
		}
	}
}
