using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Extensions.ObjectPool;
using Yggdrasil.Util;

namespace Melia.Shared.Network
{
	/// <summary>
	/// A packet reader/writer for composing or reading data sent between
	/// client and server.
	/// </summary>
	public class Packet : IDisposable
	{
		private static readonly ObjectPool<Packet> Pool = new DefaultObjectPool<Packet>(new PacketPoolPolicy(), 5000);

		private class PacketPoolPolicy : IPooledObjectPolicy<Packet>
		{
			public Packet Create()
			{
				return new Packet();
			}

			public bool Return(Packet packet)
			{
				// The vast majority of packets are small and we shouldn't
				// need larger ones on constant standby.
				if (packet._buffer.Length >= 1024)
				{
					packet._buffer.Dispose();
					return false;
				}

				packet.Reset();
				return true;
			}
		}

		private static readonly Encoding DefaultEncoding = Encoding.UTF8;

		private BufferReaderWriter _buffer;
		private int _bodyStart;
		private bool _disposed;

		/// <summary>
		/// Returns the length of the packet's buffer.
		/// </summary>
		public int Length => _buffer.Length;

		/// <summary>
		/// Packet's op.
		/// </summary>
		public int Op { get; protected set; }

		/// <summary>
		/// Creates a new instance. Used only internally for the object
		/// pool, use <see cref="Packet.Rent"/> to get a packet instance.
		/// </summary>
		private Packet()
		{
		}

		/// <summary>
		/// Returns a packet instance from the internal pool for the given
		/// op, ready to be written to.
		/// </summary>
		/// <param name="op"></param>
		/// <returns></returns>
		public static Packet Rent(int op)
		{
			var packet = Pool.Get();
			packet._disposed = false;

			if (packet._buffer == null)
			{
				packet._buffer = new BufferReaderWriter(BufferReaderWriter.DefaultSize);
				packet._buffer.Endianness = Endianness.LittleEndian;
			}
			else
			{
				packet._buffer.Reuse(BufferReaderWriter.DefaultSize);
			}

			packet.Op = op;
			packet._bodyStart = 0;

			return packet;
		}

		/// <summary>
		/// Returns a packet instance from the internal pool for the given
		/// buffer, ready to be read from.
		/// </summary>
		/// <param name="buffer"></param>
		/// <returns></returns>
		public static Packet Rent(byte[] buffer)
		{
			var packet = Pool.Get();
			packet._disposed = false;

			if (packet._buffer == null)
			{
				packet._buffer = new BufferReaderWriter(buffer);
				packet._buffer.Endianness = Endianness.LittleEndian;
			}
			else
			{
				packet._buffer.Reuse(buffer);
			}

			packet.Op = packet.GetShort();
			var index = packet.GetInt();
			var checksum = packet.GetInt();

			// [i339427]
			// Unknown values that appeared in the header of
			// all client packets at some point.
			// Social server packets don't have the extra bin
			// so we can skip reading it.
			if (packet.Op < Network.Op.CS_LOGIN)
				packet.GetBin(12);

			packet._bodyStart = packet._buffer.Index;

			return packet;
		}

		/// <summary>
		/// Disposes the packet, returning it to the internal pool.
		/// </summary>
		public void Dispose()
		{
			if (_disposed)
				return;

			_disposed = true;
			Pool.Return(this);
		}

		/// <summary>
		/// Throws an exception if the packet has been disposed.
		/// </summary>
		/// <exception cref="ObjectDisposedException"></exception>
		private void AssertNotDisposed()
		{
			if (_disposed)
				throw new PacketDisposedException(this);
		}

		/// <summary>
		/// Resets the packet's state, preparing it for reuse.
		/// </summary>
		private void Reset()
		{
			this.Op = 0;
		}

		/// <summary>
		/// Sets the reading and writing pointer back to the start of
		/// the packet.
		/// </summary>
		public void Rewind()
		{
			this.AssertNotDisposed();
			_buffer.Seek(_bodyStart, SeekOrigin.Begin);
		}

