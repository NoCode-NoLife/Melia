using System;
using Melia.Shared.Data.Database;
using Melia.Zone.World.Maps;
using Yggdrasil.Util;

namespace Melia.Zone.World.MonsterManager
{
	/// <summary>
	/// This is an auxiliary class to MonsterSpawnPoint. Each MonsterSpawnPoint 
	/// should be associated to a generator and use properties of said generator.
	/// For example: If a same generator is used in two spawn points and the
	/// generator has a maximum population of 30, the two spawn points will
	/// not spawn more than 30 monsters together.
	/// </summary>
	public class MonsterGenerator
	{
		/// <summary>
		/// Current amount of monsters in this generator
		/// </summary>
		private int _currentCount;

		/// <summary>
		/// Maximum amount of monsters that can be in this generator
		/// </summary>
		private int _maxCount;

		/// <summary>
		/// The monster this generator can generate.
		/// Note: Only one monster class allowed per generator
		/// </summary>
		public MonsterData MonsterData;

		/// <summary>
		/// Returns the class name of the map
		/// spawned on
		/// </summary>
		public string MapClassName { get; }

		/// <summary>
		/// Returns max population
		/// </summary>
		public int MaxPopulation
		{
			get { return _maxCount; }
		}

		/// <summary>
		/// Returns current population
		/// </summary>
		public int CurrentPopulation
		{
			get { return _currentCount; }
		}

		/// <summary>
		/// Returns Available population: MaxCount - CurrentCount
		/// </summary>
		public int AvailablePopulation
		{
			get { return _maxCount - _currentCount; }
		}

		/// <summary>
		/// Creates new monster generator. Current population will always
		/// be initialized at zero.
		/// </summary>
		/// <param name="mapClassName"></param>
		/// <param name="monsterClassId"></param>
		/// <param name="maxPopulation"></param>
		/// <exception cref="ArgumentException"></exception>
		public MonsterGenerator(string mapClassName, int monsterClassId, int maxPopulation)
		{
			if (!ZoneServer.Instance.Data.MonsterDb.TryFind(monsterClassId, out MonsterData))
				throw new ArgumentException($"No monster data found for '{monsterClassId}'.");

			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out var map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			this.MapClassName = mapClassName;
			_maxCount = maxPopulation;
			_currentCount = 0;
		}

		/// <summary>
		/// Changes current population by a given amount. Clamps between 0 and MaxCount
		/// </summary>
		public void IncrementPopulation(int amount)
		{
			_currentCount = Math2.Clamp(0, _maxCount, _currentCount + amount);
		}

		/// <summary>
		/// Sets the current population to zero.
		/// </summary>
		public void InitializePopulation()
		{
			_currentCount = 0;
		}
	}
}
