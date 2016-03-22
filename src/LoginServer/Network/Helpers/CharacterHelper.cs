// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
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
			packet.AddCommander(character);
			packet.PutLong(character.Id);

			// [i11025 (2016-02-26)]
			// Index was previously stored as a short, now there seem
			// to be two byte, with the first being the index.
			{
				packet.PutByte(character.Index);
				packet.PutByte(181);
			}

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
			packet.PutFloat(character.BarrackPosition.X);
			packet.PutFloat(character.BarrackPosition.Y);
			packet.PutFloat(character.BarrackPosition.Z);
			packet.PutFloat(0); // Vector direction
			packet.PutFloat(0); // Vector direction

			packet.PutInt(0);
		}
	}
}
