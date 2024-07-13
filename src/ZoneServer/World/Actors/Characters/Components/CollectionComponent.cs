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
		private readonly Dictionary<int, Collection> _collections = new();

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

				var collection = new Collection(collectionData);
				collection.RedeemCount = redeemCount;

				_collections.Add(collectionId, collection);

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
		/// Returns the list of all collections the user has registered.
		/// </summary>
		/// <returns></returns>
		public List<Collection> GetList()
		{
			lock (_syncLock)
				return _collections.Values.ToList();
		}

		/// <summary>
		/// Registers an item to this collection. Returns false if the collection
		/// didn't exist yet or the item is not needed.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <param name="itemId"></param>
		/// <param name="silent">If true, the client is not updated.</param>
		/// <returns></returns>
		public bool RegisterItem(int collectionId, int itemId, bool silent = false)
		{
			lock (_syncLock)
			{
				if (!_collections.TryGetValue(collectionId, out var collectionProgress))
					return false;

				if (!collectionProgress.RegisterItem(itemId))
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
		/// <param name="bonuses">List of bonuses, they key being a property name and the value the bonus.</param>
		/// <param name="silent">If true, the client is not updated.</param>
		/// <param name="multiplier">Bonuses are multiplied by this amount, use -1 to remove the bonus.</param>
		private void AddBonuses(Dictionary<string, int> bonuses, bool silent = false, int multiplier = 1)
		{
			if (!bonuses.Any())
				return;

			var properties = this.Character.Properties;

			foreach (var bonus in bonuses)
			{
				var propertyName = bonus.Key;
				var value = bonus.Value;

				properties.Modify(propertyName, value * multiplier);
			}

			if (!silent)
			{
				properties.InvalidateAll();
				Send.ZC_OBJECT_PROPERTY(this.Character);
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
	}

	/// <summary>
	/// Represents a collection of a player.
	/// </summary>
	public class Collection
	{
		/// <summary>
		/// Returns the collection's id.
		/// </summary>
		public int Id { get; }

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
		public bool IsComplete => this.RegisteredItems.Count >= this.Data.RequiredItems.Count;

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="data"></param>
		public Collection(CollectionData data)
		{
			this.Id = data.Id;
			this.Data = data;
		}

		/// <summary>
		/// Registers an item to this collection. Returns false if the item is
		/// not needed.
		/// </summary>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public bool RegisterItem(int itemId)
		{
			if (!this.Data.RequiredItems.TryGetValue(itemId, out var neededCount))
				return false;

			var registeredCount = this.RegisteredItems.Count(a => a == itemId);
			var gotAll = registeredCount >= neededCount;

			if (gotAll)
				return false;

			this.RegisteredItems.Add(itemId);

			return true;
		}
	}
}
