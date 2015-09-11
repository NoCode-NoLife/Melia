// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Network;
using Melia.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Social.Network
{
	public class SocialConnection : Connection
	{
		/// <summary>
		/// Handles login server packets.
		/// </summary>
		/// <param name="packet"></param>
		protected override void HandlePacket(Packet packet)
		{
			Log.Debug("Unhandled:\n{0}", packet.ToString());
		}
	}
}
