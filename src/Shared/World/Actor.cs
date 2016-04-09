using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;

namespace Melia.Shared.World
{
	public class Actor
	{
		/// <summary>
		/// Actor's Handle
		/// </summary>
		public int Handle {	get; set; }

		/// <summary>
		/// Flag indicating if this actor must be destroyed
		/// </summary>
		public bool ToDestroy;

		/// <summary>
		/// Flag indicating if this actor must be destroyed
		/// </summary>
		public bool Destroyed;

		/// <summary>
		/// Actor's position
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Actor's Direction
		/// </summary>
		public Direction Direction { get; set; }

		/// <summary>
		/// Actor's Radious
		/// </summary>
		public float Radius { get; set; }

		/*
		/// <summary>
		/// Move function
		/// </summary>
		public virtual bool Move(Position pos, Position newPos) { return true; }
		*/

		/// <summary>
		/// Check if an actor is in rage to other actor
		/// </summary>
		public bool isNearObject(Actor actor, float range)
		{
			// Check if object is within range
			return this.Position.InRange2D(actor.Position, (int)range + (int) this.Radius - (int) actor.Radius);
		}

		/// <summary>
		/// Check if an actor is close enough (to a given range) for another actor. 
		/// This function doesn't take in count Radius. 
		/// </summary>
		public bool IsMyArea(Position pos, float range)
		{
			// THIS RANGE CHECK must be FAST. 
			// It is used to concider if an actor is close enough to other, to make further checks for collision (isNearObject)

			// Check if object is within range
			return this.Position.InRange2D(pos, (int)range); // Change this function for a function not using Math.Sqrt()
			
		}

	}
}
