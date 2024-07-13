using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using g3;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// A component that controls an entity's movement.
	/// </summary>
	public class MovementComponent : CombatEntityComponent, IUpdateable
	{
		private readonly object _positionSyncLock = new();
		private double _moveX, _moveZ;
		private TimeSpan _moveTime;
		private List<Position> _path;
		private int _currentPathIndex;

		private ITriggerableArea[] _triggerAreas = [];

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
		/// Gets or sets where the entity is moving to.
		/// </summary>
		private MoveTargetType MoveTarget { get; set; }

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
		/// Makes entity move to the given destination in a straight
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
				var position = this.Entity.Position;

				// Don't move if the entity is already at the destination
				if (destination == position)
					return TimeSpan.Zero;

				// Use Pathfinder to find a path to the destination
				var pathfinder = this.Entity.Map.Pathfinder;
				var path = pathfinder.FindPath(position, destination);

				if (path == null || path.Count == 0)
					return TimeSpan.Zero; // No valid path found

				// Get distance to next path
				var nextPath = path[0];
				var diffX = nextPath.X - position.X;
				var diffZ = nextPath.Z - position.Z;

				// Get total distance of paths
				double totalDistance = 0;
				totalDistance += position.Get2DDistance(nextPath);
				var i = 0;
				for (i = 0; i < path.Count - 1; i++)
				{
					totalDistance += path[i].Get2DDistance(path[i + 1]);
				}
				totalDistance += path[i].Get2DDistance(destination);

				// Get speed
				var speed = this.Entity.Properties.GetFloat(PropertyName.MSPD);

				// With 0 speed, we can't move anywhere
				if (speed == 0)
					return TimeSpan.Zero;

				// Don't move if too close to destination
				if (position.Get2DDistance(destination) <= 10)
					return TimeSpan.Zero;

				// Calculate move time
				_moveTime = TimeSpan.FromSeconds(totalDistance / speed);
				_moveX = (diffX / _moveTime.TotalSeconds);
				_moveZ = (diffZ / _moveTime.TotalSeconds);

				if (executeMove)
				{
					this.IsMoving = true;
					this.Destination = destination;
					this.MoveTarget = MoveTargetType.Position;
					this._path = path;
					this._currentPathIndex = 0;

					// Set direction relative to current position
					this.Entity.Direction = this.Entity.Position.GetDirection(nextPath);

					var fromCellPos = this.Entity.Map.Ground.GetCellPosition(this.Entity.Position);
					var toCellPos = this.Entity.Map.Ground.GetCellPosition(nextPath);

					// Update clients
					Send.ZC_MOVE_PATH(this.Entity, fromCellPos, toCellPos, speed);
				}

				return _moveTime;
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
			if (this.Entity is Mob mob && this.MoveSpeedType != type)
			{
				this.MoveSpeedType = type;
				this.Entity.Properties.Invalidate(PropertyName.MSPD);

				Send.ZC_MSPD(this.Entity);
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
		/// Updates entity position while it's moving.
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
					this.Entity.Position = this.Destination;

					this.IsMoving = false;
					_moveTime = TimeSpan.Zero;
				}
				// If there's still move time left, update the current position.
				else
				{
					// Move along the path
					if (_currentPathIndex < _path.Count)
					{
						var position = this.Entity.Position;
						
						position.X += (float)(_moveX * elapsed.TotalSeconds);
						position.Z += (float)(_moveZ * elapsed.TotalSeconds);

						if (!this.Entity.Map.Ground.TryGetHeightAt(position, out var height))
							height = 0;

						position.Y = height;

						this.Entity.Position = position;

						// Checks if we reached the current path
						var distance = position.Get2DDistance(_path[_currentPathIndex]);
						if (distance <= 10)
						{
							_currentPathIndex++;
							if (_currentPathIndex < _path.Count)
							{
								var nextPath = _path[_currentPathIndex];
								this.Entity.Direction = this.Entity.Position.GetDirection(nextPath);
								var diffX = nextPath.X - position.X;
								var diffZ = nextPath.Z - position.Z;
								var speed = this.Entity.Properties.GetFloat(PropertyName.MSPD);
								_moveX = (diffX / _moveTime.TotalSeconds);
								_moveZ = (diffZ / _moveTime.TotalSeconds);

								// Note: We do not need to update clients here as
								// the client implements its own pathfinding
							}
						}
					}
				}
			}
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
			{
				if (triggerArea.EnterFunc == null)
					continue;

				var dialog = new Dialog(this.Entity, triggerArea);
				triggerArea.EnterFunc.Invoke(dialog);
			}

			foreach (var triggerArea in leftTriggerAreas)
			{
				if (triggerArea.LeaveFunc == null)
					continue;

				var dialog = new Dialog(this.Entity, triggerArea);
				triggerArea.LeaveFunc.Invoke(dialog);
			}

			_triggerAreas = triggerAreas;
		}

		private enum MoveTargetType
		{
			Position,
			Direction,
		}
	}

	public enum MoveSpeedType
	{
		Walk,
		Run,
	}
}
