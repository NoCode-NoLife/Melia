﻿using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Composition;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.Components
{
	/// <summary>
	/// A state and lock management component for actors.
	/// </summary>
	/// <remarks>
	/// The state lock component combines the concepts of setting locks,
	/// to prevent actors from taking certain actions, with the ability
	/// to register states that apply their associated locks automatically,
	/// simplifying the process of applying series' of lock combinations.
	/// 
	/// Both locks and states can be set freely, allowing sources such as
	/// buffs to quickly disable an actor's ability to move for example.
	/// Both also stack, making it easy to extend a timed lock or state
	/// by simply applying it again. For non-timed ones, this means you
	/// have to unlock or remove the lock or state as many times as you
	/// added it.
	/// </remarks>
	public class StateLockComponent : IComponent, IUpdateable
	{
		private readonly object _syncLock = new();

		private readonly Dictionary<string, State> _states = new();

		private readonly List<LockEnd> _lockEnds = new();
		private readonly Dictionary<string, int> _lockCounts = new();
		private readonly List<LockEnd> _stateEnds = new();
		private readonly Dictionary<string, int> _stateCounts = new();

		/// <summary>
		/// Returns the owner of the component.
		/// </summary>
		public IActor Owner { get; }

		/// <summary>
		/// Creates a new instance for the actor.
		/// </summary>
		public StateLockComponent(IActor owner)
		{
			this.Owner = owner;

			this.RegisterState(new(StateType.Stunned, [LockType.Movement, LockType.Attack]));
			this.RegisterState(new(StateType.KnockedBack, [LockType.Movement, LockType.Attack]));
			this.RegisterState(new(StateType.KnockedDown, [LockType.Movement, LockType.Attack]));
			this.RegisterState(new(StateType.Held, [LockType.Movement]));
		}

		/// <summary>
		/// Clears all locks and states.
		/// </summary>
		public void Clear()
		{
			lock (_syncLock)
			{
				_lockCounts.Clear();
				_lockEnds.Clear();

				_stateCounts.Clear();
				_stateEnds.Clear();
			}
		}

		/// <summary>
		/// Returns true if the a lock of the given type is active.
		/// </summary>
		/// <remarks>
		/// If a certain action is locked, the actor should not be able to
		/// perform it and have it performed on them.
		/// </remarks>
		/// <param name="lockType"></param>
		/// <returns></returns>
		public bool IsLocked(string lockType)
		{
			lock (_syncLock)
				return _lockCounts.ContainsKey(lockType);
		}

		/// <summary>
		/// Adds an indefinite lock for the given type.
		/// </summary>
		/// <remarks>
		/// Indefinite locks must be released manually.
		/// </remarks>
		/// <param name="lockType"></param>
		public void Lock(string lockType)
			=> this.Lock(lockType, TimeSpan.MaxValue);

		/// <summary>
		/// Adds a lock for the given type that will be released automatically
		/// after the given amount of time.
		/// </summary>
		/// <param name="lockType"></param>
		/// <param name="duration"></param>
		public void Lock(string lockType, TimeSpan duration)
		{
			lock (_syncLock)
			{
				if (_lockCounts.TryGetValue(lockType, out var value))
					_lockCounts[lockType] = ++value;
				else
					_lockCounts[lockType] = 1;

				if (duration != TimeSpan.MaxValue)
				{
					var endTime = DateTime.Now.Add(duration);
					_lockEnds.Add(new(lockType, endTime));
				}
			}

			if (lockType == LockType.Movement && this.Owner is ICombatEntity entity)
			{
				if (entity.Components.TryGet<MovementComponent>(out var movement))
					movement.Stop();

				entity.Properties.Invalidate(PropertyName.MSPD);
			}
		}

		/// <summary>
		/// Releases a lock of the given type.
		/// </summary>
		/// <remarks>
		/// Locks are stacked, meaning they must all be released for a certain
		/// action to get unlocked again.
		/// </remarks>
		/// <param name="lockType"></param>
		public void Unlock(string lockType)
		{
			lock (_syncLock)
			{
				if (!_lockCounts.TryGetValue(lockType, out var value))
					return;

				_lockCounts[lockType] = --value;

				if (_lockCounts[lockType] <= 0)
					_lockCounts.Remove(lockType);
			}

			if (lockType == LockType.Movement && this.Owner is ICombatEntity entity)
			{
				if (entity.Components.TryGet<MovementComponent>(out var movement))
					movement.Stop();

				entity.Properties.Invalidate(PropertyName.MSPD);
			}
		}

		/// <summary>
		/// Registers a new state, which represents a set of locks the will
		/// be set when the state is activated.
		/// </summary>
		/// <param name="state"></param>
		public void RegisterState(State state)
		{
			lock (_syncLock)
				_states[state.Type] = state;
		}

		/// <summary>
		/// Returns true if the given state is active.
		/// </summary>
		/// <param name="stateType"></param>
		/// <returns></returns>
		public bool IsStateActive(string stateType)
		{
			lock (_syncLock)
				return _stateCounts.ContainsKey(stateType);
		}

		/// <summary>
		/// Adds a state of the given type, locking the associated actions.
		/// </summary>
		/// <remarks>
		/// States simplify the application of set collections of locks, and they
		/// stack in the same way. This means if you apply a certain state twice,
		/// you also need to remove it twice to unlock the associated actions fully.
		/// </remarks>
		/// <param name="stateType"></param>
		public void AddState(string stateType)
			=> this.AddState(stateType, TimeSpan.MaxValue);

		/// <summary>
		/// Adds a state of the given type, locking the associated actions
		/// for the given duration.
		/// </summary>
		/// <param name="stateType"></param>
		/// <param name="duration"></param>
		/// <exception cref="ArgumentException"></exception>
		public void AddState(string stateType, TimeSpan duration)
		{
			// Technically we could do away with tracking states, now that they're
			// mostly glorified lock lists. We could just get the locks to apply
			// on add and remove. But we'll leave it like this for now, in case
			// we need to be able to tell whether a specific state is active.

			lock (_syncLock)
			{
				if (!_states.TryGetValue(stateType, out var state))
					throw new ArgumentException($"Unknown state '{stateType}'.");

				foreach (var lockType in state.Locks)
					this.Lock(lockType);

				if (_stateCounts.TryGetValue(stateType, out var value))
					_stateCounts[stateType] = ++value;
				else
					_stateCounts[stateType] = 1;

				if (duration != TimeSpan.MaxValue)
				{
					var endTime = DateTime.Now.Add(duration);
					_stateEnds.Add(new(stateType, endTime));
				}
			}
		}

		/// <summary>
		/// Unlocks one set of the locks associated with the given state.
		/// </summary>
		/// <param name="stateType"></param>
		/// <exception cref="ArgumentException"></exception>
		public void RemoveState(string stateType)
		{
			lock (_syncLock)
			{
				if (!_states.TryGetValue(stateType, out var state))
					throw new ArgumentException($"Unknown state '{stateType}'.");

				if (!_stateCounts.TryGetValue(stateType, out var value))
					return;

				_stateCounts[stateType] = --value;

				if (_stateCounts[stateType] <= 0)
					_stateCounts.Remove(stateType);

				foreach (var lockType in state.Locks)
					this.Unlock(lockType);
			}
		}

		/// <summary>
		/// Updates the component, transitioning states and releasing locks.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			var now = DateTime.Now;

			if (this.Owner.Map.ClassName.StartsWith("c_high") && this.Owner is Mob mob && mob.Id == 400001)
			{
				Log.Debug("locks: {0}", string.Join(", ", _lockCounts.Keys));
			}

			lock (_syncLock)
			{
				for (var i = _stateEnds.Count - 1; i >= 0; --i)
				{
					var stateEnd = _stateEnds[i];

					if (now >= stateEnd.EndTime)
					{
						this.RemoveState(stateEnd.Type);
						_stateEnds.RemoveAt(i);
					}
				}

				for (var i = _lockEnds.Count - 1; i >= 0; --i)
				{
					var lockEnd = _lockEnds[i];

					if (now >= lockEnd.EndTime)
					{
						this.Unlock(lockEnd.Type);
						_lockEnds.RemoveAt(i);
					}
				}
			}
		}
	}

	/// <summary>
	/// An action that be locked.
	/// </summary>
	public static class LockType
	{
		public const string Movement = "Move";
		public const string Attack = "Attack";
		public const string GetHit = "GetHit";
		public const string Speak = "Speak";
	}

	/// <summary>
	/// A type of state an actor can be in.
	/// </summary>
	public static class StateType
	{
		public const string Stunned = "Stunned";
		public const string KnockedBack = "KnockedBack";
		public const string KnockedDown = "KnockedDown";
		public const string Held = "Held";
	}

	/// <summary>
	/// A state an actor can be in.
	/// </summary>
	public class State
	{
		/// <summary>
		/// Returns the type of the state.
		/// </summary>
		public readonly string Type;

		/// <summary>
		/// Returns the type of state that follows this one if it's activated
		/// for a set duration.
		/// </summary>
		public readonly string NextState;

		/// <summary>
		/// Returns the locks that will be set when the state is activated.
		/// </summary>
		public HashSet<string> Locks { get; } = new();

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="nextState"></param>
		/// <param name="locks"></param>
		public State(string type, string[] locks = null)
		{
			this.Type = type;

			if (locks?.Length > 0)
				this.Locks.UnionWith(locks);
		}
	}

	/// <summary>
	/// A record representing the end of a lock.
	/// </summary>
	/// <param name="Type"></param>
	/// <param name="EndTime"></param>
	public record LockEnd(string Type, DateTime EndTime);
}
