using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Zone.World.Maps;
using Yggdrasil.Geometry;

namespace Melia.Zone.World.Spawner
{
	public class MonsterSpawnPoint
	{
		// The map this spawn point is in
		public Map Map { get; set; }

		// The area of this spawn point
		public IShape Area { get; set; }

		/// <summary>
		/// Creates a new spawn point
		/// </summary>
		/// <param name="map"></param>
		/// <param name="area"></param>
		public MonsterSpawnPoint(Map map, IShape area)
		{
			this.Map = map;
			this.Area = area;
		}
	}
}
