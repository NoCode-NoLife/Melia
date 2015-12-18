// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Const;
using Melia.Shared.Network.Helpers;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.World
{
	public class Character : Shared.World.BaseCharacter, ICommander
	{
		/// <summary>
		/// Index of character in character list.
		/// </summary>
		public byte Index { get; set; }

		/// <summary>
		/// Ids of equipped items.
		/// </summary>
		public int[] Equipment { get; private set; }

		/// <summary>
		/// Character's position in barracks.
		/// </summary>
		public Position BarrackPosition { get; set; }

		/// <summary>
		/// Creates new character.
		/// </summary>
		public Character()
		{
			this.Level = 1;
			this.Equipment = Items.DefaultItems.ToArray();
		}

		/// <summary>
		/// Returns ids of equipped items.
		/// </summary>
		/// <returns></returns>
		public int[] GetEquipIds()
		{
			return this.Equipment;
		}
	}
}
