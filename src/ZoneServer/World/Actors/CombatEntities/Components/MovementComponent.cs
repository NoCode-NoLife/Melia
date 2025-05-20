using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// A component that controls an entity's movement.
	/// </summary>
	public class MovementComponent : CombatEntityComponent, IUpdateable
	{
		private Queue<Position> _path;

		private readonly object _positionSyncLock = new();
		private double _moveX, _moveZ;
		private TimeSpan _moveTime;

		private ITriggerableArea[] _triggerAreas = [];

		/// <summary>
		/// Returns the entity's current destination, if it's moving to
		/// a specific location.
		/// </summary>
		public Position Destination { get; private set; }

		/// <summary>
		/// Returns the entity's final destination, if it's moving to a
		/// specific location on a path.
		/// </summary>
		public Position FinalDestination { get; private set; }

		/// <summary>
		/// Returns whether the entity is currently moving.
		/// </summary>
		public bool IsMoving { get; private set; }

		/// <summary>
		/// Gets or sets where the entity is moving to.
		/// </summary>
		public MoveTargetType MoveTarget { get; private set; }

		/// <summary>
		/// Returns whether the entity is currently on the ground or
		/// in the air.
		/// </summary>
		public bool IsGrounded { get; private set; }

		/// <summary>
		/// Returns the entity's current movement speed type.
		/// </summary>
		public MoveSpeedType MoveSpeedType { get; private set; }

		/// <summary>
		/// Creates new movement component.
		/// </summary>
		/// <param name="entity"></param>
		public MovementComponent(ICombatEntity entity) : base(entity)
		{
		}

		/// <summary>
		/// Makes entity move to the given destination via path.
		/// Returns the amount of time the move will take.
		/// </summary>
		/// <remarks>
		/// The position doesn't need a correct Y coordinate, as the
		/// method sets it as needed.
		/// </remarks>
		/// <param name="destination"></param>
		/// <returns></returns>
		public TimeSpan MoveTo(Position destination)
		{
			if (!this.IsValidDestination(destination))
				return TimeSpan.Zero;

			var pathfinder = this.Entity.Map.Pathfinder;
			var start = this.Entity.Position;
			var end = destination;
			var radius = this.Entity.AgentRadius;

			if (!pathfinder.TryFindPath(start, end, radius, out var path))
				return TimeSpan.Zero;

			return this.MovePath(path, true);
		}

		/// <summary>
		/// Makes entity move to the given destination in a straight line.
		/// Returns the amount of time the move will take.
		/// </summary>
		/// <remarks>
		/// The position doesn't need a correct Y coordinate, as the
		/// method sets it as needed.
		/// </remarks>
		/// <param name="destination"></param>
		public TimeSpan MoveStraight(Position destination)
		{
			if (!this.IsValidDestination(destination))
				return TimeSpan.Zero;

			return this.MovePath([destination], true);
		}

		/// <summary>
		/// Prepares and possibly starts movement through the given
		/// path list, returning the amount of time it will/would 
		/// take the entity to get there.
		/// </summary>
		/// <remarks>
		/// The destinations doesn't need correct Y coordinates, as the
		/// method sets them as needed.
		/// </remarks>
		/// <remarks>
		/// The path list is expected to include the start
		/// and destination positons.
		/// </remarks>
		/// <param name="destinations"></param>
		/// <param name="executeMove"></param>
		/// <returns></returns>
		public TimeSpan MovePath(IEnumerable<Position> destinations, bool executeMove)
		{
			var destQueue = new Queue<Position>(destinations);

			lock (_positionSyncLock)
			{
				var curPos = this.Entity.Position;

				// We're treating the path as a list of destinations, so we'll
				// dequeue the first destination if it's the current position,
				// just in case someone decided to start the path with the
				// current position, as path finding algorithms tend to do.
				if (destQueue.Peek() == curPos)
					destQueue.Dequeue();

				// Check the destinations we have left after potentially removing
				// the first one
				if (destQueue.Count == 0)
					return TimeSpan.Zero;

				var totalDistance = 0.0;
				var prevPos = curPos;

				foreach (var pos in destQueue)
				{
					totalDistance += prevPos.Get2DDistance(pos);
					prevPos = pos;
				}

				var speed = this.Entity.Properties.GetFloat(PropertyName.MSPD);
				var totalMoveTime = TimeSpan.FromSeconds(totalDistance / speed);

				if (executeMove)
				{
					_path = destQueue;

					this.IsMoving = true;
					this.FinalDestination = _path.Last();
					this.MoveTarget = MoveTargetType.Position;

					this.ExecuteNextMove();
				}

				return totalMoveTime;
			}
		}

		/// <summary>
		/// Returns whether the entity can move to the destination,
		/// based on its validity and the entity's current state.
		/// </summary>
		/// <param name="destination"></param>
		/// <returns></returns>
		private bool IsValidDestination(Position destination)
		{
			lock (_positionSyncLock)
			{
				var distance = this.Entity.Position.Get3DDistance(destination);
				var speed = this.Entity.Properties.GetFloat(PropertyName.MSPD);

				// Don't move if too close to destination
				if (distance <= 10)
					return false;

				// With 0 speed, we can't move anywhere
				if (speed == 0)
					return false;

				// Can't move if entity is casting
				if (this.Entity.IsCasting())
					return false;

				return true;
			}
		}

		/// <summary>
		/// Sets the destination to the next position in the path list.
		/// </summary>
		private void ExecuteNextMove()
		{
			lock (_positionSyncLock)
			{
				if (_path.Count == 0)
					return;

				var nextDestination = _path.Dequeue();

				var position = this.Entity.Position;
				var diffX = nextDestination.X - position.X;
				var diffZ = nextDestination.Z - position.Z;
				var distance = Math.Sqrt(diffX * diffX + diffZ * diffZ);

				var speed = this.Entity.Properties.GetFloat(PropertyName.MSPD);
				_moveTime = TimeSpan.FromSeconds(distance / speed);
				_moveX = (diffX / _moveTime.TotalSeconds);
				_moveZ = (diffZ / _moveTime.TotalSeconds);

				this.Destination = nextDestination;
				this.Entity.Direction = position.GetDirection(nextDestination);

				var fromCellPos = this.Entity.Map.Ground.GetCellPosition(position);
				var toCellPos = this.Entity.Map.Ground.GetCellPosition(nextDestination);

				Send.ZC_MOVE_PATH(this.Entity, fromCellPos, toCellPos, speed);
			}
		}

		/// <summary>
		/// Stops movement and returns the current position the entity
		/// stopped at.
		/// </summary>
		/// <returns></returns>
		public Position Stop()
		{
			var pos = this.Entity.Position;

			if (this.IsMoving)
			{
				this.IsMoving = false;
				this.Destination = pos;

				Send.ZC_MOVE_STOP(this.Entity, pos);
			}

			return pos;
		}

		/// <summary>
		/// Makes entity jump.
		/// </summary>
		/// <remarks>
		/// This method is primarily used by the server to forward
		/// character movement information. It should only be used
		/// by the packet handlers for the moment.
		/// </remarks>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		/// <param name="unkFloat"></param>
		/// <param name="unkByte"></param>
		internal void NotifyJump(Position pos, Direction dir, float unkFloat, byte unkByte)
		{
			this.Entity.Position = pos;
			this.Entity.Direction = dir;

			this.IsMoving = true;
			this.MoveTarget = MoveTargetType.Direction;

			if (this.Entity is Character character)
			{
				var staminaUsage = (int)character.Properties.GetFloat(PropertyName.Sta_Jump);
				character.ModifyStamina(-staminaUsage);

				Send.ZC_JUMP(character, pos, dir, unkFloat, unkByte);
			}
		}

		/// <summary>
		/// Sets whether the entity is currently on the ground.
		/// </summary>
		/// <remarks>
		/// This method is primarily used by the server to forward
		/// character movement information. It should only be used
		/// by the packet handlers for the moment.
		/// </remarks>
		/// <param name="grounded"></param>
		internal void NotifyGrounded(bool grounded)
		{
			this.IsGrounded = grounded;
		}

		/// <summary>
		/// Updates current position and direction of the entity.
		/// </summary>
		/// <remarks>
		/// This method is primarily used by the server to forward
		/// character movement information. It should only be used
		/// by the packet handlers for the moment.
		/// </remarks>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		/// <param name="unkFloat"></param>
		internal void NotifyMove(Position pos, Direction dir, float unkFloat)
		{
			this.Entity.Position = pos;
			this.Entity.Direction = dir;

			this.IsMoving = true;
			this.MoveTarget = MoveTargetType.Direction;

			Send.ZC_MOVE_DIR(this.Entity, pos, dir, unkFloat);
		}

		/// <summary>
		/// Stops movement and returns the new position.
		/// </summary>
		/// <remarks>
		/// This method is primarily used by the server to forward
		/// character movement information. It should only be used
		/// by the packet handlers for the moment.
		/// </remarks>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		internal Position NotifyStopMove(Position pos, Direction dir)
		{
			this.Entity.Position = pos;
			this.Entity.Direction = dir;

			this.IsMoving = false;
			this.Destination = pos;
			this.MoveTarget = MoveTargetType.Direction;

			if (this.Entity is Character character)
			{
				// Sending ZC_MOVE_STOP works as well, but it doesn't have
				// a direction, so the character stops and looks north
				// on others' screens.
				Send.ZC_PC_MOVE_STOP(character, character.Position, character.Direction);
			}
			else
			{
				Send.ZC_MOVE_STOP(this.Entity, pos);
			}

			this.Entity.Components.Get<BuffComponent>().Remove(BuffId.DashRun);
			this.CheckWarp();

			return pos;
		}

		/// <summary>
		/// Checks for a warp at the entity's current position and executes
		/// it if they don't move for a moment.
		/// </summary>
		private void CheckWarp()
		{
			if (this.Entity is not Character character)
				return;

			var prevPos = character.Position;

			// In the packets I don't see any indication for a client-side
			// trigger, so I guess the server has to check for warps and
			// initiate it all on its own. Seems a little weird... but
			// oh well. If this is a thing, we probably should have some
			// kind of "trigger" system. -- exec
			// 
			// Update: By now we know that this is in fact how it works,
			// but we also know that warps aren't triggered on a delay
			// as we initially assumed (see below). The official behavior
			// is to either warp on contact (classic) or after confirming
			// the warp in a dialog (newer versions). But since I'm not
			// a fan of either option we'll keep our own implementation.
			// Eventually we'll make it configurable. -- exec

			var warpNpc = this.Entity.Map.GetNearbyWarp(prevPos);
			if (warpNpc == null)
				return;

			// Wait 1s to see if the character actually wants to warp
			// (indicated by him not moving). Official behavior unknown,
			// as I have never played the game =<
			Task.Delay(1000).ContinueWith(_ =>
			{
				// Cancel if character moved in that time
				if (character.Position != prevPos)
					return;

				character.Warp(warpNpc.WarpLocation);
			});
		}

		/// <summary>
		/// Sets whether the entity is walking or running, scaling their
		/// movement speed up and down accordingly. Not supported by
		/// all entity types.
		/// </summary>
		/// <param name="type"></param>
		public void SetMoveSpeedType(MoveSpeedType type)
		{
			if (this.MoveSpeedType == type)
				return;

			if (this.Entity is Mob mob)
			{
				this.MoveSpeedType = type;
				this.Entity.Properties.Invalidate(PropertyName.MSPD);

				Send.ZC_MSPD(this.Entity);
			}
			else if (this.Entity is Character character && character is DummyCharacter dummyCharacter)
			{
				this.MoveSpeedType = type;
				character.Properties.Invalidate(PropertyName.MSPD);

				Send.ZC_MSPD(dummyCharacter.Owner, character);
			}
		}

		/// <summary>
		/// Fixes the entity's movement speed at the given value.
		/// </summary>
		/// <param name="mspd"></param>
		public void SetFixedMoveSpeed(float mspd)
		{
			this.Entity.Properties.SetFloat(PropertyName.FIXMSPD_BM, mspd);
			Send.ZC_MSPD(this.Entity);
		}

		/// <summary>
		/// Resets the entity's movement speed to its default value.
		/// </summary>
		public void ResetFixedMoveSpeed()
		{
			this.Entity.Properties.SetFloat(PropertyName.FIXMSPD_BM, 0);
			Send.ZC_MSPD(this.Entity);
		}

		/// <summary>
		/// Updates the entity's position while it's moving.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.UpdateMove(elapsed);
			this.UpdateTriggerAreas();
		}

		/// <summary>
		/// Updates movement, setting positions and queuing moves.
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

				var arrived = (_moveTime -= elapsed) <= TimeSpan.Zero;

				if (!arrived)
				{
					this.UpdateEntityPosition(elapsed);
					return;
				}

				this.QueueNextMove();
			}
		}

		/// <summary>
		/// Stops movement if the end of the path was reached or queues the
		/// move to the next destination on it.
		/// </summary>
		private void QueueNextMove()
		{
			this.Entity.Position = this.Destination;

			if (_path.Count == 0)
			{
				_moveTime = TimeSpan.Zero;
				this.IsMoving = false;
				return;
			}

			this.ExecuteNextMove();
		}

		/// <summary>
		/// Updates the entity's position based on its current movement parameters.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateEntityPosition(TimeSpan elapsed)
		{
			var position = this.Entity.Position;
			position.X += (float)(_moveX * elapsed.TotalSeconds);
			position.Z += (float)(_moveZ * elapsed.TotalSeconds);

			if (!this.Entity.Map.Ground.TryGetHeightAt(position, out var height))
				height = 0;

			position.Y = height;

			this.Entity.Position = position;
		}

		/// <summary>
		/// Updates trigger areas and triggers relevant ones.
		/// </summary>
		private void UpdateTriggerAreas()
		{
			// TODO: It's technically possible for an entity to move so
			//   quickly that they zap past a trigger area before we see
			//   it. To solve this issue we'd need to get the movement
			//   path since the last update and check if it intersects
			//   with any trigger areas. Not overly complicated, but
			//   support needs to be added to the shape classes first.

			var prevTriggerAreas = _triggerAreas;
			var triggerAreas = this.Entity.Map.GetTriggerableAreasAt(this.Entity.Position);

			if (prevTriggerAreas.Length == 0 && triggerAreas.Length == 0)
				return;

			var enteredTriggerAreas = triggerAreas.Except(prevTriggerAreas);
			var leftTriggerAreas = prevTriggerAreas.Except(triggerAreas);

			foreach (var triggerArea in enteredTriggerAreas)
				triggerArea.EnterFunc?.Invoke(new TriggerActorArgs(TriggerType.Enter, triggerArea, this.Entity));

			foreach (var triggerArea in leftTriggerAreas)
				triggerArea.LeaveFunc?.Invoke(new TriggerActorArgs(TriggerType.Leave, triggerArea, this.Entity));

			_triggerAreas = triggerAreas;
		}
	}

	public enum MoveTargetType
	{
		Position,
		Direction,
	}

	public enum MoveSpeedType
	{
		Walk,
		Run,
	}
}
