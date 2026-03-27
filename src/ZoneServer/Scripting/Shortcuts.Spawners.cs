using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Spawning;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;
using Yggdrasil.Util;

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
		/// creating it if it doesn't exist yet. Returns null if the map
		/// is not loaded on this server.
		/// </summary>
		/// <param name="identifier">Spawn area collection identifier.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <returns></returns>
		public static SpawnArea AddSpawnPoint(string identifier, string mapClassName, IShapeF area)
		{
			// Add the spawn area collection regardless of whether the map
			// is served, so we can reference its existence and whether
			// areas were added to it.
			if (!ZoneServer.Instance.World.TryGetSpawnAreas(identifier, out var spc))
			{
				spc = new SpawnAreaCollection(identifier);
				ZoneServer.Instance.World.AddSpawnAreas(spc);
			}

			// Throw if the map doesn't exist at all, ignore if the server
			// just doesn't doesn't serve it.
			if (!ZoneServer.Instance.World.MapExists(mapClassName))
			{
				if (!ZoneServer.Instance.Data.MapDb.Contains(mapClassName))
					throw new ArgumentException($"Map '{mapClassName}' not found.");

				return null;
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
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, string map, IShapeF area)
			=> AddSpawner(monsterClassId, amount, default, map, area, TendencyType.Peaceful);

		/// <summary>
		/// Adds a spawner to the world.
		/// </summary>
		/// <param name="monsterClassId">Id of the monster to spawn.</param>
		/// <param name="amount">Amount of monsters to spawn at a time. The minimum will default to 50% of the max.</param>
		/// <param name="respawn">Constant delay until killed monsters respawn.</param>
		/// <param name="map">Class name of the map to spawn monsters one.</param>
		/// <param name="area">Area in which to spawn monsters in.</param>
		/// <returns></returns>
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, TimeSpan? respawn, string map, IShapeF area)
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
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, TimeSpan? respawn, string map, IShapeF area, TendencyType tendency)
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
		public static MonsterSpawner AddSpawner(int monsterClassId, int min, int max, TimeSpan? respawn, string map, IShapeF area)
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
		public static MonsterSpawner AddSpawner(int monsterClassId, int min, int max, TimeSpan? respawn, string map, IShapeF area, TendencyType tendency)
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
		public static MonsterSpawner AddSpawner(int monsterClassId, int min, int max, TimeSpan? initialSpawn, TimeSpan? minRespawn, TimeSpan? maxRespawn, string map, IShapeF area, TendencyType tendency)
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
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int amount, TimeSpan? respawn = null, TendencyType tendency = TendencyType.Peaceful)
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
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int min, int max, TimeSpan? respawn = null, TendencyType tendency = TendencyType.Peaceful)
			=> AddSpawner(identifier, monsterClassId, min, max, TimeSpan.Zero, respawn, respawn, tendency);

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
		public static MonsterSpawner AddSpawner(string identifier, int monsterClassId, int min, int max, TimeSpan? initialSpawn, TimeSpan? minRespawn, TimeSpan? maxRespawn, TendencyType tendency)
		{
			// We have to let the creation of the spawner go through, even
			// if no spawn areas exist yet, because spawners and spawn
			// areas can be defined in any order. The spawner will then
			// simply not spawn anything if no spawn areas are added or
			// the map isn't being served.

			var initialSpawnTime = initialSpawn ?? TimeSpan.Zero;
			var minRespawnTime = minRespawn ?? ZoneServer.Instance.Conf.World.DefaultMinRespawn;
			var maxRespawnTime = maxRespawn ?? ZoneServer.Instance.Conf.World.DefaultMaxRespawn;

			minRespawnTime = Math2.Max(TimeSpan.Zero, minRespawnTime);
			maxRespawnTime = Math2.Max(minRespawnTime, maxRespawnTime);

			var spawner = new MonsterSpawner(monsterClassId, min, max, identifier, initialSpawnTime, minRespawnTime, maxRespawnTime, tendency);
			ZoneServer.Instance.World.AddSpawner(spawner);

			return spawner;
		}

		/// <summary>
		/// Adds an override for the properties of a monster on a specific
		/// map. These override the stats of monsters spawned via spawners
		/// if no property overrides are specified for the spawner itself.
		/// </summary>
		/// <param name="mapClassName"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		public static void AddPropertyOverrides(string mapClassName, int monsterClassId, PropertyOverrides propertyOverrides)
		{
			// Throw if the map doesn't exist at all, ignore if the server
			// just doesn't doesn't serve it.
			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out var map))
			{
				if (!ZoneServer.Instance.Data.MapDb.Contains(mapClassName))
					throw new ArgumentException($"Map '{mapClassName}' not found.");

				return;
			}

			map.AddPropertyOverrides(monsterClassId, propertyOverrides);
		}

		/// <summary>
		/// Returns a list of named properties based on a list of key/value
		/// pairs.
		/// </summary>
		/// <example>
		/// Properties("MHP", 1000, "EXP", 5) // { "MHP": 1000, "EXP": 5 }
		/// </example>
		/// <param name="properties"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static PropertyOverrides Properties(params object[] properties)
		{
			var result = new PropertyOverrides();

			if (properties.Length % 2 != 0)
				throw new ArgumentException("Expected an even amount of arguments for key/value pairs.");

			for (var i = 0; i < properties.Length; i += 2)
			{
				var propertyNameObj = properties[i];
				var propertyValueObj = properties[i + 1];

				if (propertyNameObj is not string propertyName)
					throw new ArgumentException($"Expected a string for key, got '{propertyValueObj.GetType().Name}'.");

				switch (propertyValueObj)
				{
					case int _:
					case float _:
					case string _:
						result[propertyName] = propertyValueObj;
						break;

					default:
						throw new ArgumentException($"Expected an int, float or string for value, got '{propertyValueObj.GetType().Name}'.");
				}
			}

			return result;
		}

		/// <summary>
		/// Returns a polygonal shape made up of the given coordinates.
		/// </summary>
		/// <param name="coordinates">Evenly numbered list of at least 3 X and Y coordinates.</param>
		/// <returns></returns>
		/// <example>
		/// Area(0, 0, 0, 10, 10, 10, 10, 0) // 10x10 square
		/// </example>
		public static IShapeF Area(params double[] coordinates)
		{
			if (coordinates.Length == 0 || coordinates.Length % 2 != 0)
				throw new ArgumentException("Expected an even amount of coordinates for area.");

			if (coordinates.Length < 3)
				throw new ArgumentException("Needs at least 3 points (6 X/Y coordinates).");

			var points = new List<Vector2F>();
			for (var i = 0; i < coordinates.Length;)
			{
				var point = new Vector2F((float)coordinates[i++], (float)coordinates[i++]);
				points.Add(point);
			}

			return new PolygonF(points);
		}

		/// <summary>
		/// Returns a circular shape with the given coordinates and radius.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="radius"></param>
		/// <returns></returns>
		public static IShapeF Spot(double x, double y, double radius = 0)
		{
			var center = new Vector2F((float)x, (float)y);
			return new CircleF(center, (int)radius);
		}

		/// <summary>
		/// Returns a rectangular shape at the given coordinates.
		/// </summary>
		/// <remarks>
		/// The rectangle is created centered around the given coordinates,
		/// stretching out in all directions based on the width and height
		/// arguments.
		/// </remarks>
		/// <param name="x">X-coordinate of the shape's center.</param>
		/// <param name="y">Z-Coordinate of the shape's center.</param>
		/// <param name="width">Width of the rectangle.</param>
		/// <param name="height">Height of the rectangle. Defaults to width.</param>
		/// <returns></returns>
		public static IShapeF Rectangle(double x, double y, double width, double height = 0)
		{
			var center = new Vector2F((float)x, (float)y);
			var size = new Vector2F((float)width, (float)(height != 0 ? height : width));

			return RectangleF.Centered(center, size);
		}

		/// <summary>
		/// Returns a specialized shape that is considered a map-wide area
		/// by certain systems, such as monster spawners.
		/// </summary>
		/// <returns></returns>
		public static IShapeF MapWide => RectangleF.Centered(Vector2F.Zero, new(-1, -1));
	}

	/// <summary>
	/// A list of properties that can be used to override default values
	/// for spawned monsters.
	/// </summary>
	public class PropertyOverrides : Dictionary<string, object>
	{
	}
}
