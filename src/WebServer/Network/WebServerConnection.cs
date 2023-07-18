using Melia.Shared.Network;
using Yggdrasil.Network.TCP;

namespace Melia.Web.Network
{
	/// <summary>
	/// A connection from the client to the web server server.
	/// </summary>
	public interface IWebServerConnection : IConnection
	{
	}

	/// <summary>
	/// A connection from the client to the web server.
	/// </summary>
	public class WebServerConnection : Connection, IWebServerConnection
	{
		/// <summary>
		/// Handles the given packet for this connection.
		/// </summary>
		/// <param name="packet"></param>
		protected override void OnPacketReceived(Packet packet)
		{
		}

		/// <summary>
		/// Called when the connection was closed.
		/// </summary>
		/// <param name="type"></param>
		protected override void OnClosed(ConnectionCloseType type)
		{
			base.OnClosed(type);
		}
	}
}
