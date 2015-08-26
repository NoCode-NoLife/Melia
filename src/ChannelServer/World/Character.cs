// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class Character : Shared.World.Character
	{
		/// <summary>
		/// Connection this character uses.
		/// </summary>
		public ChannelConnection Connection { get; set; }

		/// <summary>
		/// Index in world collection?
		/// </summary>
		public int WorldId { get; set; }

		/// <summary>
		/// Gets or sets whether the character is sitting.
		/// </summary>
		public bool IsSitting { get; set; }

		/// <summary>
		/// Gets or sets whether the character is standing on the ground.
		/// </summary>
		public bool IsGrounded { get; set; }

		/// <summary>
		/// The character's inventory.
		/// </summary>
		public Inventory Inventory { get; protected set; }

		/// <summary>
		/// Gets or sets character's strength (STR).
		/// </summary>
		public float Strength { get; set; }

		/// <summary>
		/// Gets or sets character's vitality (CON).
		/// </summary>
		public float Vitality { get; set; }

		/// <summary>
		/// Gets or sets character's intelligence (INT).
		/// </summary>
		public float Intelligence { get; set; }

		/// <summary>
		/// Gets or sets character's spirit (SPR/MNA).
		/// </summary>
		public float Spirit { get; set; }

		/// <summary>
		/// Gets or sets character's agility (DEX).
		/// </summary>
		public float Agility { get; set; }

		/// <summary>
		/// Returns combined weight of all items the character is currently carrying.
		/// </summary>
		public float NowWeight { get { return this.Inventory.GetNowWeight(); } }

		/// <summary>
		/// Returns maximum weight the character can carry.
		/// </summary>
		public float MaxWeight { get { return 200; } }

		/// <summary>
		/// Returns ratio between NowWeight and MaxWeight.
		/// </summary>
		public float WeightRatio { get { return 100f / this.MaxWeight * this.NowWeight; } }

		/// <summary>
		/// Creates new character.
		/// </summary>
		public Character()
		{
			this.Level = 1;
			this.Strength = 1;
			this.Vitality = 1;
			this.Intelligence = 1;
			this.Spirit = 1;
			this.Agility = 1;
			this.WorldId = 1337;
			this.Inventory = new Inventory(this);
		}

		/// <summary>
		/// Returns character's current speed.
		/// </summary>
		/// <returns></returns>
		public float GetSpeed()
		{
			return 50;
		}

		/// <summary>
		/// Returns character's current jump strength.
		/// </summary>
		/// <returns></returns>
		public float GetJumpStrength()
		{
			return 300;
		}

		/// <summary>
		/// Returns character's jump type.
		/// </summary>
		/// <returns></returns>
		public int GetJumpType()
		{
			return 1;
		}
	}
}
