// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

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
		/// <summary>
		/// Character's id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Character's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Character's team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Character's job.
		/// </summary>
		public Job Job { get; set; }

		/// <summary>
		/// Character's gender.
		/// </summary>
		public Gender Gender { get; set; }

		/// <summary>
		/// Character's hair style.
		/// </summary>
		public byte Hair { get; set; }

		/// <summary>
		/// Character's level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// The zone the character is in.
		/// </summary>
		public int ZoneId { get; set; }

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
		public float VectorX { get; set; }

		/// <summary>
		/// Direction vector.
		/// </summary>
		public float VectorY { get; set; }

		/// <summary>
		/// Gets or sets whether the character is moving.
		/// </summary>
		public bool IsMoving { get; set; }

		/// <summary>
		/// Current experience points.
		/// </summary>
		public int Exp { get; set; }

		/// <summary>
		/// Current maximum experience points.
		/// </summary>
		public int MaxExp { get; set; }

		/// <summary>
		/// Health points.
		/// </summary>
		public int Hp { get; set; }

		/// <summary>
		/// Maximum health points.
		/// </summary>
		public int MaxHp { get; set; }

		/// <summary>
		/// Health points.
		/// </summary>
		public int Sp { get; set; }

		/// <summary>
		/// Maximum health points.
		/// </summary>
		public int MaxSp { get; set; }

		/// <summary>
		/// Stamina points.
		/// </summary>
		public int Stamina { get; set; }

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
