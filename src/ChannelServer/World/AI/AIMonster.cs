using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World.AI
{
	public class AIMonster : AIBase
	{
		private IEntity _target;

		private bool _thinking;

		private int _movetoTick = 500;
		private DateTime _nextMoveToTime;
		private Position _moveToPosition;

		

		public AIMonster(Entity owner) : base(owner)
		{
			_target = null;
			_thinking = false;
			this.SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);

			_moveToPosition = new Position();
			_nextMoveToTime = DateTime.Now;
		}

		public override void Process(Object obj)
		{
			onEventThink();
		}

		public void onEventThink()
		{
			if (_thinking)
				return;

			_thinking = true;

			switch (GetIntention())
			{
				case IntentionTypes.AI_INTENTION_ACTIVE:
					{
						thinkActive();
						break;
					}
				case IntentionTypes.AI_INTENTION_ATTACK:
					{
						thinkAttack();
						break;
					}
				case IntentionTypes.AI_INTENTION_MOVETO:
					{
						thinkMoveTo();
						break;
					}
				default:
					break;

			}

			_thinking = false;
		}

		private void thinkActive()
		{
			var actors = _entity.Map.SectorManager.GetActorsAtRange(_entity.Position, 300f);

			if (actors.Count > 0)
			{
				foreach (var actor in actors)
				{
					if (actor == _entity)
						continue;

					if (actor is Character)
					{
						_target = (IEntity)actor;
					}
				}
			}

			Log.Debug("target {0}", _target.Handle);

			if (_target != null)
			{
				ChangeIntention(IntentionTypes.AI_INTENTION_MOVETO);
			}
		}

		private void thinkAttack()
		{

		}

		private void thinkMoveTo()
		{
			// Check if its time to process this 
			if (_nextMoveToTime > DateTime.Now)
				return;

			// Set next process time
			_nextMoveToTime = DateTime.Now.AddMilliseconds(_movetoTick);

			if (_target == null)
			{
				ChangeIntention(IntentionTypes.AI_INTENTION_ACTIVE);
				return;
			}

			if (_moveToPosition != _target.Position)
			{
				_moveToPosition = _target.Position;
			}
			Log.Debug("_moveToposition {0} {1} {2}", _moveToPosition.X, _moveToPosition.Y, _moveToPosition.Z);
			Log.Debug("_entity {0} {1} {2}", _entity.Position.X, _entity.Position.Y, _entity.Position.Z);
			// Calculate distance to destination
			float vX = _moveToPosition.X - _entity.Position.X;
			float vZ = _moveToPosition.Z - _entity.Position.Z;
			float distDestination = (float)Math.Sqrt(vX * vX + vZ * vZ);
			Log.Debug("Distance: {0}", distDestination);

			Direction dir = Shared.Util.Math2.AngleBetweenTwoEntity(_entity.Position, _target.Position);

			_entity.SetDirection(dir.Cos, dir.Sin);

			// Set next position 
			// If destination can be reached in this Heartbeat, we go for it. Otherwise, we calculate the next position in the path.
			Position nextPosition;
			if (distDestination <= _entity.GetSpeed() / 2)
			{
				// Get destination position as next position
				nextPosition = _moveToPosition;
			}
			else
			{
				// Calculate next position in path to destination
				nextPosition = new Position((_entity.GetSpeed() / 2) * _entity.Direction.Cos + _entity.Position.X, _entity.Position.Y, (_entity.GetSpeed() / 2) * _entity.Direction.Sin + _entity.Position.Z);
			}

			if (nextPosition == _entity.Position)
			{
				return;
			}

			if (distDestination < 30f)	
			{
				((Monster)_entity).MoveStop();
				ChangeIntention(IntentionTypes.AI_INTENTION_ACTIVE);
				return;
			}

			((Monster)_entity).MoveTo(nextPosition, dir);
		}

		public void SetTarget(IEntity target)
		{
			_target = target;
		}

		public IEntity GetTarget()
		{
			return _target;
		}

		public void ChangeIntention(IntentionTypes intention)
		{
			SetIntention(intention);

			switch (intention)
			{
				case IntentionTypes.AI_INTENTION_MOVETO:
					{
						thinkMoveTo();
						break;
					}
				default:
					break;
			}
		}
	}
}
