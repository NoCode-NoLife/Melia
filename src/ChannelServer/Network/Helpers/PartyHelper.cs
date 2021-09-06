using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World;
using Melia.Shared.Network;

namespace Melia.Channel.Network.Helpers
{
	public static class PartyHelper
	{
		public static void AddMember(this Packet packet, Character character)
		{
			packet.PutLong(character.AccountId);
			packet.PutString(character.TeamName, 64);
			packet.PutShort(24);
			packet.PutShort(1305);
			packet.PutLong(0);
			packet.PutInt(0);
			packet.PutInt(character.MapId);
			packet.PutInt(character.Handle);
			packet.PutString(character.TeamName, 64);
			packet.PutString(character.Name, 64);
			packet.PutShort(0);
			packet.PutShort((short)character.JobId);
			packet.PutInt((int)character.JobId);
			packet.PutInt(character?.Party.Members.IndexOf(character) + 1 ?? 0);
			packet.PutShort(1);
			packet.PutInt(31);
			packet.PutInt(1003); // ?
			packet.PutEmptyBin(18);
			packet.PutInt(character?.Party.Members.IndexOf(character) + 1 ?? 0);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0xFF);
			packet.PutInt((int)character.JobId);
			packet.PutEmptyBin(12);
			packet.PutInt(character?.Party.Members.IndexOf(character) + 1 ?? 0);
			packet.PutFloat(character.Position.X);
			packet.PutFloat(character.Position.Y);
			packet.PutFloat(character.Position.Z);
			packet.PutInt(character.Hp);
			packet.PutInt(character.Sp);
			packet.PutInt(character.MaxHp);
			packet.PutInt(character.MaxSp);
			packet.PutInt(0);
			packet.PutInt(character?.Party.Members.IndexOf(character) + 1 ?? 0);
			packet.PutShort(0);
		}
	}
}
