using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Shared.Network;

namespace Melia.Channel.Network.Helpers
{
	public static class BuffHelper
	{
		/// <summary>
		/// Adds buff data to packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="buff"></param>
		public static void AddBuff(this Packet packet, Buff buff)
		{
			packet.PutInt(buff.Target.Handle);
			packet.PutInt(buff.Handle);
			packet.PutInt((int)buff.Id);
			packet.PutInt((int)buff.SkillId);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(buff.OverbuffCounter);
			packet.PutInt((int)buff.Duration.TotalMilliseconds);
			packet.PutInt(0);
			packet.PutInt(0);
			// Instead of just the length of the string + null terminator byte (LpString),
			// there are 4 extra bytes in this short for a total of 5 bytes.
			packet.PutShort(buff.Caster.Name.Length + 5);
			packet.PutString(buff.Caster.Name);
			packet.PutInt(buff.Caster.Handle);
			packet.PutInt(buff.Handle);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutByte(1);
			packet.PutByte(1);
		}

		/// <summary>
		/// Adds buff data to packet.
		/// </summary>
		/// <remark>
		/// This version is used in ZC_BUFF_LIST
		/// </remarks>
		/// <param name="packet"></param>
		/// <param name="buff"></param>
		public static void AddBuffData(this Packet packet, Buff buff)
		{
			packet.PutInt((int)buff.Id);
			packet.PutInt(0); // i1
			packet.PutInt(0); // i2
			packet.PutInt(0); // i3
			packet.PutInt(0); // i4
			packet.PutInt(0); // i5
			packet.PutInt(buff.OverbuffCounter);
			packet.PutInt((int)buff.Duration.TotalMilliseconds);
			packet.PutInt(0); // i6
			packet.PutInt(0); // i7
							  // Instead of just the length of the string + null terminator byte (LpString),
							  // there are 4 extra bytes in this short for a total of 5 bytes.
			packet.PutShort(buff.Caster.Name.Length + 5);
			packet.PutString(buff.Caster.Name);
			packet.PutInt(buff.Caster.Handle);
			packet.PutInt(buff.Handle);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutByte(1);
			packet.PutByte(0);
		}
	}
}
