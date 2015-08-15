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
		protected override void HandlePacket(Packet packet)
		{
			LoginPacketHandler.Instance.Handle(this, packet);
		}
	}
}