		/// <summary>
		/// Returns the length of the string when converted to bytes,
		/// as per the packet's encoding for strings.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public int GetByteLength(string val)
		{
			this.AssertNotDisposed();
			return DefaultEncoding.GetByteCount(val);
		}

		/// <summary>
		/// Reads byte from buffer.
		/// </summary>
		/// <returns></returns>
		public byte GetByte()
		{
			this.AssertNotDisposed();
			return _buffer.ReadByte();
		}

		/// <summary>
		/// Reads byte from buffer and returns it as bool (true != 0).
		/// </summary>
		/// <returns></returns>
		public bool GetBool()
		{
			this.AssertNotDisposed();
			return this.GetByte() != 0;
		}

		/// <summary>
		/// Reads short from buffer.
		/// </summary>
		/// <returns></returns>
		public short GetShort()
		{
			this.AssertNotDisposed();
			return _buffer.ReadInt16();
		}

		/// <summary>
		/// Reads int from buffer.
		/// </summary>
		/// <returns></returns>
		public int GetInt()
		{
			this.AssertNotDisposed();
			return _buffer.ReadInt32();
		}

		/// <summary>
		/// Reads unsigned int from buffer.
		/// </summary>
		/// <returns></returns>
		public uint GetUInt()
		{
			this.AssertNotDisposed();
			return _buffer.ReadUInt32();
		}

		/// <summary>
		/// Reads long from buffer.
		/// </summary>
		/// <returns></returns>
		public long GetLong()
		{
			this.AssertNotDisposed();
			return _buffer.ReadInt64();
		}

		/// <summary>
		/// Reads float from buffer.
		/// </summary>
		/// <returns></returns>
		public float GetFloat()
		{
			this.AssertNotDisposed();
			return _buffer.ReadFloat();
		}

		/// <summary>
		/// Reads given number of bytes from buffer and returns them as
		/// UTF8 string. Stops reading at the first null-byte.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetString(int length)
		{
			this.AssertNotDisposed();

			var bytes = _buffer.ReadAsSpan(length);
			var val = DefaultEncoding.GetString(bytes);

			// Relatively fast way to get rid of null bytes
			var nullIndex = val.IndexOf((char)0);
			if (nullIndex != -1)
				val = val.Substring(0, nullIndex);

			return val;
		}

		/// <summary>
		/// Reads length-prefixed string from buffer and returns it as
		/// UTF8 string.
		/// </summary>
		/// <returns></returns>
		public string GetLpString()
		{
			this.AssertNotDisposed();

			var length = this.GetShort();
			return this.GetString(length);
		}

		/// <summary>
		/// Reads null-terminated string from buffer and returns it as UTF8.
		/// </summary>
		/// <returns></returns>
		public string GetString()
		{
			this.AssertNotDisposed();

			var index = _buffer.IndexOf(0);
			if (index == -1)
				throw new Exception("String not null-terminated.");

			var len = index - _buffer.Index;
			var val = this.GetString(len);

			// Skip null-terminator
			_buffer.Seek(1, SeekOrigin.Current);

			return val;
		}

		/// <summary>
		/// Reads FileTime from buffer, 8 byte representation.
		/// </summary>
		/// <returns>DateTime</returns>
		public DateTime GetDate()
		{
			this.AssertNotDisposed();
			return DateTime.FromFileTime(this.GetLong());
		}

		/// <summary>
		/// Reads given amount of bytes from buffer.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public byte[] GetBin(int length)
		{
			this.AssertNotDisposed();
			return _buffer.Read(length);
		}

		/// <summary>
		/// Reads given amount of bytes from buffer and returns them as
		/// hex string.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetBinAsHex(int length)
		{
			this.AssertNotDisposed();

			var bytes = _buffer.ReadAsSpan(length);
			var hex = Hex.ToString(bytes, HexStringOptions.None);

			return hex;
		}

		/// <summary>
		/// Reads a binary value from packet, decompresses it, and returns
		/// it.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public byte[] GetCompressedBin(int length)
		{
			this.AssertNotDisposed();

			var bytes = _buffer.Read(length);

			using (var msIn = new MemoryStream(bytes))
			using (var msOut = new MemoryStream())
			{
				using (var ds = new DeflateStream(msIn, CompressionMode.Decompress))
					ds.CopyTo(msOut);

				return msOut.ToArray();
			}
		}

