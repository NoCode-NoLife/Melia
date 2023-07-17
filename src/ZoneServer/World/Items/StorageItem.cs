using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.ObjectProperties;

namespace Melia.Zone.World.Items
{
	/// <summary>
	/// This class represents an item in storage.
	/// This can be personal or team storage.
	/// </summary>
	public class StorageItem
	{
		private static long Ids;

		/// <summary>
		/// Storage Item's unique Id
		/// </summary>
		public long Id { get; private set; }

		/// <summary>
		/// Item's object reference
		/// </summary>
		public Item Item { get; set; }

		/// <summary>
		/// Item's position in storage
		/// </summary>
		public int Position { get; set; }

		/// <summary>
		/// Creates new storage item
		/// </summary>
		/// <param name="item"></param>
		/// <param name="position"></param>
		public StorageItem(Item item, int position)
		{
			this.Id = Interlocked.Increment(ref Ids);
			this.Item = item;
			this.Position = position;
		}
	}
}
