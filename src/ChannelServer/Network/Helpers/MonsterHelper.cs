// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.World;
using Melia.Shared.Network;

namespace Melia.Channel.Network.Helpers
{
	public static class MonsterHelper
	{
		public static void AddMonster(this Packet packet, Monster monster)
		{
			packet.PutInt(monster.Handle);
			packet.PutFloat(monster.Position.X);
			packet.PutFloat(monster.Position.Y);
			packet.PutFloat(monster.Position.Z);
			packet.PutFloat(monster.Direction.Cos);
			packet.PutFloat(monster.Direction.Sin);
			packet.PutByte((byte)monster.NpcType); // 0~2,  0: friendly?, 1: monster, 2: NPC
			packet.PutByte(0); // bool ?
			packet.PutInt(monster.Hp);
			packet.PutInt(monster.MaxHp);
			packet.PutShort(0);
			packet.PutFloat(0);

			// [i11025 (2016-02-26)] ?
			{
				packet.PutShort(16832);
			}

			// MONSTER
			{
				packet.PutInt(monster.Id);
				packet.PutInt(0);
				packet.PutInt(monster.MaxHp);

				// [i11025 (2016-02-26)] Removed?
				{
					//packet.PutShort(0); // MaxShield?
					//packet.PutEmptyBin(2);
				}

				packet.PutInt(monster.Level);
				packet.PutFloat(monster.SDR);
				packet.PutByte(0);
				packet.PutEmptyBin(3);
			}
			packet.PutInt(0); // GenType
			packet.PutInt(0);

			//packet.PutShort(0); // parameters size
			// it was, like this in IDA o.o
			packet.PutByte(0); // parameters size
			packet.PutByte(0); // ??
			packet.PutByte(0); // [i170175] ?
			packet.PutInt(0);  // [i171960] ?

			packet.PutLpString(monster.Name);
			packet.PutLpString(""); // UniqueName
			packet.PutLpString(monster.DialogName); // (if string is set - HP isn't shown, and talking activated)
			packet.PutLpString(monster.WarpName);
			packet.PutLpString(""); // str3

			packet.PutEmptyBin(0); // parameters
		}
	}
}
