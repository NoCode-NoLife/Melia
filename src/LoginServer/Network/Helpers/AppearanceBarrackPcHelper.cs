// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Login.Database;
using Melia.Login.World;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				packet.PutByte(181);
			}

			packet.PutShort(pc.MapId);
			packet.PutShort(pc.Channel);
			packet.PutShort(0);
			packet.PutInt(0);
			packet.PutInt(0); // maxXP
			packet.PutInt(0); // currentExp

			// Position?
			packet.PutFloat(pc.BarrackPosition.X);
			packet.PutFloat(pc.BarrackPosition.Y);
			packet.PutFloat(pc.BarrackPosition.Z);
			packet.PutFloat(0);	// Vector direction
			packet.PutFloat(0); // Vector direction

			// ?
			packet.PutFloat(pc.BarrackPosition.X);
			packet.PutFloat(pc.BarrackPosition.Y);
			packet.PutFloat(pc.BarrackPosition.Z);
			packet.PutFloat(0); // Vector direction
			packet.PutFloat(0); // Vector direction

			packet.PutInt(0);
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