using System;
using Melia.Barracks.Database;
using Melia.Shared.Network;

namespace Melia.Barracks.Network.Helpers
{
	/// <summary>
	/// Contains extensions for writing barracks character data to packets.
	/// </summary>
	public static class BarrackPetHelper
	{
		/// <summary>
		/// Writes the character's data to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="companion"></param>
		/// <exception cref="InvalidOperationException"></exception>
		public static void AddCompanion(this Packet packet, Companion companion)
		{
			packet.PutInt(companion.MonsterId);
			packet.PutLong(companion.ObjectId);
			packet.PutLong(companion.CharacterObjectId);
			packet.PutLong(companion.Exp);
			packet.PutLpString(companion.Name);
			packet.PutByte(0);
			packet.PutFloat(companion.BarracksPosition.X);
			packet.PutFloat(companion.BarracksPosition.Y);
			packet.PutFloat(companion.BarracksPosition.Z);
			packet.PutFloat(companion.BarracksDirection.Cos);
			packet.PutFloat(companion.BarracksDirection.Sin);
			packet.PutLong(0);
			packet.PutByte(companion.Index);
			var weaponSlots = (byte)0;
			packet.PutInt(weaponSlots);
			for (var i = 0; i < weaponSlots; i++)
				packet.PutByte(0); // Is Equipped
			packet.PutByte(1);
			var armorSlots = (byte)0;
			packet.PutShort(armorSlots);
			packet.PutShort(0); // Property Count
			for (var i = 0; i < armorSlots; i++)
				packet.PutByte(0);
			packet.PutByte(1);
			packet.PutInt(1);
			packet.PutByte(0);
			packet.PutLong(60000);
		}
	}
}
