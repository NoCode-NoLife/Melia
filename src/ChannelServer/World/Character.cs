using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class Character
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public Job Job { get; set; }
		public Gender Gender { get; set; }
		public byte Hair { get; set; }
		public int Level { get; set; }

		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }

		public int WorldId { get; set; }

		public int Stance
		{
			get
			{
				var cls = (short)this.Job / 1000;

				switch (cls)
				{
					case 1: return 10000; // Swordsman
					case 2: return 10006; // Wizard
					case 3: return 10008; // Archer
					case 4:
					case 9: return 10004; // Cleric
				}

				throw new Exception("Unknown job class.");
			}
		}

		public Character()
		{
			this.Level = 1;
			this.WorldId = 1337;
		}

		public float GetSpeed()
		{
			return 50;
		}

		public float GetJumpStrength()
		{
			return 300;
		}

		public int GetJumpType()
		{
			return 1;
		}
	}
}
