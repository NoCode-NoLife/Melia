using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents social.conf.
	/// </summary>
	public class SocialConf : ConfFile
	{
		public int RoomMemberMaxCount { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.RoomMemberMaxCount = this.GetInt("room_member_max_count", 20);
		}
	}
}
