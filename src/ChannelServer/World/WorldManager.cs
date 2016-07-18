// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Channel.World.SkillEffects;

namespace Melia.Channel.World
{
	public class WorldManager
	{
		public const int HeartbeatTime = 100;
		public const int Second = 1000, Minute = Second * 60, Hour = Minute * 60;

		private int _handles = 0;

		private Dictionary<int, Map> _mapsId;
		private Dictionary<string, Map> _mapsName;
		private object _mapsLock = new object();

		private Timer _heartbeatTimer;

		public delegate EventResult EventHandle(EventData evData);
		private Dictionary<int, Dictionary<EventTypes, List<EventHandle>>> _eventBindings;

		/// <summary>
		/// Returns the amount of maps in the world.
		/// </summary>
		public int Count { get { lock (_mapsLock) return _mapsId.Count; } }

		/// <summary>
		/// Creates new world manager.
		/// </summary>
		public WorldManager()
		{
			_mapsId = new Dictionary<int, Map>();
			_mapsName = new Dictionary<string, Map>();

			_eventBindings = new Dictionary<int, Dictionary<EventTypes, List<EventHandle>>>();
		}

		/// <summary>
		/// Initializes heartbeat timer.
		/// </summary>
		private void SetUpHeartbeat()
		{
			var now = DateTime.Now;

			// Start timer on the next HeartbeatTime
			// (eg on the next full 500 ms) and run it regularly afterwards.
			_heartbeatTimer = new Timer(Heartbeat, null, HeartbeatTime - (now.Ticks / 10000 % HeartbeatTime), HeartbeatTime);
		}

		/// <summary>
		/// Handles regularly occuring events and raises time events.
		/// </summary>
		/// <remarks>
		/// On the first call all time events are raised,
		/// because lastHeartbeat is 0, and the events depend on the time
		/// since the last heartbeat. This also ensures that they aren't
		/// called multiple times.
		/// </remarks>
		private void Heartbeat(object _)
		{
			this.UpdateEntities();
		}

		/// <summary>
		/// Updates all entities on all maps.
		/// </summary>
		private void UpdateEntities()
		{
			lock (_mapsLock)
			{
				foreach (var map in _mapsId.Values)
					map.UpdateEntities();
			}
		}

		/// <summary>
		/// Returns a new handle to be used for a character or monster.
		/// </summary>
		/// <returns></returns>
		public int CreateHandle()
		{
			// TODO: 2b are a lot, but if items use this as well... we might
			//   need a fallback, or a way to release handles of logged out
			//   characters or killed monsters.
			return Interlocked.Increment(ref _handles);
		}

		/// <summary>
		/// Initializes world.
		/// </summary>
		public void Initialize()
		{
			foreach (var entry in ChannelServer.Instance.Data.MapDb.Entries.Values)
			{
				var map = new Map(entry.Id, entry.ClassName);
				_mapsId.Add(map.Id, map);
				_mapsName.Add(map.Name, map);
			}

			this.SetUpHeartbeat();
		}

		/// <summary>
		/// Returns map by id, or null if it doesn't exist.
		/// </summary>
		/// <param name="mapId"></param>
		public Map GetMap(int mapId)
		{
			Map result;
			lock (_mapsLock)
				_mapsId.TryGetValue(mapId, out result);
			return result;
		}

		/// <summary>
		/// Returns map by name, or null if it doesn't exist.
		/// </summary>
		/// <param name="mapName"></param>
		public Map GetMap(string mapName)
		{
			Map result;
			lock (_mapsLock)
				_mapsName.TryGetValue(mapName, out result);
			return result;
		}

		/// <summary>
		/// Removes all scripted entities, like NPCs.
		/// </summary>
		public void RemoveScriptedEntities()
		{
			lock (_mapsLock)
			{
				foreach (var map in _mapsId.Values)
					map.RemoveScriptedEntities();
			}
		}

		/// <summary>
		/// Returns the first character found with the given team name,
		/// or null if none were found.
		/// </summary>
		public Character GetCharacterByTeamName(string teamName)
		{
			lock (_mapsLock)
			{
				foreach (var map in _mapsId.Values)
				{
					var character = map.GetCharacterByTeamName(teamName);
					if (character != null)
						return character;
				}
			}

			return null;
		}

		/// <summary>
		/// Creates appropiate Item class based on ItemId
		/// or null if itemId is not found.
		/// </summary>
		public Item CreateItem(int itemId, int amount)
		{
			if (!ChannelServer.Instance.Data.ItemDb.Exists(itemId))
			{
				Log.Error("ItemId not exist: {0}", itemId);
				return null;
			}

			ItemData itemData = ChannelServer.Instance.Data.ItemDb.FindByItemId(itemId);

			Item newItem;
			switch (itemData.Category)
			{
				case InventoryCategory.Weapon:
					newItem = new Weapon(itemId, amount);
					newItem.Data.slot = EquipSlot.RightHand;
					break;
				default:
					newItem = new Item(itemId, amount);
					break;
			}

			return newItem;

		}

