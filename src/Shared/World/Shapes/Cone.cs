using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.World.Shapes
{
	public class Cone : Shape
	{
		private float Angle { get; set; }
		private float Lenght { get; set; }

		public Cone(float a, float l)
		{
			this.Angle = a;
			this.Lenght = l;
		}

		override public bool IntersectWith(Shape other)
		{
			return false;
		}

		public bool IntersectWith(Cone other)
		{
			/// TODO
			return false;
		}

		public bool IntersectWith(Circle other)
		{
			/// TODO
			return false;
		}

		public bool IntersectWith(Square other)
		{
			/// TODO
			return false;
		}
	}
}
