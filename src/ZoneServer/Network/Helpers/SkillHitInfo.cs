using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
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

			packet.PutInt(skillHitInfo.IsKnockBack ? 1 : 0);
			packet.PutShort((short)skillHitInfo.DamageDelay.TotalMilliseconds);
			packet.PutByte(0);

			packet.PutByte(0);
			packet.PutShort((short)skillHitInfo.SkillHitDelay.TotalMilliseconds); // Skill Hit Delay? Adds pause in attack animation?
			packet.PutByte((byte)skillHitInfo.HitEffect);
			packet.PutByte(0);
			packet.PutInt(0);
			packet.PutInt(skillHitInfo.ForceId); // This being set to anything causes a delay in the dagger damage animation
			packet.PutShort(0);
			packet.PutShort(0);

			packet.PutShort(0); // count1
			packet.PutByte(2); // count2
			packet.PutByte(0);

			if (skillHitInfo.IsKnockBack)
			{
				var kb = skillHitInfo.KnockBackInfo;

				packet.PutPosition(kb.FromPosition);
				packet.PutPosition(kb.ToPosition);
				packet.PutInt(kb.Velocity);
				packet.PutInt(kb.HAngle);
				packet.PutInt(kb.VAngle);
				packet.PutInt(0);
				packet.PutShort((short)kb.Time.TotalMilliseconds);
				packet.PutShort(0);
				packet.PutFloat(1);
				packet.PutFloat(1);
				packet.PutInt(0);
				packet.PutInt(0);
			}

			// for count2
			{
				// Type 0 is for multi hits. The damage is divided by
				// the hit count and the displayed damage splits up
				// into multiple hits.
				packet.PutByte(0);
				packet.PutInt(skillHitInfo.HitCount);
				packet.PutByte(0);
				packet.PutInt(0);

				// The purpose of type 3 is unknown, usually comes with a
				// negative float.
				packet.PutByte(3);
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
			packet.PutShort((short)hitInfo.Type);

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
