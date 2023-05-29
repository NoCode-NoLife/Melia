using System;
using Melia.Shared.Network;
using Xunit;
using Yggdrasil.Util;

namespace Melia.Test.Shared.Network
{
	public class PacketTests
	{
		[Fact]
		public void Write()
		{
			var packet = new Packet(1001);
			packet.PutByte(1);
			packet.PutShort(2);
			packet.PutInt(3);
			packet.PutLong(4);
			packet.PutFloat(5.6f);
			packet.PutString("foo");
			packet.PutString("bar", 6);

			var bytes = packet.Build();
			var expected = Hex.ToByteArray("01   02 00   03 00 00 00   04 00 00 00 00 00 00 00   33 33 B3 40   66 6F 6F 00   62 61 72 00 00 00");

			Assert.Equal(expected.Length, bytes.Length);
			Assert.Equal(expected, bytes);
		}

		[Fact]
		public void WriteNtString()
		{
			var packet = new Packet(1001);
			packet.PutString("foo");

			var bytes = packet.Build();
			var expected = Hex.ToByteArray("66 6F 6F 00");

			Assert.Equal(expected.Length, bytes.Length);
		}

		[Fact]
		public void WritePaddedString()
		{
			var packet = new Packet(1001);
			packet.PutString("foo", 6);

			var bytes = packet.Build();
			var expected = Hex.ToByteArray("66 6F 6F 00 00 00");
			Assert.Equal(expected, bytes);

			packet = new Packet(1001);
			packet.PutString("foo", 4);

			bytes = packet.Build();
			expected = Hex.ToByteArray("66 6F 6F 00");
			Assert.Equal(expected, bytes);

			packet = new Packet(1001);
			packet.PutString("foo", 3);

			bytes = packet.Build();
			expected = Hex.ToByteArray("66 6F 6F");
			Assert.Equal(expected, bytes);

			packet = new Packet(1001);
			Assert.Throws<ArgumentException>(() => packet.PutString("foo", 2));
		}

		[Fact]
		public void WriteRawString()
		{
			var packet1 = new Packet(1001);
			packet1.PutString("foo", 3);

			var packet2 = new Packet(1001);
			packet2.PutRawString("foo");

			var bytes1 = packet1.Build();
			var bytes2 = packet2.Build();

			Assert.Equal(bytes1, bytes2);

			var expected = Hex.ToByteArray("66 6F 6F");
			Assert.Equal(expected, bytes1);
			Assert.Equal(expected, bytes2);
		}
	}
}
