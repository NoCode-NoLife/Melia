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
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.MonsterManager
{
	/// <summary>
	/// This class is responsible for creating a monster spawner.
	/// A monster spawner controls the monster population and the spawn
	/// points where that monster can spawn.
	/// </summary>
	public class MonsterSpawner : IUpdateable
	{
		private const float FlexIncreaseLimit = 100;
		private const float FlexDecreaseLimit = -100;
		private const float FlexMeterDefault = 0;
		private const float FlexMeterIncreasePerDeath = 10;
		private const float FlexMeterDecreasePerMillisecond = 0.0005f;

		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

		private static int Ids;

		private readonly MonsterData _monsterData;

		private float _flexMeter = 0;
		private TimeSpan _flexSpawnDelay = TimeSpan.Zero;
		private TimeSpan _respawnDelay = TimeSpan.Zero;

		/// <summary>
		/// List of spawn points associated to this spawner.
		/// The monsters in this spawner can spawn in any of these
		/// points (randomly).
		/// </summary>
		private List<MonsterSpawnPoint> _spawnPoints = new List<MonsterSpawnPoint>();

		/// <summary>
		/// Returns the unique id of this spawner.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the name of this spawner.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Current amount of monsters spawned by this spawner
		/// </summary>
		public int CurrentPopulation { get; private set; }

		/// <summary>
		/// Maximum amount of monsters that this spawner can spawn
		/// </summary>
		public int MaxPopulation { get; }

		/// <summary>
		/// Returns the min amount of monsters this spawner spawns at a time.
		/// </summary>
		public int MinRespawnAmount { get; }

		/// <summary>
		/// Returns the max amount of monsters this spawner spawns at a time.
		/// </summary>
		public int MaxRespawnAmount { get; }

		/// <summary>
		/// Returns the  amount of monsters this spawner currently spawns at
		/// a time. This number may change based on how frequently monsters
		/// are killed.
		/// </summary>
		public int FlexAmount { get; private set; }

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
		/// Creates a monster spawner
		/// </summary>
		/// <param name="name"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="area"></param>
		/// <param name="initialSpawnDelay"></param>
		/// <param name="minRespawnDelay"></param>
		/// <param name="maxRespawnDelay"></param>
		/// <param name="minRespawnAmount"></param>
		/// <param name="maxRespawnAmount"></param>
		/// <param name="tendency"></param>
		/// <param name="propertyOverrides"></param>
		/// <exception cref="ArgumentException"></exception>
		public MonsterSpawner(string name, int monsterClassId, int maxPopulation, TimeSpan initialSpawnDelay,
			TimeSpan minRespawnDelay, TimeSpan maxRespawnDelay, int minRespawnAmount, int maxRespawnAmount, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			if (!ZoneServer.Instance.Data.MonsterDb.TryFind(monsterClassId, out _monsterData))
				throw new ArgumentException($"No monster data found for '{monsterClassId}'.");

			minRespawnAmount = Math.Max(0, minRespawnAmount);
			maxRespawnAmount = Math.Max(1, maxRespawnAmount);
			initialSpawnDelay = Math2.Max(TimeSpan.Zero, initialSpawnDelay);
			minRespawnDelay = Math2.Max(TimeSpan.Zero, minRespawnDelay);
			maxRespawnDelay = Math2.Max(TimeSpan.Zero, maxRespawnDelay);

			this.Id = Interlocked.Increment(ref Ids);
			this.Name = name;
			this.InitializePopulation();
			this.MaxPopulation = maxPopulation;
			this.MinRespawnAmount = minRespawnAmount;
			this.MaxRespawnAmount = maxRespawnAmount;
			this.FlexAmount = 0;
			this.InitialDelay = initialSpawnDelay;
			this.MinRespawnDelay = minRespawnDelay;
			this.MaxRespawnDelay = maxRespawnDelay;
			this.Tendency = tendency;
			this.PropertyOverrides = propertyOverrides;

			_flexSpawnDelay = this.InitialDelay;
		}

		/// <summary>
		/// Overrides monster's properties with the ones defined for
		/// this spawner. Will check for property overrides in the
		/// spawner or in the map received as parameter.
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
			this.IncrementPopulation(-1);

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
		/// This method spawns monsters normally with the constant respawn delay.
		/// Monsters can only be spawned up to its maximum population.
		/// Monsters spawn in random amounts between MinRespawnAmount and
		/// MaxRespawnAmount at a time.
		/// </summary>
		/// <param name="elapsed"></param>
		private void RespawnMonsters(TimeSpan elapsed)
		{
			var availablePopulation = this.AvailablePopulation;
			
			// No population available to respawn
			if (availablePopulation <= 0)
				return;

			// No spawn points available to spawn
			if (_spawnPoints.Count <= 0)
				return;

			// Updates respawn delay
			_respawnDelay -= elapsed;

			// If still in delay, return
			if (_respawnDelay > TimeSpan.Zero)
				return;

			// Checks amount of mobs that can be spawned
			var amount = Math.Min(GetRandomRespawnAmount(), availablePopulation);

			// No mob population available to spawn
			if (amount <= 0)
				return;

			// Spawns monsters in a random spawn point
			this.SpawnInRandomSpawnPoint(amount);

			// Resets the delay
			_respawnDelay = this.GetRandomRespawnDelay();
		}

		/// <summary>
		/// This method boosts up the default respawn method by allowing
		/// monsters to respawn even faster depending on the players
		/// killing them. The faster mobs are being killed, the faster
		/// they will respawn. Monsters can still only respawn up
		/// to their max population.
		/// </summary>
		/// <param name="elapsed"></param>
		private void FlexSpawnMonsters(TimeSpan elapsed)
		{
			var availablePopulation = this.AvailablePopulation;

			// No population available to respawn
			if (availablePopulation <= 0)
				return;

			// No spawn points available to spawn
			if (_spawnPoints.Count <= 0)
				return;

			// Updates flexible respawn delay
			_flexSpawnDelay -= elapsed;

			// If still in delay, return
			if (_flexSpawnDelay > TimeSpan.Zero)
				return;

			// Checks amount of mobs that can be spawned
			var amount = Math.Min(this.FlexAmount * GetRandomRespawnAmount(), availablePopulation);

			// No mob population available to spawn
			if (amount <= 0)
				return;

			// Spawns monsters in a random spawn point
			this.SpawnInRandomSpawnPoint(amount);

			// Resets the flex spawn delay
			_flexSpawnDelay = this.GetRandomRespawnDelay();
		}

		/// <summary>
		/// Increases or decreases flex spawn amount based on the
		/// killing activity.
		/// </summary>
		/// <param name="elapsed"></param>
		private void BalanceSpawnAmounts(TimeSpan elapsed)
		{
			// Drain flex meter over time
			_flexMeter -= (float)(elapsed.TotalMilliseconds * FlexMeterDecreasePerMillisecond);

			// If the flex meter reached the increase limit, we increase
			// the spawn amount.
			if (_flexMeter > FlexIncreaseLimit)
			{
				this.FlexAmount = Math.Min(this.MaxPopulation, this.FlexAmount + 1);
				_flexMeter = FlexMeterDefault;
			}
			// If the meter instead fell below the decrease limit, the
			// spawn amount decreases.
			else if (_flexMeter <= FlexDecreaseLimit)
			{
				this.FlexAmount = Math.Max(0, this.FlexAmount - 1);
				_flexMeter = FlexMeterDefault;
			}
		}

		/// <summary>
		/// Adds a spawn point to this spawner
		/// </summary>
		/// <param name="spawnPoint"></param>
		public void AddSpawnPoint(MonsterSpawnPoint spawnPoint)
		{
			_spawnPoints.Add(spawnPoint);
		}

		/// <summary>
		/// This method is responsible to create a new mob actor
		/// and invoke a random spawn point within this spawner.
		/// </summary>
		/// <param name="amount">amount of monsters to spawn</param>
		public void SpawnInRandomSpawnPoint(int amount)
		{
			if (_spawnPoints.Count <= 0)
				throw new ArgumentException($"SpawnInRandomSpawnPoint: No spawn points available for spawner name: '{this.Name}'.");

			for (var i = 0; i < amount; ++i)
			{
				// Creates new monster actor
				var monster = new Mob(_monsterData.Id, MonsterType.Mob);
				monster.FromGround = true;
				monster.Tendency = this.Tendency;
				monster.Died += this.OnMonsterDied;

				// Gets random index from spawn point list
				var index = _rnd.Next(0, _spawnPoints.Count);

				this.OverrideProperties(monster, _spawnPoints[index].Map);

				monster.Components.Add(new MovementComponent(monster));
				monster.Components.Add(new AiComponent(monster, "BasicMonster"));

				var success = _spawnPoints[index].Spawn(monster);

				if (success)
					this.IncrementPopulation(1);
			}
		}

		/// <summary>
		/// Returns a random delay between min and max respawn delay.
		/// </summary>
		/// <returns></returns>
		private TimeSpan GetRandomRespawnDelay()
			=> _rnd.Between(this.MinRespawnDelay, this.MaxRespawnDelay);

		/// <summary>
		/// Returns a random value between min and max respawn amount.
		/// </summary>
		/// <returns></returns>
		private int GetRandomRespawnAmount()
			=> _rnd.Next(this.MinRespawnAmount, this.MaxRespawnAmount);


		/// <summary>
		/// Returns Available population: MaxCount - CurrentCount
		/// </summary>
		public int AvailablePopulation
		{
			get { return this.MaxPopulation - this.CurrentPopulation; }
		}

		/// <summary>
		/// Changes current population by a given amount. Clamps between 0 and MaxCount
		/// </summary>
		public void IncrementPopulation(int amount)
		{
			this.CurrentPopulation = Math2.Clamp(0, this.MaxPopulation, this.CurrentPopulation + amount);
		}

		/// <summary>
		/// Sets the current population to zero.
		/// </summary>
		public void InitializePopulation()
		{
			this.CurrentPopulation = 0;
		}

	}
}
