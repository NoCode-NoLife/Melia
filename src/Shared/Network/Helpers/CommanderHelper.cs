// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Const;

namespace Melia.Shared.Network.Helpers
{
	public static class CommanderHelper
	{
		public static void AddCommander(this Packet packet, ICommander commander)
		{
			packet.PutString(commander.Name, 65);
			packet.PutString(commander.TeamName, 64);
			packet.PutEmptyBin(7);
			packet.PutLong(0); // Account ID
			packet.PutShort(commander.Stance);
			packet.PutShort(0);
			packet.PutShort((short)commander.Job);
			packet.PutByte((byte)commander.Gender);
			packet.PutByte(0);
			packet.PutInt(commander.Level);

			// Items
			var equipIds = commander.GetEquipIds();
			for (int i = 0; i < equipIds.Length; ++i)
				packet.PutInt(equipIds[i]);

			packet.PutShort(commander.Hair);
			packet.PutShort(0); // Pose

			// [i10671, 2015-10-26 iCBT2] ?
			{
				packet.PutInt(0);
				packet.PutInt(0);
			}
		}
	}

	public interface ICommander
	{
		string Name { get; }
		string TeamName { get; }
		int Stance { get; }
		Job Job { get; }
		Gender Gender { get; }
		int Level { get; }
		byte Hair { get; }

		int[] GetEquipIds();
	}
}
