using System;
using Melia.Zone.World.Maps;
using Yggdrasil.Util;

namespace Melia.Zone.World
{
	/// <summary>
	/// This is an auxiliary class to MonsterSpawner. Each MonsterSpawner 
	/// should be associated to a population and cannot spawn more mobs
	/// than the max population limit.
	/// </summary>
	public class MonsterPopulation
	{
		private readonly Map _map;

		/// <summary>
		/// Current amount of monsters in this population
		/// </summary>
		private int _currentCount;

		/// <summary>
		/// Maximum amount of monsters that can be in this population
		/// </summary>
		public int _maxCount;

		/// <summary>
		/// Returns the class name of the map
		/// spawned on
		/// </summary>
		public string MapClassName { get; }

		/// <summary>
		/// Name of this population, used for identification purposes
		/// </summary>
		public string Name { get; }

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
		/// Creates new monster population. Current population will always be initialized at zero.
		/// </summary>
		/// <param name="maxPopulation">Maximum amount of monsters that can be in this population</param>
		public MonsterPopulation(string mapClassName, string name, int maxPopulation)
		{
			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out _map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			this.Name = name;
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
