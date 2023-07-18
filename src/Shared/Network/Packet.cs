using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;
using Yggdrasil.Util;

namespace Melia.Shared.Network
{
	public class Packet
	{
		private static readonly Encoding DefaultEncoding = Encoding.UTF8;

		private readonly BufferReaderWriter _buffer;
		private readonly int _bodyStart;

		/// <summary>
		/// Returns the length of the packet's buffer.
		/// </summary>
		public int Length => _buffer.Length;

		/// <summary>
		/// Packet's op.
		/// </summary>
		public int Op { get; protected set; }

		/// <summary>
		/// Creates packet from buffer coming from client.
		/// </summary>
		/// <param name="buffer"></param>
		public Packet(byte[] buffer)
		{
			_buffer = new BufferReaderWriter(buffer);
			_buffer.Endianness = Endianness.LittleEndian;

			this.Op = this.GetShort();
			var index = this.GetInt();
			var checksum = this.GetInt();

			// [i339427]
			// Unknown values that appeared in the header of
			// all client packets at some point.
			// Social server packets don't have the extra bin
			// so we can skip reading it.
			if (this.Op < Network.Op.CS_LOGIN)
				this.GetBin(12);

			_bodyStart = _buffer.Index;
		}

		/// <summary>
		/// Creates new packet with given op.
		/// </summary>
		/// <param name="op"></param>
		public Packet(int op)
		{
			this.Op = op;

			_buffer = new BufferReaderWriter();
			_buffer.Endianness = Endianness.LittleEndian;

			_bodyStart = 0;
		}

		/// <summary>
		/// Sets the reading and writing pointer back to the start of
		/// the packet.
		/// </summary>
		public void Rewind()
		{
			_buffer.Seek(_bodyStart, SeekOrigin.Begin);
		}

		/// <summary>
		/// Returns the length of the string when converted to bytes,
		/// as per the packet's encoding for strings.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public int GetByteLength(string val)
			=> DefaultEncoding.GetByteCount(val);

		/// <summary>
		/// Reads byte from buffer.
		/// </summary>
		/// <returns></returns>
		public byte GetByte()
			=> _buffer.ReadByte();

		/// <summary>
		/// Reads byte from buffer and returns it as bool (true != 0).
		/// </summary>
		/// <returns></returns>
		public bool GetBool()
			=> this.GetByte() != 0;

		/// <summary>
		/// Reads short from buffer.
		/// </summary>
		/// <returns></returns>
		public short GetShort()
			=> _buffer.ReadInt16();

		/// <summary>
		/// Reads int from buffer.
		/// </summary>
		/// <returns></returns>
		public int GetInt()
			=> _buffer.ReadInt32();

		/// <summary>
		/// Reads long from buffer.
		/// </summary>
		/// <returns></returns>
		public long GetLong()
			=> _buffer.ReadInt64();

		/// <summary>
		/// Reads float from buffer.
		/// </summary>
		/// <returns></returns>
		public float GetFloat()
			=> _buffer.ReadFloat();

		/// <summary>
		/// Reads given number of bytes from buffer and returns them as
		/// UTF8 string. Stops reading at the first null-byte.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetString(int length)
		{
			var bytes = _buffer.Read(length);
			var val = DefaultEncoding.GetString(bytes);

			// Relatively fast way to get rid of null bytes.
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
			var length = this.GetShort();
			return this.GetString(length);
		}

		/// <summary>
		/// Reads null-terminated string from buffer and returns it as UTF8.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetString()
		{
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
			=> DateTime.FromFileTime(this.GetLong());

		/// <summary>
		/// Reads struct from buffer.
		/// </summary>
		/// <typeparam name="TStruct"></typeparam>
		/// <returns></returns>
		//public TStruct GetStruct<TStruct>() where TStruct : new()
		//{
		//	var type = typeof(TStruct);
		//	if (!type.IsValueType || type.IsPrimitive)
		//		throw new Exception("GetObj can only marshal to structs.");

		//	var size = Marshal.SizeOf(typeof(TStruct));
		//	var buffer = this.GetBin(size);

		//	var intPtr = Marshal.AllocHGlobal(buffer.Length);
		//	Marshal.Copy(buffer, 0, intPtr, buffer.Length);
		//	var val = Marshal.PtrToStructure(intPtr, typeof(TStruct));
		//	Marshal.FreeHGlobal(intPtr);

		//	return (TStruct)val;
		//}

		/// <summary>
		/// Reads given amount of bytes from buffer.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public byte[] GetBin(int length)
			=> _buffer.Read(length);

		/// <summary>
		/// Reads given amount of bytes from buffer and returns them as hex string.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetBinAsHex(int length)
			=> Hex.ToString(this.GetBin(length), HexStringOptions.None);

		/// <summary>
		/// Reads a binary value from packet, decompresses it, and returns it.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public byte[] GetCompressedBin(int length)
		{
			var buffer = this.GetBin(length);

			using (var msIn = new MemoryStream(buffer))
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
			=> _buffer.WriteByte(val);

		/// <summary>
		/// Writes value as byte (0|1) to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutByte(bool val)
			=> this.PutByte(val ? (byte)1 : (byte)0);

		/// <summary>
		/// Writes short to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutShort(int val)
			=> _buffer.WriteInt16((short)val);

		/// <summary>
		/// Writes int to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutInt(int val)
			=> _buffer.WriteInt32(val);

		/// <summary>
		/// Writes uint to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutUInt(uint val)
			=> this.PutInt((int)val);

		/// <summary>
		/// Writes long to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutLong(long val)
			=> _buffer.WriteInt64(val);

		/// <summary>
		/// Writes float to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutFloat(float val)
			=> _buffer.WriteFloat(val);

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
			if (val == null)
				val = "";

			// Append terminator
			if (val == "" || (val.Length > 0 && val[val.Length - 1] != '\0'))
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
			if (val == null)
				val = "";

			// Append terminator
			if (val == "" || (val.Length > 0 && val[val.Length - 1] != '\0'))
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
			=> _buffer.Write(val);

		/// <summary>
		/// Writes bytes parsed from given hex string to buffer.
		/// </summary>
		/// <param name="hex"></param>
		public void PutBinFromHex(string hex)
		{
			if (hex == null)
				throw new ArgumentNullException("hex");

			var bytes = Hex.ToByteArray(hex);
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes the given amount of bytes to the buffer.
		/// </summary>
		/// <param name="amount"></param>
		public void PutEmptyBin(int amount)
		{
			if (amount <= 0)
				return;

			this.PutBin(new byte[amount]);
		}

		/// <summary>
		/// Writes struct to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutBin(object val)
		{
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
			=> this.PutLong(val.ToFileTime());

		/// <summary>
		/// Convert DateTime to a series of shorts
		/// </summary>
		/// <param name="dateTime"></param>
		public void PutShortDate(DateTime dateTime)
		{
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
				var zlibPacket = new Packet(this.Op);
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
			var subPacket = new Packet(this.Op);
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
			var compressed = this.GetBin(compressedSize);

			byte[] uncompressed;
			using (var msIn = new MemoryStream(compressed))
			using (var msOut = new MemoryStream())
			{
				using (var ds = new DeflateStream(msIn, CompressionMode.Decompress))
					ds.CopyTo(msOut);

				uncompressed = msOut.ToArray();
			}

			var packet = new Packet(this.Op);
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
			=> _buffer.CopyTo(buffer, offset);

		/// <summary>
		/// Returns buffer as formatted hex string.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
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
}
