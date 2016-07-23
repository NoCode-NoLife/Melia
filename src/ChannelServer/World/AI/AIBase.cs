using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Melia.Shared.World;
using Melia.Shared.Util;

namespace Melia.Channel.World.AI
{
	public class AIBase : IControl
	{
		protected Entity _entity;
		private IntentionTypes _intention;
		private Object _intentionArg0;
		private Object _intentionArg1;

		public int FOLLOW_INTERVAL = 500; // Millis

		protected Timer _futureFollow;
		protected IEntity _followTarget;
		protected int _distanceToFollow = 10;

		protected bool _thinking;

		public void FollowTask(Object obj)
		{
			if (_futureFollow == null)
				return;

			var targetToFollow = _followTarget;

			if (targetToFollow == null)
			{
				StopFollow();
				return;
			}

			if (this._entity.Position.Get2DDistance(targetToFollow.Position) > 10)
			{
				moveToEntity(targetToFollow, _distanceToFollow);
			}
		}

		public void StartFollow(IEntity targetToFollow)
		{
			// Stop any possible task
			if (_futureFollow != null)
			{
				_futureFollow.Dispose();
				_futureFollow = null;
			}

			_followTarget = targetToFollow;
			_futureFollow = TasksPoolManager.Instance.AddGeneralTaskAtFixedRate(new TimerCallback(FollowTask), null, 5, FOLLOW_INTERVAL);
		}

		public void StopFollow()
		{
			// Stop any possible task
			if (_futureFollow != null)
			{
				_futureFollow.Dispose();
				_futureFollow = null;
			}

			_followTarget = null;
		}

		public void moveToEntity(IEntity entityToFollow, int range)
		{
			
			if (entityToFollow == null)
			{
				SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);
				return;
			}

			_entity.MoveTo(entityToFollow.Position, _distanceToFollow);
			
		}

		public bool IsInsideRange(IEntity entity, int r)
		{
			return false;
		}

		public AIBase(Entity owner)
		{
			_entity = owner;
		}


		virtual public void Process(Object obj)
		{
			onEvtThink();
		}

		virtual public void ChangeIntention(IntentionTypes newItenntion, Object arg0 = null, Object arg1 = null)
		{
			_intention = newItenntion;
			_intentionArg0 = arg0;
			_intentionArg1 = arg1;
		}

		public void SetIntention(IntentionTypes intention, Object arg0 = null, Object arg1 = null)
		{
			Log.Debug("SetIntention Called - intention: {0}", intention);
			switch (intention)
			{
				case IntentionTypes.AI_INTENTION_ACTIVE:
					onIntentionActive();
					break;
				case IntentionTypes.AI_INTENTION_IDLE:
					onIntentionIdle();
					break;
				case IntentionTypes.AI_INTENTION_MOVETO:
					onIntentionMoveTo((Position) arg0);
					break;
				case IntentionTypes.AI_INTENTION_FOLLOW:
					onIntentionFollow((IEntity) arg0);
					break;
				case IntentionTypes.AI_INTENTION_ATTACK:
					onIntentionAttack((IEntity)arg0);
					break;
				case IntentionTypes.AI_INTENTION_REST:
					onIntentionRest();
					break;
				case IntentionTypes.AI_INTENTION_CAST:
					onIntentionCast((Skill) arg0, (IEntity) arg1);
					break;
			}
		}

		public IntentionTypes GetIntention()
		{
			return _intention;
		}

		public void notifyEvent(AIEventTypes aiEvent, Object arg0 = null, Object arg1 = null)
		{
			Log.Debug("notifyEvent {0}", aiEvent);
			switch (aiEvent)
			{
				case AIEventTypes.AI_EVENT_THINK:
					onEvtThink();
					break;
				case AIEventTypes.AI_EVENT_ATTACKED:
					onEvtAttacked((IEntity) arg0);
					break;
				case AIEventTypes.AI_EVENT_DEAD:
					onEvtDead();
					break;
				case AIEventTypes.AI_EVENT_READY_TO_ACT:
					onEvtReadyToAct();
					break;
				case AIEventTypes.AI_EVENT_ARRIVED:
					onEvtArrived();
					break;
			}
		}

		public Entity GetEntity()
		{
			return _entity;
		}

		protected virtual void onIntentionActive() { }

		protected virtual void onIntentionIdle() { }

		protected virtual void onIntentionMoveTo(Position pos) { }

		protected virtual void onIntentionFollow(IEntity entityToFollow) {

			if (entityToFollow == null)
				return;

			ChangeIntention(IntentionTypes.AI_INTENTION_FOLLOW);

			this.StartFollow(entityToFollow);

		}

		protected virtual void onIntentionAttack(IEntity entityToAttack) { }
		protected virtual void onIntentionRest() { }
		protected virtual void onIntentionCast(Skill skill, IEntity target) { }

		// Events
		protected virtual void onEvtThink() { }

		protected virtual void onEvtAttacked(IEntity attacker) { }
		protected virtual void onEvtDead() { }
		protected virtual void onEvtReadyToAct() { }
		protected virtual void onEvtArrived() { }

		protected void ClientStopMoving(Position pos)
		{
			// Stop entity move.
			if (_entity.IsMoving())
			{
				_entity.MoveStop();
			}

			// Reset flag values related to movement
			_distanceToFollow = 0;
			_followTarget = null;

		}

	}
}
