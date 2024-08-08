using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Zone.Skills.Combat;

namespace Melia.Zone.Network.Helpers
{
	public static class KnockbackHelper
	{
		/// <summary>
		/// Adds information about the knock back to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="knockBackInfo"></param>
		public static void AddKnockbackInfo(this Packet packet, KnockBackInfo knockBackInfo)
		{
			packet.PutPosition(knockBackInfo.FromPosition);
			packet.PutPosition(knockBackInfo.ToPosition);
			packet.PutInt(knockBackInfo.Velocity);
			packet.PutInt(knockBackInfo.HAngle);
			packet.PutInt(knockBackInfo.VAngle);
			packet.PutInt(0);
			packet.PutShort((short)knockBackInfo.Time.TotalMilliseconds);
			packet.PutShort(0);
			packet.PutFloat(1);
			packet.PutFloat(1);
			packet.PutInt(0);
			packet.PutInt(0);
		}
	}
}
