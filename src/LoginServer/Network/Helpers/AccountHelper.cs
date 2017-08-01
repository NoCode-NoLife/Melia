// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Shared.Const;
using Melia.Shared.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			packet.PutShort(43); // Account properties size

			// [i11257 (2016-03-25)] ?
			{
				packet.PutShort(1004);
			}

			// Free TP
			packet.PutInt(ObjectProperty.Account.Medal);
			packet.PutFloat(account.Medals);

			packet.PutInt(ObjectProperty.Account.Medal_Get_Date);

			packet.PutShort(5); // length of the next string
			packet.PutString("None");
			
			//Event TP
			packet.PutInt(ObjectProperty.Account.GiftMedal);
			packet.PutFloat(10);

			// TP
			packet.PutInt(ObjectProperty.Account.PremiumMedal);
			packet.PutFloat(0);

			packet.PutInt(ObjectProperty.Account.SelectedBarrack);
			packet.PutFloat(account.SelectedBarrack);
		}
	}
}
