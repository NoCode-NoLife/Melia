﻿// Copyright (c) Aura development team - Licensed under GNU GPL
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
			packet.PutShort(15); // Account properties size

			{
				packet.PutShort(1003);
			}

			packet.PutShort(ObjectProperty.Account.Medal);
			packet.PutFloat(account.Medals);

			packet.PutShort(ObjectProperty.Account.Medal_Get_Date);
			packet.PutShort(5);

			packet.PutString("None");
		}
	}
}
