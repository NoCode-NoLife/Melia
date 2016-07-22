using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	public class SectorManager
	{
		/// <summary>
		/// Sectors for this sector manager
		/// </summary>
		private Sector[] sectors;

		/// <summary>
		/// Amount of "units" in width.
		/// IMPORTANT: This is not the max Position in X, but the max amount of units. The length of the map in X direction.
		/// </summary>
		private int width;

		/// <summary>
		/// Amount of "units" in height.
		/// IMPORTANT: This is not the max Position in Z, but the max amount of units. The length of the map in Z direction.
		/// </summary>
		private int height;

		/// <summary>
		/// Base coordinate in X
		/// Eg. If a map starts in x:-2000,y:-1000, baseX = -2000
		/// </summary>
		private int baseX;

		/// <summary>
		/// Base coordinate in Y (actually Z in Position)
		/// Eg. If a map starts in x:-2000,y:-1000, baseY = -1000
		/// </summary>
		private int baseY;

		/// <summary>
		/// Count of sectors
		/// </summary>
		private int count;

		/// <summary>
		/// Map that owns this sector manager
		/// </summary>
		private Map owner;

		/// <summary>
		/// Size of every sector (in position units)
		/// It will be used to divide the map into sectors.
		/// </summary>
		private const int SECTOR_SIZE = 100;

		/// <summary>
		/// Initializes a Sector Manager
		/// </summary>
		public bool Init(Map mapOwner, int width, int height, int baseX, int baseY)
		{
			//Log.Info("SectorManager Initializing: w:{0} h:{1}, bX: {2}, bY: {3}", width, height, baseX, baseY);

			// Set map owner
			this.owner = mapOwner;

			// Set base
			this.baseX = baseX;
			this.baseY = baseY;

			// Set sector manager width and height
			this.width = (width + SECTOR_SIZE - 1) / SECTOR_SIZE;
			this.height = (height + SECTOR_SIZE - 1) / SECTOR_SIZE;

			if (this.width < 0)
			{
				// Error
				Log.Error("SectorManager not initialized for map {0}, width is not valid.", mapOwner.Id);
				return false;
			}

			if (this.height < 0)
			{
				// Error
				Log.Error("SectorManager not initialized for map {0}, height is not valid.", mapOwner.Id);
				return false;
			}

			// Set count of sectors
			this.count = this.width * this.height;

			//Log.Info("SectorManager: Sectors: w:{0} h:{1}, c: {2}", this.width, this.height, this.count);

			// Create sectors
			sectors = new Sector[this.count];
			for (int i = 0; i < this.count; i++)
			{
				sectors[i] = new Sector();
				// Set index for this sector
				sectors[i].index = i;
			}
				

			// Link every sector with all surrounding sectors.
			for (int i = 0; i < this.count; i++)
			{
				sectors[i].LinkSector(SectorDirection.SECTOR_N, GetSector(i, -1, -1));
				sectors[i].LinkSector(SectorDirection.SECTOR_N, GetSector(i, 0, -1));
				sectors[i].LinkSector(SectorDirection.SECTOR_NE, GetSector(i, 1, -1));
				sectors[i].LinkSector(SectorDirection.SECTOR_W, GetSector(i, -1, 0));
				sectors[i].LinkSector(SectorDirection.SECTOR_E, GetSector(i, 1, 0));	
				sectors[i].LinkSector(SectorDirection.SECTOR_SW, GetSector(i, -1, 1));
				sectors[i].LinkSector(SectorDirection.SECTOR_S, GetSector(i, 0, 1));
				sectors[i].LinkSector(SectorDirection.SECTOR_SE, GetSector(i, 1, 1));
			}

			return true;
		}

		/// <summary>
		/// Get a sector given a specific index and an orientation (dx,dy)
		/// This function is used to get neighbor sectors
		/// </summary>
		public Sector GetSector(int index, int dx, int dy)
		{
			int y = index / this.width;
			int x = index % this.width;

			y += dy;
			x += dx;

			if (y >= 0 && y < this.height)
				if (x >= 0 && x < this.width)
					return this.sectors[x + y * this.width];

			return null;
		}

		/// <summary>
		/// Get a sector given a World Position
		/// </summary>
		public Sector GetSector(Position pos) 
		{
			int x = ((int) pos.X - this.baseX) / SECTOR_SIZE;
			int y = ((int) pos.Z - this.baseY) / SECTOR_SIZE;

			// Check this coordinate is inside boundaries
			if (!(0 <= y && y < this.height))
				return null;
			if (!(0 <= x && x < this.width))
				return null;

			return this.sectors[y * this.width + x];

		}

		/// <summary>
		/// Adds an actor in a given position to the Sector Manager
		/// </summary>
		public bool Add(Actor actor, Position pos) {

			// Check if position is valid in this map
			/// TODO
			/// 

			// Updates Actor Position
			actor.Position = pos;

			// Get sector for this position
			Sector sector = GetSector(pos);
			if (sector == null)
				return false;

			// Add actor to this sector
			return sector.Add(actor);

		}

		/// <summary>
		/// Removes an Actor from Sector Manager
		/// </summary>
		public bool Remove(Actor actor)
		{
			// Check if entity has a valid position
			/// TODO
			/// 

			// Get the sector for this actor's position
			Sector sector = GetSector(actor.Position);
			if (sector == null)
				return false;

			// Remove actor
			return sector.Remove(actor);
		}

		/// <summary>
		/// Moves an actor given a position
		/// </summary>
		public bool Move(Actor actor, Position newPos)
		{
			// Get actor's current position
			var currentPos = actor.Position;

			// Check if positions are valid
			/// TODO
			/// 

			// Get the sector of Actor's current position
			Sector currentSector = GetSector(currentPos);
			if (currentSector == null)
			{
				// Error
				return false;
			}

			// Get the sector for the Actor's new position (or desired position)
			Sector newSector = GetSector(newPos);
			if (newSector == null)
			{
				// Error
				return false;
			}

			// Check if we need to change the actor from CURRENT SECTOR to NEW SECTOR
			if (newSector != currentSector)
			{
				// Remove actor from Current Sector
				if (currentSector.Remove(actor) == false)
					return false;

				// Add actor to the new Sector
				if (newSector.Add(actor) == false)
					return false;

			}

			// Update's actor position with the new position
			actor.Position = newPos;
			return true;
		}

		/// <summary>
		/// Visit a given position with a Visitor, given a range
		/// 'Visit' can be seen as 'interact with'
		/// The actor visits the sector (and all surrounding sectors) trying to interact with other actors.
		/// </summary>
		public void Visit(Position pos, IVisitor visitor, float range)
		{
			Sector sector = GetSector(pos);
			if (sector == null)
				return;

			sector.Visit(pos, visitor, range);
		}

		public List<Actor> GetActorsAtRange(Position pos, float range)
		{
			Sector sector = GetSector(pos);
			if (sector == null)
				return null;

			return sector.GetActorsAtRange(pos, range);
		}
	}
}
