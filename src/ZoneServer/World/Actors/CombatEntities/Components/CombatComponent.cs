using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Zone.Network;
using Yggdrasil.Logging;
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

		private readonly object _hitLock = new object();
		private readonly Dictionary<int, float> _damageTaken = new Dictionary<int, float>();
		private readonly Dictionary<int, int> _hitsTaken = new Dictionary<int, int>();

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

		/// <summary>
		/// Registers a hit from the given attacker.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="damage"></param>
		public void RegisterHit(ICombatEntity attacker, float damage)
		{
			lock (_hitLock)
			{
				if (!_damageTaken.TryGetValue(attacker.Handle, out var totalDamage))
					totalDamage = 0;

				if (!_hitsTaken.TryGetValue(attacker.Handle, out var totalHits))
					totalHits = 0;

				_damageTaken[attacker.Handle] = totalDamage + damage;
				_hitsTaken[attacker.Handle] = totalHits + 1;
			}
		}

		/// <summary>
		/// Returns the attacker that has dealt the most damage to this
		/// entity and is still nearby and alive.
		/// </summary>
		/// <returns></returns>
		public ICombatEntity GetTopAttackerByDamage()
		{
			lock (_hitLock)
			{
				foreach (var kv in _damageTaken.OrderByDescending(a => a.Value))
				{
					var handle = kv.Key;

					if (!this.Entity.Map.TryGetCombatEntity(handle, out var attacker))
						continue;

					if (attacker.IsDead)
						continue;

					return attacker;
				}
			}

			return null;
		}

		/// <summary>
		/// Returns the attacker that has hit this entity the most and
		/// is still nearby and alive.
		/// </summary>
		/// <returns></returns>
		public ICombatEntity GetTopAttackerByHits()
		{
			lock (_hitLock)
			{
				foreach (var kv in _hitsTaken.OrderByDescending(a => a.Value))
				{
					var handle = kv.Key;

					if (!this.Entity.Map.TryGetCombatEntity(handle, out var attacker))
						continue;

					if (attacker.IsDead)
						continue;

					return attacker;
				}
			}

			return null;
		}
	}
}