		/// <summary>
		/// Reads the given number of values from the packet using the
		/// getter function and returns them as an array.
		/// </summary>
		/// <typeparam name="TListItem"></typeparam>
		/// <param name="count"></param>
		/// <param name="getter"></param>
		/// <returns></returns>
		public TListItem[] GetList<TListItem>(int count, Func<TListItem> getter)
		{
			this.AssertNotDisposed();

			var result = new TListItem[count];

			for (var i = 0; i < count; i++)
				result[i] = getter();

			return result;
		}

		/// <summary>
		/// Writes byte to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutByte(byte val)
		{
			this.AssertNotDisposed();
			_buffer.WriteByte(val);
		}

		/// <summary>
		/// Writes value as byte (0|1) to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutByte(bool val)
		{
			this.AssertNotDisposed();
			this.PutByte(val ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Writes short to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutShort(int val)
		{
			this.AssertNotDisposed();
			_buffer.WriteInt16((short)val);
		}

		/// <summary>
		/// Writes int to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutInt(int val)
		{
			this.AssertNotDisposed();
			_buffer.WriteInt32(val);
		}

		/// <summary>
		/// Writes uint to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutUInt(uint val)
		{
			this.AssertNotDisposed();
			_buffer.WriteUInt32(val);
		}

		/// <summary>
		/// Writes long to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutLong(long val)
		{
			this.AssertNotDisposed();
			_buffer.WriteInt64(val);
		}

		/// <summary>
		/// Writes float to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutFloat(float val)
		{
			this.AssertNotDisposed();
			_buffer.WriteFloat(val);
		}

		/// <summary>
		/// Writes double to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutDouble(double val)
		{
			this.AssertNotDisposed();
			_buffer.WriteDouble(val);
		}

		/// <summary>
		/// Writes fixed-sized string to packet, padding it with zeroes
		/// to reach the given byte length.
		/// </summary>
		/// <remarks>
		/// Commonly used for fixed-sized strings as used in C.
		/// For example: char teamName[64].
		/// </remarks>
		/// <example>
		/// packet.PutString("foo", 6); // 66 6F 6F 00 00 00
		/// packet.PutString("foo", 4); // 66 6F 6F 00
		/// packet.PutString("foo", 3); // 66 6F 6F
		/// packet.PutString("foo", 2); // Error, 2 < "foo".Length
		/// </example>
		/// <param name="val">The string to write to the packet.</param>
		/// <param name="byteLength">
		/// The number of writes that will be written into the packet,
		/// starting with the string and padded with zeroes.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Thrown if the byte length is less than the string length.
		/// </exception>
		public void PutString(string val, int byteLength)
		{
			this.AssertNotDisposed();

			var bytes = DefaultEncoding.GetBytes(val ?? "");

			if (bytes.Length > byteLength)
				throw new ArgumentException($"Byte length of string ({bytes.Length}) is longer than given length ({byteLength}).");

			var writeLength = Math.Min(bytes.Length, byteLength);
			var paddingLength = byteLength - writeLength;

			_buffer.Write(bytes, 0, writeLength);

			for (var i = 0; i < paddingLength; ++i)
				_buffer.WriteByte(0);
		}

		/// <summary>
		/// Writes null-terminated string to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutString(string val)
		{
			this.AssertNotDisposed();

			if (val == null)
				val = "";

			// Append terminator
			if (val == "" || (val.Length > 0 && val[^1] != '\0'))
				val += '\0';

			var bytes = DefaultEncoding.GetBytes(val);
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes raw string to buffer, without null terminator or
		/// length prefix.
		/// </summary>
		/// <param name="val"></param>
		public void PutRawString(string val)
		{
			this.AssertNotDisposed();

			var bytes = DefaultEncoding.GetBytes(val ?? "");
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes string to buffer, incl. null terminator, and prefixed
		/// with a short specifiying the string's byte length.
		/// </summary>
		/// <param name="val"></param>
		public void PutLpString(string val)
		{
			this.AssertNotDisposed();

			if (val == null)
				val = "";

			// Append terminator
			if (val == "" || (val.Length > 0 && val[^1] != '\0'))
				val += '\0';

			var bytes = DefaultEncoding.GetBytes(val);
			this.PutShort(bytes.Length);
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes bytes to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutBin(params byte[] val)
		{
			this.AssertNotDisposed();
			_buffer.Write(val);
		}

		/// <summary>
		/// Writes bytes parsed from given hex string to buffer.
		/// </summary>
		/// <param name="hex"></param>
		public void PutBinFromHex(string hex)
		{
			this.AssertNotDisposed();

			if (hex == null)
				throw new ArgumentNullException(nameof(hex));

			var bytes = Hex.ToByteArray(hex);
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes the given amount of bytes to the buffer.
		/// </summary>
		/// <param name="amount"></param>
		public void PutEmptyBin(int amount)
		{
			this.AssertNotDisposed();

			if (amount <= 0)
				return;

			for (var i = 0; i < amount; i++)
				_buffer.WriteByte(0);
		}

		/// <summary>
		/// Adds the given number of empty bytes to the packet.
		/// </summary>
		/// <remarks>
		/// Effectively the same as PutEmptyBin, but specifically for known
		/// gaps in packets.
		/// </remarks>
		/// <param name="amount"></param>
		public void PutGap(int amount)
		{
			this.AssertNotDisposed();
			this.PutEmptyBin(amount);
		}

		/// <summary>
		/// Writes struct to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutBin(object val)
		{
			this.AssertNotDisposed();

			var type = val.GetType();
			if (!type.IsValueType || type.IsPrimitive)
				throw new Exception("PutBin only takes byte[] and structs.");

			var size = Marshal.SizeOf(val);
			var arr = new byte[size];
			var ptr = Marshal.AllocHGlobal(size);

			Marshal.StructureToPtr(val, ptr, true);
			Marshal.Copy(ptr, arr, 0, size);
			Marshal.FreeHGlobal(ptr);

			this.PutBin(arr);
		}

		/// <summary>
		/// Writes DateTime to buffer as a long.
		/// </summary>
		/// <param name="val"></param>
		public void PutDate(DateTime val)
		{
			this.AssertNotDisposed();
			this.PutLong(val.ToFileTime());
		}

		/// <summary>
		/// Writes date into packet as a series of shorts.
		/// </summary>
		/// <param name="dateTime"></param>
		public void PutShortDate(DateTime dateTime)
		{
			this.AssertNotDisposed();

			this.PutShort(dateTime.Year);
			this.PutShort(dateTime.Month);
			this.PutShort((short)dateTime.DayOfWeek);
			this.PutShort(dateTime.Day);
			this.PutShort(dateTime.Hour);
			this.PutShort(dateTime.Minute);
			this.PutShort(dateTime.Second);
			this.PutShort(dateTime.Millisecond);
		}

		/// <summary>
		/// Compresses value and write it to packet, prefixed with its
		/// length as an int.
		/// </summary>
		/// <param name="value">Byte array to put into packet.</param>
		/// <param name="length">Number of bytes to use from the array.</param>
		public void PutCompressedBin(byte[] value, int length)
		{
			this.AssertNotDisposed();

			using (var ms = new MemoryStream())
			{
				using (var ds = new DeflateStream(ms, CompressionMode.Compress))
					ds.Write(value, 0, length);

				var compressed = ms.ToArray();

				this.PutInt(compressed.Length);
				this.PutBin(compressed);
			}
		}

		/// <summary>
		/// Provides a packet to write values to with a callback function,
		/// which is afterwards (optionally) compressed and written
		/// to this packet as a binary value, prefixed with a length
		/// and a header.
		/// </summary>
		/// <param name="compress"></param>
		/// <param name="zlibPacketFunc"></param>
		public void Zlib(bool compress, Action<Packet> zlibPacketFunc)
		{
			this.AssertNotDisposed();

			// If uncompressed, empty zlib header, followed by the raw data.
			if (compress == false)
			{
				this.PutShort(0);
				zlibPacketFunc(this);
			}
			// If compressed, write data into a new, temporary packet,
			// and then write the data from that packet into this one,
			// after compressing it.
			else
			{
				using var zlibPacket = Packet.Rent(this.Op);
				zlibPacketFunc(zlibPacket);

				var buffer = zlibPacket._buffer.Copy();
				var len = zlibPacket.Length;

				this.PutShort(0xFA8D); // zlib header
				this.PutCompressedBin(buffer, len);
			}
		}

		/// <summary>
		/// Calls the given callback to write data into a temporary
		/// packet and returns the written data in compressed form.
		/// </summary>
		/// <param name="packetFunc"></param>
		/// <returns></returns>
		public byte[] CompressData(Action<Packet> packetFunc)
		{
			this.AssertNotDisposed();

			using var subPacket = Packet.Rent(this.Op);
			packetFunc(subPacket);

			var buffer = subPacket._buffer.Copy();

			using (var ms = new MemoryStream())
			{
				using (var ds = new DeflateStream(ms, CompressionMode.Compress))
					ds.Write(buffer, 0, buffer.Length);

				var compressed = ms.ToArray();
				return compressed;
			}
		}

		/// <summary>
		/// Reads the given amount of bytes from the packet, uncompresses
		/// them, and adds the data to a temporary packet that is passed
		/// to the call-back to read the data.
		/// </summary>
		/// <param name="compressedSize"></param>
		/// <param name="packetFunc"></param>
		public void UncompressData(int compressedSize, Action<Packet> packetFunc)
		{
			this.AssertNotDisposed();

			var compressed = this.GetBin(compressedSize);

			byte[] uncompressed;
			using (var msIn = new MemoryStream(compressed))
			using (var msOut = new MemoryStream())
			{
				using (var ds = new DeflateStream(msIn, CompressionMode.Decompress))
					ds.CopyTo(msOut);

				uncompressed = msOut.ToArray();
			}

			using var packet = Packet.Rent(this.Op);
			packet.PutBin(uncompressed);
			packet.Rewind();

			packetFunc(packet);
		}

		/// <summary>
		/// Builds the packet and returns it.
		/// </summary>
		/// <returns></returns>
		public byte[] Build()
		{
			this.AssertNotDisposed();

			var buffer = new byte[this.Length];
			this.Build(ref buffer, 0);

			return buffer;
		}

		/// <summary>
		/// Copies packet's body to given buffer at offset.
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="offset"></param>
		/// <returns></returns>
		public void Build(ref byte[] buffer, int offset)
		{
			this.AssertNotDisposed();
			_buffer.CopyTo(buffer, offset);
		}

		/// <summary>
		/// Returns buffer as formatted hex string.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			this.AssertNotDisposed();

			var sb = new StringBuilder();
			var buffer = _buffer.Copy();
			var length = this.Length;
			var tableSize = Network.Op.GetSize(this.Op);
			var opName = Network.Op.GetName(this.Op);
			var spacer = "".PadLeft(78, '-');

			sb.AppendLine(spacer);
			sb.AppendFormat("Op: {0:X4} {1}, Size: {2}", this.Op, opName, length);
			if (tableSize != 0)
				sb.AppendFormat(" (Table: {0}, Garbage: {1})", tableSize, length - tableSize);
			sb.AppendLine();
			sb.AppendLine(spacer);

			sb.AppendLine(Hex.ToString(buffer, HexStringOptions.HexEditor));

			sb.AppendLine(spacer);

			return sb.ToString().Trim();
		}
	}

	/// <summary>
	/// Custom exception for disposed packets.
	/// </summary>
	/// <remarks>
	/// This exception is thrown when an operation is attempted on a
	/// packet that has already been disposed. It's important for us to
	/// distinguish this from a regular ObjectDisposedException, because
	/// ObjectDisposedException will be thrown and swallowed by the
	/// network handling in certain circumstances.
	/// </remarks>
	public class PacketDisposedException : Exception
	{
		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="obj"></param>
		public PacketDisposedException(object obj)
			: base($"Packet '{obj}' has been disposed and cannot be used.")
		{
		}

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="message"></param>
		public PacketDisposedException(string message) : base(message)
		{
		}
	}
}
