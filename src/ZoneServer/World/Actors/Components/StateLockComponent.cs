using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Composition;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.Components
{
	/// <summary>
	/// A state and lock management component for actors.
	/// </summary>
	public class StateLockComponent : IComponent, IUpdateable
	{
		private readonly object _syncLock = new();

		private readonly List<LockEnd> _lockEnds = new();
		private readonly Dictionary<string, int> _lockCounts = new();
		private readonly Dictionary<string, State> _states = new();

		private State _currentState;
		private string _nextState = null;
		private DateTime _nextStateTime = DateTime.MaxValue;

		/// <summary>
		/// Returns the owner of the component.
		/// </summary>
		public IActor Owner { get; }

		/// <summary>
		/// Returns the type of the state the actor is currently in.
		/// </summary>
		public string CurrentState => _currentState.Type;

		/// <summary>
		/// Creates a new instance for the actor.
		/// </summary>
		public StateLockComponent(IActor owner)
		{
			this.Owner = owner;

			this.RegisterState(new(StateType.Default));
			this.RegisterState(new(StateType.Stunned, [LockType.Movement, LockType.Attack]));
			this.RegisterState(new(StateType.KnockedBack, [LockType.Movement, LockType.Attack]));

			_currentState = _states[StateType.Default];
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
		/// Sets the actor's state to the given type.
		/// </summary>
		/// <remarks>
		/// Sets the locks associated with the state and releases the locks
		/// the previous state might have set.
		/// </remarks>
		/// <param name="stateType"></param>
		public void SetState(string stateType)
			=> this.SetState(stateType, TimeSpan.MaxValue);

		/// <summary>
		/// Sets the actor's state to the given type for the given duration.
		/// </summary>
		/// <remarks>
		/// After the duration has passed, the state will automatically switch
		/// to the next one configured in the selected state. For example,
		/// the next state for 'Stunned' might be 'Default', which doesn't
		/// have locks and will hence enable all actions again.
		/// </remarks>
		/// <param name="stateType"></param>
		/// <param name="duration"></param>
		/// <exception cref="ArgumentException"></exception>
		public void SetState(string stateType, TimeSpan duration)
		{
			lock (_syncLock)
			{
				if (!_states.TryGetValue(stateType, out var state))
					throw new ArgumentException($"Unknown state '{stateType}'.");

				if (_currentState.Type != stateType)
				{
					foreach (var lockType in _currentState.Locks)
						this.Unlock(lockType);
				}

				foreach (var lockType in state.Locks)
					this.Lock(lockType);

				_currentState = state;

				if (duration != TimeSpan.MaxValue)
				{
					_nextState = state.NextState;
					_nextStateTime = DateTime.Now.Add(duration);
				}
				else
				{
					_nextState = null;
					_nextStateTime = DateTime.MaxValue;
				}
			}
		}

		/// <summary>
		/// Updates the component, transitioning states and releasing locks.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			var now = DateTime.Now;

			lock (_syncLock)
			{
				if (_nextState != null && now >= _nextStateTime)
					this.SetState(_nextState);

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
		public const string Default = "Default";
		public const string Stunned = "Stunned";
		public const string KnockedBack = "KnockedBack";
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
			: this(type, StateType.Default, locks)
		{
		}

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="nextState"></param>
		/// <param name="locks"></param>
		public State(string type, string nextState, string[] locks = null)
		{
			this.Type = type;
			this.NextState = nextState;

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
