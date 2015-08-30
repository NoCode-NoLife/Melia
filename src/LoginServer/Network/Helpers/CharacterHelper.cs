// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

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
			// Commander
			// TODO: Used in ZC_CONNECT_OK (etc?), ove to Shared?
			{
				packet.PutString(character.Name, 65);
				packet.PutString("", 64);
				packet.PutEmptyBin(7);
				packet.PutLong(0); // Account ID
				packet.PutShort(character.Stance);
				packet.PutShort(0);
				packet.PutShort((short)character.Job);
				packet.PutByte((byte)character.Gender);
				packet.PutByte(0);
				packet.PutInt(character.Level);

				// Items
				foreach (var itemId in character.Equipment)
					packet.PutInt(itemId);

				packet.PutShort(character.Hair);
				packet.PutShort(0); // Pose
			}
			packet.PutLong(character.Id); // socialInfoId ?
			packet.PutShort(character.Index);
			packet.PutShort(character.MapId);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0); // maxXP ?
			packet.PutInt(0);

			// Position?
			packet.PutFloat(character.BarrackPosition.X);
			packet.PutFloat(character.BarrackPosition.Y);
			packet.PutFloat(character.BarrackPosition.Z);
			packet.PutFloat(0);	// Vector direction
			packet.PutFloat(0); // Vector direction

			// ?
			packet.PutFloat(0); // X
			packet.PutFloat(0); // Y
			packet.PutFloat(0); // Z
			packet.PutFloat(0); // Vector direction
			packet.PutFloat(0); // Vector direction

			packet.PutInt(0);
		}
	}
}
