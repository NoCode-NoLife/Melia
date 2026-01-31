using System;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Notifies SocialServer when a player joins or leaves a party.
	/// Used to update party chat room membership in real-time.
	/// </summary>
	[Serializable]
	public class PartyUpdateMessage : ICommMessage
	{
		/// <summary>
		/// Gets or sets whether the player is joining (true) or leaving (false) a party.
		/// </summary>
		public bool IsJoining { get; set; }

		/// <summary>
		/// Gets or sets the account's database id.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Gets or sets the party's database id.
		/// When leaving, this is 0.
		/// </summary>
		public long PartyId { get; set; }

		/// <summary>
		/// Parameterless constructor for serialization.
		/// </summary>
		public PartyUpdateMessage() { }

		/// <summary>
		/// Creates new message.
		/// </summary>
		/// <param name="accountId">The account's database id.</param>
		/// <param name="partyId">The party's database id (0 when leaving).</param>
		/// <param name="isJoining">True if joining, false if leaving.</param>
		public PartyUpdateMessage(long accountId, long partyId, bool isJoining)
		{
			this.AccountId = accountId;
			this.PartyId = partyId;
			this.IsJoining = isJoining;
		}
	}
}
