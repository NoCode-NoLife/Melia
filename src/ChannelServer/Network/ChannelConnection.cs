using Melia.Shared.Network;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.Network
{
	public class ChannelConnection : Connection
	{
		public Character SelectedCharacter { get; set; }

		protected override void HandlePacket(Packet packet)
		{
			ChannelPacketHandler.Instance.Handle(this, packet);
		}
	}
}
