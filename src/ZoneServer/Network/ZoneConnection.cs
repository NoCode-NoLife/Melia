using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Network2;
using Melia.Zone.Database;
using Melia.Zone.World.Entities;

namespace Melia.Zone.Network
{
	public interface IZoneConnection : IConnection
	{
		Account Account { get; }
		Character SelectedCharacter { get; }
	}

	public class ZoneConnection : Connection, IZoneConnection
	{
		public Account Account => throw new NotImplementedException();
		public Character SelectedCharacter => throw new NotImplementedException();

		protected override void OnPacketReceived(Packet packet)
		{
			throw new NotImplementedException();
		}
	}
}
