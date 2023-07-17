using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Shared.World;
using Melia.Zone.World.Maps;
using Yggdrasil.Geometry;
using Yggdrasil.Util;

namespace Melia.Zone.World.Spawning
{
	/// <summary>
	/// A collection of spawn areas, grouped by a common identifier.
	/// </summary>
	public class SpawnAreaCollection
	{
		private static int Ids;

		private readonly Random _rnd = new Random(RandomProvider.GetSeed());
		private readonly List<SpawnArea> _spawnAreas = new List<SpawnArea>();

		/// <summary>
		/// Returns the unique id of this spawn area collection.
		/// </summary>
		public int Id { get; } = Interlocked.Increment(ref Ids);

		/// <summary>
		/// Returns the name identifier for this spawn area collection.
		/// </summary>
		public string Identifier { get; }

		/// <summary>
		/// Creates an empty spawn area collection.
		/// </summary>
		/// <param name="identifier"></param>
		public SpawnAreaCollection(string identifier)
		{
			if (string.IsNullOrWhiteSpace(identifier))
				throw new ArgumentException($"SpawnAreas: Invalid name.");

			this.Identifier = identifier;
		}

		/// <summary>
		/// Adds a spawn area to this collection.
		/// </summary>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <returns></returns>
		public SpawnArea AddSpawnPoint(string mapClassName, IShape area)
		{
			var spawnPoint = new SpawnArea(mapClassName, area);

			lock (_spawnAreas)
				_spawnAreas.Add(spawnPoint);

			return spawnPoint;
		}

		/// <summary>
		/// Returns all spawn areas of this collection that are onn a
		/// specific map.
		/// </summary>
		/// <param name="map"></param>
		/// <returns></returns>
		public SpawnArea[] GetAllOnMap(Map map)
		{
			lock (_spawnAreas)
				return _spawnAreas.Where(a => a.Map.ClassName == map.ClassName).ToArray();
		}

		/// <summary>
		/// Returns a list of all spawn areas in this collection.
		/// </summary>
		/// <returns></returns>
		public SpawnArea[] GetAll()
		{
			lock (_spawnAreas)
				return _spawnAreas.ToArray();
		}

		/// <summary>
		/// Returns a random spawn area via out, returns false if the
		/// collection is empty.
		/// </summary>
		/// <returns></returns>
		public bool TryGetRandom(out SpawnArea spawnArea)
		{
			spawnArea = null;

			lock (_spawnAreas)
			{
				if (_spawnAreas.Count == 0)
					return false;

				var index = _rnd.Next(_spawnAreas.Count);
				spawnArea = _spawnAreas[index];

				return true;
			}
		}

		/// <summary>
		/// Returns a random location from any of the collection's spawn
		/// areas via out. Returns false if no valid location could be
		/// found.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
		public bool TryGetRandomLocation(out Map map, out Position pos)
		{
			map = null;
			pos = Position.Zero;

			if (!this.TryGetRandom(out var spawnArea))
				return false;

			map = spawnArea.Map;

			if (!spawnArea.TryGetRandomPosition(out pos))
				return false;

			return true;
		}
	}
}
