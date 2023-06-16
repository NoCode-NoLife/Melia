using Melia.Shared.Network;
using Melia.Zone.Skills.Combat;

namespace Melia.Zone.Network.Helpers
{
	public static class HitInfoHelpers
	{
		/// <summary>
		/// Adds skill hit info data to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="skillHitInfo"></param>
		public static void AddSkillHitInfo(this Packet packet, SkillHitInfo skillHitInfo)
		{
			packet.PutByte(0);
			packet.PutByte(4); // attack type?
			packet.PutByte(0);
			packet.PutByte(0);

			packet.PutInt(skillHitInfo.Target.Handle);
			packet.AddHitInfo(skillHitInfo.HitInfo);

			packet.PutInt(0);
			packet.PutShort((short)skillHitInfo.DamageDelay.TotalMilliseconds);
			packet.PutByte(0);

			packet.PutByte(0);
			packet.PutShort((short)skillHitInfo.SkillHitDelay.TotalMilliseconds); // Skill Hit Delay? Adds pause in attack animation?
			packet.PutByte((byte)skillHitInfo.HitEffect);
			packet.PutByte(0);
			packet.PutInt(0);
			packet.PutInt(0); // This being set to anything causes a delay in the dagger damage animation
			packet.PutShort(0);
			packet.PutShort(0);

			packet.PutShort(0); // count1
			packet.PutByte(1); // count2
			packet.PutByte(0);

			// for count2
			{
				packet.PutByte(3); // type

				// variable info values
				packet.PutFloat(-1845);
			}
		}

		/// <summary>
		/// Adds hit info data to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="hitInfo"></param>
		public static void AddHitInfo(this Packet packet, HitInfo hitInfo)
		{
			packet.PutInt((int)hitInfo.Damage);
			packet.PutInt((int)hitInfo.Hp);
			packet.PutInt(hitInfo.HpPriority);
			packet.PutShort(0);

			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);

			packet.PutShort((short)hitInfo.ResultType);

			packet.PutByte(1);
			packet.PutByte(0);
			packet.PutByte(0);
			packet.PutByte(0);
		}
	}
}
