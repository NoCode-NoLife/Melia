using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Zone.World.Maps;
using Yggdrasil.Geometry;
using Yggdrasil.Util;

namespace Melia.Zone.World.Spawner
{
	/// <summary>
	/// The spawn point is a location of map and area where the
	/// monster can spawn, but it depends on other classes
	/// such as the MonsterSpawner to actually spawn it.
	/// </summary>
	public class MonsterSpawnPoint
	{
		/// <summary>
		/// How many attempts we should make when trying
		/// to get a random position within the spawn point's
		/// area.
		/// </summary>
		private const int MaxValidPositionTries = 50;

		/// <summary>
		/// Random generator
		/// </summary>
		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

		// The map this spawn point is in
		public Map Map { get; set; }

		// The area of this spawn point
		public IShape Area { get; set; }

		/// <summary>
		/// Creates a new spawn point
		/// </summary>
		/// <param name="map"></param>
		/// <param name="area"></param>
		public MonsterSpawnPoint(Map map, IShape area)
		{
			this.Map = map;
			this.Area = area;
		}

		/// <summary>
		/// Attempts to find a valid random position within this spawn
		/// point and returns it via out. Returns false if no valid
		/// position could be found within a reasonable amount of
		/// tries.
		/// </summary>
		/// <param name="pos">
		/// The found available position or zero if not found
		/// </param>
		/// <returns></returns>
		public bool TryGetRandomPosition(out Position pos)
		{
			// Since we have no way of knowing what kinds of spawn areas
			// users will create, we have no other choice but to try a
			// a couple of positions and see if we can find a valid one.
			// If we can't, we have to fail the attempt because even the
			// area's center or edge points might be invalid.

			for (var i = 0; i < MaxValidPositionTries; ++i)
			{
				var rndVector = this.Area.GetRandomPoint(_rnd);
				if (this.TryGetPositionFromPoint(this.Map, rndVector, out pos))
					return true;
			}

			// If all tries failed, try the area's center point
			if (this.TryGetPositionFromPoint(this.Map, this.Area.Center, out pos))
				return true;

			// No dice? Okay... What about the edge points?
			foreach (var edgePoint in this.Area.GetEdgePoints().OrderBy(_ => _rnd.Next()))
			{
				if (this.TryGetPositionFromPoint(this.Map, edgePoint, out pos))
					return true;
			}

			// TODO: The game has spawns that span entire maps, which makes
			//   it difficult to find spawn positions randomly. We don't
			//   *have* to support this, but I understand why someone
			//   would want it, so we should find a way to handle them.

			// Well, we gave our best. Kind of.
			pos = Position.Zero;
			return false;
		}

		/// <summary>
		/// Tries to turn point into a valid position and returns it via
		/// out. Returns false if the point was not a valid position.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="point"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
		private bool TryGetPositionFromPoint(Map map, Vector2 point, out Position pos)
		{
			pos = new Position(point.X, 0, point.Y);
			if (map.Ground.TryGetHeightAt(pos, out var height))
			{
				pos.Y = height;
				return true;
			}

			pos = Position.Zero;
			return false;
		}
	}
}
