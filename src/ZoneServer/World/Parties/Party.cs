using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using Melia.Shared.ObjectProperties;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Util;

namespace Melia.Zone.World.Parties
{
	/// <summary>
	/// Represents a quest that was taken on by a character.
	/// </summary>
	public class Party : IDisposable
	{
		public List<Character> Members = new List<Character>();

		/// <summary>
		/// Gets or sets the party's unique database id.
		/// </summary>
		public long DbId { get; set; }

		/// <summary>
		/// Party's name.
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Party's description.
		/// </summary>
		public string Description { get; private set; }

		/// <summary>
		/// Party's leader character Id
		/// </summary>
		public long LeaderId { get; private set; }

		/// <summary>
		/// Party's leader team name
		/// </summary>
		public string LeaderTeamName { get; private set; }

		/// <summary>
		/// Returns the creation date of the party.
		/// </summary>
		public DateTime CreationTime { get; }

		/// <summary>
		/// Creates new quest.
		/// </summary>
		/// <param name="questData"></param>
		public Party(string name, string description, long leaderId, DateTime creationTime, string leaderTeamName, long dbId)
		{
			Name = name;
			Description = description;
			LeaderId = leaderId;
			DbId = dbId;
			CreationTime = creationTime;
			LeaderTeamName = leaderTeamName;
		}

		/// <summary>
		/// Sets the new leader Id.
		/// </summary>
		/// <param name="newLeaderId"></param>
		public void SetNewLeader(long newLeaderId, string newLeaderTeamName)
		{
			LeaderId = newLeaderId;
			LeaderTeamName = newLeaderTeamName;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
