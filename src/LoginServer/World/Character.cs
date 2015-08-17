using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.World
{
	public class Character : Shared.World.Character
	{
		public byte Index { get; set; }

		public Character()
		{
			this.Level = 1;
		}
	}
}
