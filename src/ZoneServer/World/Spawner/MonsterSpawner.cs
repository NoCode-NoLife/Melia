using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Shared.Data.Database;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;
using Yggdrasil.Extensions;
using Yggdrasil.Geometry;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Spawner
{
	/// <summary>
	/// Spawns and respawns monsters.
	/// </summary>
	public class MonsterSpawner :IUpdateable
	{
		private const float FlexIncreaseLimit = 100;
		private const float FlexDecreaseLimit = -100;
		private const float FlexMeterDefault = 0;
		private const float FlexMeterIncreasePerDeath = 10;
		private const float FlexMeterDecreasePerSecond = 0.5f;

		private static int Ids;

		private readonly MonsterData _monsterData;

		private float _flexMeter = 0;
		private TimeSpan _flexSpawnDelay = TimeSpan.MaxValue;
		private readonly List<TimeSpan> _respawnDelays = new List<TimeSpan>();

		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

		/// <summary>
		/// List of spawn points this spawner can spawn monsters in.
		/// The spawn point is chosen at random each time there are
		/// monsters to be spawned.
		/// </summary>
		private List<MonsterSpawnPoint> _spawnPoints = new List<MonsterSpawnPoint>();

		/// <summary>
		/// Returns the unique id of this spawner.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the name identifier for this spawner.
		/// </summary>
		public string Name { get; set; }

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
		/// Returns the amount of monsters currently spawned.
		/// </summary>
		public int Amount { get; private set; }

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
		public PropertyOverrides PropertyOverrides { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="minAmount"></param>
		/// <param name="maxAmount"></param>
		/// <param name="initialSpawnDelay"></param>
		/// <param name="minRespawnDelay"></param>
		/// <param name="maxRespawnDelay"></param>
		/// <param name="tendency"></param>
		/// <param name="propertyOverrides"></param>
		public MonsterSpawner(string name, int monsterClassId, int minAmount, int maxAmount, TimeSpan initialSpawnDelay, TimeSpan minRespawnDelay, TimeSpan maxRespawnDelay, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			if (!ZoneServer.Instance.Data.MonsterDb.TryFind(monsterClassId, out _monsterData))
				throw new ArgumentException($"No monster data found for '{monsterClassId}'.");

			maxAmount = Math.Max(1, maxAmount);
			initialSpawnDelay = Math2.Max(TimeSpan.Zero, initialSpawnDelay);
			minRespawnDelay = Math2.Max(TimeSpan.Zero, minRespawnDelay);
			maxRespawnDelay = Math2.Max(TimeSpan.Zero, maxRespawnDelay);

			this.Name = name;
			this.Id = Interlocked.Increment(ref Ids);
			this.MinAmount = minAmount;
			this.MaxAmount = maxAmount;
			this.FlexAmount = this.MinAmount;
			this.InitialDelay = initialSpawnDelay;
			this.MinRespawnDelay = minRespawnDelay;
			this.MaxRespawnDelay = maxRespawnDelay;
			this.Tendency = tendency;
			this.PropertyOverrides = propertyOverrides;

			_flexSpawnDelay = this.InitialDelay;
		}

		/// <summary>
		/// Adds a spawn point where this spawner can generate mobs into.
		/// </summary>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <returns></returns>
		public MonsterSpawnPoint AddSpawnPoint(string mapClassName, IShape area)
		{
			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out var map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			var spawnPoint = new MonsterSpawnPoint(map, area);
			_spawnPoints.Add(spawnPoint);

			return spawnPoint;
		}

		/// <summary>
		/// Gets all spawn points of this spawner that are in a specific
		/// map. Returns copy of list with matching spawn points, or null
		/// if none are found.
		/// </summary>
		/// <param name="map"></param>
		/// <returns></returns>
		public List<MonsterSpawnPoint> GetSpawnPointsInMap(Map map)
		{
			List<MonsterSpawnPoint> ls = null;
			ls = _spawnPoints.FindAll(p => p.Map.Name.Equals(map.Name));
			return ls;
		}

		/// <summary>
		/// Initializes the population by setting current monster amount to zero
		/// </summary>
		public void InitializePopulation()
		{
			this.Amount = 0;
		}

		/// <summary>
		/// Spawns the given number of monsters in a random spawn point.
		/// </summary>
		public void Spawn(int amount)
		{
			// Gets random spawn point
			var index = _rnd.Next(0, _spawnPoints.Count);
			var spawnPoint = _spawnPoints[index];

			for (var i = 0; i < amount; ++i)
			{
				if (!spawnPoint.TryGetRandomPosition(out var pos))
				{
					Log.Warning($"MonsterSpawner: Couldn't find a valid spawn position for monster '{_monsterData.ClassName}' on map '{spawnPoint.Map.Name}'.");
					continue;
				}

				var monster = new Mob(_monsterData.Id, MonsterType.Mob);
				monster.Position = pos;
				monster.FromGround = true;
				monster.Tendency = this.Tendency;
				monster.Died += this.OnMonsterDied;

				this.OverrideProperties(monster, spawnPoint.Map);

				monster.Components.Add(new MovementComponent(monster));
				monster.Components.Add(new AiComponent(monster, "BasicMonster"));

				spawnPoint.Map.AddMonster(monster);
			}

			this.Amount += amount;
		}

		/// <summary>
		/// Overrides monster's properties with the ones defined for
		/// this spawner. Receives map to verify if there are map
		/// overrides as well.
		/// </summary>
		/// <param name="monster"></param>
		/// <param name="map"></param>
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

			foreach (var propertyOverride in propertyOverrides)
			{
				var propertyName = propertyOverride.Key;
				var properties = monster.Properties as Properties;

				// Calculated properties can't be overridden directly,
				// instead we swap to the override properties that the
				// calculation functions use.
				if (properties.TryGet<CFloatProperty>(propertyName, out var calculatedProperty))
					properties = monster.Properties.Overrides;

				switch (propertyOverride.Value)
				{
					case int intValue:
						properties.SetFloat(propertyName, intValue);
						break;

					case float floatValue:
						properties.SetFloat(propertyName, floatValue);
						break;

					case string stringValue:
						properties.SetString(propertyName, stringValue);
						break;
				}
			}

			monster.Properties.InvalidateAll();

			monster.Properties.SetFloat(PropertyName.HP, monster.Properties.GetFloat(PropertyName.MHP));
			monster.Properties.SetFloat(PropertyName.SP, monster.Properties.GetFloat(PropertyName.MSP));
		}

		/// <summary>
		/// Called when one of the monsters this instance spawned died and
		/// disappeared.
		/// </summary>
		/// <param name="monster"></param>
		/// <param name="killer"></param>
		private void OnMonsterDied(Mob monster, ICombatEntity killer)
		{
			this.Amount--;

			_respawnDelays.Add(this.GetRandomRespawnDelay());
			_flexMeter += FlexMeterIncreasePerDeath;
		}

		/// <summary>
		/// (Re)spawns monsters regularly.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.RespawnMonsters(elapsed);
			this.FlexSpawnMonsters(elapsed);
			this.BalanceSpawnAmounts(elapsed);
		}

		/// <summary>
		/// Respawns monsters that have been killed up until the current
		/// flex amount.
		/// </summary>
		/// <param name="elapsed"></param>
		private void RespawnMonsters(TimeSpan elapsed)
		{
			for (var i = 0; i < _respawnDelays.Count; ++i)
			{
				var spawnDelay = _respawnDelays[i];
				_respawnDelays[i] = spawnDelay - elapsed;
			}

			var expiredDelayCount = _respawnDelays.Count(d => d <= TimeSpan.Zero);
			if (expiredDelayCount == 0)
				return;

			_respawnDelays.RemoveAll(d => d <= TimeSpan.Zero);

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

			_flexSpawnDelay = this.GetRandomRespawnDelay();

			var potentialSpawnAmount = Math.Max(0, this.FlexAmount - this.Amount - _respawnDelays.Count);
			if (potentialSpawnAmount > 0)
				this.Spawn(1);
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
