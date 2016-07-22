using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Melia.Shared.World;

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
			
			if (_followTarget == null)
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

		public void ChangeIntention(IntentionTypes newItenntion, Object arg0 = null, Object arg1 = null)
		{
			_intention = newItenntion;
			_intentionArg0 = arg0;
			_intentionArg1 = arg1;
		}

		public void SetIntention(IntentionTypes intention, Object arg0 = null, Object arg1 = null)
		{
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
			}
		}

		public IntentionTypes GetIntention()
		{
			return _intention;
		}

		public void notifyEvent(AIEventTypes aiEvent, Object arg0 = null, Object arg1 = null)
		{
			switch (aiEvent)
			{
				case AIEventTypes.AI_EVENT_THINK:
					onEvtThink();
					break;
				case AIEventTypes.AI_EVENT_ATTACKED:
					//onEvtAttacked((IEntity) arg0);
					break;
				case AIEventTypes.AI_EVENT_DEAD:
					//onEvtDead();
					break;
				case AIEventTypes.AI_EVENT_READY_TO_ACT:
					//onEvtReadyToAct();
					break;
			}
		}

		public Entity GetEntity()
		{
			return _entity;
		}

		protected virtual void onIntentionActive() {
			ChangeIntention(IntentionTypes.AI_INTENTION_FOLLOW);

		}

		protected virtual void onIntentionIdle() { }

		protected virtual void onIntentionMoveTo(Position pos) { }

		protected virtual void onIntentionFollow(IEntity entityToFollow) {
			ChangeIntention(IntentionTypes.AI_INTENTION_FOLLOW);

			this.StartFollow(entityToFollow);

			TasksPoolManager.Instance.AddGeneralTaskAtFixedRate(new TimerCallback(Process), null, 5, 500);
		}

		protected virtual void onIntentionAttack(IEntity entityToAttack) { }

		// Events
		protected virtual void onEvtThink() {
			if (_thinking)
				return;

			// Just in case, stop follow
			if (_intention != IntentionTypes.AI_INTENTION_FOLLOW)
			{
				StopFollow();
			}

			_thinking = true;

			if (_intention == IntentionTypes.AI_INTENTION_FOLLOW) { 
			}

			_thinking = false;
		}

		protected virtual void onEvtAttacked(IEntity attacker) { }
		protected virtual void onEvtDead() { }
		protected virtual void onEvtReadyToAct() { }



	}
}
