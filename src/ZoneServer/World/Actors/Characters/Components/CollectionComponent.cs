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
		/// <exception cref="ArgumentException"></exception>
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
		/// Returns whether the given collection was completed.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns></returns>
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
		/// Returns the number of times the given collection was redeemed.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns></returns>
		public int GetRedeemCount(int collectionId)
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
		/// Returns a list of ids for the items that were registered to
		/// the given collection. Returns null if the collection hasn't
		/// been registered yet.
		/// </summary>
		/// <param name="collectionId"></param>
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
		/// Registers an item to this collection.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <param name="itemData"></param>
		/// <param name="silent">If true, the client is not updated.</param>
		/// <returns></returns>
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
		/// Grants the given bonus properties to the current character.
		/// </summary>
		/// <param name="silent">If true, the client is not updated.</param>
		/// <param name="multiplier">Bonuses are multiplied by this amount, use -1 to remove the bonus.</param>
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
		/// Removes all property bonuses. This must be done before saving the
		/// properties, so the bonuses don't stack infinitely.
		/// </summary>
		/// <param name="silent">If true, the client is not updated.</param>
		public void RemoveAllBonuses()
		{
			foreach (var collection in _collections.Values)
			{
				if (collection.IsComplete && collection.Data.RewardProperties.Any())
					this.AddBonuses(collection.Data.RewardProperties, true, -1);
			}
		}

		/// <summary>
		/// Redeems all available collections one time.
		/// </summary>
		/// <param name="toCharacterStorage">If false, the item is added to the character's storage.</param>
		public void RedeemAll(bool toCharacterStorage)
		{
			// TODO: Implement.
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
