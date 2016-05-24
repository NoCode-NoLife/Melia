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
		public Shape CollisionShape { get; set; }
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
		private Position _position;
		public Position Position { get { return _position;  }
			set {
				_position = value;
				if (CollisionShape != null)
					CollisionShape.Position = value;
			}
		}

		/// <summary>
		/// Actor's Direction
		/// </summary>
		private Direction _direction;
		public Direction Direction { get { return _direction; }
			set {
				_direction = value;
				if (CollisionShape != null)
					CollisionShape.Direction = value;
			}
		}

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
