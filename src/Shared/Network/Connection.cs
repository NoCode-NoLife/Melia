using Melia.Shared.Database;
using Melia.Shared.Network.Crypto;
using Melia.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Melia.Shared.Network
{
	public abstract class Connection
	{
		private byte[] _buffer, _backBuffer;
		private Socket _socket;
		private TOSCrypto _crypto;

		/// <summary>
		/// State of the connection.
		/// </summary>
		public ConnectionState State { get; protected set; }

		/// <summary>
		/// Remote address.
		/// </summary>
		public string Address { get; protected set; }

		/// <summary>
		/// Session id for this connection.
		/// </summary>
		public long SessionId { get; set; }

		/// <summary>
		/// Account associated with this connection.
		/// </summary>
		public Account Account { get; set; }

		/// <summary>
		/// Creates new connection.
		/// </summary>
		public Connection()
		{
			_buffer = new byte[1024 * 500];
			_backBuffer = new byte[ushort.MaxValue];
			_crypto = new TOSCrypto();

			this.State = ConnectionState.Connected;
			this.Address = "?:?";
		}

		/// <summary>
		/// Sets connection's socket once.
		/// </summary>
		/// <param name="socket"></param>
		/// <exception cref="InvalidOperationException">Thrown if socket was already set.</exception>
		public void SetSocket(Socket socket)
		{
			if (_socket != null)
				throw new InvalidOperationException("Socket is already set.");

			_socket = socket;
			this.Address = ((IPEndPoint)socket.RemoteEndPoint).Address.ToString();
		}

		/// <summary>
		/// Kills connection.
		/// </summary>
		public void Kill()
		{
			try { _socket.Disconnect(false); }
			catch { }
			try { _socket.Shutdown(SocketShutdown.Both); }
			catch { }
			try { _socket.Close(2); }
			catch { }

			this.State = ConnectionState.Disconnected;

			Log.Info("Killed connection from '{0}'.", this.Address);
		}

		/// <summary>
		/// Starts packet receiving.
		/// </summary>
		public void BeginReceive()
		{
			_socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, OnReceive, null);
		}

		/// <summary>
		/// Called when new data is available from socket.
		/// </summary>
		/// <param name="result"></param>
		private void OnReceive(IAsyncResult result)
		{
			try
			{
				SocketError error;
				var length = _socket.EndReceive(result, out error);
				var read = 0;

				// Client disconnected?
				if (length == 0)
				{
					this.State = ConnectionState.Disconnected;
					Log.Info("Connection closed from '{0}'.", this.Address);
					return;
				}

				// Lost connection?
				if (error != SocketError.Success)
				{
					this.State = ConnectionState.Disconnected;
					Log.Info("Connection lost from '{0}'.", this.Address);
					return;
				}

				while (read < length)
				{
					var packetLength = BitConverter.ToUInt16(_buffer, read);
					if (packetLength > length)
					{
						Log.Debug(BitConverter.ToString(_buffer, read, length - read));
						throw new Exception("Packet length greater than buffer length (" + packetLength + " > " + length + ").");
					}

					// Read packet from buffer
					var packetBuffer = new byte[packetLength];
					Buffer.BlockCopy(_buffer, read + sizeof(short), packetBuffer, 0, packetLength);
					read += sizeof(short) + packetLength;
					_crypto.Decrypt(packetBuffer, 0, packetLength);

					// Debug
					var recvStr = BitConverter.ToString(packetBuffer).Replace("-", " ");
					recvStr = recvStr.Insert(0, "[");
					recvStr = recvStr.Insert(6, "]");
					recvStr = recvStr.Insert(8, "[");
					recvStr = recvStr.Insert(20, "]");
					recvStr = recvStr.Insert(22, "[");
					recvStr = recvStr.Insert(34, "]");
					Log.Debug("Recv: {0}", recvStr);

					// Handle
					var packet = new Packet(packetBuffer);

					// Check size from table?
					var size = Op.GetSize(packet.Op);
					if (size != 0 && packet.Length < size)
					{
						Log.Warning("Invalid packet size for '{0:X4}' ({1} < {2}), from '{3}'. Ignoring packet.", packet.Op, packet.Length, size, this.Address);
					}
					else
					{
						// Check login state
						if (packet.Op != Op.CB_LOGIN && packet.Op != Op.CS_LOGIN && packet.Op != Op.CZ_CONNECT)
						{
							if (this.Account == null)
							{
								Log.Warning("Non-login packet ({0:X4}) sent before being logged in, from '{1}'. Killing connection.", packet.Op, this.Address);
								this.Kill();
								return;
							}
						}

						// Handle
						try
						{
							this.HandlePacket(packet);
						}
						catch (Exception ex)
						{
							Log.Exception(ex, "Error while handling packet '{0:X4}'.", packet.Op);
						}
					}
				}

				this.BeginReceive();
			}
			catch (ObjectDisposedException)
			{
			}
			catch (Exception ex)
			{
				Log.Exception(ex, "Error while reading receiving packet.");
			}
		}

		/// <summary>
		/// Called for every packet that is read from the network stream.
		/// </summary>
		/// <param name="packet"></param>
		protected virtual void HandlePacket(Packet packet)
		{
			Log.Warning("No packet handling.");
		}

		/// <summary>
		/// Sends packet to client.
		/// </summary>
		/// <param name="packet"></param>
		public void Send(Packet packet)
		{
			if (_socket == null || this.State == ConnectionState.Disconnected)
				return;

			// Get size from table
			var size = Op.GetSize(packet.Op);
			if (size == -1)
				throw new ArgumentException("Size for op '" + packet.Op.ToString("X4") + "' unknown.");

			// Calculate length
			var length = (size == 0 ? sizeof(short) + sizeof(int) + sizeof(short) + packet.Length : size);

			// Check table length
			if (size != 0 && length < sizeof(short) + sizeof(int) + packet.Length)
				throw new Exception("Packet is bigger than specified in the packet size table.");

			// Create packet
			var buffer = new byte[length];
			Buffer.BlockCopy(BitConverter.GetBytes((short)packet.Op), 0, buffer, 0, sizeof(short));
			Buffer.BlockCopy(BitConverter.GetBytes(0), 0, buffer, sizeof(short), sizeof(int)); // checksum?

			var offset = 6;
			if (size == 0)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((short)length), 0, buffer, 6, sizeof(short));
				offset += 2;
			}

			packet.Build(ref buffer, offset);

			// Debug
			var sendStr = BitConverter.ToString(buffer).Replace("-", " ");
			sendStr = sendStr.Insert(0, "[");
			sendStr = sendStr.Insert(6, "]");
			sendStr = sendStr.Insert(8, "[");
			sendStr = sendStr.Insert(20, "]");
			if (size == 0)
			{
				sendStr = sendStr.Insert(22, "[");
				sendStr = sendStr.Insert(28, "]");
			}
			Log.Debug("Send: {0}", sendStr);

			//Send
			_socket.Send(buffer);
		}
	}

	public enum ConnectionState
	{
		Disconnected,
		Connected,
	}
}
