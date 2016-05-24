using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Shared.World.Shapes;

namespace Melia.Shared.World
{
	public abstract class Shape
	{
		public Position Position { get; set; }
		public Direction Direction { get; set; }
		public abstract bool IntersectWith(Shape otherShape);
	}
}
