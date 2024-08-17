using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Shared.Network;
using Melia.Zone.Events;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Groups;
using Melia.Zone.World.Maps;
using Melia.Zone.World.Spawning;
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

		// Unique handles for pads? Potentially part of the normal handle pool.
		private int _padHandles = 0;

		private int _genTypes = 1_000_000;

		private readonly Dictionary<int, Map> _mapsId = new();
		private readonly Dictionary<string, Map> _mapsName = new();
		private readonly Dictionary<int, MonsterSpawner> _spawners = new();
		private readonly Dictionary<string, SpawnAreaCollection> _spawnAreaCollections = new();
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
		/// Returns the world's parties, a manager for
		/// all the parties in the world.
		/// </summary>
		public PartyManager Parties { get; } = new PartyManager();

		/// <summary>
		/// Returns the world's guilds, a collection of
		/// all the guilds in the world.
		/// </summary>
		public GuildManager Guilds { get; } = new GuildManager();

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
		/// Returns a new handle to be used with a skill/pad.
		/// </summary>
		/// <returns></returns>
		public int CreatePadHandle()
		{
			return Interlocked.Increment(ref _padHandles);
		}

		/// <summary>
		/// Initializes world, creating maps and setting up events.
		/// </summary>
		internal void Initialize()
		{
			this.CreateMaps();
			this.InitUpdatables();
		}

		/// <summary>
		/// Populates world mit maps based on the map data and adds them
		/// to the heartbeat.
		/// </summary>
		private void CreateMaps()
		{
			foreach (var entry in ZoneServer.Instance.Data.MapDb.Entries.Values)
			{
				var map = new Map(entry.Id, entry.ClassName);
				_mapsId.Add(map.Id, map);
				_mapsName.Add(map.ClassName, map);

				this.Heartbeat.Add(map);
			}
		}

		/// <summary>
		/// Initializes updatable world objects, such as event raisers.
		/// </summary>
		private void InitUpdatables()
		{
			this.Heartbeat.Add(new TimeEventRaiser());
			this.Heartbeat.Add(this.DayNightCycle = new DayNightCycle());
		}

		/// <summary>
		/// Starts the world's heartbeat if it isn't already running.
		/// </summary>
		internal void Start()
		{
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

			lock (_spawners)
			{
				foreach (var spawner in _spawners.Values)
				{
					spawner.InitializePopulation();
					this.Heartbeat.Remove(spawner);
				}

				_spawners.Clear();
			}

			lock (_spawnAreaCollections)
				_spawnAreaCollections.Clear();
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
		/// Adds a monster spawner object to the world
		/// </summary>
		/// <param name="spawner"></param>
		public void AddSpawner(MonsterSpawner spawner)
		{
			lock (_spawners)
			{
				_spawners.Add(spawner.Id, spawner);
				this.Heartbeat.Add(spawner);
			}
		}

		/// <summary>
		/// Adds a spawn area collection to the world.
		/// </summary>
		/// <param name="spawnAreas"></param>
		public void AddSpawnAreas(SpawnAreaCollection spawnAreas)
		{
			// Just replace the old one if it exists, since users might
			// want to override existing spawn areas.

			lock (_spawnAreaCollections)
				_spawnAreaCollections[spawnAreas.Identifier] = spawnAreas;
		}

		/// <summary>
		/// Returns by out a spawn area collection with a given identifier
		/// if it exists in the world. Returns true if found, false otherwise.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="spawner"></param>
		/// <returns></returns>
		public bool TryGetSpawnAreas(string identifier, out SpawnAreaCollection spawnAreas)
		{
			lock (_spawnAreaCollections)
				return _spawnAreaCollections.TryGetValue(identifier, out spawnAreas);
		}

		/// <summary>
		/// Returns a list of all spawn areas that currently exist in the
		/// world. Returns it as an array.
		/// </summary>
		/// <returns></returns>
		public SpawnAreaCollection[] GetSpawnAreas()
		{
			lock (_spawners)
				return _spawnAreaCollections.Values.ToArray();
		}

		/// <summary>
		/// Returns a list of all spawners that currently exist in the world.
		/// </summary>
		/// <returns></returns>
		public MonsterSpawner[] GetSpawners()
		{
			lock (_spawners)
				return _spawners.Values.ToArray();
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
		/// Returns all online characters that match the given predicate.
		/// </summary>
		public Character GetCharacter(Func<Character, bool> predicate)
		{
			lock (_mapsLock)
			{
				foreach (var map in _mapsId.Values)
				{
					var character = map.GetCharacter(predicate);

					if (character != null)
						return character;
				}
				return null;
			}
		}

		/// <summary>
		/// Returns a party if found by id or null
		/// </summary>
		/// <param name="partyId"></param>
		/// <returns></returns>
		public Party GetParty(long partyId)
			=> this.Parties.GetParty(partyId);

		/// <summary>
		/// Returns a guild if found by id or null
		/// </summary>
		/// <param name="guildId"></param>
		/// <returns></returns>
		public Guild GetGuild(long guildId)
			=> this.Guilds.GetGuild(guildId);

		/// <summary>
		/// Returns all characters that are currently online.
		/// </summary>
		public Character[] GetCharacters()
		{
			lock (_mapsLock)
				return _mapsId.Values.SelectMany(a => a.GetCharacters()).ToArray();
		}

		/// <summary>
		/// Returns the first monster that matches the given predicate
		/// on any map via out. Returns false if no matching monster was
		/// found.
		/// </summary>
		/// <param name="predicate"></param>
		/// <param name="monster"></param>
		/// <returns></returns>
		public bool TryGetMonster(Func<IMonster, bool> predicate, out IMonster monster)
		{
			lock (_mapsLock)
			{
				foreach (var map in _mapsId.Values)
				{
					if (map.TryGetMonster(predicate, out var m))
					{
						monster = m;
						return true;
					}
				}
			}

			monster = null;
			return false;
		}

		/// <summary>
		/// Returns the total number of player characters across all maps.
		/// </summary>
		/// <returns></returns>
		public int GetCharacterCount()
		{
			lock (_mapsLock)
				return _mapsId.Values.Sum(a => a.CharacterCount);
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
