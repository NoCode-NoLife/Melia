using Melia.Login.Database;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.Network.Helpers
{
	public static class CharacterHelper
	{
		public static void AddCharacter(this Packet packet, Character character)
		{
			packet.PutString(character.Name, 65);
			packet.PutString("", 64);
			packet.PutEmptyBin(7);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutShort(character.Stance);
			packet.PutShort(0);
			packet.PutShort((short)character.Job);
			packet.PutByte((byte)character.Gender);
			packet.PutByte(0);
			packet.PutInt(character.Level);

			// Items
			foreach (var itemId in character.Equipment)
				packet.PutInt(itemId);

			packet.PutByte(character.Hair);
			packet.PutByte(0);

			packet.PutShort(0);
			packet.PutLong(character.Id);
			packet.PutByte(character.Index);

			packet.PutByte(0);
			packet.PutShort(character.ZoneId);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);

			// Position?
			packet.PutFloat(character.X);
			packet.PutFloat(character.Y);
			packet.PutFloat(character.Z);
			packet.PutFloat(0);	// Vector direction
			packet.PutFloat(0); // Vector direction

			// ?
			packet.PutFloat(0);
			packet.PutFloat(0);
			packet.PutFloat(0);
			packet.PutFloat(0);
			packet.PutFloat(0);

			packet.PutInt(0);
		}
	}
}
