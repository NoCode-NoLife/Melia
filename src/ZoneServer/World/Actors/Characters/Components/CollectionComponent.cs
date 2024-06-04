using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Melia.Zone.World.Items;
using Melia.Shared.Data.Database;
using Melia.Shared.Scripting;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// A character's collection manager.
	/// </summary>
	/// <remarks>
	/// An important thing to note about the collection system is that Collections are account-level.
	/// </remarks>
	public class CollectionComponent : CharacterComponent
	{
		private class CollectionProgress
		{
			public CollectionData data;
			public List<int> registeredItems;
			public int redeemCount;

			public CollectionProgress(CollectionData data)
			{
				this.data = data;
				registeredItems = new List<int>();
				redeemCount = 0;
			}

			public bool registerItem(ItemData item)
			{
				if (!data.RequiredItems.Contains(item.ClassName))
					return false;

				var itemsNeeded = data.RequiredItems.Count(a => a.Equals(item.ClassName));
				var itemsAddedAlready = registeredItems.Count(a => a == item.Id);

				if (itemsAddedAlready >= itemsNeeded)
					return false;

				registeredItems.Add(item.Id);
				return true;
			}

			public bool isComplete
				=> data.RequiredItems.Count == registeredItems.Count;
		}

		private readonly object _syncLock = new object();
		private readonly Dictionary<int, CollectionProgress> _collectionList = new Dictionary<int, CollectionProgress>();

		/// <summary>
		/// Returns the total number of registered collections
		/// </summary>
		/// <returns></returns>
		public int Count
			=> _collectionList.Count;


		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public CollectionComponent(Character character)
			: base(character)
		{
		}


		/// <summary>
		/// Creates a new empty Collection, optionally specifying the number of times it has already been redeemed
		/// <param name="collectionId"></param>
		/// <param name="redeemCount"></param>
		public bool Add(int collectionId, int redeemCount = 0)
		{
			lock (_syncLock)
			{
				if (ZoneServer.Instance.Data.CollectionDb.TryFind(collectionId, out var collectionData) && !_collectionList.ContainsKey(collectionId))
				{
					var newCollection = new CollectionProgress(collectionData);
					newCollection.redeemCount = redeemCount;
					_collectionList.Add(collectionId, newCollection);

					return true;
				}
				return false;
			}
		}


		/// <summary>
		/// Returns if a given collection is complete
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns>false if the collection isn't complete or hasn't been registered at all</returns>
		public bool isComplete(int collectionId)
		{
			lock (_syncLock)
			{
				if (_collectionList.TryGetValue(collectionId, out var collectionProgress))
					return collectionProgress.isComplete;
				else
					return false;
			}
		}


		/// <summary>
		/// Returns the number of times a given collection was redeemed
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns>0 if the collection isn't present at all</returns>
		public int getRedeemCount(int collectionId)
		{
			lock (_syncLock)
			{
				if (_collectionList.TryGetValue(collectionId, out var collectionProgress))
					return collectionProgress.redeemCount;
				else
					return 0;
			}
		}

		/// <summary>
		/// Gets a collection and returns the list of items registered to it.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <param name="registeredItems"></param>
		/// <returns>false if the collection hasn't been registered at all</returns>
		public bool TryGetItems(int collectionId, out List<int> registeredItems)
		{
			lock (_syncLock)
			{
				if (_collectionList.TryGetValue(collectionId, out var collectionProgress)) {
					registeredItems = new List<int>(collectionProgress.registeredItems);
					return true;
				}
				else
				{
					registeredItems = null;
					return false;
				}
			}
		}		

		/// <summary>
		/// Returns the list of all collections the user has registered
		/// </summary>
		/// <returns></returns>
		public List<int> GetList()
		{
			lock (_syncLock)
				return _collectionList.Keys.ToList();
		}

		/// <summary>
		/// Returns the list of items currently registered to the given collection
		/// This list might be empty if no items are registered
		/// Returns null if the collection isn't registered at all
		/// </summary>
		/// <returns></returns>
		public List<int> GetProgress(int collectionId)
		{
			lock (_syncLock)
			{ 
				if (TryGetItems(collectionId, out var progress))
					return progress;
				return null;
			}
		}


		/// <summary>
		/// Registers an item to this collection
		/// <param name="collectionId"></param>
		/// <param name="item"></param>
		/// </summary>
		public bool RegisterItem(int collectionId, ItemData item)
		{
			lock (_syncLock)
			{
				if (!_collectionList.TryGetValue(collectionId, out var collectionProgress))
					return false;

				if (!collectionProgress.registerItem(item))
				{
					return false;
				}

				if (collectionProgress.isComplete)
				{
					// TODO: Give the award here and re-calculate stats
				}
				return true;
			}
		}

		/// <summary>
		/// Redeems all available collections one time
		/// <param name="toCharacterStorage">If false, goes to team storage instead</param>
		/// </summary>
		public void RedeemAll(bool toCharacterStorage)
		{
			// TODO: unimplemented
		}
	}
}
