// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using Melia.Shared.Const;
using Melia.Shared.Network;

namespace Melia.Login.Network.Helpers
{
	public static class BarrackPcHelper
	{
		public static void AddBarrackPc(this Packet packet, IBarrackPc pc)
		{
			var equipProperties = pc.GetEquipmentProperties();
			if (equipProperties.Length != Items.EquipSlotCount)
				throw new InvalidOperationException("Expected " + Items.EquipSlotCount + " items for property list.");

			packet.AddAppearanceBarrackPc(pc);

			// Equip properties
			foreach (var item in equipProperties)
			{
				packet.PutShort(0); // byte length of properties

				// foreach item.properties
				//   put key
				//   put value
			}

			// [i170175] ?
			packet.PutByte(1);
			packet.PutByte(1);
			packet.PutByte(1);

			// Job list?
			// Example: A Mage that switched to Pyromancer has two
			//   elements in this list, 2001 and 2002.
			packet.PutShort(1); // count
			{ // foreach
				packet.PutShort((short)pc.Job);
			}

			packet.PutInt(0);
		}
	}

	/// <summary>
	/// Represents an entity in the barrack.
	/// </summary>
	public interface IBarrackPc : IAppearanceBarrackPc
	{
		int[] GetEquipmentProperties();
	}
}
