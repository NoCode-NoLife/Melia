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
			using var packet = Packet.Rent(1001);
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
			using var packet = Packet.Rent(1001);
			packet.PutString("foo");

			var bytes = packet.Build();
			var expected = Hex.ToByteArray("66 6F 6F 00");

			Assert.Equal(expected.Length, bytes.Length);
		}

		[Fact]
		public void WritePaddedString()
		{
			using var packet1 = Packet.Rent(1001);
			packet1.PutString("foo", 6);

			var bytes = packet1.Build();
			var expected = Hex.ToByteArray("66 6F 6F 00 00 00");
			Assert.Equal(expected, bytes);

			using var packet2 = Packet.Rent(1001);
			packet2.PutString("foo", 4);

			bytes = packet2.Build();
			expected = Hex.ToByteArray("66 6F 6F 00");
			Assert.Equal(expected, bytes);

			using var packet3 = Packet.Rent(1001);
			packet3.PutString("foo", 3);

			bytes = packet3.Build();
			expected = Hex.ToByteArray("66 6F 6F");
			Assert.Equal(expected, bytes);

			using var packet4 = Packet.Rent(1001);
			Assert.Throws<ArgumentException>(() => packet4.PutString("foo", 2));
		}

		[Fact]
		public void WriteRawString()
		{
			using var packet1 = Packet.Rent(1001);
			packet1.PutString("foo", 3);

			using var packet2 = Packet.Rent(1001);
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
