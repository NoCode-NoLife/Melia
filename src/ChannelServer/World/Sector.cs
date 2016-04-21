using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	public class Sector
	{
		/// <summary>
		/// List of entities for this sector
		/// </summary>
		private List<Actor> entities;

		/// <summary>
		/// neighbor sectors
		/// </summary>
		private Sector[] neighbors;

		/// <summary>
		/// Index of this sector in the sectorManager
		/// </summary>
		public int index { get; set; }

		/// <summary>
		/// Initialize a sector
		/// </summary>
		public Sector()
		{
			entities = new List<Actor>();
			neighbors = new Sector[8];
		}

		/// <summary>
		/// Add an actor to this sector
		/// </summary>
		public bool Add(Actor entity)
		{
			lock (entities)
				entities.Add(entity);
			return true;
		}

		/// <summary>
		/// Removes an actor from this sector
		/// </summary>
		public bool Remove(Actor entity)
		{
			lock (entities)
				entities.Remove(entity);
			return true;
		}

		/// <summary>
		/// Link a sector to another sector, given a direction 
		/// </summary>
		public void LinkSector(SectorDirection direction, Sector sector)
		{
			if (sector == null)
				return;

			this.neighbors[(int)direction] = sector;
		}

		/// <summary>
		/// Performs a visit for a given visitor and range, to all reachable entities in this sector.
		/// </summary>
		public void VisitInternal(Position pos, IVisitor visitor, float range)
		{
			// Tell all entities about this visit
			lock (entities)
			{
				foreach (var entity in entities)
				{
					if (visitor == (IVisitor)entity)
						continue;

					if (entity == null)
						continue;

					if (entity.IsMyArea(pos, range) == false)
						continue;

					if (visitor.OnVisit(entity) == false)
						return;
				}
			}
		}

		/// <summary>
		/// Visits a given point+range in this sector and all neighbor sectors
		/// </summary>
		public void Visit(Position pos, IVisitor visitor, float range)
		{
			// Visit this sector
			VisitInternal(pos, visitor, range);
			// Visit all neighbors
			for (int i = 0; i < 8; i++)
			{
				if (this.neighbors[i] == null)
					continue;

				this.neighbors[i].VisitInternal(pos, visitor, range);
			}
		}
	}

	/// <summary>
	/// Sector directions
	/// </summary>
	public enum SectorDirection : int
	{
		SECTOR_N = 0,
		SECTOR_NE = 1,
		SECTOR_E = 2,
		SECTOR_SE = 3,
		SECTOR_S = 4,
		SECTOR_SW = 5,
		SECTOR_W = 6,
		SECTOR_NW = 7
	}
}
