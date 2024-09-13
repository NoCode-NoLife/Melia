using System;
using Melia.Shared.Network;

namespace Melia.Zone.Network.Helpers
{
	/// <summary>
	/// Packet string related helper methods.
	/// </summary>
	public static class PacketStringHelper
	{
		/// <summary>
		/// Returns the id for the given packet string.
		/// </summary>
		/// <param name="packetString"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static int GetStringId(this string packetString)
		{
			if (packetString == null)
				return 0;

			if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var data))
				throw new ArgumentException($"Unknown packet string: {packetString}");

			return data.Id;
		}

		/// <summary>
		/// Writes the id for the given packet string to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="packetString"></param>
		public static void AddStringId(this Packet packet, string packetString)
		{
			var id = packetString.GetStringId();
			packet.PutInt(id);
		}
	}
}
