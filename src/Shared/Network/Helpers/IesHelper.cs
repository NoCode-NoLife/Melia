using System.Linq;
using Melia.Shared.IES;

namespace Melia.Shared.Network.Helpers
{
	/// <summary>
	/// Extension methods for writing IES-related information to packets.
	/// </summary>
	public static class IesHelper
	{
		/// <summary>
		/// Adds IES mods to packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="iesModList"></param>
		public static void AddIesModList(this Packet packet, IesModList iesModList)
		{
			packet.PutShort(iesModList.Mods.Count);
			foreach (var group in iesModList.Mods.Values)
			{
				packet.PutLpString(group.Namespace);
				packet.PutShort(group.Classes.Count);

				foreach (var cls in group.Classes.Values)
				{
					packet.PutInt(cls.ClassId);
					packet.PutShort(cls.Properties.Count);

					foreach (var property in cls.Properties.Values)
					{
						packet.PutLpString(property.Name);
						packet.PutShort(property.Changes.Count);

						foreach (var change in property.Changes.OrderByDescending(a => a.Revision))
						{
							packet.PutInt(change.Revision);
							packet.PutLpString(change.OldValue);
							packet.PutLpString(change.NewValue);
							packet.PutLpString(change.AuthorName);
							packet.PutLpString(change.Date.ToString("yyyy-M-d H:m"));
							packet.PutLpString(change.Comment);
						}
					}
				}
			}
		}
	}
}
