using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Zone.Network;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// A character's collection manager.
	/// </summary>
	/// <remarks>
	/// While we appear to manage collections on a per-character basis,
	/// they're actually account-wide.
	/// </remarks>
	public class CollectionComponent : CharacterComponent
	{
		private readonly object _syncLock = new();
		private readonly Dictionary<int, CollectionProgress> _collections = new();

		/// <summary>
		/// Returns the total number of registered collections.
		/// </summary>
		/// <returns></returns>
		public int Count { get { lock (_syncLock) return _collections.Count; } }

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public CollectionComponent(Character character)
			: base(character)
		{
		}

		/// <summary>
		/// Adds a new collection, optionally specifying the number of times
		/// it has already been redeemed. Returns false if the collection
		/// already existed.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <param name="redeemCount"></param>
		/// <returns></returns>
		public bool Add(int collectionId, int redeemCount = 0)
		{
			if (!ZoneServer.Instance.Data.CollectionDb.TryFindByClassId(collectionId, out var collectionData))
				throw new ArgumentException($"Collection with id {collectionId} not found in data.");

			lock (_syncLock)
			{
				if (_collections.ContainsKey(collectionId))
					return false;

				var newCollection = new CollectionProgress(collectionData);
				newCollection.RedeemCount = redeemCount;

				_collections.Add(collectionId, newCollection);

				return true;
			}
		}


		/// <summary>
		/// Returns if a given collection is complete
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns>false if the collection isn't complete or hasn't been registered at all</returns>
		public bool IsComplete(int collectionId)
		{
			lock (_syncLock)
			{
				if (_collections.TryGetValue(collectionId, out var progress))
					return progress.IsComplete;
			}

			return false;
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
				if (_collections.TryGetValue(collectionId, out var progress))
					return progress.RedeemCount;
			}

			return 0;
		}

		/// <summary>
		/// Returns a list of ids for the items registered to the given collection.
		/// Returns false if the collection hasn't been registered yet.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <param name="itemIds"></param>
		/// <returns></returns>
		public bool TryGetItems(int collectionId, out List<int> itemIds)
		{
			lock (_syncLock)
			{
				if (_collections.TryGetValue(collectionId, out var progress))
				{
					itemIds = progress.RegisteredItems.ToList();
					return true;
				}
			}

			itemIds = null;
			return false;
		}

		/// <summary>
		/// Returns the list of all collections the user has registered
		/// </summary>
		/// <returns></returns>
		public List<int> GetList()
		{
			lock (_syncLock)
				return _collections.Keys.ToList();
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
				if (this.TryGetItems(collectionId, out var progress))
					return progress;
			}

			return null;
		}


		/// <summary>
		/// Registers an item to this collection
		/// <param name="collectionId"></param>
		/// <param name="itemData"></param>
		/// <param name="silent">Skips updating the client of any stat changes</param>
		/// </summary>
		public bool RegisterItem(int collectionId, ItemData itemData, bool silent = false)
		{
			lock (_syncLock)
			{
				if (!_collections.TryGetValue(collectionId, out var collectionProgress))
					return false;

				if (!collectionProgress.RegisterItem(itemData))
					return false;

				if (collectionProgress.IsComplete)
				{
					if (collectionProgress.Data.RewardProperties.Any())
						this.AddBonuses(collectionProgress.Data.RewardProperties, silent);
				}

				return true;
			}
		}

		/// <summary>
		/// Grants bonus properties
		/// <param name="silent">Skips updating the client</param>
		/// <param name="multiplier">Multiplies by this amount, use -1 to remove the bonus</param>
		/// </summary>
		public void AddBonuses(Dictionary<string, int> bonusProperties, bool silent = false, int multiplier = 1)
		{
			var properties = this.Character.Properties;

			if (bonusProperties.Any())
			{
				foreach (var bonus in bonusProperties)
					properties.Modify(bonus.Key, bonus.Value * multiplier);

				if (!silent)
				{
					properties.InvalidateAll();
					Send.ZC_OBJECT_PROPERTY(this.Character);
				}
			}
		}


		/// <summary>
		/// Removes all bonus properties.  This must be done before saving the properties,
		/// so the bonuses don't infinitely stack
		/// <param name="silent">Skips updating the client</param>
		/// </summary>
		public void RemoveAllBonuses()
		{
			foreach (var key in _collections.Keys)
			{
				var collection = _collections[key];

				if (collection.IsComplete && collection.Data.RewardProperties.Any())
					this.AddBonuses(collection.Data.RewardProperties, true, -1);
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

		/// <summary>
		/// Represents the progress made on a collection.
		/// </summary>
		private class CollectionProgress
		{
			/// <summary>
			/// Returns a reference to the collection data.
			/// </summary>
			public CollectionData Data { get; }

			/// <summary>
			/// Returns a list of ids for the items registered.
			/// </summary>
			public List<int> RegisteredItems { get; } = new();

			/// <summary>
			/// Returns the number of times the collection has been redeemed.
			/// </summary>
			public int RedeemCount { get; set; }

			/// <summary>
			/// Returns true if the collection is complete.
			/// </summary>
			public bool IsComplete => this.Data.RequiredItems.Count == this.RegisteredItems.Count;

			/// <summary>
			/// Creates new instance.
			/// </summary>
			/// <param name="data"></param>
			public CollectionProgress(CollectionData data)
			{
				this.Data = data;
			}

			/// <summary>
			/// Registers an item to this collection.
			/// </summary>
			/// <param name="item"></param>
			/// <returns></returns>
			public bool RegisterItem(ItemData item)
			{
				if (!this.Data.RequiredItems.ContainsKey(item.ClassName))
					return false;

				var neededCount = this.Data.RequiredItems.Count(a => a.Equals(item.ClassName));
				var addedCount = this.RegisteredItems.Count(a => a == item.Id);

				if (addedCount >= neededCount)
					return false;

				this.RegisteredItems.Add(item.Id);

				return true;
			}
		}
	}
}
