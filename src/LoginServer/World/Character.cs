// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Collections.Generic;
using System.Linq;
using Melia.Login.Network.Helpers;
using Melia.Shared.Const;
using Melia.Shared.World;

namespace Melia.Login.World
{
	public class Character : IBarrackPc
	{
		/// <summary>
		/// Character's unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Id of the character's account.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Index of character in character list.
		/// </summary>
		public byte Index { get; set; }

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
		public JobId Job { get; set; }

		/// <summary>
		/// Character's gender.
		/// </summary>
		public Gender Gender { get; set; }

		/// <summary>
		/// Character's hair style.
		/// </summary>
		public byte Hair { get; set; }

		/// <summary>
		/// Ids of equipped items.
		/// </summary>
		public int[] Equipment { get; private set; }

		/// <summary>
		/// Specifies which hats are visible on the character.
		/// </summary>
		public HatVisibleStates VisibleHats { get { return HatVisibleStates.Hat1 | HatVisibleStates.Hat2 | HatVisibleStates.Hat3; } }

		/// <summary>
		/// Character's level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Layer in the barrack that the character should appear in.
		/// </summary>
		public int BarrackLayer { get; set; }

		/// <summary>
		/// Character's position in barracks.
		/// </summary>
		public Position BarrackPosition { get; set; }

		/// <summary>
		/// The channel the character is currently on.
		/// </summary>
		public int Channel { get; set; }

		/// <summary>
		/// The map the character is in.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// Character's current position.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Returns stance, based on job and other factors.
		/// </summary>
		/// <remarks>
		/// The stance is affected by the equipped items and other factors.
		/// For the official conditions see stancecondition.ies.
		/// </remarks>
		public int Stance
		{
			get
			{
				switch (this.Job.ToClass())
				{
					default:
					case Class.Swordsman: return 10000;
					case Class.Wizard: return 10006;
					case Class.Archer: return 10008;
					case Class.Cleric:
					case Class.GM: return 10004;
				}
			}
		}

		/// <summary>
		/// Current HP.
		/// </summary>
		public int Hp { get; set; }

		/// <summary>
		/// Maximum HP.
		/// </summary>
		public int MaxHp { get; set; }

		/// <summary>
		/// Current SP.
		/// </summary>
		public int Sp { get; set; }

		/// <summary>
		/// Maximum SP.
		/// </summary>
		public int MaxSp { get; set; }

		/// <summary>
		/// Current stamina.
		/// </summary>
		public int Stamina { get; set; }

		/// <summary>
		/// Maximum stamina.
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
		/// Creates new character.
		/// </summary>
		public Character()
		{
			this.Level = 1;
			this.Channel = 1;
			this.BarrackLayer = 1;
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

		/// <summary>
		/// Returns the equipment properties as an array.
		/// </summary>
		/// <returns></returns>
		public int[] GetEquipmentProperties()
		{
			// TODO: This needs to return the actual properties of equipment which have variable lengths.
			return this.GetEquipIds();
		}

		/// <summary>
		/// Sets the equipment for a character.
		/// </summary>
		/// <returns></returns>
		public void SetEquipment(IDictionary<EquipSlot, int> equipment)
		{
			foreach (var item in equipment)
				this.Equipment[(int)item.Key] = item.Value;
		}
	}
}
