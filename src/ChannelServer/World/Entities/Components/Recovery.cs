using System;
using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.EntityComponents;

namespace Melia.Channel.World.Entities.Components
{
	/// <summary>
	/// Recovery component, restores an entity's HP, SP, and Stamina
	/// over time.
	/// </summary>
	public class Recovery : IUpdatableComponent
	{
		private TimeSpan _rhpTime;
		private TimeSpan _shpTime;

		/// <summary>
		/// Returns the owner of this component.
		/// </summary>
		public ICombatEntity Entity { get; }

		/// <summary>
		/// Creates new component.
		/// </summary>
		/// <param name="entity"></param>
		public Recovery(ICombatEntity entity)
		{
			this.Entity = entity;
		}

		/// <summary>
		/// Updates the entity's stats.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			_rhpTime -= elapsed;
			_shpTime -= elapsed;

			if (_rhpTime <= TimeSpan.Zero)
			{
				this.RecoverHp();
				_rhpTime = TimeSpan.FromMilliseconds(this.Entity.Properties.GetFloat(PropertyId.PC.RHPTIME));
			}

			if (_shpTime <= TimeSpan.Zero)
			{
				this.RecoverSp();
				_shpTime = TimeSpan.FromMilliseconds(this.Entity.Properties.GetFloat(PropertyId.PC.RHPTIME));
			}
		}

		/// <summary>
		/// Recovers some HP.
		/// </summary>
		private void RecoverHp()
		{
			var cur = this.Entity.Properties.GetFloat(PropertyId.PC.HP);
			var max = this.Entity.Properties.GetFloat(PropertyId.PC.MHP);
			var rec = this.Entity.Properties.GetFloat(PropertyId.PC.RHP);

			if (rec > 0 && cur < max)
				this.Entity.Heal(rec, 0);
		}

		/// <summary>
		/// Recovers some SP.
		/// </summary>
		private void RecoverSp()
		{
			var cur = this.Entity.Properties.GetFloat(PropertyId.PC.SP);
			var max = this.Entity.Properties.GetFloat(PropertyId.PC.MSP);
			var rec = this.Entity.Properties.GetFloat(PropertyId.PC.RSP);

			if (rec > 0 && cur < max)
				this.Entity.Heal(0, rec);
		}
	}
}
