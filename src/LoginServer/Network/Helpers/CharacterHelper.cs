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
			// Defaults are literally empty items, NoHat, NoWeapon, etc.
			packet.PutInt(2); // Hair Acc
			packet.PutInt(2); // Subsidiary Acc
			packet.PutInt(4); // Outer?
			packet.PutInt(8); // Top
			packet.PutInt(6); // Gloves
			packet.PutInt(7); // Shoes
			packet.PutInt(10000); // Helmet? (headless)
			packet.PutInt(11000); // Armband
			packet.PutInt(9999996); // L Weapon
			packet.PutInt(9999996); // R Weapon
			packet.PutInt(4); // Costume
			packet.PutInt(9); // Ring?
			packet.PutInt(9); // Ring?
			packet.PutInt(4); // Outer?
			packet.PutInt(9); // Pants
			packet.PutInt(9); // Ring?
			packet.PutInt(9); // Ring?
			packet.PutInt(9); // Bracelet 1
			packet.PutInt(9); // Bracelet 2
			packet.PutInt(10); // Necklace

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
