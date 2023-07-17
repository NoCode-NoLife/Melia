using System;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Spawning;
using Yggdrasil.Geometry;

namespace Melia.Zone.Scripting
{
	public static partial class Shortcuts
	{
		/// <summary>
		/// Adds a spawn point to the collection with the given identifier,
		/// creating it if it doesn't exist yet.
		/// </summary>
		/// <param name="identifier">Spawn point collection identifier.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <returns></returns>
		public static SpawnPoint AddSpawnPoint(string identifier, string mapClassName, IShape area)
		{
			if (!ZoneServer.Instance.World.TryGetSpawnPointCollectionByIdentifier(identifier, out var spc))
			{
				spc = new SpawnPointCollection(identifier);
				ZoneServer.Instance.World.AddSpawnPointCollection(spc);
			}

			return spc.AddSpawnPoint(mapClassName, area);
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int maxAmount, TimeSpan respawn, string mapClassName, IShape area)
			=> AddSpawner(monsterClassId, maxAmount, respawn, mapClassName, area, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int maxAmount, TimeSpan respawn, string mapClassName, IShape area, TendencyType tendency)
			=> AddSpawner(monsterClassId, maxAmount, respawn, mapClassName, area, tendency, null);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <param name="propertyOverrides">Overrides for the monster's properties. Use null for none.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int maxAmount, TimeSpan respawn, string mapClassName, IShape area, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			// Use half of the max amount as the minimum, since spawning
			// the max amount, based on the client files, appears to be
			// way too much.
			var minAmount = Math.Max(1, maxAmount / 2);

			return AddSpawner(monsterClassId, minAmount, maxAmount, respawn, mapClassName, area, tendency, propertyOverrides);
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="minAmount">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn, string mapClassName, IShape area)
			=> AddSpawner(monsterClassId, minAmount, maxAmount, respawn, mapClassName, area, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="minAmount">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn, string mapClassName, IShape area, TendencyType tendency)
			=> AddSpawner(monsterClassId, minAmount, maxAmount, respawn, mapClassName, area, tendency, null);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="minAmount">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <param name="propertyOverrides">Overrides for the monster's properties. Use null for none.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn, string mapClassName, IShape area, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			var count = ZoneServer.Instance.World.GetSpawnPointCollections().Length;
			var identifier = "__GeneratedCollection" + count + "__";
			AddSpawnPoint(identifier, mapClassName, area);

			var spawner = AddSpawner(identifier, monsterClassId, minAmount, maxAmount, respawn, tendency, propertyOverrides);
			return spawner;
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn point collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int maxAmount, TimeSpan respawn)
			=> AddSpawner(identifier, monsterClassId, maxAmount, respawn, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn point collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int maxAmount, TimeSpan respawn, TendencyType tendency)
			=> AddSpawner(identifier, monsterClassId, maxAmount, respawn, tendency, null);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn point collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <param name="propertyOverrides">Overrides for the monster's properties. Use null for none.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int maxAmount, TimeSpan respawn, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			// Use half of the max amount as the minimum, since spawning
			// the max amount, based on the client files, appears to be
			// way too much.
			var minAmount = Math.Max(1, maxAmount / 2);

			return AddSpawner(identifier, monsterClassId, minAmount, maxAmount, respawn, tendency, propertyOverrides);
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn point collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="minAmount">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn)
			=> AddSpawner(identifier, monsterClassId, minAmount, maxAmount, respawn, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn point collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="minAmount">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn, TendencyType tendency)
			=> AddSpawner(identifier, monsterClassId, minAmount, maxAmount, respawn, tendency, null);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn point collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="minAmount">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <param name="propertyOverrides">Overrides for the monster's properties. Use null for none.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			var initialSpawnDelay = TimeSpan.Zero;
			var minRespawnDelay = respawn;
			var maxRespawnDelay = respawn;

			var spawner = AddSpawner(identifier, monsterClassId, minAmount, maxAmount, initialSpawnDelay, minRespawnDelay, maxRespawnDelay, tendency, propertyOverrides);
			return spawner;
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn point collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="minAmount">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="maxAmount">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="initialSpawnDelay">Initial delay before monsters are spawned.</param>
		/// <param name="minRespawnDelay">Minimum delay before killed monsters are respawned.</param>
		/// <param name="maxRespawnDelay">Maximum delay before killed monsters are respawned.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <param name="propertyOverrides">Overrides for the monster's properties. Use null for none.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int minAmount, int maxAmount, TimeSpan initialSpawnDelay, TimeSpan minRespawnDelay, TimeSpan maxRespawnDelay, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			var spawner = new MonsterSpawner(monsterClassId, minAmount, maxAmount, identifier, initialSpawnDelay, minRespawnDelay, maxRespawnDelay, tendency, propertyOverrides);
			ZoneServer.Instance.World.AddSpawner(spawner);

			return spawner;
		}
	}
}
