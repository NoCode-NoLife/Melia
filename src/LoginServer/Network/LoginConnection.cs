// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Shared.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.Network
{
	public class LoginConnection : Connection
	{
		/// <summary>
		/// Account associated with this connection.
		/// </summary>
		public Account Account { get; set; }

		/// <summary>
		/// Handles login server packets.
		/// </summary>
		/// <param name="packet"></param>
		protected override void HandlePacket(Packet packet)
		{
			LoginPacketHandler.Instance.Handle(this, packet);
		}

		/// <summary>
		/// Cleans up connection, incl. account and characters.
		/// </summary>
		protected override void CleanUp()
		{
			if (this.Account == null)
				return;

			this.Account.Save();
		}
	}
}
