using System;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;
using Yggdrasil.Geometry.Shapes;
using Yggdrasil.Logging;
using Yggdrasil.Util;

namespace Melia.Zone.World
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
		public IShape Area { get; }

		/// <summary>
		/// Creates a new spawner.
		/// </summary>
		/// <param name="monsterClassName">Class name of the monster to spawn.</param>
		/// <param name="amount">Amount of monsters to spawn and keep around.</param>
		/// <param name="respawnDelay">Delay until a monster is spawned again.</param>
		/// <param name="mapClassName">Class name of the map to spawn monsters on.</param>
		/// <param name="area">Area monsters might spawn in.</param>
		public MonsterSpawner(string monsterClassName, int amount, TimeSpan respawnDelay, string mapClassName, IShape area)
		{
			if (!ZoneServer.Instance.Data.MonsterDb.TryFind(a => a.ClassName == monsterClassName, out _monsterData))
				throw new ArgumentException($"No monster data found for '{monsterClassName}'.");

			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out _map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			this.MonsterClassName = monsterClassName;
			this.Amount = amount;
			this.RespawnDelay = respawnDelay;
			this.MapClassName = mapClassName;
			this.Area = area;

			_rnd = new Random(RandomProvider.Get().Next());
			_totalAmount = this.Amount;
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
		public MonsterLegacy Spawn()
		{
			var monster = new MonsterLegacy(_monsterData.Id, MonsterType.Mob);
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
		private void OnMonsterDied(MonsterLegacy monster, ICombatEntity killer)
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
			var rndVector = this.Area.GetRandomPoint(_rnd);
			var pos = new Position(rndVector.X, 0, rndVector.Y);

			if (!_map.Ground.TryGetHeightAt(pos, out var height))
				Log.Warning("MonsterSpawner.GetRandomPosition: Failed to get height at {0} for '{1}' spawner on '{2}'.", pos, this.MonsterClassName, this.MapClassName);

			pos.Y = height;

			return pos;
		}
	}
}
