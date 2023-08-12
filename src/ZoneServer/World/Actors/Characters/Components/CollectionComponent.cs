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
		private readonly static TimeSpan AutoReceiveDelay = TimeSpan.FromMinutes(1);

		private readonly object _syncLock = new object();
		private readonly Dictionary<int, CollectionData> _collectionList = new Dictionary<int, CollectionData>();
		private readonly Dictionary<int, List<int>> _collectionProgress = new Dictionary<int, List<int>>();		
		private TimeSpan _autoReceiveDelay = AutoReceiveDelay;

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public CollectionComponent(Character character)
			: base(character)
		{
		}


		/// <summary>
		/// Adds a new empty Collection.
		/// <param name="collectionId"></param>
		public bool Add(int collectionId)
		{
			lock (_syncLock)
			{
				if (ZoneServer.Instance.Data.CollectionDb.TryFind(collectionId, out var collectionData) && !_collectionList.ContainsKey(collectionId))
				{
					_collectionList.Add(collectionId, collectionData);
					_collectionProgress.Add(collectionId, new List<int>());
					return true;
				}
				return false;
			}
		}


		/// <summary>
		/// Adds a Collection without informing the client.
		/// </summary>
		/// <remarks>
		/// This is primarily used while the character and its quests are
		/// loaded from the database.
		/// </remarks>
		/// <param name="collectionId"></param>
		/// <param name="registeredItems"></param>
		public void AddSilent(int collectionId, List<int> registeredItems)
		{
			lock (_syncLock)
			{
				if (ZoneServer.Instance.Data.CollectionDb.TryFind(collectionId, out var collectionData))
				{
					_collectionList.Add(collectionId, collectionData);
					_collectionProgress.Add(collectionId, registeredItems);
					if (registeredItems.Count == collectionData.RequiredItems.Count)
					{
						// TODO: Add the reward to the list of earned rewards
					}
				}
			}
		}

		/// <summary>
		/// Gets a collection and returns the list of items registered to it.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <param name="registeredItems"></param>
		/// <returns></returns>
		public bool TryGet(int collectionId, out List<int> registeredItems)
		{
			lock (_syncLock)
				return _collectionProgress.TryGetValue(collectionId, out registeredItems);
		}

		/// <summary>
		/// Returns the total number of registered collections
		/// </summary>
		/// <returns></returns>
		public int Count()
		{
			lock (_syncLock)
				return _collectionList.Count;
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
				if (_collectionProgress.TryGetValue(collectionId, out var progress))
					return progress;
				return null;
			}
		}


		/// <summary>
		/// Registers an item to this collection
		/// <param name="collectionId"></param>
		/// <param name="item"></param>
		/// </summary>
		public bool RegisterItem(int collectionId, Item item)
		{
			lock (_syncLock)
			{
				if (_collectionList.TryGetValue(collectionId, out var collectionData))
					if (collectionData.RequiredItems.Contains(item.Data.ClassName))
						if (_collectionProgress.TryGetValue(collectionId, out var collectionProgress))
						{ 
							// First need to check how many times this item appears in the collection
							var itemsNeeded = collectionData.RequiredItems.Count(a => a.Equals(item.Data.ClassName));
							var itemsAddedAlready = collectionProgress.Count(a => a == item.Id);

							if (itemsNeeded > itemsAddedAlready)
							{ 
								collectionProgress.Add(item.Data.Id);
								if (collectionProgress.Count == collectionData.RequiredItems.Count)
								{
									// TODO: Give the award here and re-calculate stats
								}
								return true;
							}
						}
				return false;
			}
		}
	}
}
