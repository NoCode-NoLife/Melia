using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using Melia.Shared.Network.Crypto;
using Yggdrasil.Logging;
using Yggdrasil.Network.TCP;

namespace Melia.Shared.Network
{
	/// <summary>
	/// A connection from the client to the server.
	/// </summary>
	public interface IConnection
	{
		/// <summary>
		/// Gets or sets whether the player authenticated themselves.
		/// </summary>
		bool LoggedIn { get; set; }

		/// <summary>
		/// Gets or sets the session key associated with the connection.
		/// </summary>
		string SessionKey { get; }

		/// <summary>
		/// Sends packet to client.
		/// </summary>
		/// <param name="packet"></param>
		void Send(Packet packet);

		/// <summary>
		/// Closes connection to client.
		/// </summary>
		void Close();

		/// <summary>
		/// Closes the connection after the given amount of milliseconds.
		/// </summary>
		/// <remarks>
		/// This gives the client time to, for example, display login
		/// error messages before the connection is closed and the
		/// messages get lost.
		/// </remarks>
		/// <param name="milliseconds"></param>
		void Close(int milliseconds);
	}

	/// <summary>
	/// A connection from the client to the server.
	/// </summary>
	public abstract class Connection : TcpConnection, IConnection
	{
		protected readonly TosFramer _framer = new(1024 * 50);
		protected readonly Codec _crypto = new();

		/// <summary>
		/// Gets or sets whether the player authenticated themselves.
		/// </summary>
		public bool LoggedIn { get; set; }

		/// <summary>
		/// Gets or sets the session key associated with the connection.
		/// </summary>
		public string SessionKey { get; }

		/// <summary>
		/// Creates new connection.
		/// </summary>
		public Connection()
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
		protected virtual void OnMessageReceived(byte[] buffer)
		{
			_crypto.Decrypt(buffer, 0, buffer.Length);

			var packet = new Packet(buffer);

			// Check login state
			if (packet.Op != Op.CB_LOGIN && packet.Op != Op.CB_LOGIN_BY_PASSPORT && packet.Op != Op.CS_LOGIN && packet.Op != Op.CZ_CONNECT)
			{
				if (!this.LoggedIn)
				{
					Log.Warning("Non-login packet ({0:X4}) sent before login from '{1}'. Killing connection.", packet.Op, this.Address);
					this.Close();
					return;
				}
			}

			this.OnPacketReceived(packet);
		}

		/// <summary>
		/// Called when a packet was received from the client.
		/// </summary>
		/// <param name="packet"></param>
		protected abstract void OnPacketReceived(Packet packet);

		/// <summary>
		/// Sends packet to client.
		/// </summary>
		/// <param name="packet"></param>
		public void Send(Packet packet)
		{
			var buffer = _framer.Frame(packet);

			var op = packet.Op;

			var tableSize = Op.GetSize(op);
			if (tableSize != TosFramer.DynamicPacketSize && buffer.Length != tableSize)
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
		/// Called when an exception occurred while reading data from
		/// the TCP stream.
		/// </summary>
		/// <param name="ex"></param>
		protected override void OnReceiveException(Exception ex)
		{
			Log.Error("Error while receiving data: {0}", ex);
		}

		/// <summary>
		/// Called when the connection was closed.
		/// </summary>
		/// <param name="type"></param>
		protected override void OnClosed(ConnectionCloseType type)
		{
			switch (type)
			{
				case ConnectionCloseType.Disconnected: Log.Info("Connection from '{0}' was closed by the client.", this.Address); break;
				case ConnectionCloseType.Closed: Log.Info("Connection to '{0}' was closed by the server.", this.Address); break;
				case ConnectionCloseType.Lost: Log.Info("Lost connection from '{0}'.", this.Address); break;
			}
		}

		/// <summary>
		/// Closes the connection after the given amount of milliseconds.
		/// </summary>
		/// <remarks>
		/// This gives the client time to, for example, display login
		/// error messages before the connection is closed and the
		/// messages get lost.
		/// </remarks>
		/// <param name="milliseconds"></param>
		public async void Close(int milliseconds)
		{
			await Task.Delay(milliseconds);
			this.Close();
		}
	}
}
