using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Zone.World.Maps;
using Yggdrasil.Geometry;
using Yggdrasil.Util;

namespace Melia.Zone.World.Spawning
{
	/// <summary>
	/// This class stores a collection of spawn points, identified by
	/// its identifier string.
	/// </summary>
	public class SpawnPointCollection
	{
		private static int Ids;

		private readonly Random _rnd = new Random(RandomProvider.GetSeed());
		private readonly List<SpawnPoint> _spawnPoints = new List<SpawnPoint>();

		/// <summary>
		/// Returns the unique id of this spawn point collection.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the name identifier for this spawn point collection.
		/// </summary>
		public string Identifier { get; set; }

		/// <summary>
		/// Creates an empty spawn point collection.
		/// </summary>
		/// <param name="identifier"></param>
		public SpawnPointCollection(string identifier)
		{
			if (string.IsNullOrWhiteSpace(identifier))
				throw new ArgumentException($"SpawnPointCollection: Invalid name.");

			this.Identifier = identifier;

			this.Id = Interlocked.Increment(ref Ids);
		}

		/// <summary>
		/// Adds a spawn point to this collection.
		/// </summary>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <returns></returns>
		public SpawnPoint AddSpawnPoint(string mapClassName, IShape area)
		{
			var spawnPoint = new SpawnPoint(mapClassName, area);

			lock (_spawnPoints)
				_spawnPoints.Add(spawnPoint);

			return spawnPoint;
		}

		/// <summary>
		/// Returns all spawn points of this collection that are in a specific
		/// map.
		/// </summary>
		/// <param name="map"></param>
		/// <returns></returns>
		public SpawnPoint[] GetSpawnPointsInMap(Map map)
		{
			lock (_spawnPoints)
				return _spawnPoints.Where(a => a.Map.ClassName == map.ClassName).ToArray();
		}

		/// <summary>
		/// Gets all spawn points of this collection. Note that they can be
		/// in different maps.
		/// </summary>
		/// <returns></returns>
		public SpawnPoint[] GetSpawnPoints()
		{
			lock (_spawnPoints)
				return _spawnPoints.ToArray();
		}

		/// <summary>
		/// Returns via out a random spawn point of this collection.
		/// Returns false if collection has no spawn points.
		/// </summary>
		/// <returns></returns>
		public bool TryGetRandomSpawnPoint(out SpawnPoint spawnPoint)
		{
			spawnPoint = null;

			lock (_spawnPoints)
			{
				if (_spawnPoints.Count == 0)
					return false;

				var index = _rnd.Next(_spawnPoints.Count);
				spawnPoint = _spawnPoints[index];

				return true;
			}
		}
	}
}
