// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Login.Network.Helpers
{
	public static class AppearanceBarrackPcHelper
	{
		public static void AddAppearanceBarrackPc(this Packet packet, IAppearanceBarrackPc pc)
		{
			packet.AddAppearancePc(pc);
			packet.PutLong(pc.Id);

			// [i11025 (2016-02-26)]
			// Index was previously stored as a short, now there seem
			// to be two byte, with the first being the index.
			{
				packet.PutByte(pc.Index);
				packet.PutByte(1);
			}

			packet.PutShort(0);
			packet.PutShort(pc.MapId);
			packet.PutShort(pc.Channel);
			packet.PutInt(0);
			packet.PutInt(0); // maxXP
			packet.PutInt(8); // currentExp (8 instead of 0)
			packet.PutInt(0);
			packet.PutInt(0);

			packet.PutFloat(0); //x
			packet.PutFloat(0); //y
			packet.PutFloat(0); //z

			// Position?
			packet.PutFloat(pc.BarrackPosition.X);
			packet.PutFloat(pc.BarrackPosition.Y);
			packet.PutFloat(pc.BarrackPosition.Z);
			packet.PutFloat(0); // Vector direction
			packet.PutFloat(0); // Vector direction

			packet.PutFloat(pc.BarrackPosition.X);
			packet.PutFloat(pc.BarrackPosition.Y);
			packet.PutFloat(pc.BarrackPosition.Z);
			packet.PutFloat(0); // Vector direction
			packet.PutFloat(0); // Vector direction

			packet.PutInt(0);
			packet.PutShort(0);
		}
	}

	public interface IAppearanceBarrackPc : IAppearancePc
	{
		long Id { get; }
		byte Index { get; }
		int MapId { get; }
		int Channel { get; }
		Position BarrackPosition { get; }
	}
}
