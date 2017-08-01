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
		/// Initializes equipment for first time creation.
		/// </summary>
		public void InitEquipment()
		{
			// TODO: This belongs in a constructor (complicated with data persistence).
			switch (this.Job)
			{
				case Job.Archer:
					this.Equipment[(int)EquipSlot.LeftHand] = 161101;
					this.Equipment[(int)EquipSlot.RightHand] = 161101;
					break;
				case Job.Swordsman:
					this.Equipment[(int)EquipSlot.LeftHand] = 101101;
					break;
				case Job.Cleric:
					this.Equipment[(int)EquipSlot.LeftHand] = 201101;
					break;
				case Job.Wizard:
					this.Equipment[(int)EquipSlot.LeftHand] = 141101;
					break;
				default:
					throw new ArgumentException(string.Format("The job type '{0}' is not valid for this method.", this.Job));
			}

			this.Equipment[(int)EquipSlot.Pants] = 521101;
			this.Equipment[(int)EquipSlot.Top] = 531101;
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
