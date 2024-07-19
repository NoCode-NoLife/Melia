using System;
using Melia.Shared.World;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.Components
{
	/// <summary>
	/// A component that controls an actor's movement.
	/// </summary>
	/// <remarks>
	/// This component is essentially a copy of our normal movement component,
	/// with parts of it having been pulled out for a redesign, so we can
	/// also use it for pads. During this ongoing update we will have two
	/// movement components.
	/// </remarks>
	public abstract class ActorMovementComponent : IActorComponent, IUpdateable
	{
		private readonly object _positionSyncLock = new();
		private double _moveX, _moveZ;
		private TimeSpan _moveTime;

		/// <summary>
		/// Returns the component's owner.
		/// </summary>
		public IActor Owner { get; }

		/// <summary>
		/// Returns the actor's current destination, if it's moving to
		/// a specific location.
		/// </summary>
		public Position Destination { get; private set; }

		/// <summary>
		/// Returns whether the actor is currently moving.
		/// </summary>
		public bool IsMoving { get; private set; }

		/// <summary>
		/// Gets or sets where the actor is moving to.
		/// </summary>
		private MoveTargetType MoveTarget { get; set; }

		/// <summary>
		/// Gets or sets the owner's movement speed.
		/// </summary>
		public virtual float Speed { get; set; } = 30;

		/// <summary>
		/// Creates new movement component.
		/// </summary>
		/// <param name="actor"></param>
		public ActorMovementComponent(IActor actor) : base()
		{
			this.Owner = actor;
		}

		/// <summary>
		/// Makes actor move to the given destination in a straight
		/// line. Returns the amount of time the move will take.
		/// </summary>
		/// <remarks>
		/// The position doesn't need a correct Y coordinate, as the
		/// method sets it as needed.
		/// </remarks>
		/// <param name="destination"></param>
		/// <returns></returns>
		public TimeSpan MoveTo(Position destination)
		{
			return this.MoveToConditional(destination, true);
		}

		/// <summary>
		/// Calculates and returns the time it would take the actor
		/// to move to the destination from its current position.
		/// </summary>
		/// <param name="destination"></param>
		/// <returns></returns>
		public TimeSpan CalcMoveToTime(Position destination)
		{
			return this.MoveToConditional(destination, false);
		}

		/// <summary>
		/// Starts movement to destination if execution is requested,
		/// returns the amount of time it will/would take the actor
		/// to get there.
		/// </summary>
		/// <param name="destination"></param>
		/// <param name="executeMove"></param>
		private TimeSpan MoveToConditional(Position destination, bool executeMove)
		{
			// TODO: Optionally check validity of the move.

			lock (_positionSyncLock)
			{
				// Don't move if the actor is already at the destination
				if (destination == this.Owner.Position)
					return TimeSpan.Zero;

				// Get distance to destination
				var position = this.Owner.Position;
				var diffX = destination.X - position.X;
				var diffZ = destination.Z - position.Z;
				var distance = Math.Sqrt(diffX * diffX + diffZ * diffZ);

				// Get speed
				var speed = this.Speed;

				// With 0 speed, we can't move anywhere
				if (speed == 0)
					return TimeSpan.Zero;

				// Don't move if too close to destination
				if (distance <= 10)
					return TimeSpan.Zero;

				// Calculate movement and move time
				_moveTime = TimeSpan.FromSeconds(distance / speed);
				_moveX = diffX / _moveTime.TotalSeconds;
				_moveZ = diffZ / _moveTime.TotalSeconds;

				if (executeMove)
				{
					this.IsMoving = true;
					this.Destination = destination;
					this.MoveTarget = MoveTargetType.Position;

					// Set direction relative to current position
					this.Owner.Direction = position.GetDirection(destination);

					//var fromCellPos = this.Entity.Map.Ground.GetCellPosition(this.Entity.Position);
					//var toCellPos = this.Entity.Map.Ground.GetCellPosition(this.Destination);

					// Update clients
					this.UpdateMoveTo(position, destination, speed);
				}

				return _moveTime;
			}
		}

		/// <summary>
		/// Stops movement and returns the current position the owner
		/// stopped at.
		/// </summary>
		/// <returns></returns>
		public Position Stop()
		{
			var pos = this.Owner.Position;

			if (this.IsMoving)
			{
				this.IsMoving = false;
				this.Destination = pos;

				this.UpdateStop(pos);
			}

			return pos;
		}

		/// <summary>
		/// Updates the actor's position while it's moving.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.UpdateMove(elapsed);
		}

		/// <summary>
		/// Updates actor position while it's moving.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateMove(TimeSpan elapsed)
		{
			lock (_positionSyncLock)
			{
				// No need to update the position if the character isn't moving.
				if (!this.IsMoving)
					return;

				// Don't update the position this way for directional
				// movement for now. That will require a bit more
				// research to get right.
				if (this.MoveTarget != MoveTargetType.Position)
					return;

				// If the move time reached 0, set position to destination
				// and stop moving.
				if ((_moveTime -= elapsed) <= TimeSpan.Zero)
				{
					this.Owner.Position = this.Destination;

					this.IsMoving = false;
					_moveTime = TimeSpan.Zero;
				}
				// If there's still move time left, update the current position.
				else
				{
					var position = this.Owner.Position;
					position.X += (float)(_moveX * elapsed.TotalSeconds);
					position.Z += (float)(_moveZ * elapsed.TotalSeconds);

					if (!this.Owner.Map.Ground.TryGetHeightAt(position, out var height))
						height = 0;

					position.Y = height;

					this.Owner.Position = position;
				}
			}
		}

		/// <summary>
		/// Sends potential updates about the movement to clients.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="dest"></param>
		/// <param name="speed"></param>
		protected virtual void UpdateMoveTo(Position pos, Position dest, float speed)
		{
		}

		/// <summary>
		/// Sends potential updates about the stop to clients.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="dest"></param>
		/// <param name="speed"></param>
		protected virtual void UpdateStop(Position pos)
		{
		}

		private enum MoveTargetType
		{
			Position,
			Direction,
		}
	}
}
