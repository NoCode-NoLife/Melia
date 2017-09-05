// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System.Linq;
using Melia.Shared.Network;

namespace Melia.Login.Network.Helpers
{
	public static class BarrackPcHelper
	{
		public static void AddBarrackPc(this Packet packet, IBarrackPc pc)
		{
			packet.AddAppearanceBarrackPc(pc);

			// Equip properties, short->length
			var properties = pc.GetEquipmentProperties();
			for (var i = 0; i < properties.Count(); ++i)
				packet.PutShort(0);

			// Unknown
			packet.PutByte(1);
			packet.PutByte(1);
			packet.PutByte(1);

			// Job history?
			// While this short existed in iCBT1, it might not have
			// been used, couldn't find a log.
			// Example: A Mage that switched to Pyromancer has two
			//   elements in this list, 2001 and 2002.
			packet.PutShort(1); // count
			{ // foreach
				packet.PutShort((short)pc.Job);
			}

			// [i11025 (2016-02-26)] ?
			{
				packet.PutInt(0);
			}
		}
	}

	/// <summary>
	/// Represents an entity in the barrack.
	/// </summary>
	public interface IBarrackPc : IAppearanceBarrackPc
	{
		// TODO: Fill this interface with properties as they are identified in BarrackPcHelper.

		int[] GetEquipmentProperties();
	}
}
