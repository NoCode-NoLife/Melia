using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Zone.Network;
using Yggdrasil.Network.Communication;

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
		/// Returns the collection with the given id via out. Returns false if
		/// the collection doesn't exist.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <param name="collection"></param>
		/// <returns></returns>
		public bool TryGet(int collectionId, out Collection collection)
		{
			lock (_syncLock)
				return _collections.TryGetValue(collectionId, out collection);
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
		/// Adds a new collection. Returns false if the collection already existed.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns></returns>
		public bool Add(int collectionId)
		{
			lock (_syncLock)
			{
				if (_collections.ContainsKey(collectionId))
					return false;

				_collections.Add(collectionId, new Collection(collectionId));

				return true;
			}
		}

		/// <summary>
		/// Adds the given collection or overrides it if it already exists.
		/// </summary>
		/// <remarks>
		/// The method is primarily intended for loading collections from the
		/// database.
		/// </remarks>
		/// <param name="collectionId"></param>
		/// <param name="redeemCount"></param>
		internal Collection InitAdd(int collectionId, int redeemCount)
		{
			lock (_syncLock)
			{
				var collection = new Collection(collectionId);
				collection.RedeemCount = redeemCount;

				return _collections[collectionId] = collection;
			}
		}

		/// <summary>
		/// Registers the item to the collection without triggering checks or
		/// events.
		/// </summary>
		/// <remarks>
		/// The method is primarily intended for loading collections from the
		/// database.
		/// </remarks>
		/// <param name="collectionId"></param>
		/// <param name="itemId"></param>
		internal void InitRegisterItem(int collectionId, int itemId)
		{
			if (this.TryGet(collectionId, out var collection))
				collection.RegisterItem(itemId);
		}

		/// <summary>
		/// Returns whether the given collection was completed.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns></returns>
		public bool IsComplete(int collectionId)
		{
			if (this.TryGet(collectionId, out var collection))
				return collection.IsComplete;

			return false;
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
			if (!this.TryGet(collectionId, out var collection))
				return false;

			if (!collection.RegisterItem(itemId))
				return false;

			if (collection.IsComplete)
				this.OnCompleted(collection);

			return true;
		}

		/// <summary>
		/// Called when a collection was completed, grants rewards to current
		/// character.
		/// </summary>
		/// <param name="collection"></param>
		private void OnCompleted(Collection collection)
		{
			this.GrantRewards(collection, this.Character);
		}

		/// <summary>
		/// Grants all rewards of all collections they are eligible for to the
		/// current character.
		/// </summary>
		public void GrantEligibleRewards()
		{
			foreach (var collection in this.GetList().Where(a => a.IsComplete))
				this.GrantRewards(collection, this.Character);
		}

		/// <summary>
		/// Grants the collection's rewards to the given character.
		/// </summary>
		/// <param name="collection"></param>
		/// <param name="character"></param>
		private void GrantRewards(Collection collection, Character character)
		{
			if (!collection.GotPropertyBonuses(character))
				collection.GrantPropertyBonuses(character);

			if (!collection.GotAccountPropertyBonuses(character))
				collection.GrantAccountPropertyBonuses(character);
		}
	}

	/// <summary>
	/// Represents a collection of a player.
	/// </summary>
	public class Collection
	{
		private readonly object _syncLock = new();
		private readonly List<int> _registeredItems = new();

		/// <summary>
		/// Returns the collection's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns a reference to the collection data.
		/// </summary>
		public CollectionData Data { get; }

		/// <summary>
		/// Returns the number of times the collection's item rewards have
		/// been redeemed.
		/// </summary>
		public int RedeemCount { get; internal set; }

		/// <summary>
		/// Returns the maximum number of times the collection's item rewards
		/// can be redeemed.
		/// </summary>
		public int RedeemMax => this.Data.RedeemMax;

		/// <summary>
		/// Returns true if the collection's item rewards have been redeemed
		/// the maximum number of times.
		/// </summary>
		public bool RedeemMaxReached => this.RedeemCount >= this.RedeemMax;

		/// <summary>
		/// Returns true if the collection is complete.
		/// </summary>
		public bool IsComplete { get { lock (_syncLock) return _registeredItems.Count >= this.Data.RequiredItems.Count; } }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="collectionId"></param>
		public Collection(int collectionId)
		{
			if (!ZoneServer.Instance.Data.CollectionDb.TryFindByClassId(collectionId, out var data))
				throw new ArgumentException($"Collection with id {collectionId} not found in data.");

			this.Id = data.Id;
			this.Data = data;
		}

		/// <summary>
		/// Returns a list of ids for the items registered to this collection.
		/// </summary>
		/// <returns></returns>
		public List<int> GetRegisteredItems()
		{
			lock (_syncLock)
				return _registeredItems.ToList();
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

			lock (_syncLock)
			{
				var registeredCount = _registeredItems.Count(a => a == itemId);
				var gotAll = registeredCount >= neededCount;

				if (gotAll)
					return false;

				_registeredItems.Add(itemId);
			}

			return true;
		}

		/// <summary>
		/// Grants the collection's property bonuses to the given character.
		/// </summary>
		/// <param name="character"></param>
		public void GrantPropertyBonuses(Character character)
		{
			var rewardProperties = this.Data.RewardProperties;

			foreach (var bonus in rewardProperties)
			{
				var propertyName = bonus.Key;
				var value = bonus.Value;

				character.Properties.Modify(propertyName, value);
			}

			character.Variables.Perm.SetBool("Melia.Collections.GotProperties_" + this.Id, true);

			character.Properties.InvalidateAll();
			Send.ZC_OBJECT_PROPERTY(character);
		}

		/// <summary>
		/// Grants the collection's account property bonuses to the given
		/// character's account.
		/// </summary>
		/// <param name="character"></param>
		public void GrantAccountPropertyBonuses(Character character)
		{
			var account = character.Connection.Account;
			var rewardProperties = this.Data.RewardAccountProperties;

			foreach (var bonus in rewardProperties)
			{
				var propertyName = bonus.Key;
				var value = bonus.Value;

				account.Properties.Modify(propertyName, value);
			}

			account.Variables.Perm.SetBool("Melia.Collections.GotProperties_" + this.Id, true);

			account.Properties.InvalidateAll();
			Send.ZC_NORMAL.AccountProperties(character);
		}

		/// <summary>
		/// Grants the collection's item rewards to the given character.
		/// </summary>
		/// <param name="character"></param>
		public void GrantItemRewards(Character character)
		{
			var rewardItems = this.Data.RewardItems;

			foreach (var rewardItem in rewardItems)
			{
				var itemId = rewardItem.Key;
				var amount = rewardItem.Value;

				character.Inventory.Add(itemId, amount);
			}

			this.RedeemCount++;
		}

		/// <summary>
		/// Returns whether the character was already granted the collection's
		/// property bonuses.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public bool GotPropertyBonuses(Character character)
		{
			return character.Variables.Perm.GetBool("Melia.Collections.GotProperties_" + this.Id);
		}

		/// <summary>
		/// Returns whether the character was already granted the collection's
		/// account property bonuses.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public bool GotAccountPropertyBonuses(Character character)
		{
			return character.Connection.Account.Variables.Perm.GetBool("Melia.Collections.GotProperties_" + this.Id);
		}
	}
}
