using System.Text;
using Melia.Shared.Network;
using Melia.Zone.Buffs;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Network.Helpers
{
	public static class BuffHelper
	{
		/// <summary>
		/// Adds buff data to packet.
		/// </summary>
		/// <remarks>
		/// This helper is used in ZC_BUFF_ADD and ZC_BUFF_UPDATE.
		/// </remarks>
		/// <param name="packet"></param>
		/// <param name="buff"></param>
		public static void AddTargetedBuff(this Packet packet, Buff buff)
		{
			packet.PutInt(buff.Target.Handle);
			packet.PutInt(buff.Handle);
			packet.AddBuff(buff);
		}

		/// <summary>
		/// Adds buff data to packet.
		/// </summary>
		/// <remark>
		/// This helper is used in ZC_BUFF_LIST.
		/// </remarks>
		/// <param name="packet"></param>
		/// <param name="buff"></param>
		public static void AddBuff(this Packet packet, Buff buff)
		{
			packet.PutInt((int)buff.Id);
			packet.PutInt((int)buff.NumArg1);
			packet.PutInt((int)buff.NumArg2);
			packet.PutInt(0); // NumArg3?
			packet.PutInt(0); // NumArg4?
			packet.PutInt(0); // NumArg5?
			packet.PutInt(buff.OverbuffCounter);
			packet.PutInt((int)buff.RemainingDuration.TotalMilliseconds);
			packet.PutInt(0);
			packet.PutInt(0);

			// Instead of just the length of the string + null terminator
			// byte (LpString), the short integer in this packet is always
			// 4 higher for unknown reasons.
			var bytes = Encoding.UTF8.GetBytes(buff.Caster.Name + '\0');
			packet.PutShort(bytes.Length + 4);
			packet.PutBin(bytes);

			packet.PutInt(buff.Caster.Handle);
			packet.PutInt(buff.Handle);

			// Party ID for party UI buff synchronization
			long partyId = 0;
			if (buff.Target is Character targetChar && targetChar.Connection?.Party != null)
				partyId = targetChar.Connection.Party.ObjectId;
			packet.PutLong(partyId);

			packet.PutByte(1);
			packet.PutByte(0); // if 1, DashRun is sent again while running, which seems wrong
		}
	}
}
