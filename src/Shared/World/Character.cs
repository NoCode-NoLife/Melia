using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.World
{
	public abstract class Character
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

		/// <summary>
		/// Returns stance, based on job and other factors.
		/// </summary>
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
	}
}
