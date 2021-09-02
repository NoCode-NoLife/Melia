﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace Melia.Shared.Network
{
	public class Packet
	{
		private const int DefaultSize = 1024;

		private byte[] _buffer;
		private int _ptr;
		//private Packet _zlibPacket;
		//private ZlibMode _zlibMode;

		/// <summary>
		/// Length of the packet.
		/// </summary>
		public int Length { get; protected set; }

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
			_buffer = buffer;

			this.Length = buffer.Length;
			this.Op = this.GetShort();
			var index = this.GetInt();
			var checksum = this.GetInt();
		}

		/// <summary>
		/// Creates new packet with given op.
		/// </summary>
		/// <param name="op"></param>
		public Packet(int op)
		{
			_buffer = new byte[DefaultSize];
			this.Op = op;
		}

		/// <summary>
		/// Throws if not enough bytes are left to read a value with the given length.
		/// </summary>
		/// <param name="needed"></param>
		/// <returns></returns>
		private void AssertGotEnough(int needed)
		{
			if (_ptr + needed > this.Length)
				throw new InvalidOperationException("Not enough bytes left to read a '" + needed + "' byte value.");
		}

		/// <summary>
		/// Increases buffer size if more space is needed to fit the given
		/// amount of bytes.
		/// </summary>
		/// <param name="needed"></param>
		private void EnsureSpace(int needed)
		{
			if (_ptr + needed > this.Length)
				Array.Resize(ref _buffer, _buffer.Length + DefaultSize);
		}

		/// <summary>
		/// Reads byte from buffer.
		/// </summary>
		/// <returns></returns>
		public byte GetByte()
		{
			this.AssertGotEnough(1);

			var val = _buffer[_ptr];
			_ptr += sizeof(byte);

			return val;
		}

		/// <summary>
		/// Reads byte from buffer and returns it as bool (true != 0).
		/// </summary>
		/// <returns></returns>
		public bool GetBool()
		{
			return (this.GetByte() != 0);
		}

		/// <summary>
		/// Reads short from buffer.
		/// </summary>
		/// <returns></returns>
		public short GetShort()
		{
			this.AssertGotEnough(2);

			var val = BitConverter.ToInt16(_buffer, _ptr);
			_ptr += sizeof(short);

			return val;
		}

		/// <summary>
		/// Reads int from buffer.
		/// </summary>
		/// <returns></returns>
		public int GetInt()
		{
			this.AssertGotEnough(4);

			var val = BitConverter.ToInt32(_buffer, _ptr);
			_ptr += sizeof(int);

			return val;
		}

		/// <summary>
		/// Reads long from buffer.
		/// </summary>
		/// <returns></returns>
		public long GetLong()
		{
			this.AssertGotEnough(8);

			var val = BitConverter.ToInt64(_buffer, _ptr);
			_ptr += sizeof(long);

			return val;
		}

		/// <summary>
		/// Reads float from buffer.
		/// </summary>
		/// <returns></returns>
		public float GetFloat()
		{
			this.AssertGotEnough(4);

			var val = BitConverter.ToSingle(_buffer, _ptr);
			_ptr += sizeof(float);

			return val;
		}

		/// <summary>
		/// Reads given number of bytes from buffer and returns them as
		/// UTF8 string. Stops reading at the first null-byte.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetString(int length)
		{
			this.AssertGotEnough(length);

			var val = Encoding.UTF8.GetString(_buffer, _ptr, length);

			// Relatively fast way to get rid of null bytes.
			var nullIndex = val.IndexOf((char)0);
			if (nullIndex != -1)
				val = val.Substring(0, nullIndex);

			_ptr += length;

			return val;
		}

		/// <summary>
		/// Reads length-prefixed string from buffer and returns it as
		/// UTF8 string.
		/// </summary>
		/// <returns></returns>
		public string GetLpString()
		{
			this.AssertGotEnough(sizeof(short));

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
			for (var i = _ptr; i < _buffer.Length; ++i)
			{
				if (_buffer[i] == 0)
				{
					var val = Encoding.UTF8.GetString(_buffer, _ptr, i - _ptr);
					_ptr += val.Length + 1;
					return val;
				}
			}

			throw new Exception("String not null-terminated.");
		}

		/// <summary>
		/// Reads FileTime from buffer, 8 byte representation.
		/// </summary>
		/// <returns>DateTime</returns>
		public DateTime GetDate()
		{
			return DateTime.FromFileTime(this.GetLong());
		}

		/// <summary>
		/// Reads struct from buffer.
		/// </summary>
		/// <typeparam name="TStruct"></typeparam>
		/// <returns></returns>
		public TStruct GetStruct<TStruct>() where TStruct : new()
		{
			var type = typeof(TStruct);
			if (!type.IsValueType || type.IsPrimitive)
				throw new Exception("GetObj can only marshal to structs.");

			var size = Marshal.SizeOf(typeof(TStruct));
			var buffer = this.GetBin(size);

			var intPtr = Marshal.AllocHGlobal(buffer.Length);
			Marshal.Copy(buffer, 0, intPtr, buffer.Length);
			var val = Marshal.PtrToStructure(intPtr, typeof(TStruct));
			Marshal.FreeHGlobal(intPtr);

			return (TStruct)val;
		}

		/// <summary>
		/// Reads given amount of bytes from buffer.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public byte[] GetBin(int length)
		{
			this.AssertGotEnough(length);

			var val = new byte[length];
			Buffer.BlockCopy(_buffer, _ptr, val, 0, length);
			_ptr += length;

			return val;
		}

		/// <summary>
		/// Reads given amount of bytes from buffer and returns them as hex string.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetBinAsHex(int length)
		{
			return BitConverter.ToString(this.GetBin(length)).ToString().Replace("-", "").ToUpper();
		}

		/// <summary>
		/// Writes byte to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutByte(byte val)
		{
			this.EnsureSpace(1);

			_buffer[_ptr++] = (byte)(val);
			this.Length += sizeof(byte);
		}

		/// <summary>
		/// Writes value as byte (0|1) to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutByte(bool val)
		{
			this.PutByte(val ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Writes short to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutShort(int val)
		{
			this.EnsureSpace(2);

			_buffer[_ptr++] = (byte)(val >> (8 * 0));
			_buffer[_ptr++] = (byte)(val >> (8 * 1));
			this.Length += sizeof(short);
		}

		/// <summary>
		/// Writes int to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutInt(int val)
		{
			this.EnsureSpace(4);

			_buffer[_ptr++] = (byte)(val >> (8 * 0));
			_buffer[_ptr++] = (byte)(val >> (8 * 1));
			_buffer[_ptr++] = (byte)(val >> (8 * 2));
			_buffer[_ptr++] = (byte)(val >> (8 * 3));
			this.Length += sizeof(int);
		}

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
		{
			this.EnsureSpace(8);

			_buffer[_ptr++] = (byte)(val >> (8 * 0));
			_buffer[_ptr++] = (byte)(val >> (8 * 1));
			_buffer[_ptr++] = (byte)(val >> (8 * 2));
			_buffer[_ptr++] = (byte)(val >> (8 * 3));
			_buffer[_ptr++] = (byte)(val >> (8 * 4));
			_buffer[_ptr++] = (byte)(val >> (8 * 5));
			_buffer[_ptr++] = (byte)(val >> (8 * 6));
			_buffer[_ptr++] = (byte)(val >> (8 * 7));
			this.Length += sizeof(long);
		}

		/// <summary>
		/// Writes float to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutFloat(float val)
		{
			this.EnsureSpace(4);

			var bVal = BitConverter.GetBytes(val);
			_buffer[_ptr++] = bVal[0];
			_buffer[_ptr++] = bVal[1];
			_buffer[_ptr++] = bVal[2];
			_buffer[_ptr++] = bVal[3];
			this.Length += sizeof(float);
		}

		/// <summary>
		/// Writes string of given length to buffer.
		/// </summary>
		/// <remarks>
		/// If length is greater than string's length it's filled with null bytes.
		/// </remarks>
		/// <param name="val"></param>
		/// <param name="length"></param>
		public void PutString(string val, int length)
		{
			this.EnsureSpace(length);

			if (val == null)
				val = "";

			var bytes = Encoding.UTF8.GetBytes(val);
			Buffer.BlockCopy(bytes, 0, _buffer, _ptr, Math.Min(bytes.Length, length));
			_ptr += length;
			this.Length += length;
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

			this.PutBin(Encoding.UTF8.GetBytes(val));
		}

		/// <summary>
		/// Writes string to buffer, incl. null terminator, and prefixed
		/// with a short describing its length.
		/// </summary>
		/// <param name="val"></param>
		public void PutLpString(string val)
		{
			if (val == null)
				val = "";

			// Append terminator
			if (val == "" || (val.Length > 0 && val[val.Length - 1] != '\0'))
				val += '\0';

			var bytes = Encoding.UTF8.GetBytes(val);
			this.PutShort(bytes.Length);
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes bytes to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutBin(params byte[] val)
		{
			this.EnsureSpace(val.Length);

			Buffer.BlockCopy(val, 0, _buffer, _ptr, val.Length);
			_ptr += val.Length;
			this.Length += val.Length;
		}

		/// <summary>
		/// Writes bytes parsed from given hex string to buffer.
		/// </summary>
		/// <param name="hex"></param>
		public void PutBinFromHex(string hex)
		{
			if (hex == null)
				throw new ArgumentNullException("hex");

			hex = hex.Trim().Replace(" ", "").Replace("-", "").Replace("\r", "").Replace("\n", "");

			if (hex == "")
				return;

			this.PutBin(SoapHexBinary.Parse(hex).Value);
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
		{
			this.PutLong(val.ToFileTime());
		}

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

				var buffer = zlibPacket._buffer;
				var len = zlibPacket.Length;

				using (var ms = new MemoryStream())
				{
					using (var ds = new DeflateStream(ms, CompressionMode.Compress))
						ds.Write(buffer, 0, len);

					var compressedVal = ms.ToArray();

					this.PutShort(0xFA8D); // zlib header
					this.PutInt(compressedVal.Length);
					this.PutBin(compressedVal);
				}
			}
		}

		/// <summary>
		/// Copies packet data to given buffer at offset.
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="offset"></param>
		/// <returns></returns>
		public byte[] Build(ref byte[] buffer, int offset)
		{
			Buffer.BlockCopy(_buffer, 0, buffer, offset, this.Length);

			return _buffer;
		}

		/// <summary>
		/// Returns buffer as formatted hex string.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			var buffer = _buffer;
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

			for (var i = 0; i < length; i += 16)
			{
				sb.AppendFormat("{0:X4}   ", i);

				var k = 0;
				for (var j = 0; j < 16; ++j, ++k)
				{
					if (i + j > length - 1)
						break;
					sb.Append(buffer[i + j].ToString("X2") + ' ');
					if (j == 7)
						sb.Append(' ');
				}

				sb.Append("".PadLeft((16 - k) * 3, ' '));
				sb.Append("  ");

				for (var j = 0; j < 16; ++j)
				{
					if (i + j > length - 1)
						break;

					var b = buffer[i + j];
					// Only display ANSI characters, and no curly braces.
					if (b >= 32 && b <= 126 && b != 123 && b != 125)
						sb.Append((char)b);
					else
						sb.Append('.');
				}

				sb.AppendLine();
			}

			sb.AppendLine(spacer);

			return sb.ToString().Trim();
		}

		private enum ZlibMode
		{
			None,
			Compressed,
			Uncompressed,
		}
	}
}
