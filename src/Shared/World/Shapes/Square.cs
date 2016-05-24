using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.World.Shapes
{
	public class Square : Shape
	{
		private float Width { get; set; }
		private float Height { get; set; }

		public Square(float w, float h)
		{
			this.Width = w;
			this.Height = h;
		}

		override public bool IntersectWith(Shape other)
		{
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
