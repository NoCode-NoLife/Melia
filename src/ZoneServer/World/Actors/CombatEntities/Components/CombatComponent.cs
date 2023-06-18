using System;
using Melia.Zone.Network;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// An entity component that encapsulates combat-related methods
	/// and properties.
	/// </summary>
	public class CombatComponent : CombatEntityComponent, IUpdateable
	{
		private static readonly TimeSpan AttackStateDuration = TimeSpan.FromSeconds(10);

		/// <summary>
		/// Returns the entity's attack state.
		/// </summary>
		public bool AttackState { get; private set; }

		/// <summary>
		/// Returns the last time the entity was involved in combat in
		/// any way.
		/// </summary>
		public DateTime LastCombatTime { get; private set; }

		/// <summary>
		/// Creates new component for entity.
		/// </summary>
		/// <param name="entity"></param>
		public CombatComponent(ICombatEntity entity) : base(entity)
		{
		}

		/// <summary>
		/// Sets the entity's attack state.
		/// </summary>
		/// <param name="state"></param>
		public void SetAttackState(bool inAttackState)
		{
			this.AttackState = inAttackState;
			this.LastCombatTime = DateTime.Now;

			Send.ZC_PC_ATKSTATE(this.Entity, inAttackState);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="elapsed"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void Update(TimeSpan elapsed)
		{
			this.UpdateAttackState();
		}

		/// <summary>
		/// Updates the entity's attack state.
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		private void UpdateAttackState()
		{
			if (!this.AttackState)
				return;

			var timePassed = DateTime.Now - this.LastCombatTime;
			if (timePassed > AttackStateDuration)
				this.SetAttackState(false);
		}
	}
}
