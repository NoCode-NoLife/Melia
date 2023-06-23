using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Shared.Data.Database;
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
using Yggdrasil.Util;

namespace Melia.Zone.World
{
	/// <summary>
	/// Spawns and respawns monsters.
	/// </summary>
	public class MonsterSpawner
	{
		private const int MaxValidPositionTries = 50;

		private const float FlexIncreaseLimit = 100;
		private const float FlexDecreaseLimit = -100;
		private const float FlexMeterDefault = 0;
		private const float FlexMeterIncreasePerDeath = 10;
		private const float FlexMeterDecreasePerMillisecond = 0.005f;

		private static int Ids;

		private readonly MonsterData _monsterData;
		private readonly Map _map;

		private float _flexMeter = 0;
		private TimeSpan _flexSpawnDelay = TimeSpan.Zero;
		private TimeSpan _respawnDelay = TimeSpan.Zero;

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
		/// Returns the default tendency for monsters spawned by this spawner.
		/// </summary>
		public TendencyType Tendency { get; }

		/// <summary>
		/// Returns overrides for the spawn monsters' properties.
		/// </summary>
		public PropertyOverrides PropertyOverrides { get; }

		/// <summary>
		/// The monster population associated to this spawner. The number of monsters
		/// spawned cannot exceed its max population.
		/// </summary>
		public MonsterPopulation MonsterPopulation { get; }

		/// <summary>
		/// Creates new instance
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="monsterPopulation"></param>
		/// <param name="mapClassName"></param>
		/// <param name="area"></param>
		/// <param name="initialSpawnDelay"></param>
		/// <param name="minRespawnDelay"></param>
		/// <param name="maxRespawnDelay"></param>
		/// <param name="minRespawnAmount"></param>
		/// <param name="maxRespawnAmount"></param>
		/// <param name="tendency"></param>
		/// <param name="propertyOverrides"></param>
		/// <exception cref="ArgumentException"></exception>
		public MonsterSpawner(int monsterClassId, MonsterPopulation monsterPopulation, string mapClassName, IShape area, TimeSpan initialSpawnDelay,
			TimeSpan minRespawnDelay, TimeSpan maxRespawnDelay, int minRespawnAmount, int maxRespawnAmount, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			if (!ZoneServer.Instance.Data.MonsterDb.TryFind(monsterClassId, out _monsterData))
				throw new ArgumentException($"No monster data found for '{monsterClassId}'.");

			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out _map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			minRespawnAmount = Math.Max(0, minRespawnAmount);
			maxRespawnAmount = Math.Max(1, maxRespawnAmount);
			initialSpawnDelay = Math2.Max(TimeSpan.Zero, initialSpawnDelay);
			minRespawnDelay = Math2.Max(TimeSpan.Zero, minRespawnDelay);
			maxRespawnDelay = Math2.Max(TimeSpan.Zero, maxRespawnDelay);

			this.Id = Interlocked.Increment(ref Ids);
			this.MinRespawnAmount = minRespawnAmount;
			this.MaxRespawnAmount = maxRespawnAmount;
			this.FlexAmount = 0;
			this.MapClassName = mapClassName;
			this.Area = area;
			this.InitialDelay = initialSpawnDelay;
			this.MinRespawnDelay = minRespawnDelay;
			this.MaxRespawnDelay = maxRespawnDelay;
			this.Tendency = tendency;
			this.PropertyOverrides = propertyOverrides;
			this.MonsterPopulation = monsterPopulation;

			_flexSpawnDelay = this.InitialDelay;
		}

		/// <summary>
		/// Spawns the given number of monsters
		/// </summary>
		public void Spawn(int amount)
		{
			for (var i = 0; i < amount; ++i)
			{
				if (!this.TryGetRandomPosition(out var pos))
				{
					Log.Warning($"MonsterSpawner: Couldn't find a valid spawn position for monster '{_monsterData.ClassName}' on map '{_map.Name}'.");
					continue;
				}

				var monster = new Mob(_monsterData.Id, MonsterType.Mob);
				monster.Position = pos;
				monster.FromGround = true;
				monster.Tendency = this.Tendency;
				monster.Died += this.OnMonsterDied;

				this.OverrideProperties(monster);

				monster.Components.Add(new MovementComponent(monster));
				monster.Components.Add(new AiComponent(monster, "BasicMonster"));

				_map.AddMonster(monster);
			}

			MonsterPopulation.CurrentCount += amount;
		}

		/// <summary>
		/// Overrides monster's properties with the ones defined for
		/// this spawner.
		/// </summary>
		/// <param name="monster"></param>
		private void OverrideProperties(Mob monster)
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
				if (!_map.TryGetPropertyOverrides(_monsterData.Id, out propertyOverrides))
					return;
			}

			foreach (var propertyOverride in propertyOverrides)
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
			MonsterPopulation.CurrentCount -= 1;

			if (MonsterPopulation.CurrentCount < 0)
				MonsterPopulation.CurrentCount = 0;

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
		/// Monsters spawn in random amounts between MinRespawnAmount and MaxRespawnAmount at a time.
		/// </summary>
		/// <param name="elapsed"></param>
		private void RespawnMonsters(TimeSpan elapsed)
		{
			int availablePopulation = MonsterPopulation.AvailablePopulation();
			
			// No population available to respawn
			if (availablePopulation <= 0)
				return;

			// Updates respawn delay
			_respawnDelay -= elapsed;

			// If still in delay, return
			if (_respawnDelay > TimeSpan.Zero)
				return;

			// Checks amount of mobs that can be spawned
			var amount = Math.Min(GetRandomRespawnAmount(), availablePopulation);

			if (amount <= 0)
				return;

			// Spawns monsters
			this.Spawn(amount);

			// Resets the delay
			_respawnDelay = this.GetRandomRespawnDelay();
		}

		/// <summary>
		/// This method boosts up the default respawn method by allowing monsters to respawn
		/// even faster depending on the players killing them. The faster mobs are being killed,
		/// the faster they will respawn. Monsters can still only respawn up to their max population.
		/// </summary>
		/// <param name="elapsed"></param>
		private void FlexSpawnMonsters(TimeSpan elapsed)
		{
			int availablePopulation = MonsterPopulation.AvailablePopulation();

			// No population available to respawn
			if (availablePopulation <= 0)
				return;

			// Updates flexible respawn delay
			_flexSpawnDelay -= elapsed;

			// If still in delay, return
			if (_flexSpawnDelay > TimeSpan.Zero)
				return;

			// Checks amount of mobs that can be spawned
			var amount = Math.Min(this.FlexAmount * GetRandomRespawnAmount(), availablePopulation);

			if (amount <= 0)
				return;

			// Spawns monsters
			this.Spawn(amount);

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
				this.FlexAmount = Math.Min(MonsterPopulation.MaxCount, this.FlexAmount + 1);
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
			if (_map.Ground.TryGetHeightAt(pos, out var height))
			{
				pos.Y = height;
				return true;
			}

			pos = Position.Zero;
			return false;
		}
	}
}
