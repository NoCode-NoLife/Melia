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
			packet.PutInt(buff.Duration);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutShort((buff.Caster as Character)?.Name.Length + 5 ?? 5);
			packet.PutString((buff.Caster as Character)?.Name ?? "");
			packet.PutInt(buff.Caster.Handle);
			packet.PutInt(buff.Handle);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutByte(1);
			packet.PutByte(1);
		}
	}
}
