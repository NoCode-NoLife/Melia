using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Zone.World.Maps;

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
		/// Returns the class name of the map
		/// spawned on
		/// </summary>
		public string MapClassName { get; }

		/// <summary>
		/// Name of this population, used for identification purposes
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Current amount of monsters in this population
		/// </summary>
		public int CurrentCount { get; set; }

		/// <summary>
		/// Maximum amount of monsters that can be in this population
		/// </summary>
		public int MaxCount { get; set; }

		/// <summary>
		/// Creates new monster population. Current population will always be initialized at zero.
		/// </summary>
		/// <param name="maxPopulation">Maximum amount of monsters that can be in this population</param>
		public MonsterPopulation(string mapClassName, string name, int maxPopulation)
		{
			if (!ZoneServer.Instance.World.TryGetMap(mapClassName, out _map))
				throw new ArgumentException($"Map '{mapClassName}' not found.");

			this.CurrentCount = 0;
			this.Name = name;
			this.MapClassName = mapClassName;
			this.MaxCount = maxPopulation;
		}

		/// <summary>
		/// Returns Available population: MaxCount - CurrentCount
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public int AvailablePopulation()
		{
			return MaxCount - CurrentCount;
		}
	}
}
