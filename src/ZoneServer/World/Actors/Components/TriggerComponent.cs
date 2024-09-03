﻿using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Yggdrasil.Geometry;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Components
{
	/// <summary>
	/// A trigger component that controls events that occur when actors enter
	/// or leave a specific area related to an actor.
	/// </summary>
	/// <remarks>
	/// This component is currently primarily intended for usage with pads
	/// and some features might not work with other actor types.
	/// </remarks>
	public class TriggerComponent : IActorComponent, IUpdateable
	{
		private readonly static TimeSpan DefaultUpdateInterval = TimeSpan.FromSeconds(1);

		private readonly object _syncLock = new();

		private List<IActor> _actorsInside = new();
		private int _actorCount = 0;
		private int _maxActorCount = short.MaxValue;
		private int _useCount;

		private DateTime _creationTime;
		private TimeSpan _updateTimer;
		private TimeSpan _lifetimeTimer;
		private bool _elapsedInitalized;
		private bool _destroyed;

		/// <summary>
		/// Returns the component's owner.
		/// </summary>
		public IActor Owner { get; }

		/// <summary>
		/// Returns the trigger area.
		/// </summary>
		public IShapeF Area { get; }

		/// <summary>
		/// Gets or sets the interval in which the trigger's interval update event
		/// is raised.
		/// </summary>
		/// <remarks>
		/// Note that the updates are dependent on the world's update rate and
		/// might not trigger in time if the interval is too short.
		/// </remarks>
		public TimeSpan UpdateInterval { get; set; } = DefaultUpdateInterval;

		/// <summary>
		/// Gets or sets the life time of the trigger. Once the trigger has
		/// existed on a map for this amount of time, it will be destroyed
		/// automatically.
		/// </summary>
		public TimeSpan LifeTime { get; set; } = TimeSpan.MaxValue;

		/// <summary>
		/// Returns the number of actors currently inside the trigger.
		/// </summary>
		public int ActorCount
		{
			get => _actorCount;
			set => _actorCount = Math.Max(0, value);
		}

		/// <summary>
		/// Returns the maximum number of actors that can be inside the trigger
		/// at a time.
		/// </summary>
		/// <remarks>
		/// The enter and leave events will not be raised if the trigger has
		/// reached its maximum actor count. But as actors leave the trigger,
		/// new ones will be considered again.
		/// </remarks>
		public int MaxActorCount
		{
			get => _maxActorCount;
			set => _maxActorCount = Math.Max(0, value);
		}

		/// <summary>
		/// Returns true if the max actor count has been reached.
		/// </summary>
		public bool AtCapacity => this.ActorCount >= this.MaxActorCount;

		/// <summary>
		/// Gets or sets the maximum number of "uses" for the trigger.
		/// If the max count is reached, the trigger will be destroyed
		/// automatically.
		/// </summary>
		/// <remarks>
		/// What constitues a use is entirely dependent on the trigger's
		/// subscribers and how they increase the use count. One example
		/// might be a type of "safety wall" skill/pad, that increases
		/// its use count every time an actor inside it is hit, destroying
		/// it automatically after X hits.
		/// </remarks>
		public int MaxUseCount { get; set; } = short.MaxValue;

		/// <summary>
		/// Gets or sets which types of actors the component considers actors
		/// that can trigger it. Only actors that are included in the filter
		/// are valid candidates.
		/// </summary>
		public TriggerActorFilter Filter { get; set; } = TriggerActorFilter.CombatEntities;

		/// <summary>
		/// Event that is triggered when the actor added to a map.
		/// </summary>
		public event EventHandler<TriggerArgs> Created;

		/// <summary>
		/// Event that is triggered when the actor is removed from a map.
		/// </summary>
		public event EventHandler<TriggerArgs> Destroyed;

		/// <summary>
		/// Event that is triggered when an actor enters the trigger.
		/// </summary>
		public event EventHandler<TriggerActorArgs> Entered;

		/// <summary>
		/// Event that is triggered when an actor leaves the trigger.
		/// </summary>
		public event EventHandler<TriggerActorArgs> Left;

		/// <summary>
		/// Event that is triggered for actors inside the trigger in
		/// regular intervals.
		/// </summary>
		public event EventHandler<TriggerArgs> Updated;

		/// <summary>
		/// Creates new instance for actor.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="area"></param>
		public TriggerComponent(IActor actor, IShapeF area)
		{
			this.Owner = actor;
			this.Area = area;
		}

		/// <summary>
		/// Returns a list of actors currently inside the trigger area.
		/// </summary>
		/// <returns></returns>
		public List<IActor> GetActors()
		{
			lock (_syncLock)
				return _actorsInside.ToList();
		}

		/// <summary>
		/// Returns a list of actors currently inside the trigger area
		/// that are of the given type.
		/// </summary>
		/// <typeparam name="TActor"></typeparam>
		/// <returns></returns>
		public List<TActor> GetActors<TActor>() where TActor : IActor
		{
			lock (_syncLock)
				return _actorsInside.OfType<TActor>().ToList();
		}

		/// <summary>
		/// Returns a list of actors currently inside the trigger area
		/// that can be attacked by the given actor.
		/// </summary>
		/// <param name="attacker"></param>
		/// <returns></returns>
		public List<ICombatEntity> GetAttackableEntities(ICombatEntity attacker)
		{
			lock (_syncLock)
				return _actorsInside.OfType<ICombatEntity>().Where(attacker.CanAttack).ToList();
		}

		/// <summary>
		/// Updates the component, triggering events.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			// Make sure the elapsed time is not the full update time if we run
			// for the first time, since the component might not have been around
			// for the full update interval, which would mess with the update time
			// calculations. We probably want to standardize this in some say,
			// since this is generally what we would want to know. TODO.
			if (!_elapsedInitalized)
			{
				elapsed = Math2.Max(TimeSpan.Zero, DateTime.Now - _creationTime);
				_elapsedInitalized = true;
			}

			// There are two approaches to checking actors inside a trigger.
			// We can do it from the trigger, which means every trigger needs
			// to check all actors, or we can do it from the actors (and their
			// movement components for example), where every actor needs to
			// check all triggers. Which one is more performant somewhat
			// depends on the environment, though there will usually be
			// less triggers than actors, so the latter should perform
			// better. For simplicity we'll keep it here for the moment
			// though.

			this.Area.UpdatePosition(this.Owner.Position);

			var nowInside = this.Owner.Map.GetActorsIn<IActor>(this.Area, this.IsValidTriggerer);

			lock (_syncLock)
			{
				var wereInside = _actorsInside;

				var entered = nowInside.Except(wereInside);
				var left = wereInside.Except(nowInside);

				foreach (var actor in entered)
					this.Entered?.Invoke(this, new TriggerActorArgs(TriggerType.Enter, this.Owner, actor));

				foreach (var actor in left)
					this.Left?.Invoke(this, new TriggerActorArgs(TriggerType.Leave, this.Owner, actor));

				_actorsInside = nowInside;
				this.ActorCount = nowInside.Count;
			}

			_updateTimer += elapsed;

			if (_updateTimer >= this.UpdateInterval)
			{
				this.Updated?.Invoke(this, new TriggerArgs(TriggerType.Update, this.Owner));
				_updateTimer = TimeSpan.Zero;
			}

			if (this.LifeTime != TimeSpan.MaxValue)
			{
				_lifetimeTimer += elapsed;

				if (_lifetimeTimer >= this.LifeTime)
				{
					this.DestroyOwner();
					_lifetimeTimer = TimeSpan.Zero;
				}
			}
		}

		/// <summary>
		/// Returns true if the given actor is allowed to trigger the trigger.
		/// </summary>
		/// <param name="actor"></param>
		/// <returns></returns>
		private bool IsValidTriggerer(IActor actor)
		{
			if (!this.Filter.Has(TriggerActorFilter.Characters) && actor is Character) return false;
			if (!this.Filter.Has(TriggerActorFilter.Mobs) && actor is Mob) return false;
			if (!this.Filter.Has(TriggerActorFilter.Npcs) && actor is Npc) return false;
			if (!this.Filter.Has(TriggerActorFilter.Items) && actor is ItemMonster) return false;

			return true;
		}

		/// <summary>
		/// Increases the trigger's use count and automatically destroys
		/// the owner if the max use count is reached. Returns true if
		/// the max use count was reached.
		/// </summary>
		public bool IncreaseUseCount()
		{
			_useCount++;

			var usedUp = _useCount >= this.MaxUseCount;
			if (usedUp)
				this.DestroyOwner();

			return usedUp;
		}

		/// <summary>
		/// Destroys the component's owner, removing them from the world.
		/// </summary>
		private void DestroyOwner()
		{
			// TODO: Make more generic, so we don't need explicit conversions.

			switch (this.Owner)
			{
				case Pad pad: pad.Destroy(); return;
				case IMonster monster: monster.Map.RemoveMonster(monster); return;
				case Character character: character.Map.RemoveCharacter(character); return;
			}

			throw new InvalidOperationException($"Unknown owner type '{this.Owner.GetType()}'.");
		}

		/// <summary>
		/// Called when the actor was added to a map.
		/// </summary>
		internal void OnAddedToMap()
		{
			_destroyed = false;
			_creationTime = DateTime.Now;

			this.Created?.Invoke(this, new TriggerArgs(TriggerType.Create, this.Owner));
		}

		/// <summary>
		/// Called when the actor is being removed from a map.
		/// </summary>
		internal void OnRemovingFromMap()
		{
			if (_destroyed)
				return;

			_destroyed = true;

			this.Destroyed?.Invoke(this, new TriggerArgs(TriggerType.Destroy, this.Owner));
		}

		/// <summary>
		/// Subscribes to a trigger event.
		/// </summary>
		/// <remarks>
		/// Subscribe effectively does the same thing as subscribing to the
		/// events directly, but it dynamically adjusts the event arguments
		/// for easier and more flexible use.
		/// </remarks>
		/// <param name="type"></param>
		/// <param name="handler"></param>
		/// <exception cref="ArgumentException"></exception>
		public void Subscribe(TriggerType type, EventHandler<TriggerArgs> handler)
		{
			switch (type)
			{
				case TriggerType.Create: this.Created += handler; break;
				case TriggerType.Destroy: this.Destroyed += handler; break;
				case TriggerType.Update: this.Updated += handler; break;
				case TriggerType.Enter: this.Entered += ArgsToActorArgs(handler); break;
				case TriggerType.Leave: this.Left += ArgsToActorArgs(handler); break;

				default:
					throw new ArgumentException($"Unknown trigger type '{type}'.");
			}
		}

		/// <summary>
		/// Subscribes to a trigger event.
		/// </summary>
		/// <remarks>
		/// Subscribe effectively does the same thing as subscribing to the
		/// events directly, but it dynamically adjusts the event arguments
		/// for easier and more flexible use.
		/// </remarks>
		/// <param name="type"></param>
		/// <param name="handler"></param>
		/// <exception cref="ArgumentException"></exception>
		public void Subscribe(TriggerType type, EventHandler<TriggerActorArgs> handler)
		{
			switch (type)
			{
				case TriggerType.Enter: this.Entered += handler; break;
				case TriggerType.Leave: this.Left += handler; break;

				case TriggerType.Create:
				case TriggerType.Destroy:
				case TriggerType.Update:
					throw new ArgumentException("Event handler not supported for this trigger type.");

				default:
					throw new ArgumentException($"Unknown trigger type '{type}'.");
			}
		}

		/// <summary>
		/// Subscribes to a trigger event.
		/// </summary>
		/// <remarks>
		/// Subscribe effectively does the same thing as subscribing to the
		/// events directly, but it dynamically adjusts the event arguments
		/// for easier and more flexible use.
		/// </remarks>
		/// <param name="type"></param>
		/// <param name="handler"></param>
		/// <exception cref="ArgumentException"></exception>
		public void Subscribe(TriggerType type, EventHandler<PadTriggerArgs> handler)
		{
			switch (type)
			{
				case TriggerType.Create: this.Created += PadArgsToArgs(handler); break;
				case TriggerType.Destroy: this.Destroyed += PadArgsToArgs(handler); break;
				case TriggerType.Enter: this.Entered += PadArgsToActorArgs(handler); break;
				case TriggerType.Leave: this.Left += PadArgsToActorArgs(handler); break;
				case TriggerType.Update: this.Updated += PadArgsToArgs(handler); break;

				default:
					throw new ArgumentException($"Unknown trigger type '{type}'.");
			}
		}

		/// <summary>
		/// Subscribes to a trigger event.
		/// </summary>
		/// <remarks>
		/// Subscribe effectively does the same thing as subscribing to the
		/// events directly, but it dynamically adjusts the event arguments
		/// for easier and more flexible use.
		/// </remarks>
		/// <param name="type"></param>
		/// <param name="handler"></param>
		/// <exception cref="ArgumentException"></exception>
		public void Subscribe(TriggerType type, EventHandler<PadTriggerActorArgs> handler)
		{
			switch (type)
			{
				case TriggerType.Enter: this.Entered += PadActorArgsToActorArgs(handler); break;
				case TriggerType.Leave: this.Left += PadActorArgsToActorArgs(handler); break;

				case TriggerType.Create:
				case TriggerType.Destroy:
				case TriggerType.Update:
					throw new ArgumentException("Event handler not supported for this trigger type.");

				default:
					throw new ArgumentException($"Unknown trigger type '{type}'.");
			}
		}

		/// <summary>
		/// Returns an event handler that downgrades an actor trigger event to 
		/// one without actors.
		/// </summary>
		/// <param name="handler"></param>
		/// <returns></returns>
		private static EventHandler<TriggerActorArgs> ArgsToActorArgs(EventHandler<TriggerArgs> handler)
			=> (sender, args) => handler(sender, new TriggerArgs(args.Type, args.Trigger));

		/// <summary>
		/// Returns an event handler that calls the given handler with appropriate
		/// arguments, assuming the arguments could be gathered. If not, nothing
		/// happens.
		/// </summary>
		/// <param name="handler"></param>
		/// <returns></returns>
		private static EventHandler<TriggerArgs> PadArgsToArgs(EventHandler<PadTriggerArgs> handler)
		{
			return (sender, args) =>
			{
				if (args.Trigger is not Pad pad)
					return;

				if (pad.Creator is not ICombatEntity creator)
					return;

				handler(sender, new PadTriggerArgs(args.Type, pad, creator, pad.Skill));
			};
		}

		/// <summary>
		/// Returns an event handler that calls the given handler with appropriate
		/// arguments, assuming the arguments could be gathered. If not, nothing
		/// happens.
		/// </summary>
		/// <param name="handler"></param>
		/// <returns></returns>
		private static EventHandler<TriggerActorArgs> PadArgsToActorArgs(EventHandler<PadTriggerArgs> handler)
		{
			return (sender, args) =>
			{
				if (args.Trigger is not Pad pad)
					return;

				if (pad.Creator is not ICombatEntity creator)
					return;

				var skill = pad.Skill;

				handler(sender, new PadTriggerArgs(args.Type, pad, creator, skill));
			};
		}

		/// <summary>
		/// Returns an event handler that calls the given handler with appropriate
		/// arguments, assuming the arguments could be gathered. If not, nothing
		/// happens.
		/// </summary>
		/// <param name="handler"></param>
		/// <returns></returns>
		private static EventHandler<TriggerActorArgs> PadActorArgsToActorArgs(EventHandler<PadTriggerActorArgs> handler)
		{
			return (sender, args) =>
			{
				if (args.Trigger is not Pad pad)
					return;

				if (args.Initiator is not ICombatEntity initiator)
					return;

				if (pad.Creator is not ICombatEntity creator)
					return;

				var skill = pad.Skill;

				handler(sender, new PadTriggerActorArgs(args.Type, pad, initiator, creator, skill));
			};
		}
	}

	/// <summary>
	/// Used to specify which actors are allowed to trigger a trigger.
	/// </summary>
	public enum TriggerActorFilter : uint
	{
		/// <summary>
		/// Matches player characters.
		/// </summary>
		Characters = 0x01,

		/// <summary>
		/// Matches combat-capable monsters.
		/// </summary>
		Mobs = 0x02,

		/// <summary>
		/// Matches friendly NPCs.
		/// </summary>
		Npcs = 0x04,

		/// <summary>
		/// Matches items lying on the ground.
		/// </summary>
		Items = 0x08,

		/// <summary>
		/// Matches combat entities, such as characters and mobs.
		/// </summary>
		CombatEntities = Characters | Mobs,

		/// <summary>
		/// Matches "monster-type" actors, which means everything that's
		/// not a player.
		/// </summary>
		Monsters = Mobs | Npcs | Items,

		/// <summary>
		/// Matches all actors.
		/// </summary>
		All = 0xFFFFFFFF,
	}

	/// <summary>
	/// Extensions for the trigger actor filter enum.
	/// </summary>
	public static class TriggerActorFilterExtension
	{
		/// <summary>
		/// Returns true if the filter contains the given value.
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool Has(this TriggerActorFilter filter, TriggerActorFilter value)
			=> (filter & value) != 0;
	}
}
