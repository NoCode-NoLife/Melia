using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Shared.Data.Database;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Database;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;
using Yggdrasil.Extensions;
using Yggdrasil.Geometry;
using Yggdrasil.Logging;
using Yggdrasil.Util;

namespace Melia.Zone.World.MonsterManager
{
	/// <summary>
	/// This class is responsible for spawning a monster in
	/// a specific area (spawn point).
	/// </summary>
	public class MonsterSpawnPoint
	{
		private const int MaxValidPositionTries = 50;

		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

		/// <summary>
		/// Map object this spawner is in
		/// </summary>
		public Map Map { get; }

		/// <summary>
		/// Returns the unique id of this spawner.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the class name of the map the monsters are to be
		/// spawned on
		/// </summary>
		public string MapClassName { get; }

		/// <summary>
		/// Returns the area in which the monsters are spawned.
		/// </summary>
		public IShape Area { get; }

		/// <summary>
		/// Creates a monster spawn point. This spawn point needs to be
		/// associated to a spawner.
		/// </summary>
		/// <param name="spawnerName"></param>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <exception cref="ArgumentException"></exception>
		public MonsterSpawnPoint(string spawnerName, string mapClassName, IShape area)
		{
			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out var map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			if (!ZoneServer.Instance.World.TryGetSpawnerByName(spawnerName, out var spawner))
				throw new ArgumentException($"Cannot find MonsterSpawner for MonsterSpawnPoint of center position: 'X={this.Area.Center.X}', 'Z={this.Area.Center.Y}'");

			spawner.AddSpawnPoint(this);

			this.MapClassName = mapClassName;
			this.Area = area;
			this.Map = map;
		}

		/// <summary>
		/// Spawns a single monster in a random position in this spawn point
		/// </summary>
		/// <returns>True if successful, false otherwise</returns>
		public bool Spawn(Mob monster)
		{
			if (!this.TryGetRandomPosition(out var pos))
			{
				Log.Warning($"MonsterSpawnPoint: Couldn't find a valid spawn position for monster '{monster.Data.ClassName}' on map '{this.Map.Name}'.");
				return false;
			}

			monster.Position = pos;
			this.Map.AddMonster(monster);

			return true;
		}

		/// <summary>
		/// Attempts to find a valid random position within the spawn
		/// area and returns it via out. Returns false if no valid
		/// position could be found within a reasonable amount of
		/// tries.
		/// </summary>
		/// <returns></returns>
		private bool TryGetRandomPosition(out Position pos)
		{
			// Since we have no way of knowing what kinds of spawn areas
			// users will create, we have no other choice but to try a
			// a couple of positions and see if we can find a valid one.
			// If we can't, we have to fail the attempt because even the
			// area's center or edge points might be invalid.

			for (var i = 0; i < MaxValidPositionTries; ++i)
			{
				var rndVector = this.Area.GetRandomPoint(_rnd);
				if (this.TryGetPositionFromPoint(rndVector, out pos))
					return true;
			}

			// If all tries failed, try the area's center point
			if (this.TryGetPositionFromPoint(this.Area.Center, out pos))
				return true;

			// No dice? Okay... What about the edge points?
			foreach (var edgePoint in this.Area.GetEdgePoints().OrderBy(_ => _rnd.Next()))
			{
				if (this.TryGetPositionFromPoint(edgePoint, out pos))
					return true;
			}

			// TODO: The game has spawns that span entire maps, which makes
			//   it difficult to find spawn positions randomly. We don't
			//   *have* to support this, but I understand why someone
			//   would want it, so we should find a way to handle them.

			// Well, we gave our best. Kind of.
			Log.Warning($"TryGetRandomPosition: Failed for position center: 'X={this.Area.Center.X}', 'Z={this.Area.Center.Y}'");
			pos = Position.Zero;
			return false;
		}

		/// <summary>
		/// Tries to turn point into a valid position and returns it via
		/// out. Returns false if the point was not a valid position.
		/// </summary>
		/// <param name="point"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
		private bool TryGetPositionFromPoint(Vector2 point, out Position pos)
		{
			pos = new Position(point.X, 0, point.Y);
			if (this.Map.Ground.TryGetHeightAt(pos, out var height))
			{
				pos.Y = height;
				return true;
			}

			pos = Position.Zero;
			return false;
		}
	}
}
