using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Channel.World.Entities;

namespace Melia.Channel.World
{
	public class WorldManager
	{
		private int _handles = 0;

		// These are object id range starting points. The skill objects I
		// saw in-game so far were above 0x54B600000000 for example,
		// while the session and ability objects were above 0xE1A900000000.
		// In some games, ids have to to be in specific ranges, or nothing
		// will work. You might not be able to login, or interact with the
		// world, etc. I haven't seen any indication that this is the case in
		// ToS yet, but I'd rather be on the safe side for now, until we can
		// confirm that it's unnecessary.
		private long _sessionObjectIds = 0x0000E1A900000000;
		private long _skillObjectIds = 0x000054B600000000;

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
		public Heartbeat Heartbeat { get; } = new Heartbeat();

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

				this.Heartbeat.Add(map);
			}

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
		/// Returns all Characters that are currently online.
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
	}
}
