using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Shared.Network;
using Melia.Zone.Events;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Maps;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World
{
	/// <summary>
	/// Manages the world, including maps and the heartbeat update loop.
	/// </summary>
	public class WorldManager
	{
		// Unique handles for entities
		private int _handles = 0;

		// Unique handles for buffs
		private int _buffhandles = 0;

		private int _genTypes = 1_000_000;

		private readonly Dictionary<int, Map> _mapsId = new Dictionary<int, Map>();
		private readonly Dictionary<string, Map> _mapsName = new Dictionary<string, Map>();
		private readonly object _mapsLock = new object();

		/// <summary>
		/// Returns the amount of maps in the world.
		/// </summary>
		public int Count { get { lock (_mapsLock) return _mapsId.Count; } }

		/// <summary>
		/// Returns the world's heartbeat, a manager for regularly
		/// occurring events.
		/// </summary>
		public Heartbeat Heartbeat { get; } = new Heartbeat(4);

		/// <summary>
		/// Returns the world's day/night cycle manager.
		/// </summary>
		public DayNightCycle DayNightCycle { get; private set; }

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
		/// Returns a new gen type to be used for a monster.
		/// </summary>
		/// <returns></returns>
		public int CreateGenType()
		{
			return Interlocked.Increment(ref _genTypes);
		}

		/// <summary>
		/// Returns a new handle to be used for a casted Buff.
		/// </summary>
		/// <returns></returns>
		public int CreateBuffHandle()
		{
			return Interlocked.Increment(ref _buffhandles);
		}

		/// <summary>
		/// Initializes world.
		/// </summary>
		public void Initialize()
		{
			// Create maps based on map data
			foreach (var entry in ZoneServer.Instance.Data.MapDb.Entries.Values)
			{
				var map = new Map(entry.Id, entry.ClassName);
				_mapsId.Add(map.Id, map);
				_mapsName.Add(map.Name, map);

				// Add maps to heartbeat's update scheduling
				this.Heartbeat.Add(map);
			}

			// Set up updatables
			this.Heartbeat.Add(new TimeEventRaiser());

			this.DayNightCycle = new DayNightCycle();
			if (ZoneServer.Instance.Conf.World.EnableDayNightCycle)
				this.Heartbeat.Add(this.DayNightCycle);

			// Start hearbeat loop and updates
			this.Heartbeat.Start();
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
		/// <param name="mapClassName"></param>
		public Map GetMap(string mapClassName)
		{
			Map result;
			lock (_mapsLock)
				_mapsName.TryGetValue(mapClassName, out result);

			return result;
		}

		/// <summary>
		/// Returns map by name via out, returns false if the map doesn't
		/// exist.
		/// </summary>
		/// <param name="mapClassId"></param>
		/// <param name="map"></param>
		public bool TryGetMap(int mapClassId, out Map map)
		{
			map = this.GetMap(mapClassId);
			return map != null;
		}

		/// <summary>
		/// Returns map by name via out, returns false if the map doesn't
		/// exist.
		/// </summary>
		/// <param name="mapClassName"></param>
		/// <param name="map"></param>
		public bool TryGetMap(string mapClassName, out Map map)
		{
			map = this.GetMap(mapClassName);
			return map != null;
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
		/// Returns the first character found with the given team name via
		/// out. Retrns false if no matching character was found.
		/// </summary>
		/// <param name="teamName"></param>
		/// <param name="character"></param>
		/// <returns></returns>
		public bool TryGetCharacterByTeamName(string teamName, out Character character)
		{
			character = this.GetCharacterByTeamName(teamName);
			return character != null;
		}

		/// <summary>
		/// Returns all characters that are currently online.
		/// </summary>
		public Character[] GetCharacters()
		{
			lock (_mapsLock)
				return _mapsId.Values.SelectMany(a => a.GetCharacters()).ToArray();
		}

		/// <summary>
		/// Returns all online characters that match the given predicate.
		/// </summary>
		public Character[] GetCharacters(Func<Character, bool> predicate)
		{
			lock (_mapsLock)
				return _mapsId.Values.SelectMany(a => a.GetCharacters(predicate)).ToArray();
		}

		/// <summary>
		/// Broadcasts packet on all maps.
		/// </summary>
		/// <param name="packet"></param>
		public void Broadcast(Packet packet)
		{
			lock (_mapsLock)
			{
				foreach (var map in _mapsId.Values)
					map.Broadcast(packet);
			}
		}
	}
}