		/// <summary>
		/// This function registers an actor as source of events
		/// </summary>
		public void RegisterToEvents(int actorHandle)
		{
			lock (_eventBindings)
			{
				if (!_eventBindings.ContainsKey(actorHandle))
				{

					_eventBindings.Add(actorHandle, new Dictionary<EventTypes, List<EventHandle>>());
				}
			}
		}

		/// <summary>
		/// This function unregisters an actor as a source of events
		/// </summary>
		public void UnregisterToEvents(int actorHandle)
		{
			lock (_eventBindings)
			{
				_eventBindings.Remove(actorHandle);
			}
		}

		/// <summary>
		/// This function subscribes an actor to an event (of another actor)
		/// </summary>
		public void SubscribeToEvent(EventTypes evType, EventHandle evHandle, int actorHandle)
		{
			Dictionary<EventTypes, List<EventHandle>> eventTypesDir;
			List<EventHandle> eventHandlesList;

			lock (_eventBindings)
			{
				if (_eventBindings.TryGetValue(actorHandle, out eventTypesDir)) {
					if (!eventTypesDir.ContainsKey(evType))
					{
						eventTypesDir.Add(evType, new List<EventHandle>());
					}
					if (eventTypesDir.TryGetValue(evType, out eventHandlesList))
					{
						foreach (var thisEvHandle in eventHandlesList.ToList())
						{
							if (thisEvHandle == evHandle)
								return;
						}

						eventHandlesList.Add(evHandle);
					}
				}
				else
				{
					Log.Error("This actor is not registered to subscribe to events. Actor Handle: {0}", actorHandle);
				}

			}
		}

		/// <summary>
		/// This function unsubscribes an actor to receive an event (of another actor)
		/// </summary>
		public void UnsubscribeFromEvent(EventTypes evType, EventHandle evHandle, int actorHandle)
		{
			Dictionary<EventTypes, List<EventHandle>> eventTypesDir;
			List<EventHandle> eventHandlesList;

			lock (_eventBindings)
			{
				if (_eventBindings.TryGetValue(actorHandle, out eventTypesDir))
				{
					if (eventTypesDir.TryGetValue(evType, out eventHandlesList))
					{
						eventHandlesList.Remove(evHandle);
					}
				}
				else
				{
					Log.Warning("This actor is not registered to UNSCRIBSCRIBE to events. Actor Handle: {0}", actorHandle);
				}
			}
		}

		/// <summary>
		/// This function invokes all delegated functions registered to a given event of a given actor
		/// </summary>
		public List<EventResult> SendEvent(EventTypes evType, EventData evData, int actorHandle)
		{
			Dictionary<EventTypes, List<EventHandle>> eventTypesDir;
			List<EventHandle> eventHandlesList;

			List<EventResult> eventResults = new List<EventResult>();
			EventResult thisResult;

			//Log.Debug("Going through events");
			lock (_eventBindings)
			{
				if (_eventBindings.TryGetValue(actorHandle, out eventTypesDir))
				{
					//Log.Debug("Found events for actor Handle {0}", actorHandle);
					if (eventTypesDir.TryGetValue(evType, out eventHandlesList))
					{
						//Log.Debug("Amount {0}", eventHandlesList.Count);
						foreach (var thisEvHandle in eventHandlesList.ToList())
						{
							//Log.Debug("EVENT DELEGATE: {0}", thisEvHandle.ToString());
							if (thisEvHandle == null)
							{
								// Remove from the list.
								continue;
							}

							thisResult = thisEvHandle.Invoke(evData);
							if (thisResult != null)
								eventResults.Add(thisResult);
						}
					}
				}

			}

			return eventResults;
		}

		/// <summary>
		/// Define event types
		/// </summary>
		public enum EventTypes
		{
			ADJUST_DAMAGE_MODIFIER = 1,
			TAKE_DAMAGE = 2,
			PERFORM_CAST = 3,
		}

	}

	/// <summary>
	/// Class used in events
	/// </summary>
	public class EventData
	{
		public IEntity entity;
		public float damage;
		public IEntity damageFrom;
		public Skill skill;
	}

	/// <summary>
	/// Class used in events, to return event result
	/// </summary>
	public class EventResult
	{
		public float fValue;
		public int iValue;
		public double dValue;
	}
}
