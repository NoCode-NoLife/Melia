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
			var user = friend.User;
			var character = user.Character;

			packet.PutLong(0);
			packet.PutLong(user.Id);
			packet.PutString(user.TeamName, 64);
			packet.PutString("", 56);
			packet.PutLong(0);
			packet.PutInt(character.Level);
			packet.PutString(character.Name, 128);
			packet.PutShort((short)character.Gender);
			packet.PutInt((int)character.JobId);
			packet.PutShort(0);
			packet.PutInt(0);
			packet.PutShort(1);
			packet.PutInt(character.Hair);
			packet.PutEmptyBin(26);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0x80);
			packet.PutByte(0xFF);
			packet.PutEmptyBin(18);
			packet.PutShortDate(friend.User.LastLogin);
			packet.PutEmptyBin(36);
			packet.PutByte(0);
			packet.PutLpString(friend.Group);
			packet.PutLpString(friend.Note);
		}
	}
}
