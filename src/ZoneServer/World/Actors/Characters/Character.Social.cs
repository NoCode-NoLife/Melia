// ===================================================================
// CharacterSocial.cs - Communication, party, and social features
// ===================================================================
using System.Collections.Generic;
using Melia.Zone.Network;

namespace Melia.Zone.World.Actors.Characters
{
	public partial class Character
	{
		/// <summary>
		/// Gets all party members within a specified range.
		/// </summary>
		public IEnumerable<Character> GetPartyMembersInRange(float range = 0, bool areAlive = true)
		{
			return this.Map.GetPartyMembersInRange(this, this.Position, range, areAlive);
		}

		/// <summary>
		/// Sends an addon message to the client.
		/// </summary>
		public void AddonMessage(string function, string stringParameter = null, int intParameter = 0)
		{
			Send.ZC_ADDON_MSG(this, function, intParameter, stringParameter);
		}
	}
}
