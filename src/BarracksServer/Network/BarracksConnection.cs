using Melia.Barracks.Database;
using Melia.Shared.Network2;

namespace Melia.Barracks.Network
{
	/// <summary>
	/// A connection from the client to the barracks server.
	/// </summary>
	public interface IBarracksConnection : IConnection
	{
		/// <summary>
		/// Gets or sets the account associated with the connection.
		/// </summary>
		Account Account { get; set; }
	}

	/// <summary>
	/// A connection from the client to the barracks server.
	/// </summary>
	public class BarracksConnection : Connection, IBarracksConnection
	{
		/// <summary>
		/// Gets or sets the account associated with the connection.
		/// </summary>
		public Account Account { get; set; }

		/// <summary>
		/// Handles the given packet for this connection.
		/// </summary>
		/// <param name="packet"></param>
		protected override void OnPacketReceived(Packet packet)
		{
			BarracksServer.Instance.PacketHandler.Handle(this, packet);
		}
	}
}
