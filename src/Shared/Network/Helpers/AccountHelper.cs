// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Const;

namespace Melia.Shared.Network.Helpers
{
	public static class AccountHelper
	{
		/// <summary>
		/// Writes account's properties to packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="account"></param>
		public static void AddAccountProperties(this Packet packet, IAccount account)
		{
			packet.PutShort(4 * 8); // Account properties size
			packet.PutShort(100); // This is the server group ID found in serverlist.xml.
			packet.PutInt(1);

			packet.PutInt(PropertyId.Account.Medal);
			packet.PutFloat(account.Medals);

			packet.PutInt(PropertyId.Account.PremiumMedal);
			packet.PutFloat(account.PremiumMedals);

			packet.PutInt(PropertyId.Account.GiftMedal);
			packet.PutFloat(account.GiftMedals);

			packet.PutInt(PropertyId.Account.SelectedBarrack);
			packet.PutFloat(account.SelectedBarrack);
		}
	}

	public interface IAccount
	{
		int Medals { get; }
		int GiftMedals { get; }
		int PremiumMedals { get; }
		int SelectedBarrack { get; }
	}
}
