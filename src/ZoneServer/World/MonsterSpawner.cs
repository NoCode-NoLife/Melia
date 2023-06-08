using System;
using System.Threading;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;
using Yggdrasil.Extensions;
using Yggdrasil.Geometry;
using Yggdrasil.Logging;
using Yggdrasil.Util;

namespace Melia.Zone.World
{
	/// <summary>
	/// Spawns and respawns monsters.
	/// </summary>
	public class MonsterSpawner
	{
		private static int Ids;

		private readonly static TimeSpan SpawnAmountIncreaseDelay = TimeSpan.FromSeconds(30);
		private readonly static TimeSpan SpawnAmountDecreaseDelay = TimeSpan.FromSeconds(60);

		private readonly MonsterData _monsterData;
		private readonly Map _map;

		private bool _initialSpawnDone;
		private TimeSpan _spawnDelay = TimeSpan.MaxValue;
		private TimeSpan _spawnAmountIncreaseDelay = SpawnAmountIncreaseDelay;
		private TimeSpan _spawnAmountDecreaseDelay = SpawnAmountDecreaseDelay;
		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

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
		/// Returns the area in which the monsters are spawned.
		/// </summary>
		public IShape Area { get; }

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
		/// Returns overrides for the spawn monsters' properties.
		/// </summary>
		public PropertyOverrides PropertyOverrides { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="maxAmount"></param>
		/// <param name="regionId"></param>
		/// <param name="area"></param>
		/// <param name="initialSpawnDelay"></param>
		/// <param name="minRespawnDelay"></param>
		/// <param name="maxRespawnDelay"></param>
		/// <param name="titles"></param>
		public MonsterSpawner(int monsterClassId, int maxAmount, string mapClassName, IShape area, TimeSpan initialSpawnDelay, TimeSpan minRespawnDelay, TimeSpan maxRespawnDelay, PropertyOverrides propertyOverrides)
		{
			if (!ZoneServer.Instance.Data.MonsterDb.TryFind(monsterClassId, out _monsterData))
				throw new ArgumentException($"No monster data found for '{monsterClassId}'.");

			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out _map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			maxAmount = Math.Max(1, maxAmount);
			initialSpawnDelay = Math2.Max(TimeSpan.Zero, initialSpawnDelay);
			minRespawnDelay = Math2.Max(TimeSpan.Zero, minRespawnDelay);
			maxRespawnDelay = Math2.Max(TimeSpan.Zero, maxRespawnDelay);

			var minAmount = Math.Max(1, maxAmount / 4);

			this.Id = Interlocked.Increment(ref Ids);
			this.MinAmount = minAmount;
			this.MaxAmount = maxAmount;
			this.FlexAmount = this.MinAmount;
			this.MapClassName = mapClassName;
			this.Area = area;
			this.InitialDelay = initialSpawnDelay;
			this.MinRespawnDelay = minRespawnDelay;
			this.MaxRespawnDelay = maxRespawnDelay;
			this.PropertyOverrides = propertyOverrides;

			_spawnDelay = this.InitialDelay;
		}

		/// <summary>
		/// Spawns the given number of monsters.
		/// </summary>
		public void Spawn(int amount)
		{
			for (var i = 0; i < amount; ++i)
			{
				var monster = new Mob(_monsterData.Id, MonsterType.Mob);
				monster.Position = this.GetRandomPosition();
				monster.FromGround = true;
				monster.Died += this.OnMonsterDied;

				this.OverrideProperties(monster);

				//monster.AI = new AIMonster(monster);
				//monster.AI.SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);

				_map.AddMonster(monster);
			}

			this.Amount += amount;
		}

		/// <summary>
		/// Overrides monster's properties with the ones defined for
		/// this spawner.
		/// </summary>
		/// <param name="monster"></param>
		private void OverrideProperties(Mob monster)
		{
			if (this.PropertyOverrides == null)
				return;

			if (!Feature.IsEnabled("SpawnPropertyOverrides"))
				return;

			foreach (var propertyOverride in this.PropertyOverrides)
			{
				var propertyName = propertyOverride.Key;

				switch (propertyOverride.Value)
				{
					case int intValue:
						monster.Properties.SetFloat(propertyName, intValue);
						break;

					case float floatValue:
						monster.Properties.SetFloat(propertyName, floatValue);
						break;

					case string stringValue:
						monster.Properties.SetString(propertyName, stringValue);
						break;
				}
			}

			monster.Properties.InvalidateAll();
			monster.Properties.SetFloat(PropertyName.HP, monster.Properties.GetFloat(PropertyName.MHP));
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

			// Reset spawn decreaser because the death of an monster means
			// activity, and we only want to decrease the amount when
			// nothing is happening.
			_spawnAmountDecreaseDelay = SpawnAmountDecreaseDelay;
		}

		/// <summary>
		/// (Re)spawns monsters regularly.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			// Spawn new monsters regularly
			_spawnDelay -= elapsed;
			if (_spawnDelay <= TimeSpan.Zero)
			{
				// Do a full spawn on the first run
				if (!_initialSpawnDone)
				{
					this.Spawn(this.FlexAmount);
					_initialSpawnDone = true;
					_spawnDelay = this.GetRandomRespawnDelay();
					return;
				}

				if (this.Amount < this.FlexAmount)
					this.Spawn(1);

				// Use halfed respawn rate during respawns. This is set
				// back to the normal rate when monsters are killed.
				_spawnDelay = this.GetRandomRespawnDelay().Divide(2);
			}

			// Regularly check how many monsters there currently are and
			// increase their max amount if their numbers are being kept
			// low.
			_spawnAmountIncreaseDelay -= elapsed;
			if (_spawnAmountIncreaseDelay <= TimeSpan.Zero)
			{
				// Increase amount by 1 if less than half of the spawns
				// are left
				if (this.Amount < this.FlexAmount / 2)
					this.FlexAmount = Math.Min(this.MaxAmount, this.FlexAmount + 1);

				_spawnAmountIncreaseDelay = SpawnAmountIncreaseDelay;
			}

			// Decrease spawn amount in regular intervals. This variable
			// is reset when a monster dies, to keep the number from going
			// down while monster are being hunted.
			_spawnAmountDecreaseDelay -= elapsed;
			if (_spawnAmountDecreaseDelay <= TimeSpan.Zero)
			{
				this.FlexAmount = Math2.Clamp(this.MinAmount, this.MaxAmount, this.FlexAmount - 1);
				_spawnAmountDecreaseDelay = SpawnAmountDecreaseDelay;
			}
		}

		/// <summary>
		/// Returns a random delay between min and max respawn delay.
		/// </summary>
		/// <returns></returns>
		private TimeSpan GetRandomRespawnDelay()
		{
			var min = (int)this.MinRespawnDelay.TotalMilliseconds;
			var max = (int)this.MaxRespawnDelay.TotalMilliseconds;
			var result = _rnd.Next(min, max + 1);

			return TimeSpan.FromMilliseconds(result);
		}

		/// <summary>
		/// Returns a random position within the spawn area.
		/// </summary>
		/// <returns></returns>
		private Position GetRandomPosition()
		{
			var rndVector = this.Area.GetRandomPoint(_rnd);
			var pos = new Position(rndVector.X, 0, rndVector.Y);

			if (!_map.Ground.TryGetHeightAt(pos, out var height))
				Log.Warning("MonsterSpawner.GetRandomPosition: Failed to get height at {0} for '{1}' spawner on '{2}'.", pos, _monsterData.ClassName, this.MapClassName);

			pos.Y = height;

			return pos;
		}
	}
}
