// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Shared.Const;
using Melia.Shared.Network;

namespace Melia.Login.Network.Helpers
{
	public static class AccountHelper
	{
		/// <summary>
		/// Writes account's properties to packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="account"></param>
		public static void AddAccountProperties(this Packet packet, Account account)
		{
			packet.PutShort(4 * 8); // Account properties size
			packet.PutShort(100); // This is the server group ID found in serverlist.xml.

			packet.PutInt(ObjectProperty.Account.Medal);
			packet.PutFloat(account.Medals);

			packet.PutInt(ObjectProperty.Account.PremiumMedal);
			packet.PutFloat(account.PremiumMedals);

			packet.PutInt(ObjectProperty.Account.GiftMedal);
			packet.PutFloat(account.GiftMedals);

			packet.PutInt(ObjectProperty.Account.SelectedBarrack);
			packet.PutFloat(account.SelectedBarrack);
		}
	}
}
