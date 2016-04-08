using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	public class Actor : IVisitor
	{
		/// <summary>
		/// Creature for this actor
		/// </summary>
		public Character character;

		/// <summary>
		/// Maps associated
		/// </summary>
		public Map map;

		/// <summary>
		/// Flag indicating if this actor must be deleted.
		/// </summary>
		public bool ToDelete;

		/// <summary>
		/// Actor's position
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Move function
		/// </summary>
		public virtual bool Move(Position pos, Position newPos) { return true; }

		/// <summary>
		/// Return Actor radius
		/// </summary>
		public virtual float GetRadius()
		{
			return 0.0f;
		}

		/// <summary>
		/// Get distance between two points
		/// </summary>
		public float GetDistance(Position pos1, Position pos2)
		{
			float vX = pos1.X - pos2.X;
			float vZ = pos1.Z - pos2.Z;
			float len = (float) Math.Sqrt(vX * vX + vZ * vZ);
			return len;
		}

		/// <summary>
		/// Check if an actor is in rage to other actor
		/// </summary>
		public bool isNearObject(Actor actor, float range)
		{
			// Check if object is within range
			var distance = GetDistance(this.Position, actor.Position) - (GetRadius() - actor.GetRadius());

			if (distance <= range)
				return true;

			return false;
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
			var distance = GetDistance(pos, this.Position); // Change this function for a function not using Math.Sqrt()

			if (distance <= range)
				return true;

			return false;
		}

		/// <summary>
		/// Action that takes place when an actor interacts with other entity.
		/// </summary>
		public bool OnVisit(Actor actor)
		{
			return true;
		}
	}
}
