// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

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
		public Connection Connection { get; set; }

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
		/// Creates new character.
		/// </summary>
		public Character()
		{
			this.Level = 1;
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
