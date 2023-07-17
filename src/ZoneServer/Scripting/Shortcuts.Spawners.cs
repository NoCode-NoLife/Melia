using System;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Spawning;
using Yggdrasil.Extensions;
using Yggdrasil.Geometry;
using Yggdrasil.Util;

namespace Melia.Zone.Scripting
{
	public static partial class Shortcuts
	{
		/// <summary>
		/// Adds a spawn point to an existing spawner.
		/// The identifier is responsible for linking together any
		/// spawner object.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <returns></returns>
		public static MonsterSpawnPoint AddSpawnPoint(string identifier, string mapClassName, IShape area)
		{
			if (!ZoneServer.Instance.World.TryGetSpawnPointCollectionByIdentifier(identifier, out var spc))
			{
				spc = new MonsterSpawnPointCollection(identifier);
				ZoneServer.Instance.World.AddSpawnPointCollection(spc);
			}

			return spc.AddSpawnPoint(mapClassName, area);
		}

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay, map and area without
		/// minAmount, property overrides or tendency.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="maxAmount"></param>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <param name="respawn"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int maxAmount, TimeSpan respawn, string mapClassName, IShape area)
			=> AddSpawner(monsterClassId, -1, maxAmount, mapClassName, area, respawn, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay, map and area without
		/// minAmount or property overrides.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="maxAmount"></param>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int maxAmount, string mapClassName, IShape area, TimeSpan respawn, TendencyType tendency)
			=> AddSpawner(monsterClassId, -1, maxAmount, mapClassName, area, respawn, tendency, null);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay, map and area without
		/// minAmount.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="maxAmount"></param>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int maxAmount, string mapClassName, IShape area, TimeSpan respawn, TendencyType tendency, PropertyOverrides propertyOverrides)
			=> AddSpawner(monsterClassId, -1, maxAmount, mapClassName, area, respawn, tendency, propertyOverrides);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay, map and area without
		/// property overrides or tendency.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <param name="respawn"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int minAmount, int maxAmount, string mapClassName, IShape area, TimeSpan respawn)
			=> AddSpawner(monsterClassId, minAmount, maxAmount, mapClassName, area, respawn, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay, map and area without
		/// property overrides
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int minAmount, int maxAmount, string mapClassName, IShape area, TimeSpan respawn, TendencyType tendency)
			=> AddSpawner(monsterClassId, minAmount, maxAmount, mapClassName, area, respawn, tendency, null);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay, map and area.
		/// This will internally create an identifier
		/// and the spawn point.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int minAmount, int maxAmount, string mapClassName, IShape area, TimeSpan respawn, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			// Assigns a new auto-generated identifier
			var collectionIdentifier = ZoneServer.Instance.World.GetSpawnPointCollections().Length.ToString();
			var spawner = AddSpawner(collectionIdentifier, monsterClassId, minAmount, maxAmount, respawn, tendency, propertyOverrides);
			AddSpawnPoint(collectionIdentifier, mapClassName, area);
			return spawner;
		}

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay without
		/// minAmount, property overrides or tendency.
		/// The identifier is responsible for linking together any
		/// spawner object.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int maxAmount, TimeSpan respawn)
			=> AddSpawner(identifier, monsterClassId, -1, maxAmount, respawn, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay without
		/// minAmount or property overrides.
		/// The identifier is responsible for linking together any
		/// spawner object.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int maxAmount, TimeSpan respawn, TendencyType tendency)
			=> AddSpawner(identifier, monsterClassId, -1, maxAmount, respawn, tendency, null);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay without
		/// minAmount.
		/// The identifier is responsible for linking together any
		/// spawner object.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int maxAmount, TimeSpan respawn, TendencyType tendency, PropertyOverrides propertyOverrides)
			=> AddSpawner(identifier, monsterClassId, -1, maxAmount, respawn, tendency, propertyOverrides);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay without property
		/// overrides or tendency.
		/// The identifier is responsible for linking together any
		/// spawner object.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="respawn"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn)
			=> AddSpawner(identifier, monsterClassId, minAmount, maxAmount, respawn, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay without
		/// property overrides.
		/// The identifier is responsible for linking together any
		/// spawner object.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn, TendencyType tendency)
			=> AddSpawner(identifier, monsterClassId, minAmount, maxAmount, respawn, tendency, null);

		/// <summary>
		/// Adds a monster spawner to the world using
		/// arbitrary respawn delay.
		/// The identifier is responsible for linking together any
		/// spawner object.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="respawn"></param>
		/// <param name="tendency"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int minAmount, int maxAmount, TimeSpan respawn, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			// These delays are arbitrary
			var initialSpawnDelay = TimeSpan.FromSeconds(0);
			var minRespawnDelay = Math2.Max(TimeSpan.FromSeconds(3), respawn);
			var maxRespawnDelay = minRespawnDelay.Multiply(3);

			// Creates spawner
			var spawner = AddSpawner(identifier, monsterClassId, minAmount, maxAmount, initialSpawnDelay, minRespawnDelay, maxRespawnDelay, tendency, propertyOverrides);

			return spawner;
		}

		/// <summary>
		/// Adds a monster spawner to the world.
		/// The identifier is responsible for linking together any
		/// spawner object.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="initialSpawnDelay"></param>
		/// <param name="minRespawnDelay"></param>
		/// <param name="maxRespawnDelay"></param>
		/// <param name="tendency"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int minAmount, int maxAmount, TimeSpan initialSpawnDelay, TimeSpan minRespawnDelay, TimeSpan maxRespawnDelay, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			minAmount = Math.Max(1, minAmount);
			maxAmount = Math.Max(minAmount, maxAmount);

			var spawner = new MonsterSpawner(monsterClassId, minAmount, maxAmount, identifier, initialSpawnDelay, minRespawnDelay, maxRespawnDelay, tendency, propertyOverrides);
			ZoneServer.Instance.World.AddSpawner(spawner);

			return spawner;
		}
	}
}
