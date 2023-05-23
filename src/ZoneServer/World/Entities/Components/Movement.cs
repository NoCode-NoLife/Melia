using System;
using Melia.Zone.Network;
using Melia.Shared.Tos.Const;
using Melia.Shared.EntityComponents;
using Melia.Shared.World;

namespace Melia.Zone.World.Entities.Components
{
	/// <summary>
	/// A component that controls an entity's movement.
	/// </summary>
	public class Movement : IUpdatableComponent
	{
		private readonly object _positionSyncLock = new object();
		private double _moveX, _moveZ;
		private TimeSpan _moveTime;

		/// <summary>
		/// Returns the entity this component controls.
		/// </summary>
		public IEntity Entity { get; }

		/// <summary>
		/// Returns the entity's current destination, if it's moving to
		/// a specific location.
		/// </summary>
		public Position Destination { get; private set; }

		/// <summary>
		/// Returns whether the entity is currently moving.
		/// </summary>
		public bool IsMoving { get; private set; }

		/// <summary>
		/// Creates new movement component.
		/// </summary>
		/// <param name="entity"></param>
		public Movement(IEntity entity)
		{
			this.Entity = entity;
		}

		/// <summary>
		/// Makes entity move to the given destination in a straight
		/// line. Returns the amount of time the move will take.
		/// </summary>
		/// <remarks>
		/// The position doesn't need to a correct Y coordinate, as the
		/// method sets it as needed.
		/// </remarks>
		/// <param name="destination"></param>
		/// <returns></returns>
		public TimeSpan MoveTo(Position destination)
		{
			return this.MoveToConditional(destination, true);
		}

		/// <summary>
		/// Calculates and returns the time it would take the entity
		/// to move to the destination from its current position.
		/// </summary>
		/// <param name="destination"></param>
		/// <param name="walk"></param>
		/// <returns></returns>
		public TimeSpan CalcMoveToTime(Position destination)
		{
			return this.MoveToConditional(destination, false);
		}

		/// <summary>
		/// Starts movement to destination if execution is requested,
		/// returns the amount of time it will/would take the entity
		/// to get there.
		/// </summary>
		/// <param name="destination"></param>
		/// <param name="executeMove"></param>
		private TimeSpan MoveToConditional(Position destination, bool executeMove)
		{
			lock (_positionSyncLock)
			{
				// Don't move if the entity is already at the destination
				if (destination == this.Entity.Position)
					return TimeSpan.Zero;

				// Get distance to destination
				var position = this.Entity.Position;
				var diffX = destination.X - position.X;
				var diffZ = destination.Z - position.Z;
				var distance = Math.Sqrt(diffX * diffX + diffZ * diffZ);

				// Get speed
				var speed = this.Entity.Properties.GetFloat("MSPD");

				// With 0 speed, we can't move anywhere
				if (speed == 0)
					return TimeSpan.Zero;

				// Don't move if too close to destination
				if (distance <= 10)
					return TimeSpan.Zero;

				// Calculate movement and move time
				_moveTime = TimeSpan.FromSeconds(distance / speed);
				_moveX = (diffX / _moveTime.TotalSeconds);
				_moveZ = (diffZ / _moveTime.TotalSeconds);

				if (executeMove)
				{
					this.Destination = destination;
					this.IsMoving = true;

					// Set direction relative to current position
					this.Entity.Direction = position.GetDirection(destination);

					var fromCellPos = this.Entity.Map.Ground.GetCellPosition(this.Entity.Position);
					var toCellPos = this.Entity.Map.Ground.GetCellPosition(this.Destination);

					// Update clients
					Send.ZC_MOVE_PATH(this.Entity, fromCellPos, toCellPos, speed);
				}

				return _moveTime;
			}
		}

		/// <summary>
		/// Updates the entity's position while it's moving.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			lock (_positionSyncLock)
			{
				// No need to update the position if the character isn't moving.
				if (!this.IsMoving)
					return;

				// If the move time reached 0, set position to destination
				// and stop moving.
				if ((_moveTime -= elapsed) <= TimeSpan.Zero)
				{
					this.Entity.Position = this.Destination;

					this.IsMoving = false;
					_moveTime = TimeSpan.Zero;
				}
				// If there's still move time left, update the current position.
				else
				{
					var position = this.Entity.Position;
					position.X += (float)(_moveX * elapsed.TotalSeconds);
					position.Z += (float)(_moveZ * elapsed.TotalSeconds);

					if (!this.Entity.Map.Ground.TryGetHeightAt(position, out var height))
						height = 0;

					position.Y = height;

					this.Entity.Position = position;
				}
			}
		}
	}
}
