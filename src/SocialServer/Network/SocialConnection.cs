using System.Net.Sockets;
using System;
using Melia.Shared.Network;
using Melia.Social.Database;
using Yggdrasil.Logging;
using Yggdrasil.Network.TCP;
using Melia.Social.World;

namespace Melia.Social.Network
{
	/// <summary>
	/// A connection from the client to the social server.
	/// </summary>
	public interface ISocialConnection : IConnection
	{
		/// <summary>
		/// Gets or sets the user associated with the connection.
		/// </summary>
		SocialUser User { get; set; }
	}

	/// <summary>
	/// A connection from the client to the social server.
	/// </summary>
	public class SocialConnection : Connection, ISocialConnection
	{
		protected new readonly TosSocialFramer _framer = new TosSocialFramer(1024 * 50);

		/// <summary>
		/// Gets or sets the user associated with the connection.
		/// </summary>
		public SocialUser User { get; set; }

		/// <summary>
		/// Creates new connection.
		/// </summary>
		public SocialConnection()
		{
			_framer.MessageReceived += this.OnMessageReceived;
		}

		/// <summary>
		/// Called when new data was sent from the client.
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="length"></param>
		protected override void ReceiveData(byte[] buffer, int length)
		{
			_framer.ReceiveData(buffer, length);
		}

		/// <summary>
		/// Called when a full message was received from the client.
		/// </summary>
		/// <param name="buffer"></param>
		protected override void OnMessageReceived(byte[] buffer)
		{
			var packet = new Packet(buffer);

			if (packet.Op != Op.CS_LOGIN && !this.LoggedIn)
			{
				Log.Warning("Non-login packet ({0:X4}) sent before login from '{1}'. Killing connection.", packet.Op, this.Address);
				this.Close();
				return;
			}

			this.OnPacketReceived(packet);
		}

		/// <summary>
		/// Sends packet to client.
		/// </summary>
		/// <param name="packet"></param>
		public new void Send(Packet packet)
		{
			var buffer = _framer.Frame(packet);

			var op = packet.Op;

			var tableSize = Op.GetSize(op);
			if (tableSize != TosSocialFramer.DynamicPacketSize && buffer.Length != tableSize)
			{
				var name = Op.GetName(packet.Op);

				Log.Warning("Connection.Send: Invalid packet size for '{0:X4}' ({1}) ({2} != {3}).", op, name, buffer.Length, tableSize);

				// We can't send a packet that's not the correct size, as
				// that will mess up the data stream, at which point we might
				// as well close the connection. Instead, let's fix the size
				// and hope for the best. The incorrect packet needs to be
				// fixed of course, but at least you're not kicked every
				// time you haven't updated some packet for a new version
				// yet.
				var newBuffer = new byte[tableSize];
				var copySize = Math.Min(buffer.Length, tableSize);
				Buffer.BlockCopy(buffer, 0, newBuffer, 0, copySize);

				buffer = newBuffer;
			}

			try
			{
				this.Send(buffer);
			}
			catch (SocketException)
			{
				this.Close();
			}
		}

		/// <summary>
		/// Handles the given packet for this connection.
		/// </summary>
		/// <param name="packet"></param>
		protected override void OnPacketReceived(Packet packet)
		{
			//Log.Debug("in: " + Environment.NewLine + packet);
			SocialServer.Instance.PacketHandler.Handle(this, packet);
		}

		/// <summary>
		/// Called when the connection was closed.
		/// </summary>
		/// <param name="type"></param>
		protected override void OnClosed(ConnectionCloseType type)
		{
			base.OnClosed(type);

			foreach (var friend in this.User.Friends.GetFriends())
				SocialServer.Instance.Database.SaveFriend(friend);

			SocialServer.Instance.UserManager.Remove(this.User.Id);
		}
	}
}
