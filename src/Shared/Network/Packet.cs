using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Network
{
	public class Packet
	{
		private const int DefaultSize = 2000;

		private byte[] _buffer;
		private int _ptr;

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
		/// Reads byte from buffer.
		/// </summary>
		/// <returns></returns>
		public byte GetByte()
		{
			var val = _buffer[_ptr];
			_ptr += sizeof(byte);
			this.Length += sizeof(byte);

			return val;
		}

		/// <summary>
		/// Reads short from buffer.
		/// </summary>
		/// <returns></returns>
		public short GetShort()
		{
			var val = BitConverter.ToInt16(_buffer, _ptr);
			_ptr += sizeof(short);
			this.Length += sizeof(short);

			return val;
		}

		/// <summary>
		/// Reads int from buffer.
		/// </summary>
		/// <returns></returns>
		public int GetInt()
		{
			var val = BitConverter.ToInt32(_buffer, _ptr);
			_ptr += sizeof(int);
			this.Length += sizeof(int);

			return val;
		}

		/// <summary>
		/// Reads long from buffer.
		/// </summary>
		/// <returns></returns>
		public long GetLong()
		{
			var val = BitConverter.ToInt64(_buffer, _ptr);
			_ptr += sizeof(long);
			this.Length += sizeof(long);

			return val;
		}

		/// <summary>
		/// Reads float from buffer.
		/// </summary>
		/// <returns></returns>
		public float GetFloat()
		{
			var val = BitConverter.ToSingle(_buffer, _ptr);
			_ptr += sizeof(float);
			this.Length += sizeof(float);

			return val;
		}

		/// <summary>
		/// Reads given amount of bytes from buffer and returns them as UTF8 string.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetString(int length)
		{
			var val = Encoding.UTF8.GetString(_buffer, _ptr, length);

			// Relatively fast way to get rid of null bytes.
			var nullIndex = val.IndexOf((char)0);
			if (nullIndex != -1)
				val = val.Substring(0, nullIndex);

			_ptr += length;
			this.Length += length;

			return val;
		}

		/// <summary>
		/// Reads null-terminated string from buffer and returns it as UTF8.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetString()
		{
			for (int i = _ptr; i < _buffer.Length; ++i)
			{
				if (_buffer[i] == 0)
				{
					var val = Encoding.UTF8.GetString(_buffer, _ptr, i - _ptr);
					_ptr += val.Length + 1;
					this.Length += val.Length + 1;
					return val;
				}
			}

			throw new Exception("String not null-terminated.");
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

			IntPtr intPtr = Marshal.AllocHGlobal(buffer.Length);
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
			var val = new byte[length];
			Buffer.BlockCopy(_buffer, _ptr, val, 0, length);
			_ptr += length;
			this.Length += length;

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
			_buffer[_ptr++] = (byte)(val >> (8 * 0));
			_buffer[_ptr++] = (byte)(val >> (8 * 1));
			_buffer[_ptr++] = (byte)(val >> (8 * 2));
			_buffer[_ptr++] = (byte)(val >> (8 * 3));
			this.Length += sizeof(int);
		}

		public void PutLong(long val)
		{
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
			val += '\0';
			this.PutString(val, val.Length);
		}

		/// <summary>
		/// Writes bytes to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutBin(params byte[] val)
		{
			var length = val.Length;
			Buffer.BlockCopy(val, 0, _buffer, _ptr, length);
			_ptr += length;
			this.Length += length;
		}

		/// <summary>
		/// Writes bytes parsed from given hex string to buffer.
		/// </summary>
		/// <param name="hex"></param>
		public void PutBinFromHex(string hex)
		{
			hex = hex.Trim().Replace(" ", "").Replace("-", "");

			var val =
				Enumerable.Range(0, hex.Length)
				.Where(x => x % 2 == 0)
				.Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
				.ToArray();

			this.PutBin(val);
		}

		/// <summary>
		/// Writes the given amount of bytes to the buffer.
		/// </summary>
		/// <param name="amount"></param>
		public void PutEmptyBin(int amount)
		{
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
	}
}
