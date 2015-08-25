using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class Monster
	{
		/// <summary>
		/// Index in world collection?
		/// </summary>
		public int Handle { get; set; }

		/// <summary>
		/// Dirty temp hack for unique handles
		/// </summary>
		public static int HandleCounter = 0xF0000;

		/// <summary>
		/// Monster ID in database.
		/// </summary>
		public int ClassID;

		/// <summary>
		/// Monsters's level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// X position.
		/// </summary>
		public float X { get; set; }

		/// <summary>
		/// Y position.
		/// </summary>
		public float Y { get; set; }

		/// <summary>
		/// Z position.
		/// </summary>
		public float Z { get; set; }

		/// <summary>
		/// Direction vector.
		/// </summary>
		public float vectorX { get; set; }

		/// <summary>
		/// Direction vector.
		/// </summary>
		public float vectorY { get; set; }

		/// <summary>
		/// AoE Defense Ratio
		/// </summary>
		public int SDR { get; set; }

		/// <summary>
		/// Maximum health points.
		/// </summary>
		public int MaxHp { get; set; }



		/// <summary>
		/// Creates new monster.
		/// </summary>
		public Monster(int classID)
		{
			this.Handle = HandleCounter++;
			this.ClassID = classID;
			this.Level = 1;
			this.SDR = 1;
			this.MaxHp = 100;
		}

	}
}
