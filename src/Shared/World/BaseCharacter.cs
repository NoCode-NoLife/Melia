﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.World
{
	public abstract class BaseCharacter
	{
		/// <summary>
		/// Character's id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Id of the character's account.
		/// </summary>
		public long AccountId { get; set; }

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
		/// The map the character is in.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// Character's position.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Character's direction.
		/// </summary>
		public Direction Direction { get; set; }

		/// <summary>
		/// Character's head's direction.
		/// </summary>
		public Direction HeadDirection { get; set; }

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
		/// Spell points.
		/// </summary>
		public int Sp { get; set; }

		/// <summary>
		/// Maximum spell points.
		/// </summary>
		public int MaxSp { get; set; }

		/// <summary>
		/// Stamina points.
		/// </summary>
		public int Stamina { get; set; }

		/// <summary>
		/// Maximum stamina points.
		/// </summary>
		public int MaxStamina { get; set; }

		/// <summary>
		/// Gets or sets character's strength (STR).
		/// </summary>
		public float Str { get; set; }

		/// <summary>
		/// Gets or sets character's vitality (CON).
		/// </summary>
		public float Con { get; set; }

		/// <summary>
		/// Gets or sets character's intelligence (INT).
		/// </summary>
		public float Int { get; set; }

		/// <summary>
		/// Gets or sets character's spirit (SPR/MNA).
		/// </summary>
		public float Spr { get; set; }

		/// <summary>
		/// Gets or sets character's agility (DEX).
		/// </summary>
		public float Dex { get; set; }

		/// <summary>
		/// Returns stance, based on job and other factors.
		/// </summary>
		public int Stance
		{
			get
			{
				var cls = this.Job.ToClass();

				// The stance is affected by the equipped items, we might
				// have to move this to a place where we have proper access
				// to the character's items, and we need item types.
				// Maybe we can use ItemData on Login, so we don't need
				// another Item class.
				// For the official conditions see stancecondition.ies.

				switch (cls)
				{
					default:
					case Class.Swordsman:
						return 10000;

					case Class.Wizard:
						return 10006;

					case Class.Archer:
						return 10008;

					case Class.Cleric:
					case Class.GM:
						return 10004;
				}
			}
		}

		/// <summary>
		/// Sets character's position.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public void SetPosition(float x, float y, float z)
		{
			this.Position = new Position(x, y, z);
		}

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void SetDirection(float x, float y)
		{
			this.Direction = new Direction(x, y);
		}

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void SetHeadDirection(float x, float y)
		{
			this.HeadDirection = new Direction(x, y);
		}
	}
}
