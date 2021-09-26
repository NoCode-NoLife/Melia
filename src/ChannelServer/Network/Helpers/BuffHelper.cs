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
			packet.PutInt(buff.SkillId);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(buff.OverbuffCounter);
			packet.PutInt(buff.Duration);
			packet.PutInt(0);
			packet.PutInt(0);
			if (entity is Character character)
			{
				packet.PutShort(character.Name.Length + 1 + 4);
				packet.PutString(character.Name);
			}
			else
				packet.PutLpString("");
			packet.PutInt(entity.Handle);
			packet.PutInt(buff.Handle);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutByte(1);
			packet.PutByte(1);
		}
	}
}
