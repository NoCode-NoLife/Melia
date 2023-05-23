using System;
using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Barracks.Network.Helpers
{
	/// <summary>
	/// Contains extensions for writing barracks character data to packets.
	/// </summary>
	public static class BarracksPcHelper
	{
		/// <summary>
		/// Writes the character's data to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="pc"></param>
		/// <exception cref="InvalidOperationException"></exception>
		public static void AddBarrackPc(this Packet packet, IBarrackPc pc)
		{
			var equipProperties = pc.GetEquipmentProperties();
			if (equipProperties.Length != Items.EquipSlotCount)
				throw new InvalidOperationException("Expected " + Items.EquipSlotCount + " items for property list.");

			var jobIds = pc.GetJobIds();

			packet.AddAppearanceBarrackPc(pc);

			// Equip properties
			for (var i = 0; i < equipProperties.Length; ++i)
			{
				var propertiesObj = equipProperties[i];
				var propertyList = propertiesObj.GetAll();
				var propertiesSize = propertyList.GetByteCount();

				packet.PutShort(propertiesSize);
				if (propertiesSize > 0)
				{
					packet.AddProperties(propertyList);
					packet.PutLong(pc.Id + (i + 1));
					packet.PutShort(0);
				}
			}

			packet.PutShort(0);

			// [i170175] maybe hat visibility?
			packet.PutByte(1);
			packet.PutByte(1);
			packet.PutByte(1);
			packet.PutByte(1);

			// Job list?
			// Example: A Mage that switched to Pyromancer has two
			//   elements in this list, 2001 and 2002.
			packet.PutShort(jobIds.Length);
			foreach (var jobId in jobIds)
				packet.PutShort((short)jobId);

			packet.PutInt(0);
			packet.PutInt((int)pc.JobId);

			packet.PutLong(pc.Id);
			packet.PutShort(0); // Additional properties count?

			//packet.PutShort(2); // Instance dungeon count
			//packet.PutLpString("Indun_ResetTime");
			//packet.PutLpString("21080800.000000");
			//packet.PutLpString("IndunWeeklyResetTime");
			//packet.PutLpString("21080906.000000");

			//packet.PutInt(0);
		}
	}

	/// <summary>
	/// Represents an entity in the barrack.
	/// </summary>
	public interface IBarrackPc : IAppearanceBarrackPc
	{
		Properties[] GetEquipmentProperties();
		JobId[] GetJobIds();
	}
}
