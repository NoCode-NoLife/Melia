// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	public interface IBaseStat
	{
		int Hp { get; set; }
		int MaxHp { get; set; }
		int Sp { get; set; }
		int MaxSp { get; set; }
		int Stamina { get; set; }
		int MaxStamina { get; set; }
		int Shield { get; set; }
	}

	public class BaseStat : IBaseStat
	{
		private Character _character;

		/// <summary>
		/// Lock used for modifying HP.
		/// </summary>
		private object _hpLock = new object();

		/// <summary>
		/// Holds the order of successive changes in character HP.
		/// A higher value indicates the latest damage taken.
		/// </summary>
		/// TODO: I'm not sure when this gets rolled over;
		///   More investigation is needed.
		public int HpChangeCounter { get; private set; }

		/// <summary>
		/// Gets or set HP, clamped between 0 and MaxHp.
		/// </summary>
		public int Hp
		{
			get { return _hp; }
			set { _hp = Math2.Clamp(0, this.MaxHp, value); }
		}
		private int _hp;

		/// <summary>
		/// Maximum HP.
		/// </summary>
		public int MaxHp { get; set; }

		/// <summary>
		/// Gets or sets SP, clamped between 0 and MaxSp.
		/// </summary>
		public int Sp
		{
			get { return _sp; }
			set { _sp = Math2.Clamp(0, this.MaxSp, value); }
		}
		private int _sp;

		/// <summary>
		/// Maximum SP.
		/// </summary>
		public int MaxSp { get; set; }

		/// <summary>
		/// Gets or set Stamina, clamped between 0 and MaxStamina.
		/// </summary>
		public int Stamina
		{
			get { return _stamina; }
			set { _stamina = Math2.Clamp(0, this.MaxStamina, value); }
		}
		private int _stamina;

		/// <summary>
		/// Maximum stamina.
		/// </summary>
		public int MaxStamina { get; set; }

		/// <summary>
		/// Shield value.
		/// </summary>
		public int Shield { get; set; } = 0;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="character"></param>
		public BaseStat(Character character)
		{
			//TODO: This class may be applicable to entities, but that needs to be verified.

			_character = character;
		}

		/// <summary>
		/// Modifies character's HP by the given amount and updates the
		/// client with ZC_ADD_HP.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyHp(int amount)
		{
			int hp, priority;
			var negative = (amount < 0);

			// Make sure it's not possible for two calls to interfere
			// with each other, so that the correct amount makes it to
			// the client, with the correct priority.
			lock (_hpLock)
			{
				hp = (this.Hp += amount);
				priority = (this.HpChangeCounter += 1);
			}

			Send.ZC_ADD_HP(_character, amount, negative, hp, priority);
		}
	}
}


