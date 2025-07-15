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

				// General character info? Same as in property compare.
				{
					packet.PutString(character.TeamName, 64);
					packet.PutString(character.Name, 65);
					packet.PutByte(0);
					packet.PutShort((short)character.JobId);
					packet.PutInt(1001); // serverGroupId?
					packet.PutInt(character.JobLevel);
					packet.PutShort((short)character.Gender);
					packet.PutInt(character.Hair);
					packet.PutEmptyBin(6);
					packet.PutEmptyBin(20); // 5 ints?
					packet.PutUInt(character.SkinColor); // Doesn't work. Wrong place?

					// Job ids
					for (var i = 0; i < 4; ++i)
						packet.PutShort(0);

					packet.PutLong(0);
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
