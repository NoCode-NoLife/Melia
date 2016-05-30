using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	public class Weapon : Item, IEquipable
	{
		public Skill weaponSkill;

		private float MinPATK;
		private float MaxPATK;
		private float MinMATK;
		private float MaxMATK;

		public int Handle { get; }


		public Weapon(int itemId, int amount = 1) : base(itemId, amount)
		{
			this.Handle = ChannelServer.Instance.World.CreateHandle();

			this.MinPATK = 10f;
			this.MaxPATK = 12f;
			this.MinMATK = 0f;
			this.MaxMATK = 0f;
		}

		public void Load()
		{
			this.weaponSkill = ((IEntity)owner).skillManager.GetSkill(100);
		}

		public void OnEquip()
		{
			Log.Debug("OnEquip Called {0}", this.Id);
			var entityOwner = (IEntity)owner;
			entityOwner.statsManager.AddStatMod(this.Handle, Stat.MINPATK, StatModifierType.Addition, this.MinPATK);
			entityOwner.statsManager.AddStatMod(this.Handle, Stat.MAXPATK, StatModifierType.Addition, this.MaxPATK);
			entityOwner.statsManager.AddStatMod(this.Handle, Stat.MINMATK, StatModifierType.Addition, this.MinMATK);
			entityOwner.statsManager.AddStatMod(this.Handle, Stat.MAXMATK, StatModifierType.Addition, this.MaxMATK);
		}

		public void OnUnequip()
		{
			var entityOwner = (IEntity)owner;

			entityOwner.statsManager.RemoveStatMods(this.Handle);
		}

		public void Fire()
		{
			this.Load(); // TODO. This is not the place. Just for test purposes.
			if (weaponSkill != null)
				weaponSkill.Activate();
		}

	}
}
