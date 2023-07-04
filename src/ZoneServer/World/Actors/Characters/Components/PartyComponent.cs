using System;
using System.Collections.Generic;
using Melia.Zone.World.Parties;
using Melia.Zone.World.Quests;
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
		private readonly List<Party> _parties = new List<Party>();

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
				Character.Party = party;
				_parties.Add(party);
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
		/// Get the party members from the party.
		/// </summary>
		/// <returns></returns>
		public List<Character> GetMembers()
		{
			return Character.Party.Members;
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

			if (Character.DbId == Character.Party.LeaderId)
			{
				if (Character.Party.Members.Count >= 2)
				{
					Character.Party.Members.Remove(Character);
					var rnd = RandomProvider.Get();
					var newLeader = rnd.Next(0, Character.Party.Members.Count);

					if (Character.Party.Members[newLeader] != null)
					{
						Character.Party.SetNewLeader(Character.Party.Members[newLeader].DbId);
					}
					
					//TODO: Notify Client about the new leader

					Character.Party = null;
				}
				else
				{
					var party = Character.Party;

					//TODO: Notify Client about the character that left the party

					party.Dispose();
				}
			}

			Character.Party = null;
			//TODO: Notify Client about the character that left the party
		}

		/// <summary>
		/// Disband the party
		/// </summary>
		/// <returns></returns>
		public void DisbandParty()
		{
			if (Character.Party == null)
			{
				return;
			}

			foreach (var member in Character.Party.Members)
			{
				member.Parties.LeaveParty();
			}

			var party = Character.Party;

			if (_parties.Contains(party))
			{
				_parties.Remove(party);
			}

			//TODO: Notify Client about the party that has been disposed

			party.Dispose();
		}

		/// <summary>
		/// Add a member to the party.
		/// </summary>
		/// <returns></returns>
		public bool AddMember(Character character)
		{
			if (!Character.Party.Members.Contains(character))
			{
				if (Character.Party.Members.Count <= maxMembers)
				{
					Character.Party.Members.Add(character);
					return true;
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
			// TODO: implement this
		}
	}
}
