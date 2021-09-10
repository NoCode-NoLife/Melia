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
		public static void AddBuff(this Packet packet, IEntity entity, Buff buff)
		{
			packet.PutInt(entity.Handle);
			packet.PutInt(buff.Handle);
			packet.PutInt((int)buff.Id);
			packet.PutInt(1);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(buff.OverbuffCounter);
			packet.PutInt(buff.Data.Duration);
			packet.PutInt(0);
			packet.PutInt(0);
			if (entity is Character)
				packet.PutLpString(((Character)entity).Name);
			else
				packet.PutLpString("");
			packet.PutInt(buff.Handle);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutByte(1);
			packet.PutByte(1);
		}
	}
}
