using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Melia.Zone.World.Maps;
using Yggdrasil.Geometry;
using Yggdrasil.Util;

namespace Melia.Zone.World.Spawning
{
	/// <summary>
	/// This class stores a collection of spawn points.
	/// Each collection can be identified by its identifier
	/// string.
	/// </summary>
	public class MonsterSpawnPointCollection
	{
		private static int Ids;

		/// <summary>
		/// Returns the unique id of this spawn point collection.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Random generator
		/// </summary>
		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

		/// <summary>
		/// List of spawn points this collection contains.
		/// </summary>
		private List<MonsterSpawnPoint> _spawnPoints = new List<MonsterSpawnPoint>();

		/// <summary>
		/// Returns the name identifier for this spawn point collection.
		/// </summary>
		public string Identifier { get; set; }

		/// <summary>
		/// Creates an empty spawn point collection. Note that the identifier
		/// must be unique in the world.
		/// </summary>
		/// <param name="identifier"></param>
		public MonsterSpawnPointCollection(string identifier)
		{
			// If no name is given
			if (String.IsNullOrWhiteSpace(identifier))
			{
				throw new ArgumentException($"MonsterSpawnPointCollection: Invalid name.");
			}

			this.Identifier = identifier;

			this.Id = Interlocked.Increment(ref Ids);
		}

		/// <summary>
		/// Adds a spawn point to this collection.
		/// </summary>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <returns></returns>
		public MonsterSpawnPoint AddSpawnPoint(string mapClassName, IShape area)
		{
			lock (_spawnPoints)
			{
				var spawnPoint = new MonsterSpawnPoint(mapClassName, area);
				_spawnPoints.Add(spawnPoint);

				return spawnPoint;
			}
		}

		/// <summary>
		/// Returns all spawn points of this collection that are in a specific
		/// map.
		/// </summary>
		/// <param name="map"></param>
		/// <returns></returns>
		public MonsterSpawnPoint[] GetSpawnPointsInMap(Map map)
		{
			lock (_spawnPoints)
				return _spawnPoints.FindAll(p => p.Map.ClassName.Equals(map.ClassName)).ToArray();
		}

		/// <summary>
		/// Gets all spawn points of this collection. Note that they can be
		/// in different maps.
		/// </summary>
		/// <returns></returns>
		public MonsterSpawnPoint[] GetSpawnPoints()
		{
			lock (_spawnPoints)
				return _spawnPoints.ToArray();
		}

		/// <summary>
		/// Returns via out a random spawn point of this collection.
		/// Returns false if collection has no spawn points.
		/// </summary>
		/// <returns></returns>
		public bool GetRandomSpawnPoint(out MonsterSpawnPoint spawnPoint)
		{
			spawnPoint = null;

			if (_spawnPoints.Count == 0)
				return false;

			lock (_spawnPoints)
			{
				var index = _rnd.Next(_spawnPoints.Count);
				spawnPoint = _spawnPoints[index];
				return true;
			}
		}
	}
}
