using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	/// <summary>
	/// Spawns and respawns monsters.
	/// </summary>
	public class MonsterSpawner
	{
		private readonly MonsterData _monsterData;
		private readonly Map _map;
		private int _spawnCount;
		private readonly int _totalAmount;
		private readonly Random _rnd;
		private readonly float _minX;
		private readonly float _maxX;
		private readonly float _minZ;
		private readonly float _maxZ;

		/// <summary>
		/// Returns the class name of the monster that is to be spawned.
		/// </summary>
		public string MonsterClassName { get; }

		/// <summary>
		/// Returns the amount of monsters to spawn and keep around.
		/// </summary>
		public int Amount { get; }

		/// <summary>
		/// Returns the delay until a monster is spawned again after
		/// it died.
		/// </summary>
		public TimeSpan RespawnDelay { get; }

		/// <summary>
		/// Returns the class name of the map the monsters are to be
		/// spawned on
		/// </summary>
		public string MapClassName { get; }

		/// <summary>
		/// Returns the polygonal area that monsters are spawned in.
		/// </summary>
		public Position[] Area { get; }

		/// <summary>
		/// Creates a new spawner.
		/// </summary>
		/// <param name="monsterClassName">Class name of the monster to spawn.</param>
		/// <param name="amount">Amount of monsters to spawn and keep around.</param>
		/// <param name="respawnDelay">Delay until a monster is spawned again.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters on.</param>
		/// <param name="area">Points that make up the spawn area.</param>
		public MonsterSpawner(string monsterClassName, int amount, TimeSpan respawnDelay, string mapClassName, Position[] area)
		{
			if (!ChannelServer.Instance.Data.MonsterDb.TryFind(a => a.ClassName == monsterClassName, out _monsterData))
				throw new ArgumentException($"No monster data found for '{monsterClassName}'.");

			if (!ChannelServer.Instance.World.TryGetMap(mapClassName, out _map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			if (area.Length == 0)
				throw new ArgumentException("Area can't be empty.");

			this.MonsterClassName = monsterClassName;
			this.Amount = amount;
			this.RespawnDelay = respawnDelay;
			this.MapClassName = mapClassName;
			this.Area = area;

			_rnd = new Random(RandomProvider.Get().Next());
			_totalAmount = this.Amount;
			_minX = this.Area.Min(a => a.X);
			_maxX = this.Area.Max(a => a.X);
			_minZ = this.Area.Min(a => a.Z);
			_maxZ = this.Area.Max(a => a.Z);
		}

		/// <summary>
		/// Spawns monsters until the total amount is reached.
		/// </summary>
		public void InitialSpawn()
		{
			while (_spawnCount < _totalAmount)
				this.Spawn();
		}

		/// <summary>
		/// Spawns a monster.
		/// </summary>
		/// <returns></returns>
		public Monster Spawn()
		{
			var monster = new Monster(_monsterData.Id, NpcType.Monster);
			monster.Position = this.GetRandomPosition();
			monster.FromGround = true;
			monster.Died += this.OnMonsterDied;

			//monster.AI = new AIMonster(monster);
			//monster.AI.SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);

			_map.AddMonster(monster);

			_spawnCount = Interlocked.Increment(ref _spawnCount);

			return monster;
		}

		/// <summary>
		/// Spawns a monster if the current amount is lower than the total.
		/// </summary>
		private void Respawn()
		{
			if (_spawnCount < _totalAmount)
				this.Spawn();
		}

		/// <summary>
		/// Called when a monster spawned by this spawner died.
		/// </summary>
		/// <param name="monster"></param>
		/// <param name="killer"></param>
		private void OnMonsterDied(Monster monster, ICombatEntity killer)
		{
			_spawnCount = Interlocked.Decrement(ref _spawnCount);

			// Use the spawner's respawn delay as the base, but add
			// a few random milliseconds on top, to make it appear
			// more dynamic.
			var delay = this.RespawnDelay;
			if (delay > TimeSpan.Zero)
				delay = delay.Add(TimeSpan.FromMilliseconds(_rnd.Next(250, 2000)));

			Task.Delay(delay).ContinueWith(_ => this.Respawn());
		}

		/// <summary>
		/// Returns a random position inside the spawn area.
		/// </summary>
		/// <returns></returns>
		private Position GetRandomPosition()
		{
			var _points = this.Area;
			var rnd = _rnd;

			// Single position
			if (_points.Length == 1)
				return _points[0];

			// Line
			if (_points.Length == 2)
			{
				var d = rnd.NextDouble();

				var x = _points[0].X + (_points[1].X - _points[0].X) * d;
				var y = _points[0].Y + (_points[1].Y - _points[0].Y) * d;
				var z = _points[0].Z + (_points[1].Z - _points[0].Z) * d;

				return new Position((float)x, (float)y, (float)z);
			}

			// Polygon
			var result = Position.Zero;
			var found = false;

			// Find a random position inside the polygon, but don't try
			// forever.
			for (var i = 0; i < 10; ++i)
			{
				var rndX = (float)(_minX + rnd.NextDouble() * (_maxX - _minX));
				var rndZ = (float)(_minZ + rnd.NextDouble() * (_maxZ - _minZ));

				// We will need a way to find the highest position at a
				// given location. Just use one of the Y coordinates for
				// now. Monsters can appear below the floor if Y is lower
				// than the ground. If it's above the ground, they will
				// plop down when they appear.
				var y = this.Area[0].Y;

				if (IsPointInside(this.Area, result = new Position(rndX, y, rndZ)))
				{
					found = true;
					break;
				}
			}

			// If not point was found, use a random edge point.
			if (!found)
				result = this.Area[_rnd.Next(this.Area.Length)];

			return result;
		}

		/// <summary>
		/// Returns true if the given point is within the area in 2D.
		/// </summary>
		/// <param name="area"></param>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <returns></returns>
		private static bool IsPointInside(Position[] area, Position point)
		{
			var result = false;
			var x = point.X;
			var z = point.Z;

			for (int i = 0, j = area.Length - 1; i < area.Length; j = i++)
			{
				if (((area[i].Z > z) != (area[j].Z > z)) && (x < (area[j].X - area[i].X) * (z - area[i].Z) / (area[j].Z - area[i].Z) + area[i].X))
					result = !result;
			}

			return result;
		}
	}
}
