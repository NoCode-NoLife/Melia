using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Zone.World.Groups;

namespace Melia.Zone.Network.Helpers
{
	public static class PartyHelper
	{
		public static void AddPartyMember(this Packet packet, PartyMember member)
		{
			packet.PutLong(member.AccountId);
			packet.PutString(member.TeamName, 64);
			packet.PutLong(0);
			packet.PutInt(0);
			packet.PutInt(0);
			packet.PutInt(member.IsOnline ? member.MapId : 0);
			packet.PutInt(member.Handle);
			packet.PutString(member.TeamName, 64);
			packet.PutString(member.Name, 64);
			packet.PutByte(0);
			packet.PutByte(0x40);
			packet.PutShort((short)member.VisualJobId);
			packet.PutShort((short)member.FirstJobId);
			packet.PutShort(0);
			packet.PutInt(member.JobLevel);
			packet.PutShort(1);
			packet.PutInt(46);
			packet.PutEmptyBin(18);
			packet.PutInt(member.ServerGroup);
			packet.PutInt(member.Level);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0xFF);
			packet.PutShort((short)member.FirstJobId);
			packet.PutShort((short)member.SecondJobId);
			packet.PutShort((short)member.ThirdJobId);
			packet.PutShort((short)member.FourthJobId);
			packet.PutEmptyBin(4);
			packet.PutShort(0);
			packet.PutShort(1);
			packet.PutInt(member.Level);
			packet.PutPosition(member.Position);
			packet.PutInt(member.Sp);
			packet.PutInt(member.Hp);
			packet.PutInt(member.MaxSp);
			packet.PutInt(member.MaxHp);
			packet.PutInt(0);
			packet.PutInt(member.Level);
			packet.PutShort(0);
		}

		public static void AddPartyInstantMemberInfo(this Packet packet, PartyMember member)
		{
			packet.PutLong(member.AccountId);
			packet.PutPosition(member.Position);
			packet.PutInt(member.Sp);
			packet.PutInt(member.Hp);
			packet.PutInt(member.MaxSp);
			packet.PutInt(member.MaxHp);
			packet.PutInt(0);
			packet.PutInt(member.Level);
		}
	}
}
