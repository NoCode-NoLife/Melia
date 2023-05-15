using System;
using Yggdrasil.Logging;
using Yggdrasil.Network.Framing;

namespace Melia.Shared.Network2
{
	public class TosFramer : IMessageFramer
	{
		public const int DynamicPacketSize = 0;

		private readonly byte[] _headerBuffer;
		private byte[] _messageBuffer;
		private int _bytesReceived, _headerLength;

		/// <summary>
		/// Maximum size of messages.
		/// </summary>
		public int MaxMessageSize { get; }

		/// <summary>
		/// Called every time ReceiveData got a full message.
		/// </summary>
		public event Action<byte[]> MessageReceived;

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="maxMessageSize">Maximum size of messages</param>
		public TosFramer(int maxMessageSize)
		{
			this.MaxMessageSize = maxMessageSize;
			_headerBuffer = new byte[4];
			_headerLength = 2;
		}

		/// <summary>
		/// Wraps message in frame.
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		public byte[] Frame(byte[] message)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		/// Wraps packet body in frame.
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		public byte[] Frame(Packet packet)
		{
			var op = packet.Op;

			// Get size from table
			var tableSize = Op.GetSize(op);
			if (tableSize == -1)
				throw new ArgumentException("Size for op '" + packet.Op.ToString("X4") + "' unknown.");

			// Prior to i174236 packet headers sent from the server to the
			// client were 4 bytes shorter, as they didn't have the part
			// that we call "checksum". Now they all have it. Should this
			// change again at some point, the respective sizeof(int)s need
			// to be removed again.

			// Calculate length
			//var fixHeaderSize = (sizeof(short) + sizeof(int) + sizeof(int) + packet.Length);
			//var dynHeaderSize = (sizeof(short) + sizeof(int) + sizeof(int) + sizeof(short) + packet.Length);
			//var size = (tableSize == DynamicPacketSize ? dynHeaderSize : tableSize);

			int packetSize;

			// Check table length
			if (tableSize == DynamicPacketSize)
			{
				var dynHeaderSize = sizeof(short) + sizeof(int) + sizeof(int) + sizeof(short);
				packetSize = dynHeaderSize + packet.Length;
			}
			else
			{
				var fixHeaderSize = sizeof(short) + sizeof(int) + sizeof(int);
				packetSize = fixHeaderSize + packet.Length;

				// If the packet is bigger than the table size, we'd have
				// to truncate it, messing up the network stream, so let's
				// rather not do that.
				if (packetSize > tableSize)
				{
					Log.Warning("Packet is bigger than specified in the packet size table. (op: {3} ({0:X4}), size: {1}, expected: {2})", op, fixHeaderSize, tableSize, Op.GetName(op));
					throw new Exception("Packet is bigger than specified in the packet size table. (op: {3} ({0:X4}), size: {1}, expected: {2})");
				}

				// If the packet is smaller than the table size we might
				// run into issues with the data, but if just pad it with
				// zeros we can at least still send it and don't have to
				// terminate the connection.
				if (packetSize < tableSize)
				{
					Log.Warning("Packet size doesn't match packet table size. (op: {3} ({0:X4}), size: {1}, expected: {2})", op, fixHeaderSize, tableSize, Op.GetName(op));
					packetSize = tableSize;
				}
			}

			// Create packet
			var buffer = new byte[packetSize];
			Buffer.BlockCopy(BitConverter.GetBytes((short)op), 0, buffer, 0, sizeof(short));
			Buffer.BlockCopy(BitConverter.GetBytes(-1), 0, buffer, sizeof(short), sizeof(int)); // checksum?

			var offset = (sizeof(short) + sizeof(int) + sizeof(int));
			if (tableSize == 0)
			{
				Buffer.BlockCopy(BitConverter.GetBytes((short)packetSize), 0, buffer, offset, sizeof(short));
				offset += sizeof(short);
			}

			packet.Build(ref buffer, offset);

			return buffer;
		}

		/// <summary>
		/// Receives data and calls MessageReceived every time a full message
		/// has arrived.
		/// </summary>
		/// <param name="data">Buffer to read from.</param>
		/// <param name="length">Length of actual information in data.</param>
		/// <exception cref="InvalidMessageSizeException">
		/// Thrown if a message has an invalid size. Should this occur,
		/// the connection should be terminated, because it's not save to
		/// keep receiving anymore.
		/// </exception>
		public void ReceiveData(byte[] data, int length)
		{
			var bytesAvailable = length;
			if (bytesAvailable == 0)
				return;

			for (var i = 0; i < bytesAvailable;)
			{
				if (_messageBuffer == null)
				{
					_headerBuffer[_bytesReceived] = data[i];
					_bytesReceived += 1;
					i += 1;

					// Read header once we got enough bytes and prepare
					// to read the message
					if (_bytesReceived == _headerLength)
					{
						var messageSize = BitConverter.ToUInt16(_headerBuffer, 0);

						if (messageSize < 0 || messageSize > this.MaxMessageSize)
							throw new InvalidMessageSizeException("Invalid size (" + messageSize + ").");

						_messageBuffer = new byte[messageSize];
						_bytesReceived = 0;
					}
				}

				if (_messageBuffer != null)
				{
					// Read as many bytes as we can into the message buffer
					var read = Math.Min(_messageBuffer.Length - _bytesReceived, bytesAvailable - i);
					Buffer.BlockCopy(data, i, _messageBuffer, _bytesReceived, read);

					_bytesReceived += read;
					i += read;

					// Send message once we got all bytes
					if (_bytesReceived == _messageBuffer.Length)
					{
						this.MessageReceived?.Invoke(_messageBuffer);

						_messageBuffer = null;
						_bytesReceived = 0;
					}
				}
			}
		}
	}
}
