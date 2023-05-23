using System;
using Melia.Shared.Tos.Const;
using Yggdrasil.Composition;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// Recovery component, restores an entity's HP, SP, and Stamina
	/// over time.
	/// </summary>
	public class Recovery : CombatEntityComponent, IUpdatableComponent
	{
		private TimeSpan _rhpTime;
		private TimeSpan _rspTime;

		/// <summary>
		/// Creates new component.
		/// </summary>
		/// <param name="entity"></param>
		public Recovery(ICombatEntity entity) : base(entity)
		{
		}

		/// <summary>
		/// Updates the entity's stats.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			_rhpTime -= elapsed;
			_rspTime -= elapsed;

			if (_rhpTime <= TimeSpan.Zero)
			{
				this.RecoverHp();
				_rhpTime = TimeSpan.FromMilliseconds(this.Entity.Properties.GetFloat(PropertyName.RHPTIME));
			}

			if (_rspTime <= TimeSpan.Zero)
			{
				this.RecoverSp();
				_rspTime = TimeSpan.FromMilliseconds(this.Entity.Properties.GetFloat(PropertyName.RSPTIME));
			}
		}

		/// <summary>
		/// Recovers some HP.
		/// </summary>
		private void RecoverHp()
		{
			var cur = this.Entity.Properties.GetFloat(PropertyName.HP);
			var max = this.Entity.Properties.GetFloat(PropertyName.MHP);
			var rec = this.Entity.Properties.GetFloat(PropertyName.RHP);

			if (rec > 0 && cur < max)
				this.Entity.Heal(rec, 0);
		}

		/// <summary>
		/// Recovers some SP.
		/// </summary>
		private void RecoverSp()
		{
			var cur = this.Entity.Properties.GetFloat(PropertyName.SP);
			var max = this.Entity.Properties.GetFloat(PropertyName.MSP);
			var rec = this.Entity.Properties.GetFloat(PropertyName.RSP);

			if (rec > 0 && cur < max)
				this.Entity.Heal(0, rec);
		}
	}
}
