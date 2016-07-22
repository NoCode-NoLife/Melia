using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;

namespace Melia.Shared.World.Shapes
{
	public class Circle : Shape
	{
		private float Radius { get; set;}

		public Circle(float r)
		{
			this.Radius = r;
		}

		override public bool IntersectWith(Shape other)
		{
			if (other.GetType() == typeof(Circle))
				return IntersectWithInternal((Circle)other);

			return false;
		}

		public bool IntersectWithInternal(Circle other)
		{
			var radius = this.Radius + other.Radius;
			var deltaX = this.Position.X - other.Position.X;
			var deltaY = this.Position.Z - other.Position.Z;
			return deltaX * deltaX + deltaY * deltaY <= radius * radius;
		}

	}
}
