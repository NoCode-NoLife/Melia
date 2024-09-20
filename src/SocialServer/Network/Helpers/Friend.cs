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

			// Friend
			{
				packet.PutLong(0);
				packet.PutLong(user.Id);
				packet.PutString(user.TeamName, 64);
				packet.PutString("", 56);
				packet.PutLong(0);
				packet.PutInt(character.Level);

				// Appearance
				{
					packet.PutString(character.TeamName, 64);
					packet.PutString(character.Name, 64);
					packet.PutShort(0);
					packet.PutShort((int)character.JobId);
					packet.PutInt(0);
					packet.PutInt(0);
					packet.PutShort((short)character.Gender);
					packet.PutInt(character.Hair);
					packet.PutEmptyBin(26);
					packet.PutUInt(0xFF808080); // either not skin color or wrong place?
					packet.PutEmptyBin(16);
				}

				packet.PutShort(0);
				packet.PutShortDate(user.LastLogin);
				packet.PutString("", 32);
				packet.PutByte(0);
			}

			packet.PutShort(character.MapId);
			packet.PutShort(character.ChannelId);
			packet.PutLpString(friend.Group);
			packet.PutLpString(friend.Note);
		}
	}
}
