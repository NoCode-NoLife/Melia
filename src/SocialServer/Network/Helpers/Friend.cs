using Melia.Shared.Network;
using Melia.Social.Database;

namespace Melia.Social.Network.Helpers
{
	/// <summary>
	/// Helpers for sending friend data.
	/// </summary>
	public static class FriendHelper
	{
		/// <summary>
		/// Adds friend data to packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="friend"></param>
		public static void AddFriend(this Packet packet, Friend friend)
		{
			packet.PutLong(0);
			packet.PutLong(friend.AccountId);
			packet.PutString(friend.TeamName, 64);
			packet.PutString("", 56);
			packet.PutLong(0);
			packet.PutInt(friend.Character.Level);
			packet.PutString(friend.Character.Name, 128);
			packet.PutShort((short)friend.Character.Gender);
			packet.PutInt((int)friend.Character.JobId);
			packet.PutShort(0);
			packet.PutInt(0);
			packet.PutShort(1);
			packet.PutInt(friend.Character.Hair);
			packet.PutEmptyBin(26);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0xFF);
			packet.PutEmptyBin(18);
			packet.PutShortDate(friend.LastLogin);
			packet.PutEmptyBin(36);
			packet.PutByte(0);
			packet.PutLpString(friend.Group);
			packet.PutLpString(friend.Note);
		}
	}
}
