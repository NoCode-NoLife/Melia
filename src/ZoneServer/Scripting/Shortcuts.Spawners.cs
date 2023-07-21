using System;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Spawning;
using Yggdrasil.Geometry;

namespace Melia.Zone.Scripting
{
	public static partial class Shortcuts
	{
		/// <summary>
		/// Generates an identifier for a spawn area collection.
		/// </summary>
		/// <returns></returns>
		private static string GenerateSpawnAreaIdent()
		{
			var count = ZoneServer.Instance.World.GetSpawnAreas().Length;
			var identifier = "__GeneratedCollection" + count + "__";

			return identifier;
		}

		/// <summary>
		/// Adds a spawn area to the collection with the given identifier,
		/// creating it if it doesn't exist yet.
		/// </summary>
		/// <param name="identifier">Spawn area collection identifier.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <returns></returns>
		public static SpawnArea AddSpawnPoint(string identifier, string mapClassName, IShapeF area)
		{
			if (!ZoneServer.Instance.World.TryGetSpawnAreas(identifier, out var spc))
			{
				spc = new SpawnAreaCollection(identifier);
				ZoneServer.Instance.World.AddSpawnAreas(spc);
			}

			return spc.AddSpawnPoint(mapClassName, area);
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="amount">Amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="map">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, TimeSpan respawn, string map, IShapeF area)
			=> AddSpawner(monsterClassId, amount, respawn, map, area, TendencyType.Peaceful);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="amount">Amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="map">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, TimeSpan respawn, string map, IShapeF area, TendencyType tendency)
			=> AddSpawner(monsterClassId, amount, amount, respawn, map, area, tendency);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="min">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="max">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="map">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int min, int max, TimeSpan respawn, string map, IShapeF area)
			=> AddSpawner(monsterClassId, min, max, respawn, map, area, TendencyType.Peaceful);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="min">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="max">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="map">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int min, int max, TimeSpan respawn, string map, IShapeF area, TendencyType tendency)
		{
			var identifier = GenerateSpawnAreaIdent();
			AddSpawnPoint(identifier, map, area);

			return AddSpawner(identifier, monsterClassId, min, max, respawn, tendency);
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="min">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="max">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="initialSpawn">Initial delay before monsters are spawned.</param>
		/// <param name="minRespawn">Minimum delay before killed monsters are respawned.</param>
		/// <param name="maxRespawn">Maximum delay before killed monsters are respawned.</param>
		/// <param name="map">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int min, int max, TimeSpan initialSpawn, TimeSpan minRespawn, TimeSpan maxRespawn, string map, IShapeF area, TendencyType tendency)
		{
			var identifier = GenerateSpawnAreaIdent();
			AddSpawnPoint(identifier, map, area);

			return AddSpawner(identifier, monsterClassId, min, max, initialSpawn, minRespawn, maxRespawn, tendency);
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn area collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="amount">Amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int amount, TimeSpan respawn = default, TendencyType tendency = TendencyType.Peaceful)
			=> AddSpawner(identifier, monsterClassId, amount, amount, TimeSpan.Zero, respawn, respawn, tendency);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn area collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="min">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="max">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int min, int max, TimeSpan respawn = default, TendencyType tendency = TendencyType.Peaceful)
		{
			var initialSpawnDelay = TimeSpan.Zero;
			var minRespawnDelay = respawn;
			var maxRespawnDelay = respawn;

			return AddSpawner(identifier, monsterClassId, min, max, initialSpawnDelay, minRespawnDelay, maxRespawnDelay, tendency);
		}

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="identifier">Spawn area collection identifier.</param>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="min">Minimum amount of monsters to spawn at a time.</param>
		/// <param name="max">Maximum amount of monsters to spawn at a time.</param>
		/// <param name="initialSpawn">Initial delay before monsters are spawned.</param>
		/// <param name="minRespawn">Minimum delay before killed monsters are respawned.</param>
		/// <param name="maxRespawn">Maximum delay before killed monsters are respawned.</param>
		/// <param name="tendency">The aggresive tendencies of spawned monsters.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int min, int max, TimeSpan initialSpawn, TimeSpan minRespawn, TimeSpan maxRespawn, TendencyType tendency)
		{
			var spawner = new MonsterSpawner(monsterClassId, min, max, identifier, initialSpawn, minRespawn, maxRespawn, tendency);
			ZoneServer.Instance.World.AddSpawner(spawner);

			return spawner;
		}
	}
}
