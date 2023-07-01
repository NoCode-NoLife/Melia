using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Items;

namespace Melia.Zone.World.Actors.Accounts.Components
{
	/// <summary>
	/// Represents the storage component
	/// </summary>
	public class TeamStorageComponent : AccountComponent
	{
		// Items in storage, key is position slot in storage
		private Dictionary<int, Item> _items = new Dictionary<int, Item>();

		/// <summary>
		/// Creates a new storage component
		/// </summary>
		/// <param name="account"></param>
		public TeamStorageComponent(Account account) : base(account)
		{
			// Test
			_items.Add(0, new Item(221111, 1));
			_items.Add(1, new Item(221112, 1));
		}

		/// <summary>
		/// Returns list of items in storage. Key is position slot
		/// in storage
		/// </summary>
		/// <returns></returns>
		public List<Item> GetItems()
		{
			return _items.Values.ToList();
		}

	}
}
