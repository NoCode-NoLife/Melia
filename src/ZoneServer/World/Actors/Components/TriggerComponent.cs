using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Geometry;
using Yggdrasil.Scheduling;

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

		private TimeSpan _updateDelay = DefaultUpdateInterval;
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
		/// Gets or sets the interval in which the pad's interval update event
		/// is raised.
		/// </summary>
		/// <remarks>
		/// Note that the updates are dependent on the world's update rate and
		/// might not trigger in time if the interval is too short.
		/// </remarks>
		public TimeSpan UpdateInterval { get; set; } = DefaultUpdateInterval;

		/// <summary>
		/// Returns the number of actors currently inside the pad.
		/// </summary>
		public int ActorCount
		{
			get => _actorCount;
			set => _actorCount = Math.Max(0, value);
		}

		/// <summary>
		/// Returns the maximum number of actors that can be inside the pad
		/// at a time.
		/// </summary>
		/// <remarks>
		/// The enter and leave events will not be raised if the pad has
		/// reached its maximum actor count. But as actors leave the pad,
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
		/// Event that is triggered when the actor added to a map.
		/// </summary>
		public event EventHandler<TriggerArgs> Created;

		/// <summary>
		/// Event that is triggered when the actor is removed from a map.
		/// </summary>
		public event EventHandler<TriggerArgs> Destroyed;

		/// <summary>
		/// Event that is triggered when an actor enters the pad.
		/// </summary>
		public event EventHandler<TriggerActorArgs> Entered;

		/// <summary>
		/// Event that is triggered when an actor leaves the pad.
		/// </summary>
		public event EventHandler<TriggerActorArgs> Left;

		/// <summary>
		/// Event that is triggered for actors inside the pad in regular intervals.
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
		/// Updates the component, triggering events.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
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

			var nowInside = this.Owner.Map.GetActorsIn<IActor>(this.Area);

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

			_updateDelay -= elapsed;

			if (_updateDelay <= TimeSpan.Zero)
			{
				_updateDelay = this.UpdateInterval;
				this.Updated?.Invoke(this, new TriggerArgs(TriggerType.Update, this.Owner));
			}
		}

		/// <summary>
		/// Called when the actor was added to a map.
		/// </summary>
		internal void OnAddedToMap()
		{
			_destroyed = false;

			this.Created?.Invoke(this, new TriggerArgs(TriggerType.Create, this.Owner));
			this.Update(TimeSpan.Zero);
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
	}
}
