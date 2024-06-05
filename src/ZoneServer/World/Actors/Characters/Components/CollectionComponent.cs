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
using Melia.Shared.Game.Const;

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
		/// <param name="silent">Skips updating the client of any stat changes</param>
		/// </summary>
		public bool RegisterItem(int collectionId, ItemData item, bool silent = false)
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
					if (collectionProgress.data.RewardProperties != "")
					{
						GiveBonuses(collectionProgress.data.RewardProperties, silent);
					}						
				}
				return true;
			}
		}

		/// <summary>
		/// Grants bonus properties
		/// <param name="silent">Skips updating the client</param>
		/// </summary>
		public void GiveBonuses(string bonusProperties, bool silent = false)
		{
			var properties = Character.Properties;

			string[] bonusList = bonusProperties.Split("/");
			if (bonusList.Length >= 2)
			{
				for (int i = 0; i < bonusList.Length; i += 2)
				{
					switch (bonusList[i])
					{
						case "STR_BM":
							properties.SetFloat(PropertyName.STR_BM, properties.GetFloat(PropertyName.STR_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "DEX_BM":
							properties.SetFloat(PropertyName.DEX_BM, properties.GetFloat(PropertyName.DEX_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "INT_BM":
							properties.SetFloat(PropertyName.INT_BM, properties.GetFloat(PropertyName.INT_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "MNA_BM":
							properties.SetFloat(PropertyName.MNA_BM, properties.GetFloat(PropertyName.MNA_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "CON_BM":
							properties.SetFloat(PropertyName.CON_BM, properties.GetFloat(PropertyName.CON_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "MHP_BM":
							properties.SetFloat(PropertyName.MHP_BM, properties.GetFloat(PropertyName.MHP_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "MSP_BM":
							properties.SetFloat(PropertyName.MSP_BM, properties.GetFloat(PropertyName.MSP_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "MaxSta_BM":
							properties.SetFloat(PropertyName.MaxSta_BM, properties.GetFloat(PropertyName.MaxSta_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "MaxWeight_BM":
							properties.SetFloat(PropertyName.MaxWeight_BM, properties.GetFloat(PropertyName.MaxWeight_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "RHP_BM":
							properties.SetFloat(PropertyName.RHP_BM, properties.GetFloat(PropertyName.RHP_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "RSP_BM":
							properties.SetFloat(PropertyName.RSP_BM, properties.GetFloat(PropertyName.RSP_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "HR_BM":
							properties.SetFloat(PropertyName.HR_BM, properties.GetFloat(PropertyName.HR_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "DR_BM":
							properties.SetFloat(PropertyName.DR_BM, properties.GetFloat(PropertyName.DR_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "PATK_BM":
							properties.SetFloat(PropertyName.PATK_BM, properties.GetFloat(PropertyName.PATK_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "MATK_BM":
							properties.SetFloat(PropertyName.MATK_BM, properties.GetFloat(PropertyName.MATK_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "DEF_BM":
							properties.SetFloat(PropertyName.DEF_BM, properties.GetFloat(PropertyName.DEF_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "MDEF_BM":
							properties.SetFloat(PropertyName.MDEF_BM, properties.GetFloat(PropertyName.MDEF_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "CRTATK_BM":
							properties.SetFloat(PropertyName.CRTATK_BM, properties.GetFloat(PropertyName.CRTATK_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "CRTMATK_BM":
							properties.SetFloat(PropertyName.CRTMATK_BM, properties.GetFloat(PropertyName.CRTMATK_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "CRTHR_BM":
							properties.SetFloat(PropertyName.CRTHR_BM, properties.GetFloat(PropertyName.CRTHR_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "CRTDR_BM":
							properties.SetFloat(PropertyName.CRTDR_BM, properties.GetFloat(PropertyName.CRTDR_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "ResFire_BM":
							properties.SetFloat(PropertyName.ResFire_BM, properties.GetFloat(PropertyName.ResFire_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "ResIce_BM":
							properties.SetFloat(PropertyName.ResIce_BM, properties.GetFloat(PropertyName.ResIce_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "ResLightning_BM":
							properties.SetFloat(PropertyName.ResLightning_BM, properties.GetFloat(PropertyName.ResLightning_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "ResEarth_BM":
							properties.SetFloat(PropertyName.ResEarth_BM, properties.GetFloat(PropertyName.ResEarth_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "ResPoison_BM":
							properties.SetFloat(PropertyName.ResPoison_BM, properties.GetFloat(PropertyName.ResPoison_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "ResDark_BM":
							properties.SetFloat(PropertyName.ResDark_BM, properties.GetFloat(PropertyName.ResDark_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "ResHoly_BM":
							properties.SetFloat(PropertyName.ResHoly_BM, properties.GetFloat(PropertyName.ResHoly_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "BLK_BM":
							properties.SetFloat(PropertyName.BLK_BM, properties.GetFloat(PropertyName.BLK_BM) + float.Parse(bonusList[i + 1]));
							break;
						case "BLK_BREAK_BM":
							properties.SetFloat(PropertyName.BLK_BREAK_BM, properties.GetFloat(PropertyName.BLK_BREAK_BM) + float.Parse(bonusList[i + 1]));
							break;
						default:
							Log.Warning("Unknown collection reward property specified: {0}", bonusList[i]);
							break;
					}
				}

				// Tell the system it needs to recalculate the character's stats unless silent mode is on
				if (!silent)
				{
					properties.InvalidateAll();
					Send.ZC_OBJECT_PROPERTY(Character);
				}
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
