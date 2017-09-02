// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Const;
using System;

namespace Melia.Shared.Network.Helpers
{
	public static class AppearancePcHelper
	{
		public static void AddAppearancePc(this Packet packet, IAppearancePc appearancePc)
		{
			packet.PutString(appearancePc.Name, 65);
			packet.PutString(appearancePc.TeamName, 64);
			packet.PutEmptyBin(7);
			packet.PutLong(appearancePc.AccountId);
			packet.PutShort(appearancePc.Stance);
			packet.PutShort(0);
			packet.PutShort((short)appearancePc.Job);
			packet.PutByte((byte)appearancePc.Gender);
			packet.PutByte(0);
			packet.PutInt(appearancePc.Level);

			// Items
			var equipIds = appearancePc.GetEquipIds();
			if (equipIds.Length != Items.EquipSlotCount)
				throw new InvalidOperationException("Incorrect amount of equipment (" + equipIds.Length + ").");

			for (int i = 0; i < equipIds.Length; ++i)
				packet.PutInt(equipIds[i]);

			// [i10671, 2015-10-26 iCBT2] ?
			{
				packet.PutInt(0);
				packet.PutInt(0);
			}

			packet.PutShort(appearancePc.Hair);
			packet.PutShort(0); // Pose

			// Team ID
			packet.PutInt(0);
			
			// Unknown. This could be a buffer just to keep the structure the same size since the equipment count changes.
			packet.PutInt(0);
		}
	}

	public interface IAppearancePc
	{
		long AccountId { get; }
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
