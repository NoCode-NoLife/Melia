// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Threading;

namespace Melia.Channel.World
{
	public class WorldManager
	{
		public const int HeartbeatTime = 500;
		public const int Second = 1000, Minute = Second * 60, Hour = Minute * 60;

		private int _handles = 0;
		private long _sessionObjectIds = 0x0000E1A900000000;
		private long _skillObjectIds = 0x000054B600000000;

		private Dictionary<int, Map> _mapsId;
		private Dictionary<string, Map> _mapsName;
		private object _mapsLock = new object();

		private Timer _heartbeatTimer;

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
		}

		/// <summary>
		/// Initializes heartbeat timer.
		/// </summary>
		private void SetUpHeartbeat()
		{
			var now = DateTime.Now;

			// Start timer on the next HeartbeatTime
			// (eg on the next full 500 ms) and run it regularly afterwards.
			_heartbeatTimer = new Timer(this.Heartbeat, null, HeartbeatTime - (now.Ticks / 10000 % HeartbeatTime), HeartbeatTime);
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
		/// Returns a new object id that can be used for a session object.
		/// </summary>
		/// <returns></returns>
		public long CreateSessionObjectId()
		{
			// XXX: How exactly do these unique ids work? Do they all come
			// from the same pool? Are there ranges? Do they have to be
			// unique between multiple types? Can we use one getter for
			// all "objects"?
			return Interlocked.Increment(ref _sessionObjectIds);
		}

		/// <summary>
		/// Returns a new object id that can be used for a skill object.
		/// </summary>
		/// <returns></returns>
		public long CreateSkillObjectId()
		{
			return Interlocked.Increment(ref _skillObjectIds);
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
	}
}
