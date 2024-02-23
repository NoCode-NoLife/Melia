using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.IES;

namespace Melia.Shared.Network.Helpers
{
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

		/// <summary>
		/// Splits up the given mod list into lists that can fit into one
		/// packet each.
		/// </summary>
		/// <param name="allMods"></param>
		/// <returns></returns>
		public static List<IesModList> BuildModLists(IesModList allMods)
		{
			// This... is not pretty, but there aren't many good ways to
			// do this. The IES modify list packets have a max length that
			// we can't go over (12 KB presumed), and due to the nested
			// lists in those packets, splitting them up dynamically by
			// packet size is challenging. It could be done, but honestly,
			// I dun wanna.
			//
			// This quick and dirty solution creates temporary packets to
			// measure the approximate lengths, starting a new list whenever
			// we reach the split threshold. Those lists we can then use
			// to send as man modify list packets as necessary.
			// 
			// One potential way to improve this in the future might be
			// to split the lists up as we're creating them, which would
			// be much more efficient.

			var modLists = new List<IesModList>();
			var curList = new IesModList();
			modLists.Add(curList);

			var splitLength = 1024 * 4;
			var curLength = 0;

			var packet = new Packet(Op.ZC_IES_MODIFY_LIST);

			foreach (var group in allMods.Mods.Values)
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
							var prevIndex = packet.GetCurrentIndex();

							packet.PutInt(change.Revision);
							packet.PutLpString(change.OldValue);
							packet.PutLpString(change.NewValue);
							packet.PutLpString(change.AuthorName);
							packet.PutLpString(change.Date.ToString("yyyy-M-d H:m"));
							packet.PutLpString(change.Comment);

							var newIndex = packet.GetCurrentIndex();
							var length = newIndex - prevIndex;
							curLength += length;

							if (curLength > splitLength)
							{
								packet = new Packet(Op.ZC_IES_MODIFY_LIST);
								curList = new IesModList();
								modLists.Add(curList);
								curLength = 0;
							}

							curList.AddUnsafe(group.Namespace, cls.ClassId, property.Name, change);
						}
					}
				}
			}

			return modLists;
		}
	}
}
