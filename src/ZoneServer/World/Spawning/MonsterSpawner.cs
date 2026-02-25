using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;
using Yggdrasil.Extensions;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Spawning
{
	/// <summary>
	/// Spawns and respawns monsters.
	/// </summary>
	public class MonsterSpawner : IUpdateable
	{
		private const float FlexIncreaseLimit = 100;
		private const float FlexDecreaseLimit = -100;
		private const float FlexMeterDefault = 0;
		private const float FlexMeterIncreasePerDeath = 10;
		private const float FlexMeterDecreasePerSecond = 0.5f;
		private readonly static TimeSpan FlexSpawnInterval = TimeSpan.FromSeconds(5);

		private static int Ids;

		private readonly MonsterData _monsterData;

		private bool _initialSpawnDone;
		private float _flexMeter = 0;
		private TimeSpan _flexSpawnDelay = TimeSpan.MaxValue;
		private readonly List<TimeSpan> _respawnDelays = new();

		private readonly Random _rnd = new(RandomProvider.GetSeed());

		private SpawnAreaCollection _spawnAreas;
		private bool _spawnPointsLoadFailed;

		/// <summary>
		/// The identifier of the spawn areas collection this spawner will
		/// use to find spawn locations.
		/// </summary>
		public string SpawnPointsIdent { get; }

		/// <summary>
		/// Returns the unique id of this spawner.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the min amount of monsters this spawner spawns at a time.
		/// </summary>
		public int MinAmount { get; }

		/// <summary>
		/// Returns the max amount of monsters this spawner spawns at a time.
		/// </summary>
		public int MaxAmount { get; }

		/// <summary>
		/// Returns the  amount of monsters this spawner currently spawns at
		/// a time. This number may change based on how frequently monsters
		/// are killed.
		/// </summary>
		public int FlexAmount { get; private set; }

		/// <summary>
		/// Returns the monster data currently being used for this spawner.
		/// </summary>
		public MonsterData MonsterData { get { return _monsterData; } }

		/// <summary>
		/// Returns the amount of monsters currently spawned.
		/// </summary>
		public int Amount { get; private set; }

		/// <summary>
		/// Returns the amount of monsters queued up for respawning.
		/// </summary>
		public int QueuedAmount { get { lock (_respawnDelays) return _respawnDelays.Count; } }

		/// <summary>
		/// Returns the initial delay before the first spawn.
		/// </summary>
		public TimeSpan InitialDelay { get; }

		/// <summary>
		/// Returns the minimum time until a respawn after a monster
		/// disappeared.
		/// </summary>
		public TimeSpan MinRespawnDelay { get; }

		/// <summary>
		/// Returns the maximum time until a respawn after a monster
		/// disappeared.
		/// </summary>
		public TimeSpan MaxRespawnDelay { get; }

		/// <summary>
		/// Returns the default tendency for monsters spawned by this spawner.
		/// </summary>
		public TendencyType Tendency { get; }

		/// <summary>
		/// Returns overrides for the spawn monsters' properties.
		/// </summary>
		public PropertyOverrides PropertyOverrides { get; set; }

		/// <summary>
		/// Raised for every monster the spawner creates, just before it's
		/// added to the world.
		/// </summary>
		public event EventHandler<SpawnEventArgs> Spawning;

		/// <summary>
		/// Raised for every monster the spawner creates, just after it was
		/// added to the world.
		/// </summary>
		public event EventHandler<SpawnEventArgs> Spawned;

		/// <summary>
		/// Creates a new monster spawner.
		/// </summary>
		/// <param name="monsterClassId">Id of the monsters spawned by this instance.</param>
		/// <param name="minAmount">The minimum amount of monsters to spawn at a time.</param>
		/// <param name="maxAmount">The maximum amount of monsters to spawn at a time.</param>
		/// <param name="spawnPointsIdent">The identifier for the spawn areas collection, for locations to spawn monsters in.</param>
		/// <param name="initialSpawnDelay">The initial delay before the spawner starts spawning monsters.</param>
		/// <param name="minRespawnDelay">The minimum delay before a monster is respawned after death.</param>
		/// <param name="maxRespawnDelay">The maximum delay before a monster is respawned after death.</param>
		/// <param name="tendency">Defines the spawned monsters' aggressive tendencies.</param>
		/// <exception cref="ArgumentException"></exception>
		public MonsterSpawner(int monsterClassId, int minAmount, int maxAmount, string spawnPointsIdent, TimeSpan initialSpawnDelay, TimeSpan minRespawnDelay, TimeSpan maxRespawnDelay, TendencyType tendency)
		{
			if (!ZoneServer.Instance.Data.MonsterDb.TryFind(monsterClassId, out _monsterData))
				throw new ArgumentException($"MonsterSpawner: No monster data found for '{monsterClassId}'.");

			minAmount = Math.Max(1, minAmount);
			maxAmount = Math.Max(minAmount, maxAmount);

			initialSpawnDelay = Math2.Max(TimeSpan.Zero, initialSpawnDelay);
			minRespawnDelay = Math2.Max(TimeSpan.Zero, minRespawnDelay);
			maxRespawnDelay = Math2.Max(TimeSpan.Zero, maxRespawnDelay);

			this.Id = Interlocked.Increment(ref Ids);
			this.MinAmount = minAmount;
			this.MaxAmount = maxAmount;
			this.SpawnPointsIdent = spawnPointsIdent;
			this.FlexAmount = this.MinAmount;
			this.InitialDelay = initialSpawnDelay;
			this.MinRespawnDelay = minRespawnDelay;
			this.MaxRespawnDelay = maxRespawnDelay;
			this.Tendency = tendency;

			_flexSpawnDelay = this.InitialDelay;
		}

		/// <summary>
		/// Initializes the population by setting current monster amount to zero
		/// </summary>
		public void InitializePopulation()
		{
			this.Amount = 0;
		}

		/// <summary>
		/// Spawns the given number of monsters in a random spawn area.
		/// </summary>
		/// <param name="amount"></param>
		public void Spawn(int amount)
		{
			for (var i = 0; i < amount; ++i)
			{
				if (!_spawnAreas.TryGetRandomLocation(out var map, out var pos))
					return;

				var monster = new Mob(_monsterData.Id, MonsterType.Mob);
				monster.Position = pos;
				monster.FromGround = true;
				monster.Tendency = this.Tendency;
				monster.Died += this.OnMonsterDied;

				this.OverrideProperties(monster, map);

				monster.Components.Add(new MovementComponent(monster));

				if (!string.IsNullOrWhiteSpace(monster.Data.AiName) && monster.Data.AiName != "None")
					monster.Components.Add(new AiComponent(monster, monster.Data.AiName));

				this.Spawning?.Invoke(this, new SpawnEventArgs(this, monster));

				map.AddMonster(monster);
				monster.PossiblyBecomeRare();

				this.Spawned?.Invoke(this, new SpawnEventArgs(this, monster));
			}

			this.Amount += amount;
		}

		/// <summary>
		/// Overrides monster's properties with the ones defined for
		/// this spawner or on the map.
		/// </summary>
		/// <remarks>
		/// The overrides on the spawner take precedence over the ones
		/// on the maps.
		/// </remarks>
		/// <param name="monster">The monster to override properties on.</param>
		/// <param name="map">The map to check for overrides.</param>
		private void OverrideProperties(Mob monster, Map map)
		{
			// Don't override anything if the feature is disabled
			if (!Feature.IsEnabled("SpawnPropertyOverrides"))
				return;

			// Check for overrides defined for this spawner first,
			// if there are none, check the overrides for the
			// map the spawner is on.
			var propertyOverrides = this.PropertyOverrides;
			if (propertyOverrides == null)
			{
				if (!map.TryGetPropertyOverrides(_monsterData.Id, out propertyOverrides))
					return;
			}

			monster.ApplyOverrides(propertyOverrides);
		}

		/// <summary>
		/// Called when one of the monsters this instance spawned died and
		/// disappeared.
		/// </summary>
		/// <param name="monster"></param>
		/// <param name="killer"></param>
		private void OnMonsterDied(ICombatEntity monster, ICombatEntity killer)
		{
			this.Amount--;
			_flexMeter += FlexMeterIncreasePerDeath;

			lock (_respawnDelays)
				_respawnDelays.Add(this.GetRandomRespawnDelay());
		}

		/// <summary>
		/// (Re)spawns monsters regularly.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			if (!this.ValidateSpawnPointCollection())
				return;

			this.RespawnMonsters(elapsed);
			this.FlexSpawnMonsters(elapsed);
			this.BalanceSpawnAmounts(elapsed);
		}

		/// <summary>
		/// Checks the spawn areas collection and attempts to load it
		/// if necessary. Returns true if the spawn areas are ready
		/// to be used.
		/// </summary>
		/// <returns></returns>
		private bool ValidateSpawnPointCollection()
		{
			if (_spawnAreas != null)
				return true;

			if (_spawnPointsLoadFailed)
				return false;

			if (!ZoneServer.Instance.World.TryGetSpawnAreas(this.SpawnPointsIdent, out _spawnAreas))
			{
				Log.Warning($"MonsterSpawner: Spawn areas '{this.SpawnPointsIdent}' for '{_monsterData.ClassName}' spawner not found.");

				_spawnPointsLoadFailed = true;
				return false;
			}

			return true;
		}

		/// <summary>
		/// Respawns monsters that have been killed up until the current
		/// flex amount.
		/// </summary>
		/// <param name="elapsed"></param>
		private void RespawnMonsters(TimeSpan elapsed)
		{
			int expiredDelayCount;

			lock (_respawnDelays)
			{
				for (var i = 0; i < _respawnDelays.Count; ++i)
				{
					var spawnDelay = _respawnDelays[i];
					_respawnDelays[i] = spawnDelay - elapsed;
				}

				expiredDelayCount = _respawnDelays.Count(d => d <= TimeSpan.Zero);
				if (expiredDelayCount == 0)
					return;

				_respawnDelays.RemoveAll(d => d <= TimeSpan.Zero);
			}

			var spawnAmount = Math.Min(expiredDelayCount, this.FlexAmount - this.Amount);
			if (spawnAmount <= 0)
				return;

			this.Spawn(spawnAmount);
		}

		/// <summary>
		/// Spawns monsters until the current flex amount is reached.
		/// </summary>
		/// <param name="elapsed"></param>
		private void FlexSpawnMonsters(TimeSpan elapsed)
		{
			_flexSpawnDelay -= elapsed;
			if (_flexSpawnDelay > TimeSpan.Zero)
				return;

			_flexSpawnDelay = FlexSpawnInterval;

			var targetAmount = this.FlexAmount;
			var currentAmount = this.Amount;
			var queuedAmount = this.QueuedAmount;

			var potentialSpawnAmount = Math.Max(0, targetAmount - currentAmount - queuedAmount);
			if (potentialSpawnAmount > 0)
			{
				var spawnAmount = 1;

				// Spawn the full amount on the first flex spawn to get up
				// to the flex amount without delay.
				if (!_initialSpawnDone)
				{
					spawnAmount = potentialSpawnAmount;
					_initialSpawnDone = true;
				}

				this.Spawn(spawnAmount);
			}
		}

		/// <summary>
		/// Increases or decreases flex spawn amount based on the
		/// killing activity.
		/// </summary>
		/// <param name="elapsed"></param>
		private void BalanceSpawnAmounts(TimeSpan elapsed)
		{
			// Drain flex meter over time
			_flexMeter -= (float)(elapsed.TotalSeconds * FlexMeterDecreasePerSecond);

			// If the flex meter reached the increase limit, we increase
			// the spawn amount.
			if (_flexMeter > FlexIncreaseLimit)
			{
				this.FlexAmount = Math.Min(this.MaxAmount, this.FlexAmount + 1);
				_flexMeter = FlexMeterDefault;
			}
			// If the meter instead fell below the decrease limit, the
			// spawn amount decreases.
			else if (_flexMeter < FlexDecreaseLimit)
			{
				this.FlexAmount = Math.Max(this.MinAmount, this.FlexAmount - 1);
				_flexMeter = FlexMeterDefault;
			}
		}

		/// <summary>
		/// Returns a random delay between min and max respawn delay.
		/// </summary>
		/// <returns></returns>
		private TimeSpan GetRandomRespawnDelay()
			=> _rnd.Between(this.MinRespawnDelay, this.MaxRespawnDelay);
	}
}
